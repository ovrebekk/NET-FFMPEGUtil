namespace FfmpegUtil
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxResolution = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxSharpen = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonGenerateVideo = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBoxLog = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelStartNum = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumFiles = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxScaleCrop = new System.Windows.Forms.ComboBox();
            this.labelResolution = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelAspectRatio = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxAutoClose = new System.Windows.Forms.CheckBox();
            this.pictureBoxPreview = new System.Windows.Forms.PictureBox();
            this.buttonLoadDirectory = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.labelFolder = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxResX = new System.Windows.Forms.TextBox();
            this.textBoxResY = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxResolution
            // 
            this.comboBoxResolution.FormattingEnabled = true;
            this.comboBoxResolution.Location = new System.Drawing.Point(96, 52);
            this.comboBoxResolution.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxResolution.Name = "comboBoxResolution";
            this.comboBoxResolution.Size = new System.Drawing.Size(109, 21);
            this.comboBoxResolution.TabIndex = 0;
            this.comboBoxResolution.SelectedIndexChanged += new System.EventHandler(this.comboBoxResolution_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Resolution";
            // 
            // checkBoxSharpen
            // 
            this.checkBoxSharpen.AutoSize = true;
            this.checkBoxSharpen.Checked = true;
            this.checkBoxSharpen.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxSharpen.Location = new System.Drawing.Point(96, 78);
            this.checkBoxSharpen.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxSharpen.Name = "checkBoxSharpen";
            this.checkBoxSharpen.Size = new System.Drawing.Size(15, 14);
            this.checkBoxSharpen.TabIndex = 2;
            this.checkBoxSharpen.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sharpen";
            // 
            // buttonGenerateVideo
            // 
            this.buttonGenerateVideo.Location = new System.Drawing.Point(6, 383);
            this.buttonGenerateVideo.Margin = new System.Windows.Forms.Padding(2);
            this.buttonGenerateVideo.Name = "buttonGenerateVideo";
            this.buttonGenerateVideo.Size = new System.Drawing.Size(232, 29);
            this.buttonGenerateVideo.TabIndex = 4;
            this.buttonGenerateVideo.Text = "Generate Video";
            this.buttonGenerateVideo.UseVisualStyleBackColor = true;
            this.buttonGenerateVideo.Click += new System.EventHandler(this.buttonGenerateVideo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(4, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Framerate";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(96, 99);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(40, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // textBoxLog
            // 
            this.textBoxLog.Location = new System.Drawing.Point(6, 272);
            this.textBoxLog.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxLog.Name = "textBoxLog";
            this.textBoxLog.Size = new System.Drawing.Size(313, 108);
            this.textBoxLog.TabIndex = 7;
            this.textBoxLog.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(4, 160);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Start Number";
            // 
            // labelStartNum
            // 
            this.labelStartNum.AutoSize = true;
            this.labelStartNum.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStartNum.Location = new System.Drawing.Point(94, 160);
            this.labelStartNum.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelStartNum.Name = "labelStartNum";
            this.labelStartNum.Size = new System.Drawing.Size(24, 13);
            this.labelStartNum.TabIndex = 9;
            this.labelStartNum.Text = "test";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(4, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of files";
            // 
            // labelNumFiles
            // 
            this.labelNumFiles.AutoSize = true;
            this.labelNumFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumFiles.Location = new System.Drawing.Point(94, 178);
            this.labelNumFiles.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumFiles.Name = "labelNumFiles";
            this.labelNumFiles.Size = new System.Drawing.Size(24, 13);
            this.labelNumFiles.TabIndex = 11;
            this.labelNumFiles.Text = "test";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(4, 126);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Scale/crop";
            // 
            // comboBoxScaleCrop
            // 
            this.comboBoxScaleCrop.FormattingEnabled = true;
            this.comboBoxScaleCrop.Items.AddRange(new object[] {
            "Scale to fit within",
            "Stretch to fit",
            "Crop to fit within",
            "Scale to fit outside"});
            this.comboBoxScaleCrop.Location = new System.Drawing.Point(96, 124);
            this.comboBoxScaleCrop.Margin = new System.Windows.Forms.Padding(2);
            this.comboBoxScaleCrop.Name = "comboBoxScaleCrop";
            this.comboBoxScaleCrop.Size = new System.Drawing.Size(109, 21);
            this.comboBoxScaleCrop.TabIndex = 13;
            this.comboBoxScaleCrop.SelectedIndexChanged += new System.EventHandler(this.comboBoxScaleCrop_SelectedIndexChanged);
            // 
            // labelResolution
            // 
            this.labelResolution.AutoSize = true;
            this.labelResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResolution.Location = new System.Drawing.Point(94, 197);
            this.labelResolution.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelResolution.Name = "labelResolution";
            this.labelResolution.Size = new System.Drawing.Size(24, 13);
            this.labelResolution.TabIndex = 15;
            this.labelResolution.Text = "test";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 197);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Resolution";
            // 
            // labelAspectRatio
            // 
            this.labelAspectRatio.AutoSize = true;
            this.labelAspectRatio.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAspectRatio.Location = new System.Drawing.Point(94, 215);
            this.labelAspectRatio.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAspectRatio.Name = "labelAspectRatio";
            this.labelAspectRatio.Size = new System.Drawing.Size(24, 13);
            this.labelAspectRatio.TabIndex = 17;
            this.labelAspectRatio.Text = "test";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(4, 215);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Aspect ratio";
            // 
            // checkBoxAutoClose
            // 
            this.checkBoxAutoClose.AutoSize = true;
            this.checkBoxAutoClose.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxAutoClose.Checked = true;
            this.checkBoxAutoClose.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoClose.Location = new System.Drawing.Point(242, 391);
            this.checkBoxAutoClose.Margin = new System.Windows.Forms.Padding(2);
            this.checkBoxAutoClose.Name = "checkBoxAutoClose";
            this.checkBoxAutoClose.Size = new System.Drawing.Size(74, 17);
            this.checkBoxAutoClose.TabIndex = 18;
            this.checkBoxAutoClose.Text = "AutoClose";
            this.checkBoxAutoClose.UseVisualStyleBackColor = true;
            // 
            // pictureBoxPreview
            // 
            this.pictureBoxPreview.Location = new System.Drawing.Point(206, 160);
            this.pictureBoxPreview.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBoxPreview.Name = "pictureBoxPreview";
            this.pictureBoxPreview.Size = new System.Drawing.Size(107, 68);
            this.pictureBoxPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxPreview.TabIndex = 19;
            this.pictureBoxPreview.TabStop = false;
            // 
            // buttonLoadDirectory
            // 
            this.buttonLoadDirectory.Location = new System.Drawing.Point(6, 6);
            this.buttonLoadDirectory.Margin = new System.Windows.Forms.Padding(2);
            this.buttonLoadDirectory.Name = "buttonLoadDirectory";
            this.buttonLoadDirectory.Size = new System.Drawing.Size(98, 22);
            this.buttonLoadDirectory.TabIndex = 20;
            this.buttonLoadDirectory.Text = "Load Directory";
            this.buttonLoadDirectory.UseVisualStyleBackColor = true;
            this.buttonLoadDirectory.Click += new System.EventHandler(this.buttonLoadDirectory_Click);
            // 
            // labelFolder
            // 
            this.labelFolder.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFolder.Location = new System.Drawing.Point(94, 233);
            this.labelFolder.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFolder.Name = "labelFolder";
            this.labelFolder.Size = new System.Drawing.Size(224, 37);
            this.labelFolder.TabIndex = 22;
            this.labelFolder.Text = "test";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Lato", 7.875F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(4, 233);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(60, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Base Folder";
            // 
            // textBoxResX
            // 
            this.textBoxResX.Enabled = false;
            this.textBoxResX.Location = new System.Drawing.Point(206, 53);
            this.textBoxResX.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResX.Name = "textBoxResX";
            this.textBoxResX.Size = new System.Drawing.Size(54, 20);
            this.textBoxResX.TabIndex = 23;
            this.textBoxResX.Text = "1280";
            this.textBoxResX.TextChanged += new System.EventHandler(this.textBoxResX_TextChanged);
            // 
            // textBoxResY
            // 
            this.textBoxResY.Enabled = false;
            this.textBoxResY.Location = new System.Drawing.Point(262, 53);
            this.textBoxResY.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxResY.Name = "textBoxResY";
            this.textBoxResY.Size = new System.Drawing.Size(54, 20);
            this.textBoxResY.TabIndex = 24;
            this.textBoxResY.Text = "720";
            this.textBoxResY.TextChanged += new System.EventHandler(this.textBoxResY_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(108, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 22);
            this.button1.TabIndex = 25;
            this.button1.Text = "Load Files";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "*.jpg";
            this.openFileDialog1.Filter = "JPG files|*.jpg";
            this.openFileDialog1.Multiselect = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 423);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxResY);
            this.Controls.Add(this.textBoxResX);
            this.Controls.Add(this.labelFolder);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buttonLoadDirectory);
            this.Controls.Add(this.pictureBoxPreview);
            this.Controls.Add(this.checkBoxAutoClose);
            this.Controls.Add(this.labelAspectRatio);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.labelResolution);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.comboBoxScaleCrop);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelNumFiles);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.labelStartNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxLog);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonGenerateVideo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxSharpen);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxResolution);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "FFMPEGUtil - July 11th 2018";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxResolution;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxSharpen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonGenerateVideo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.RichTextBox textBoxLog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelStartNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumFiles;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxScaleCrop;
        private System.Windows.Forms.Label labelResolution;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelAspectRatio;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxAutoClose;
        private System.Windows.Forms.PictureBox pictureBoxPreview;
        private System.Windows.Forms.Button buttonLoadDirectory;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Label labelFolder;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxResX;
        private System.Windows.Forms.TextBox textBoxResY;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

