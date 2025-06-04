
namespace Bed_Time_Story
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
            this.playButton = new System.Windows.Forms.Button();
            this.pauseButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.loadPdfButton = new System.Windows.Forms.Button();
            this.loadedPdfTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.startPageTextbox = new System.Windows.Forms.TextBox();
            this.endPageTextbox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.loadedPdfTotalPageLabel = new System.Windows.Forms.Label();
            this.clearPdfButton = new System.Windows.Forms.Button();
            this.displayPdfTextbox = new System.Windows.Forms.TextBox();
            this.pdfWebBrowser = new Microsoft.Web.WebView2.WinForms.WebView2();
            this.voiceSelectCombobox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.talkSpeedSlider = new System.Windows.Forms.TrackBar();
            this.talkVolumeSlider = new System.Windows.Forms.TrackBar();
            this.customTextCheckBox = new System.Windows.Forms.CheckBox();
            this.darkModeCheckbox = new System.Windows.Forms.CheckBox();
            this.clearTextButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.openNotesButton = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pdfWebBrowser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkSpeedSlider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkVolumeSlider)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(12, 798);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // pauseButton
            // 
            this.pauseButton.Location = new System.Drawing.Point(93, 798);
            this.pauseButton.Name = "pauseButton";
            this.pauseButton.Size = new System.Drawing.Size(75, 23);
            this.pauseButton.TabIndex = 1;
            this.pauseButton.Text = "Pause";
            this.pauseButton.UseVisualStyleBackColor = true;
            this.pauseButton.Click += new System.EventHandler(this.pauseButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(174, 798);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 2;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(966, 798);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loadPdfButton
            // 
            this.loadPdfButton.Location = new System.Drawing.Point(12, 12);
            this.loadPdfButton.Name = "loadPdfButton";
            this.loadPdfButton.Size = new System.Drawing.Size(75, 23);
            this.loadPdfButton.TabIndex = 4;
            this.loadPdfButton.Text = "Load PDF";
            this.loadPdfButton.UseVisualStyleBackColor = true;
            this.loadPdfButton.Click += new System.EventHandler(this.loadPdfButton_Click);
            // 
            // loadedPdfTextbox
            // 
            this.loadedPdfTextbox.Location = new System.Drawing.Point(93, 41);
            this.loadedPdfTextbox.Name = "loadedPdfTextbox";
            this.loadedPdfTextbox.Size = new System.Drawing.Size(191, 20);
            this.loadedPdfTextbox.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Loaded PDF";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Read text from:";
            // 
            // startPageTextbox
            // 
            this.startPageTextbox.Location = new System.Drawing.Point(94, 72);
            this.startPageTextbox.Name = "startPageTextbox";
            this.startPageTextbox.Size = new System.Drawing.Size(100, 20);
            this.startPageTextbox.TabIndex = 8;
            // 
            // endPageTextbox
            // 
            this.endPageTextbox.Location = new System.Drawing.Point(225, 72);
            this.endPageTextbox.Name = "endPageTextbox";
            this.endPageTextbox.Size = new System.Drawing.Size(100, 20);
            this.endPageTextbox.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(200, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "to:";
            // 
            // loadedPdfTotalPageLabel
            // 
            this.loadedPdfTotalPageLabel.AutoSize = true;
            this.loadedPdfTotalPageLabel.Location = new System.Drawing.Point(290, 44);
            this.loadedPdfTotalPageLabel.Name = "loadedPdfTotalPageLabel";
            this.loadedPdfTotalPageLabel.Size = new System.Drawing.Size(35, 13);
            this.loadedPdfTotalPageLabel.TabIndex = 11;
            this.loadedPdfTotalPageLabel.Text = "label4";
            // 
            // clearPdfButton
            // 
            this.clearPdfButton.Location = new System.Drawing.Point(94, 12);
            this.clearPdfButton.Name = "clearPdfButton";
            this.clearPdfButton.Size = new System.Drawing.Size(75, 23);
            this.clearPdfButton.TabIndex = 12;
            this.clearPdfButton.Text = "Clear PDF";
            this.clearPdfButton.UseVisualStyleBackColor = true;
            this.clearPdfButton.Click += new System.EventHandler(this.clearPdfButton_Click);
            // 
            // displayPdfTextbox
            // 
            this.displayPdfTextbox.Location = new System.Drawing.Point(15, 98);
            this.displayPdfTextbox.Multiline = true;
            this.displayPdfTextbox.Name = "displayPdfTextbox";
            this.displayPdfTextbox.ReadOnly = true;
            this.displayPdfTextbox.Size = new System.Drawing.Size(503, 684);
            this.displayPdfTextbox.TabIndex = 13;
            // 
            // pdfWebBrowser
            // 
            this.pdfWebBrowser.AllowExternalDrop = true;
            this.pdfWebBrowser.CreationProperties = null;
            this.pdfWebBrowser.DefaultBackgroundColor = System.Drawing.Color.White;
            this.pdfWebBrowser.Location = new System.Drawing.Point(535, 98);
            this.pdfWebBrowser.Name = "pdfWebBrowser";
            this.pdfWebBrowser.Size = new System.Drawing.Size(506, 684);
            this.pdfWebBrowser.TabIndex = 14;
            this.pdfWebBrowser.ZoomFactor = 1D;
            // 
            // voiceSelectCombobox
            // 
            this.voiceSelectCombobox.FormattingEnabled = true;
            this.voiceSelectCombobox.Location = new System.Drawing.Point(363, 14);
            this.voiceSelectCombobox.Name = "voiceSelectCombobox";
            this.voiceSelectCombobox.Size = new System.Drawing.Size(171, 21);
            this.voiceSelectCombobox.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(290, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Voice Select";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(331, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Talk Speed";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(708, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Talk Volume";
            // 
            // talkSpeedSlider
            // 
            this.talkSpeedSlider.Location = new System.Drawing.Point(399, 47);
            this.talkSpeedSlider.Minimum = -10;
            this.talkSpeedSlider.Name = "talkSpeedSlider";
            this.talkSpeedSlider.Size = new System.Drawing.Size(261, 45);
            this.talkSpeedSlider.TabIndex = 19;
            // 
            // talkVolumeSlider
            // 
            this.talkVolumeSlider.LargeChange = 10;
            this.talkVolumeSlider.Location = new System.Drawing.Point(780, 47);
            this.talkVolumeSlider.Maximum = 100;
            this.talkVolumeSlider.Name = "talkVolumeSlider";
            this.talkVolumeSlider.Size = new System.Drawing.Size(261, 45);
            this.talkVolumeSlider.SmallChange = 5;
            this.talkVolumeSlider.TabIndex = 20;
            this.talkVolumeSlider.Value = 100;
            // 
            // customTextCheckBox
            // 
            this.customTextCheckBox.AutoSize = true;
            this.customTextCheckBox.Location = new System.Drawing.Point(277, 798);
            this.customTextCheckBox.Name = "customTextCheckBox";
            this.customTextCheckBox.Size = new System.Drawing.Size(108, 17);
            this.customTextCheckBox.TabIndex = 21;
            this.customTextCheckBox.Text = "Enter custom text";
            this.customTextCheckBox.UseVisualStyleBackColor = true;
            this.customTextCheckBox.CheckedChanged += new System.EventHandler(this.customTextCheckBox_CheckedChanged);
            // 
            // darkModeCheckbox
            // 
            this.darkModeCheckbox.AutoSize = true;
            this.darkModeCheckbox.Location = new System.Drawing.Point(560, 12);
            this.darkModeCheckbox.Name = "darkModeCheckbox";
            this.darkModeCheckbox.Size = new System.Drawing.Size(79, 17);
            this.darkModeCheckbox.TabIndex = 22;
            this.darkModeCheckbox.Text = "Dark Mode";
            this.darkModeCheckbox.UseVisualStyleBackColor = true;
            this.darkModeCheckbox.CheckedChanged += new System.EventHandler(this.darkModeCheckbox_CheckedChanged);
            // 
            // clearTextButton
            // 
            this.clearTextButton.Location = new System.Drawing.Point(443, 798);
            this.clearTextButton.Name = "clearTextButton";
            this.clearTextButton.Size = new System.Drawing.Size(75, 23);
            this.clearTextButton.TabIndex = 23;
            this.clearTextButton.Text = "Clear Text";
            this.clearTextButton.UseVisualStyleBackColor = true;
            this.clearTextButton.Click += new System.EventHandler(this.clearTextButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(430, 785);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(88, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Clear custom text";
            // 
            // openNotesButton
            // 
            this.openNotesButton.Location = new System.Drawing.Point(535, 798);
            this.openNotesButton.Name = "openNotesButton";
            this.openNotesButton.Size = new System.Drawing.Size(75, 23);
            this.openNotesButton.TabIndex = 25;
            this.openNotesButton.Text = "Notes";
            this.openNotesButton.UseVisualStyleBackColor = true;
            this.openNotesButton.Click += new System.EventHandler(this.openNotesButton_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(532, 785);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Custom notes";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 833);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.openNotesButton);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.clearTextButton);
            this.Controls.Add(this.darkModeCheckbox);
            this.Controls.Add(this.customTextCheckBox);
            this.Controls.Add(this.talkVolumeSlider);
            this.Controls.Add(this.talkSpeedSlider);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.voiceSelectCombobox);
            this.Controls.Add(this.pdfWebBrowser);
            this.Controls.Add(this.displayPdfTextbox);
            this.Controls.Add(this.clearPdfButton);
            this.Controls.Add(this.loadedPdfTotalPageLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.endPageTextbox);
            this.Controls.Add(this.startPageTextbox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.loadedPdfTextbox);
            this.Controls.Add(this.loadPdfButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.pauseButton);
            this.Controls.Add(this.playButton);
            this.Name = "Form1";
            this.Text = "Bed Time Story";
            ((System.ComponentModel.ISupportInitialize)(this.pdfWebBrowser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkSpeedSlider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.talkVolumeSlider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button pauseButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loadPdfButton;
        private System.Windows.Forms.TextBox loadedPdfTextbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox startPageTextbox;
        private System.Windows.Forms.TextBox endPageTextbox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label loadedPdfTotalPageLabel;
        private System.Windows.Forms.Button clearPdfButton;
        private System.Windows.Forms.TextBox displayPdfTextbox;
        private Microsoft.Web.WebView2.WinForms.WebView2 pdfWebBrowser;
        private System.Windows.Forms.ComboBox voiceSelectCombobox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TrackBar talkSpeedSlider;
        private System.Windows.Forms.TrackBar talkVolumeSlider;
        private System.Windows.Forms.CheckBox customTextCheckBox;
        private System.Windows.Forms.CheckBox darkModeCheckbox;
        private System.Windows.Forms.Button clearTextButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button openNotesButton;
        private System.Windows.Forms.Label label8;
    }
}

