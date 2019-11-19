namespace UP1Official
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.wavTextBox = new System.Windows.Forms.TextBox();
            this.chooseFileButton = new System.Windows.Forms.Button();
            this.fileNameTextbox = new System.Windows.Forms.TextBox();
            this.playSoundBtn = new System.Windows.Forms.Button();
            this.stopPlaySoundBtn = new System.Windows.Forms.Button();
            this.mciPlayBtn = new System.Windows.Forms.Button();
            this.stopMCIBtn = new System.Windows.Forms.Button();
            this.recordButton = new System.Windows.Forms.Button();
            this.stopRecordBtn = new System.Windows.Forms.Button();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.wavDataBtn = new System.Windows.Forms.Button();
            this.startWMPBtn = new System.Windows.Forms.Button();
            this.stopWMPBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.SuspendLayout();
            // 
            // wavTextBox
            // 
            this.wavTextBox.Location = new System.Drawing.Point(12, 12);
            this.wavTextBox.Multiline = true;
            this.wavTextBox.Name = "wavTextBox";
            this.wavTextBox.Size = new System.Drawing.Size(354, 426);
            this.wavTextBox.TabIndex = 0;
            this.wavTextBox.Text = "Here will be displayed wav data.";
            // 
            // chooseFileButton
            // 
            this.chooseFileButton.Location = new System.Drawing.Point(631, 12);
            this.chooseFileButton.Name = "chooseFileButton";
            this.chooseFileButton.Size = new System.Drawing.Size(157, 72);
            this.chooseFileButton.TabIndex = 1;
            this.chooseFileButton.Text = "Choose file";
            this.chooseFileButton.UseVisualStyleBackColor = true;
            this.chooseFileButton.Click += new System.EventHandler(this.ChooseFileButton_Click);
            // 
            // fileNameTextbox
            // 
            this.fileNameTextbox.Location = new System.Drawing.Point(508, 90);
            this.fileNameTextbox.Multiline = true;
            this.fileNameTextbox.Name = "fileNameTextbox";
            this.fileNameTextbox.Size = new System.Drawing.Size(287, 72);
            this.fileNameTextbox.TabIndex = 2;
            this.fileNameTextbox.Text = "Here will be filename displayed";
            // 
            // playSoundBtn
            // 
            this.playSoundBtn.Location = new System.Drawing.Point(569, 169);
            this.playSoundBtn.Name = "playSoundBtn";
            this.playSoundBtn.Size = new System.Drawing.Size(105, 50);
            this.playSoundBtn.TabIndex = 3;
            this.playSoundBtn.Text = "PlaySound";
            this.playSoundBtn.UseVisualStyleBackColor = true;
            this.playSoundBtn.Click += new System.EventHandler(this.PlaySoundBtn_Click);
            // 
            // stopPlaySoundBtn
            // 
            this.stopPlaySoundBtn.Location = new System.Drawing.Point(680, 169);
            this.stopPlaySoundBtn.Name = "stopPlaySoundBtn";
            this.stopPlaySoundBtn.Size = new System.Drawing.Size(105, 50);
            this.stopPlaySoundBtn.TabIndex = 4;
            this.stopPlaySoundBtn.Text = "stop PlaySound";
            this.stopPlaySoundBtn.UseVisualStyleBackColor = true;
            this.stopPlaySoundBtn.Click += new System.EventHandler(this.StopPlaySoundBtn_Click);
            // 
            // mciPlayBtn
            // 
            this.mciPlayBtn.Location = new System.Drawing.Point(569, 226);
            this.mciPlayBtn.Name = "mciPlayBtn";
            this.mciPlayBtn.Size = new System.Drawing.Size(105, 37);
            this.mciPlayBtn.TabIndex = 5;
            this.mciPlayBtn.Text = "Start MCI";
            this.mciPlayBtn.UseVisualStyleBackColor = true;
            this.mciPlayBtn.Click += new System.EventHandler(this.MciPlayBtn_Click);
            // 
            // stopMCIBtn
            // 
            this.stopMCIBtn.Location = new System.Drawing.Point(683, 226);
            this.stopMCIBtn.Name = "stopMCIBtn";
            this.stopMCIBtn.Size = new System.Drawing.Size(105, 37);
            this.stopMCIBtn.TabIndex = 6;
            this.stopMCIBtn.Text = "Stop MCI";
            this.stopMCIBtn.UseVisualStyleBackColor = true;
            this.stopMCIBtn.Click += new System.EventHandler(this.StopMCIBtn_Click);
            // 
            // recordButton
            // 
            this.recordButton.Location = new System.Drawing.Point(569, 269);
            this.recordButton.Name = "recordButton";
            this.recordButton.Size = new System.Drawing.Size(105, 59);
            this.recordButton.TabIndex = 7;
            this.recordButton.Text = "Start recording";
            this.recordButton.UseVisualStyleBackColor = true;
            this.recordButton.Click += new System.EventHandler(this.RecordButton_Click);
            // 
            // stopRecordBtn
            // 
            this.stopRecordBtn.Location = new System.Drawing.Point(680, 269);
            this.stopRecordBtn.Name = "stopRecordBtn";
            this.stopRecordBtn.Size = new System.Drawing.Size(105, 59);
            this.stopRecordBtn.TabIndex = 8;
            this.stopRecordBtn.Text = "Stop recording";
            this.stopRecordBtn.UseVisualStyleBackColor = true;
            this.stopRecordBtn.Click += new System.EventHandler(this.StopRecordBtn_Click);
            // 
            // Player
            // 
            this.Player.Enabled = true;
            this.Player.Location = new System.Drawing.Point(720, 415);
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.Size = new System.Drawing.Size(75, 23);
            this.Player.TabIndex = 9;
            this.Player.Visible = false;
            // 
            // wavDataBtn
            // 
            this.wavDataBtn.Location = new System.Drawing.Point(373, 25);
            this.wavDataBtn.Name = "wavDataBtn";
            this.wavDataBtn.Size = new System.Drawing.Size(102, 69);
            this.wavDataBtn.TabIndex = 10;
            this.wavDataBtn.Text = "Show wav data";
            this.wavDataBtn.UseVisualStyleBackColor = true;
            this.wavDataBtn.Click += new System.EventHandler(this.WavDataBtn_Click);
            // 
            // startWMPBtn
            // 
            this.startWMPBtn.Location = new System.Drawing.Point(569, 334);
            this.startWMPBtn.Name = "startWMPBtn";
            this.startWMPBtn.Size = new System.Drawing.Size(105, 53);
            this.startWMPBtn.TabIndex = 11;
            this.startWMPBtn.Text = "Start WMP";
            this.startWMPBtn.UseVisualStyleBackColor = true;
            this.startWMPBtn.Click += new System.EventHandler(this.StartWMPBtn_Click);
            // 
            // stopWMPBtn
            // 
            this.stopWMPBtn.Location = new System.Drawing.Point(680, 334);
            this.stopWMPBtn.Name = "stopWMPBtn";
            this.stopWMPBtn.Size = new System.Drawing.Size(105, 53);
            this.stopWMPBtn.TabIndex = 12;
            this.stopWMPBtn.Text = "Stop WMP";
            this.stopWMPBtn.UseVisualStyleBackColor = true;
            this.stopWMPBtn.Click += new System.EventHandler(this.StopWMPBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(447, 269);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(116, 46);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "recsound";
            this.textBox1.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 243);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nazwa pliku do nagrania";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.stopWMPBtn);
            this.Controls.Add(this.startWMPBtn);
            this.Controls.Add(this.wavDataBtn);
            this.Controls.Add(this.Player);
            this.Controls.Add(this.stopRecordBtn);
            this.Controls.Add(this.recordButton);
            this.Controls.Add(this.stopMCIBtn);
            this.Controls.Add(this.mciPlayBtn);
            this.Controls.Add(this.stopPlaySoundBtn);
            this.Controls.Add(this.playSoundBtn);
            this.Controls.Add(this.fileNameTextbox);
            this.Controls.Add(this.chooseFileButton);
            this.Controls.Add(this.wavTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox wavTextBox;
        private System.Windows.Forms.Button chooseFileButton;
        private System.Windows.Forms.TextBox fileNameTextbox;
        private System.Windows.Forms.Button playSoundBtn;
        private System.Windows.Forms.Button stopPlaySoundBtn;
        private System.Windows.Forms.Button mciPlayBtn;
        private System.Windows.Forms.Button stopMCIBtn;
        private System.Windows.Forms.Button recordButton;
        private System.Windows.Forms.Button stopRecordBtn;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button wavDataBtn;
        private System.Windows.Forms.Button startWMPBtn;
        private System.Windows.Forms.Button stopWMPBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

