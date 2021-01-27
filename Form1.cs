using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Drawing.Imaging;
using System.Reflection;
using System.Runtime.InteropServices;

namespace FfmpegUtil
{
    public partial class Form1 : Form
    {
        OutResolutions[] resOptions = new OutResolutions[] {new OutResolutions( 1280, 720, "720p", "720p"),
                                                            new OutResolutions( 1920, 1080, "1080p", "1080p"),
                                                            new OutResolutions( 2560, 1440, "2560x1440", "1440p"),
                                                            new OutResolutions( 2560, 1600, "2560x1600", "1600p"),
                                                            new OutResolutions( 3840, 2160, "4K", "4K"),
                                                            new OutResolutions( 0, 0, "Custom", "")};
        string homeDirectory;
        string[] fileList;
        string[] selectedFileList = null;
        string[] selectedDirectoryList = null;
        string timelapseFileListPrefix;
        string timelapseFileListStartIndex;
        int sourceDimX = 3000;
        int sourceDimY = 2000;
        int resX, resY;
        string fileNameResPostfix, fileNameScaleCropPostfix;

        public Form1(string[] args)
        {
            InitializeComponent();
            foreach(OutResolutions resType in resOptions)
            {
                comboBoxResolution.Items.Add(resType.comboBoxName);
            }
            comboBoxResolution.SelectedIndex = 1;
            comboBoxResolution.Select();
            comboBoxScaleCrop.SelectedIndex = 0;
            comboBoxScaleCrop.Select();
            comboBoxResolution_SelectedIndexChanged(this, null); // Call this to initialize the resolution variables
            logMessage("Welcome Friends!");

            resetProject(Directory.GetCurrentDirectory());

            // Check if we should run the program in automated mode
            Boolean autoMode = false;
            if(args.Length >= 1)
            {
                autoMode = true;
                if(args[0].Equals("720p"))
                {
                    comboBoxResolution.SelectedIndex = 0;
                }
                else if (args[0].Equals("1080p"))
                {
                    comboBoxResolution.SelectedIndex = 1;
                }
                else if(args[0].Equals("2.5k"))
                {
                    comboBoxResolution.SelectedIndex = 2;
                }
                else if (args[0].Equals("4k"))
                {
                    comboBoxResolution.SelectedIndex = 3;
                }
                else
                {
                    autoMode = false;
                }
            }
            // Use dot instead of comma for float values
            System.Globalization.CultureInfo customCulture = (System.Globalization.CultureInfo)System.Threading.Thread.CurrentThread.CurrentCulture.Clone();
            customCulture.NumberFormat.NumberDecimalSeparator = ".";

            System.Threading.Thread.CurrentThread.CurrentCulture = customCulture;

            setOutFileName();

            // Run automode if the argument is present
            if (autoMode)
            {
                buttonGenerateVideo_Click(this, null);
                this.Close();
                Application.Exit();
            }
        }

        public void logMessage(string message)
        {
            textBoxLog.Text = textBoxLog.Text + message + "\r\n" ;
        }

        public void resetProject(String projectDirectory)
        {
            homeDirectory = projectDirectory;
            labelFolder.Text = homeDirectory;
            fileList = Directory.GetFiles(homeDirectory);
            List<String> fileList2 = new List<string>(fileList);
            fileList2 = fileList2.OrderBy(q => q).ToList();
            fileList = fileList2.ToArray();
            decodeFileList();
            decodeFirstImageMetaData();
        }

        public void resetProjectFileList()
        {
            labelFolder.Text = "File list";
            if (selectedFileList != null)
            {
                fileList = selectedFileList;
            }
            else if(selectedDirectoryList != null)
            //List<String> fileList2 = new List<string>(fileList);
            //fileList2 = fileList2.OrderBy(q => q).ToList();
            //fileList = fileList2.ToArray();
            decodeFileList();
            labelNumFiles.Text = selectedFileList.Length.ToString();
            labelStartNum.Text = "";
            decodeFirstImageMetaData();
        }

        public FileInfo decodeFile(string file)
        {
            FileInfo currentFileInfo = new FileInfo();
            if (Path.GetExtension(file) == ".jpg" || Path.GetExtension(file) == ".JPG")
            {
                currentFileInfo.ValidFile = true;
                currentFileInfo.FileName = Path.GetFileName(file);
                currentFileInfo.FilePrefix = currentFileInfo.FileName.Split('_')[0];
                string fileIndex = currentFileInfo.FileName.Split(new char[]{ '_', '.'})[1];
                if(!Int32.TryParse(fileIndex, out currentFileInfo.FileIndex))
                {
                    currentFileInfo.FileIndex = 0;
                }
            }
            else currentFileInfo.ValidFile = false;
            return currentFileInfo;
        }

        public void decodeFileList()
        {
            FileInfo fileInfo = null;
            Boolean firstFileFound = false;
            Boolean lastFileFound = false;
            int numFiles = 0, prevIndex = 0;

            // Find the first valid file in the directory. 
            foreach (string file in fileList)
            {
                fileInfo = decodeFile(file);
                if (!firstFileFound)
                {
                    if (fileInfo.ValidFile)
                    {
                        firstFileFound = true;
                        numFiles++;
                        timelapseFileListStartIndex = fileInfo.FileIndex.ToString();
                        timelapseFileListPrefix = fileInfo.FilePrefix;
                        prevIndex = fileInfo.FileIndex;
                        labelStartNum.Text = fileInfo.FileIndex.ToString();
                    }
                }
                else
                {
                    if(fileInfo.ValidFile && fileInfo.FileIndex == (prevIndex + 1))
                    {
                        numFiles++;
                        prevIndex++;
                    }
                    else
                    {
                        lastFileFound = true;
                        break;
                    }
                }
            }

            labelNumFiles.Text = numFiles.ToString();
        }

        public void decodeFirstImageMetaData()
        {
            if (fileList.Length > 0)
            {
                String firstFile = fileList[0];
                FileInfo firstFileInfo = decodeFile(firstFile);
                if (firstFileInfo.ValidFile)
                {
                    Image firstImage = new Bitmap(firstFile);
                    sourceDimX = firstImage.Width;
                    sourceDimY = firstImage.Height;
                    labelResolution.Text = sourceDimX.ToString() + "x" + sourceDimY.ToString();
                    labelAspectRatio.Text = sourceDimX > sourceDimY ?
                                            ((double)sourceDimX / (double)sourceDimY).ToString("0.##") + "/1" :
                                            "1/" + ((double)sourceDimY / (double)sourceDimX).ToString("0.##");
                    pictureBoxPreview.Image = firstImage;
                    //firstImage.Dispose();
                }
            }
        }

        float sourceAspect;
        float targetAspect;
        int cropW = 0, cropH = 0, cropX = 0, cropY = 0;

        private void buttonGenerateVideo_Click(object sender, EventArgs e)
        {
            sourceAspect = (float)sourceDimX / (float)sourceDimY;
            targetAspect = (float)resX / (float)resY;
            cropW = 0;
            cropH = 0;
            switch(comboBoxScaleCrop.SelectedIndex)
            {
                // Scale to fit within
                case 0:
                    if(targetAspect > sourceAspect)
                    {
                        resX = (int)((float)resY * sourceAspect);
                        // Make sure resolution is divisible by two
                        resX &= ~1;
                    }
                    else
                    {
                        resY = (int)((float)resX / sourceAspect);
                        // Make sure resolution is divisible by two
                        resY &= ~1;
                    }
                    break;
                // Stretch to fit
                case 1:
                    break;
                // Crop to fit
                case 2:
                    cropW = resX;
                    cropH = resY;
                    if (targetAspect > sourceAspect)
                    {
                        cropX = 0;
                        cropY = 0;
                    }
                    else
                    {
                        cropX = 0;
                        cropY = 0;
                    }
                    break;
                // Scale to fit outside
                case 3:
                    if (targetAspect > sourceAspect)
                    {
                        resY = (int)((float)resX / sourceAspect);
                        // Make sure resolution is divisible by two
                        resY &= ~1;
                    }
                    else
                    {
                        resX = (int)((float)resY * sourceAspect);
                        // Make sure resolution is divisible by two
                        resX &= ~1;
                    }
                    break;
                default:
                    break;
            }

            if (selectedDirectoryList != null)
            {
                foreach (string directory in selectedDirectoryList)
                {
                    prepareFfmpegCommand(directory, null, true);
                }
            }
            else prepareFfmpegCommand(homeDirectory, selectedFileList, false);
        }

        public void prepareFfmpegCommand(string fileDirectory, string [] fileList, bool waitForExit)
        { 
            string command = "ffmpeg";
            command += " -r " + numericUpDown1.Value.ToString();
            if (fileList != null) selectedFileList = fileList;
            else selectedFileList = System.IO.Directory.GetFiles(fileDirectory, "*.jpg");
            if (fileDirectory == null) fileDirectory = Path.GetDirectoryName(fileList[0]);
            if (selectedFileList != null && selectedFileList.Length > 0)
            {
                // If the selected file list contains anything, use 'random file name' mode, and save a file list to use as input for ffmpeg

                string inputFileName = "ffmpeg_input.txt";

                // Delete file if it already exists
                if (File.Exists(inputFileName))
                {
                    File.Delete(inputFileName);
                }

                // Create file list file
                using (StreamWriter fileWriter = new StreamWriter(inputFileName))
                {
                    foreach (string fName in selectedFileList)
                    {
                        fileWriter.WriteLine("file '" + fName + "'");
                    }
                }

                // Configure ffmpeg to use the file list
                command += " -f concat -safe 0 -i " + inputFileName;
            }
            else
            {
                // Use the default mode, where the file names are expected to follow Nikon standard naming convention
                command += " -start_number " + timelapseFileListStartIndex;
                command += " -i " + "\"" + fileDirectory + "\\" + timelapseFileListPrefix + "_%04d.jpg\"";
            }

            // Change pixel format to allow importing into premiere
            command += " -pix_fmt yuv420p";

            // Video filters
            bool videoFiltersUsed = false;
            if (cropW > 0 || cropH > 0)
            {
                if (targetAspect > sourceAspect)
                {
                    command += " -vf \"crop=" + "in_w" + ":" + "in_h*" + (sourceAspect / targetAspect).ToString();
                }
                else
                {
                    command += " -vf \"crop=" + "in_w*" + (targetAspect / sourceAspect).ToString() + ":" + "in_h";
                }
                videoFiltersUsed = true;
                //command += " -filter:v \"crop = " + cropW.ToString() + ":" + cropH.ToString() + ":" + cropX.ToString() + ":" + cropY.ToString() + "\"";
            }
            // Add sharpening
            if (checkBoxSharpen.Checked)
            {
                if (!videoFiltersUsed)
                {
                    command += " -vf \"unsharp=3:3:1.5";
                    videoFiltersUsed = true;
                }
                else
                {
                    command += ",unsharp=3:3:1.5";
                }
            }
            if (videoFiltersUsed) command += "\"";
            command += " -s " + resX.ToString() + "x" + resY.ToString();
            command += " -vcodec libx264";
            command += " \"" + fileDirectory + "\\" + textBoxOutFileName.Text + "\"";
            logMessage(command);
            ExecuteCommand(command, waitForExit);
        }

        public void ExecuteCommand(string Command, bool waitForExit)
        {
            ProcessStartInfo ProcessInfo;
            Process Process;

            String runMethod = checkBoxAutoClose.Checked ? "/C " : "/K ";
            ProcessInfo = new ProcessStartInfo("cmd.exe", runMethod + Command);
            ProcessInfo.CreateNoWindow = false;
            ProcessInfo.UseShellExecute = false;

            Process = Process.Start(ProcessInfo);
            if(waitForExit) Process.WaitForExit();
        }

        private void textBoxResX_TextChanged(object sender, EventArgs e)
        {
            if(textBoxResX.Enabled)
            {
                if(Int32.TryParse(textBoxResX.Text, out resX))
                {
                    fileNameResPostfix = resX.ToString() + "x" + resY.ToString();
                    setOutFileName();
                }
            }
        }

        private void textBoxResY_TextChanged(object sender, EventArgs e)
        {
            if (textBoxResY.Enabled)
            {
                if (Int32.TryParse(textBoxResY.Text, out resY))
                {
                    fileNameResPostfix = resX.ToString() + "x" + resY.ToString();
                    setOutFileName();
                }
            }
        }

        private void comboBoxScaleCrop_SelectedIndexChanged(object sender, EventArgs e)
        {
            setOutFileName();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            setOutFileName();
        }

        private void checkBoxSharpen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonLoadFiles_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            selectedFileList = openFileDialog1.FileNames;
            selectedDirectoryList = null;
            resetProjectFileList();
            logMessage(selectedFileList.Length + " files loaded");
        }

        private void buttonLoadDirectories_Click(object sender, EventArgs e)
        {
            folderBrowserDialog2.ShowDialog();
            if(folderBrowserDialog2.SelectedPath != null && folderBrowserDialog2.SelectedPath != "")
            {
                selectedDirectoryList = System.IO.Directory.GetDirectories(folderBrowserDialog2.SelectedPath);
                selectedFileList = null;
                resetProjectFileList();
            }
        }

        private void buttonLoadDirectory_Click(object sender, EventArgs e)
        {
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if(result == DialogResult.OK)
            {
                resetProject(folderBrowserDialog1.SelectedPath);
                selectedFileList = null;
                setOutFileName();
            }
        }

        private void comboBoxResolution_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool customTextBoxesEnabled = false;
            if(comboBoxResolution.SelectedIndex < (comboBoxResolution.Items.Count - 1))
            {
                resX = resOptions[comboBoxResolution.SelectedIndex].resX;
                resY = resOptions[comboBoxResolution.SelectedIndex].resY;
                fileNameResPostfix = resOptions[comboBoxResolution.SelectedIndex].filePostfixName;
            }
            else
            {
                customTextBoxesEnabled = true;
                if (Int32.TryParse(textBoxResX.Text, out resX) && Int32.TryParse(textBoxResY.Text, out resY))
                {
                    fileNameResPostfix = resX.ToString() + "x" + resY.ToString();
                }
                else fileNameResPostfix = "";
            }
            textBoxResX.Text = resX.ToString();
            textBoxResY.Text = resY.ToString();
            textBoxResX.Enabled = textBoxResY.Enabled = customTextBoxesEnabled;
            setOutFileName();
        }

        public void setOutFileName()
        {
            switch (comboBoxScaleCrop.SelectedIndex)
            {
                case 0:
                    fileNameScaleCropPostfix = "fi";
                    break;
                case 1:
                    fileNameScaleCropPostfix = "s";
                    break;
                case 2:
                    fileNameScaleCropPostfix = "c";
                    break;
                case 3:
                    fileNameScaleCropPostfix = "fo";
                    break;
                default:
                    fileNameScaleCropPostfix = "";
                    break;
            }
            textBoxOutFileName.Text = timelapseFileListPrefix + "_" + timelapseFileListStartIndex + "_interval_" + fileNameResPostfix + "_" + numericUpDown1.Value.ToString() + "f_" + fileNameScaleCropPostfix + ".mp4";
        }
    }

    public class FileInfo
    {
        public Boolean ValidFile;
        public int FileIndex;
        public string FilePrefix;
        public string FileName;

    }

    public class OutResolutions
    {
        public int resX;
        public int resY;
        public string comboBoxName;
        public string filePostfixName;

        public OutResolutions(int x, int y, string cName, string pfName)
        {
            resX = x;
            resY = y;
            comboBoxName = cName;
            filePostfixName = pfName;
        }
    }
}
