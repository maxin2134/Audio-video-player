
namespace thinkgear_form
{
    partial class AudioVideoPlayer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AudioVideoPlayer));
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.picConnectionStatus = new System.Windows.Forms.PictureBox();
            this.lblPlayerStatus = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnSubtractVolume = new System.Windows.Forms.Button();
            this.btnAddVoulme = new System.Windows.Forms.Button();
            this.pnlPlay = new System.Windows.Forms.Panel();
            this.lblTimeValue = new System.Windows.Forms.Label();
            this.prbTimeLine = new System.Windows.Forms.ProgressBar();
            this.ltbFiles = new System.Windows.Forms.ListBox();
            this.Player = new AxWMPLib.AxWindowsMediaPlayer();
            this.grbButtons = new System.Windows.Forms.GroupBox();
            this.lblVolumeName = new System.Windows.Forms.Label();
            this.lblAudioVolume = new System.Windows.Forms.Label();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.timerSongTimeLine = new System.Windows.Forms.Timer(this.components);
            this.imgLstConnectionStatus = new System.Windows.Forms.ImageList(this.components);
            this.timerButtonSound = new System.Windows.Forms.Timer(this.components);
            this.timerSettingsMode = new System.Windows.Forms.Timer(this.components);
            this.btnMinimalise = new System.Windows.Forms.Button();
            this.pnlTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).BeginInit();
            this.pnlPlay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            this.grbButtons.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlTitle.Controls.Add(this.btnMinimalise);
            this.pnlTitle.Controls.Add(this.btnExit);
            this.pnlTitle.Controls.Add(this.picConnectionStatus);
            this.pnlTitle.Controls.Add(this.lblPlayerStatus);
            this.pnlTitle.Controls.Add(this.lblTitle);
            resources.ApplyResources(this.pnlTitle, "pnlTitle");
            this.pnlTitle.Name = "pnlTitle";
            // 
            // btnExit
            // 
            resources.ApplyResources(this.btnExit, "btnExit");
            this.btnExit.ForeColor = System.Drawing.Color.Silver;
            this.btnExit.Name = "btnExit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // picConnectionStatus
            // 
            resources.ApplyResources(this.picConnectionStatus, "picConnectionStatus");
            this.picConnectionStatus.Name = "picConnectionStatus";
            this.picConnectionStatus.TabStop = false;
            // 
            // lblPlayerStatus
            // 
            resources.ApplyResources(this.lblPlayerStatus, "lblPlayerStatus");
            this.lblPlayerStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerStatus.ForeColor = System.Drawing.Color.Silver;
            this.lblPlayerStatus.Name = "lblPlayerStatus";
            // 
            // lblTitle
            // 
            resources.ApplyResources(this.lblTitle, "lblTitle");
            this.lblTitle.ForeColor = System.Drawing.Color.Silver;
            this.lblTitle.Name = "lblTitle";
            // 
            // btnSubtractVolume
            // 
            resources.ApplyResources(this.btnSubtractVolume, "btnSubtractVolume");
            this.btnSubtractVolume.Name = "btnSubtractVolume";
            this.btnSubtractVolume.UseVisualStyleBackColor = true;
            this.btnSubtractVolume.Click += new System.EventHandler(this.btnSubtractVolume_Click);
            // 
            // btnAddVoulme
            // 
            resources.ApplyResources(this.btnAddVoulme, "btnAddVoulme");
            this.btnAddVoulme.Name = "btnAddVoulme";
            this.btnAddVoulme.UseVisualStyleBackColor = true;
            this.btnAddVoulme.Click += new System.EventHandler(this.btnAddVoulme_Click);
            // 
            // pnlPlay
            // 
            this.pnlPlay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            this.pnlPlay.Controls.Add(this.lblTimeValue);
            this.pnlPlay.Controls.Add(this.prbTimeLine);
            this.pnlPlay.Controls.Add(this.ltbFiles);
            this.pnlPlay.Controls.Add(this.Player);
            this.pnlPlay.Controls.Add(this.grbButtons);
            resources.ApplyResources(this.pnlPlay, "pnlPlay");
            this.pnlPlay.Name = "pnlPlay";
            // 
            // lblTimeValue
            // 
            resources.ApplyResources(this.lblTimeValue, "lblTimeValue");
            this.lblTimeValue.ForeColor = System.Drawing.Color.Silver;
            this.lblTimeValue.Name = "lblTimeValue";
            // 
            // prbTimeLine
            // 
            this.prbTimeLine.ForeColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.prbTimeLine, "prbTimeLine");
            this.prbTimeLine.Name = "prbTimeLine";
            // 
            // ltbFiles
            // 
            this.ltbFiles.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(49)))));
            resources.ApplyResources(this.ltbFiles, "ltbFiles");
            this.ltbFiles.ForeColor = System.Drawing.Color.Silver;
            this.ltbFiles.FormattingEnabled = true;
            this.ltbFiles.Name = "ltbFiles";
            this.ltbFiles.DoubleClick += new System.EventHandler(this.ltbFiles_DoubleClick);
            // 
            // Player
            // 
            resources.ApplyResources(this.Player, "Player");
            this.Player.Name = "Player";
            this.Player.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("Player.OcxState")));
            this.Player.DoubleClickEvent += new AxWMPLib._WMPOCXEvents_DoubleClickEventHandler(this.Player_DoubleClickEvent);
            // 
            // grbButtons
            // 
            this.grbButtons.Controls.Add(this.btnSubtractVolume);
            this.grbButtons.Controls.Add(this.lblVolumeName);
            this.grbButtons.Controls.Add(this.btnAddVoulme);
            this.grbButtons.Controls.Add(this.lblAudioVolume);
            this.grbButtons.Controls.Add(this.trbVolume);
            this.grbButtons.Controls.Add(this.btnOpen);
            this.grbButtons.Controls.Add(this.btnNext);
            this.grbButtons.Controls.Add(this.btnPrevious);
            this.grbButtons.Controls.Add(this.btnStop);
            this.grbButtons.Controls.Add(this.btnPause);
            this.grbButtons.Controls.Add(this.btnPlay);
            resources.ApplyResources(this.grbButtons, "grbButtons");
            this.grbButtons.ForeColor = System.Drawing.Color.Silver;
            this.grbButtons.Name = "grbButtons";
            this.grbButtons.TabStop = false;
            // 
            // lblVolumeName
            // 
            resources.ApplyResources(this.lblVolumeName, "lblVolumeName");
            this.lblVolumeName.CausesValidation = false;
            this.lblVolumeName.Name = "lblVolumeName";
            // 
            // lblAudioVolume
            // 
            resources.ApplyResources(this.lblAudioVolume, "lblAudioVolume");
            this.lblAudioVolume.Name = "lblAudioVolume";
            // 
            // trbVolume
            // 
            this.trbVolume.LargeChange = 1;
            resources.ApplyResources(this.trbVolume, "trbVolume");
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.TickFrequency = 0;
            this.trbVolume.Value = 25;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // btnOpen
            // 
            resources.ApplyResources(this.btnOpen, "btnOpen");
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnNext
            // 
            resources.ApplyResources(this.btnNext, "btnNext");
            this.btnNext.Name = "btnNext";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnPrevious
            // 
            resources.ApplyResources(this.btnPrevious, "btnPrevious");
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnStop
            // 
            resources.ApplyResources(this.btnStop, "btnStop");
            this.btnStop.Name = "btnStop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            resources.ApplyResources(this.btnPause, "btnPause");
            this.btnPause.Name = "btnPause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            resources.ApplyResources(this.btnPlay, "btnPlay");
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // timerSongTimeLine
            // 
            this.timerSongTimeLine.Tick += new System.EventHandler(this.timerSong_Tick);
            // 
            // imgLstConnectionStatus
            // 
            this.imgLstConnectionStatus.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imgLstConnectionStatus.ImageStream")));
            this.imgLstConnectionStatus.TransparentColor = System.Drawing.Color.Transparent;
            this.imgLstConnectionStatus.Images.SetKeyName(0, "connected_v1.png");
            this.imgLstConnectionStatus.Images.SetKeyName(1, "connecting1_v1.png");
            this.imgLstConnectionStatus.Images.SetKeyName(2, "connecting2_v1.png");
            this.imgLstConnectionStatus.Images.SetKeyName(3, "connecting3_v1.png");
            this.imgLstConnectionStatus.Images.SetKeyName(4, "nosignal_v1.png");
            // 
            // timerButtonSound
            // 
            this.timerButtonSound.Interval = 500;
            this.timerButtonSound.Tick += new System.EventHandler(this.timerButtonSound_Tick);
            // 
            // timerSettingsMode
            // 
            this.timerSettingsMode.Interval = 750;
            this.timerSettingsMode.Tick += new System.EventHandler(this.timerSettingsMode_Tick);
            // 
            // btnMinimalise
            // 
            resources.ApplyResources(this.btnMinimalise, "btnMinimalise");
            this.btnMinimalise.ForeColor = System.Drawing.Color.Silver;
            this.btnMinimalise.Name = "btnMinimalise";
            this.btnMinimalise.UseVisualStyleBackColor = true;
            this.btnMinimalise.Click += new System.EventHandler(this.btnMinimalise_Click);
            // 
            // AudioVideoPlayer
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.Controls.Add(this.pnlPlay);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AudioVideoPlayer";
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picConnectionStatus)).EndInit();
            this.pnlPlay.ResumeLayout(false);
            this.pnlPlay.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            this.grbButtons.ResumeLayout(false);
            this.grbButtons.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel pnlPlay;
        private System.Windows.Forms.GroupBox grbButtons;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private AxWMPLib.AxWindowsMediaPlayer Player;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.ListBox ltbFiles;
        private System.Windows.Forms.Label lblAudioVolume;
        private System.Windows.Forms.TrackBar trbVolume;
        private System.Windows.Forms.ProgressBar prbTimeLine;
        private System.Windows.Forms.Label lblVolumeName;
        private System.Windows.Forms.Label lblTimeValue;
        private System.Windows.Forms.Label lblPlayerStatus;
        private System.Windows.Forms.Timer timerSongTimeLine;
        private System.Windows.Forms.PictureBox picConnectionStatus;
        private System.Windows.Forms.ImageList imgLstConnectionStatus;
        private System.Windows.Forms.Timer timerButtonSound;
        private System.Windows.Forms.Button btnSubtractVolume;
        private System.Windows.Forms.Button btnAddVoulme;
        private System.Windows.Forms.Timer timerSettingsMode;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnMinimalise;
    }
}