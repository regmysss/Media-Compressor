namespace Compressor
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            openFileDialog1 = new OpenFileDialog();
            InputPath = new TextBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            nameCodecVideo = new ComboBox();
            nameCodecAudio = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            bitrateVideo = new ComboBox();
            bitrateAudio = new ComboBox();
            label5 = new Label();
            compressionValue = new NumericUpDown();
            label6 = new Label();
            label7 = new Label();
            nameFile = new TextBox();
            textBox2 = new TextBox();
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            label8 = new Label();
            formatFile = new TextBox();
            loadingProcess = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)compressionValue).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // InputPath
            // 
            InputPath.AllowDrop = true;
            InputPath.Location = new Point(12, 12);
            InputPath.Multiline = true;
            InputPath.Name = "InputPath";
            InputPath.ReadOnly = true;
            InputPath.Size = new Size(367, 81);
            InputPath.TabIndex = 0;
            InputPath.Text = "Click and choose the file or drag the file here";
            InputPath.Click += InputPath_Click;
            InputPath.DragDrop += InputPath_DragDrop;
            InputPath.DragEnter += InputPath_DragEnter;
            // 
            // button1
            // 
            button1.Location = new Point(117, 364);
            button1.Name = "button1";
            button1.Size = new Size(156, 29);
            button1.TabIndex = 1;
            button1.Text = "Compress";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 143);
            label1.Name = "label1";
            label1.Size = new Size(117, 15);
            label1.TabIndex = 4;
            label1.Text = "Choose video codec:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 143);
            label2.Name = "label2";
            label2.Size = new Size(118, 15);
            label2.TabIndex = 5;
            label2.Text = "Choose audio codec:";
            // 
            // nameCodecVideo
            // 
            nameCodecVideo.DropDownStyle = ComboBoxStyle.DropDownList;
            nameCodecVideo.FormattingEnabled = true;
            nameCodecVideo.Items.AddRange(new object[] { "Default", "H.264", "H.265", "VP9", "AV1", "MPEG-4", "MJPEG" });
            nameCodecVideo.Location = new Point(12, 161);
            nameCodecVideo.Name = "nameCodecVideo";
            nameCodecVideo.Size = new Size(162, 23);
            nameCodecVideo.TabIndex = 6;
            // 
            // nameCodecAudio
            // 
            nameCodecAudio.DropDownStyle = ComboBoxStyle.DropDownList;
            nameCodecAudio.FormattingEnabled = true;
            nameCodecAudio.Items.AddRange(new object[] { "Default", "AAC", "MP3", "Opus", "FLAC", "WAV", "Dolby AC-3" });
            nameCodecAudio.Location = new Point(217, 161);
            nameCodecAudio.Name = "nameCodecAudio";
            nameCodecAudio.Size = new Size(162, 23);
            nameCodecAudio.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 207);
            label3.Name = "label3";
            label3.Size = new Size(138, 15);
            label3.TabIndex = 8;
            label3.Text = "Choose bitrate video(М):";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(217, 207);
            label4.Name = "label4";
            label4.Size = new Size(135, 15);
            label4.TabIndex = 9;
            label4.Text = "Choose bitrate audio(K):";
            // 
            // bitrateVideo
            // 
            bitrateVideo.DropDownStyle = ComboBoxStyle.DropDownList;
            bitrateVideo.FormattingEnabled = true;
            bitrateVideo.Items.AddRange(new object[] { "Default", "1", "3", "6", "10", "20", "25" });
            bitrateVideo.Location = new Point(12, 225);
            bitrateVideo.Name = "bitrateVideo";
            bitrateVideo.Size = new Size(162, 23);
            bitrateVideo.TabIndex = 10;
            // 
            // bitrateAudio
            // 
            bitrateAudio.DropDownStyle = ComboBoxStyle.DropDownList;
            bitrateAudio.FormattingEnabled = true;
            bitrateAudio.Items.AddRange(new object[] { "Default", "32", "48", "64", "96", "128", "160", "192", "256", "320" });
            bitrateAudio.Location = new Point(217, 225);
            bitrateAudio.Name = "bitrateAudio";
            bitrateAudio.Size = new Size(162, 23);
            bitrateAudio.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 105);
            label5.Name = "label5";
            label5.Size = new Size(290, 15);
            label5.TabIndex = 12;
            label5.Text = "Enter compression from 0 to 51 (23 is recommended):";
            // 
            // compressionValue
            // 
            compressionValue.Location = new Point(308, 103);
            compressionValue.Maximum = new decimal(new int[] { 51, 0, 0, 0 });
            compressionValue.Name = "compressionValue";
            compressionValue.Size = new Size(71, 23);
            compressionValue.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(12, 317);
            label6.Name = "label6";
            label6.Size = new Size(155, 15);
            label6.TabIndex = 14;
            label6.Text = "Choose the path output file:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 263);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 15;
            label7.Text = "Name of this file:";
            // 
            // nameFile
            // 
            nameFile.Location = new Point(12, 281);
            nameFile.Name = "nameFile";
            nameFile.Size = new Size(162, 23);
            nameFile.TabIndex = 16;
            nameFile.Text = "Output";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 335);
            textBox2.Name = "textBox2";
            textBox2.ReadOnly = true;
            textBox2.Size = new Size(290, 23);
            textBox2.TabIndex = 17;
            // 
            // button2
            // 
            button2.Location = new Point(308, 335);
            button2.Name = "button2";
            button2.Size = new Size(71, 23);
            button2.TabIndex = 18;
            button2.Text = "Browse";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(217, 263);
            label8.Name = "label8";
            label8.Size = new Size(67, 15);
            label8.TabIndex = 20;
            label8.Text = "Format file:";
            // 
            // formatFile
            // 
            formatFile.Location = new Point(217, 281);
            formatFile.Name = "formatFile";
            formatFile.Size = new Size(162, 23);
            formatFile.TabIndex = 21;
            formatFile.Text = "mp4";
            // 
            // loadingProcess
            // 
            loadingProcess.Location = new Point(12, 396);
            loadingProcess.Name = "loadingProcess";
            loadingProcess.Size = new Size(367, 21);
            loadingProcess.TabIndex = 22;
            loadingProcess.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Tick += timer1_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(395, 419);
            Controls.Add(loadingProcess);
            Controls.Add(formatFile);
            Controls.Add(label8);
            Controls.Add(button2);
            Controls.Add(textBox2);
            Controls.Add(nameFile);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(compressionValue);
            Controls.Add(label5);
            Controls.Add(bitrateAudio);
            Controls.Add(bitrateVideo);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameCodecAudio);
            Controls.Add(nameCodecVideo);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(InputPath);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "CompressorVideo";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)compressionValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private TextBox InputPath;
        private Button button1;
        private ComboBox codecVideo;
        private ComboBox comboBox2;
        private Label label1;
        private Label label2;
        private ComboBox nameCodecVideo;
        private ComboBox nameCodecAudio;
        private Label label3;
        private Label label4;
        private ComboBox bitrateVideo;
        private ComboBox bitrateAudio;
        private Label label5;
        private NumericUpDown compressionValue;
        private Label label6;
        private Label label7;
        private TextBox nameFile;
        private TextBox textBox2;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label label8;
        private TextBox formatFile;
        private Label loadingProcess;
        private System.Windows.Forms.Timer timer1;
    }
}
