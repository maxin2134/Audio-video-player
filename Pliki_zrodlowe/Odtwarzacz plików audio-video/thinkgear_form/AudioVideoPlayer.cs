using System;
using System.ComponentModel;
using System.Windows.Forms;
using NeuroSky.ThinkGear;
using System.Collections.Generic;
using System.Media;
using System.Diagnostics;

namespace thinkgear_form
{
    public partial class AudioVideoPlayer : Form
    {
        #region Global Vars

        string[] Paths, Files, ButtonsSounds;
        string Playing = "Playing...";

        SoundPlayer soundPlayer;

        List<Button> PlayerButtonsList = new List<Button>();

        Connector connector;

        bool IsPlaying = false;
        bool IsSettingsMode = true;

        int ButtonFocus = 0;
        int TimerSettingCounting = 0;
        int BlinksCounting = 0;

        double CurrectSongTime;

        private BackgroundWorker backgroundWorker;
        #endregion
        public AudioVideoPlayer()
        {
            InitializeComponent();
            lblAudioVolume.Text = trbVolume.Value.ToString() + "%";
            soundPlayer = new SoundPlayer();
            ButtonsSounds = new string[] { "Play.wav", "Pause.wav", "Stop.wav", "Previous.wav",
                "Next.wav", "AddVolume.wav", "SubtractVolume.wav"  };
            AddButtonsToList();
            backgroundWorker = new BackgroundWorker();
            backgroundWorker.DoWork += ConnectTGAsync;
            backgroundWorker.WorkerSupportsCancellation = true;
            backgroundWorker.RunWorkerAsync();
        }
        
        #region Read Packets as BackgroundWorker
        void ConnectTGAsync(object sender, DoWorkEventArgs e)
        {
            connector = new Connector();
            connector.DeviceConnected += new EventHandler(OnDeviceConnectedAsync);
            connector.DeviceConnectFail += new EventHandler(OnDeviceFailAsync);
            connector.DeviceValidating += new EventHandler(OnDeviceValidatingAsync);
            connector.ConnectScan("COM9");
            connector.setBlinkDetectionEnabled(true);
        }

         void OnDeviceConnectedAsync(object sender, EventArgs e)
        {
            Connector.DeviceEventArgs deviceEventArgs = (Connector.DeviceEventArgs)e;

            picConnectionStatus.Invoke((Action<int>)ChangeImageConnectionStatus, 0);

            deviceEventArgs.Device.DataReceived += new EventHandler(OnDataReceivedAsync);
        }

        

         void OnDeviceValidatingAsync(object sender, EventArgs e)
        {
            picConnectionStatus.Invoke((Action<int>)ChangeImageConnectionStatus, 3);
        }

         void OnDeviceFailAsync(object sender, EventArgs e)
        {
            picConnectionStatus.Invoke((Action<int>)ChangeImageConnectionStatus, 4);
        }

         void OnDataReceivedAsync(object sender, EventArgs e)
        {
            Device d = (Device)sender;

            Device.DataEventArgs dataEventArgs = (Device.DataEventArgs)e;

            TGParser tGParser = new TGParser();
            tGParser.Read(dataEventArgs.DataRowArray);

            for (int i = 0; i < tGParser.ParsedData.Length; i++)
            {
                if (tGParser.ParsedData[i].ContainsKey("BlinkStrength"))
                {
                    int blinkStrenght = (int)tGParser.ParsedData[i]["BlinkStrength"];

                    if (blinkStrenght > 120)
                    {
                        btnNext.Invoke((Action<int, object, EventArgs>)RunFocusedButton, ButtonFocus, sender, e);
                    }
                    else if (blinkStrenght > 75 || blinkStrenght < 90)
                    {
                        btnNext.Invoke((Action)AddUserCountBlink);
                        btnNext.Invoke((Action)StartTimerSettingsMode);
                        btnNext.Invoke((Action)GetFocusButton);
                        btnNext.Invoke((Action)MoveButtonFocus);
                        btnNext.Invoke((Action<int>)SetFocusButton, ButtonFocus);
                        btnNext.Invoke((Action<int, object, EventArgs>)RunButtonSound, ButtonFocus, sender, e);
                    }
                }
            }
        }
        #endregion

        #region Functions
        
        public void ApplicationExitChoose(bool result)
        {
            if (result)
            {
                backgroundWorker.CancelAsync();
                backgroundWorker.Dispose();
                connector.Close();
                Application.Exit();
            }
        }

        void StartTimerSettingsMode()
        {
            if (timerSettingsMode.Enabled) { } else { timerSettingsMode.Start(); }
            
        }

        void SetSettingsMode()
        {
            if (IsSettingsMode)
            {
                foreach (Button button in PlayerButtonsList)
                {
                    button.Enabled = true;
                }

                PlayerButtonsList[0].Focus();
            }
            else
            {
                foreach (Button tmp in PlayerButtonsList)
                {
                    tmp.Enabled = false;
                }

                PlayerButtonsList[5].Enabled = true;
                PlayerButtonsList[6].Focus();
                PlayerButtonsList[6].Enabled = true;
            }
        }

        void AddButtonsToList()
        {
            PlayerButtonsList.Add(btnPlay);
            PlayerButtonsList.Add(btnPause);
            PlayerButtonsList.Add(btnStop);
            PlayerButtonsList.Add(btnPrevious);
            PlayerButtonsList.Add(btnNext);
            PlayerButtonsList.Add(btnAddVoulme);
            PlayerButtonsList.Add(btnSubtractVolume);
        }

        private void AddUserCountBlink()
        {
            BlinksCounting += 1;
            if (BlinksCounting >= 4) BlinksCounting = 0;
        }

        private void SetPlayerStatus(string status)
        {
            lblPlayerStatus.Text = "Player status: " + status;
        }

        private void Play(string status)
        {
            if (IsPlaying)
            {
                Player.Ctlcontrols.currentPosition = CurrectSongTime;
                Player.Ctlcontrols.play();
                SetPlayerStatus(status);
                IsSettingsMode = false;
                SetSettingsMode();

            }
            else
            {
                if (ltbFiles.Items.Count > 0)
                {
                    Player.URL = Paths[ltbFiles.SelectedIndex];
                    Player.Ctlcontrols.play();
                    SetPlayerStatus(status);
                    timerSongTimeLine.Start();
                    IsPlaying = true;
                    IsSettingsMode = false;
                    SetSettingsMode();
                }
            }
        }

        void RunButtonSound(int Position, object sender, EventArgs e)
        {
            if (IsSettingsMode)
            {
                btnPause_Click(sender, e);
                soundPlayer.SoundLocation = ButtonsSounds[Position];
                soundPlayer.Play();
                timerButtonSound.Start();
            }
        }

        void GetFocusButton()
        {
            if (IsSettingsMode)
            {
                for (int i = 0; i < PlayerButtonsList.Count; i++)
                {
                    if (PlayerButtonsList[i].Focused)
                    {
                        ButtonFocus = i;
                    }
                }
            }
            else
            {
                for (int i = 0; i < PlayerButtonsList.Count; i++)
                {
                    if(PlayerButtonsList[i].Enabled && PlayerButtonsList[i].Focused)
                    {
                        ButtonFocus = i;
                    }
                }
            }
            
        }
        
        void SetFocusButton(int Position)
        {
            if (IsSettingsMode)
            {
                for (int i = 0; i < PlayerButtonsList.Count; i++)
                {
                    if (Position >= PlayerButtonsList.Count)
                    {
                        PlayerButtonsList[0].Focus();
                    }
                    else
                    {
                        PlayerButtonsList[Position].Focus();
                    }
                }
            }
            else
            {
                for (int i = 0; i < PlayerButtonsList.Count; i++)
                {
                    if (PlayerButtonsList[i].Enabled && Position >= PlayerButtonsList.Count)
                    {
                        PlayerButtonsList[5].Focus();
                    }
                    else
                    {
                        PlayerButtonsList[6].Focus();
                    }
                }
            }
            
        }

        void MoveButtonFocus()
        {
            ButtonFocus += 1;
            if (IsSettingsMode)
            {
                if (ButtonFocus >= PlayerButtonsList.Count)
                {
                    ButtonFocus = 0;
                }
            }
            else
            {
                if (ButtonFocus > PlayerButtonsList.Count)
                {
                    ButtonFocus = 5;
                }
            }
            
        }

        void RunFocusedButton(int Position,object sender, EventArgs e)
        {
            if (IsSettingsMode)
            {
                switch (Position)
                {
                    case 0:
                        btnPlay_Click(sender, e);
                        break;
                    case 1:
                        btnPause_Click(sender, e);
                        break;
                    case 2:
                        btnStop_Click(sender, e);
                        break;
                    case 3:
                        btnPrevious_Click(sender, e);
                        break;
                    case 4:
                        btnNext_Click(sender, e);
                        break;
                    case 5:
                        btnAddVoulme_Click(sender, e);
                        break;
                    case 6:
                        btnSubtractVolume_Click(sender, e);
                        break;
                }
            }
            else
            {
                switch (Position)
                {
                    case 6:
                        btnSubtractVolume_Click(sender, e);
                        break;
                    case 7:
                        btnAddVoulme_Click(sender, e);
                        break;
                }
            }
            
        }

        /*void AddItem(string Text)
        {
            lstBoxData.Items.Add(Text);
            lstBoxData.SelectedIndex = lstBoxData.Items.Count - 1;
            lstBoxData.SelectedIndex = -1;
        }

        void AddItem(int Text)
        {
            lstBoxData.Items.Add(Text);
            lstBoxData.SelectedIndex = lstBoxData.Items.Count - 1;
            lstBoxData.SelectedIndex = -1;
        }

        void AddItem(bool Text)
        {
            lstBoxData.Items.Add(Text);
            lstBoxData.SelectedIndex = lstBoxData.Items.Count - 1;
            lstBoxData.SelectedIndex = -1;
        }*/

        void ChangeImageConnectionStatus(int status)
        {
            picConnectionStatus.Image = imgLstConnectionStatus.Images[status];
        }
        #endregion

        #region Buttons Functionality
        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            Player.settings.volume = trbVolume.Value;
            lblAudioVolume.Text = trbVolume.Value.ToString() + "%";

        }
        private void Player_DoubleClickEvent(object sender, AxWMPLib._WMPOCXEvents_DoubleClickEvent e)
        {
            // Add making fullscreen after doubleclicks in video
        }

        private void ltbFiles_DoubleClick(object sender, EventArgs e)
        {
            IsPlaying = false;
            Play(Playing);
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            if (ltbFiles.Items.Count > 0)
            {
                Player.Ctlcontrols.pause();
                SetPlayerStatus("Paused...");
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            Play(Playing);
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            btnStop_Click(sender, e);
            if (!IsSettingsMode)
            {
                IsSettingsMode = true;
                SetSettingsMode();
            }
            ltbFiles.Items.Clear();
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Multiselect = true;
            openFileDialog.Filter = "MP3 File|*.mp3|MP4 File|*.mp4|All file|*.*";
            if (openFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Paths = openFileDialog.FileNames;
                Files = openFileDialog.SafeFileNames;
                
                for(int i = 0; i < Files.Length; i++)
                {
                    Files[i] = i + ". " + Files[i];
                }

                foreach(string file in Files)
                {
                    ltbFiles.Items.Add(file);
                }

                ltbFiles.SelectedIndex = 0;
            }
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            if (ltbFiles.Items.Count > 0)
            {
                Player.Ctlcontrols.stop();
                SetPlayerStatus("Stopped...");
                prbTimeLine.Value = 0;
                IsPlaying = false;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (ltbFiles.SelectedIndex < ltbFiles.Items.Count - 1)
            {
                IsPlaying = false;
                ltbFiles.SelectedIndex++;
                Play(Playing);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (ltbFiles.SelectedIndex > 0)
            {
                IsPlaying = false;
                ltbFiles.SelectedIndex--;
                Play(Playing);
            }
        }

        private void timerSong_Tick(object sender, EventArgs e)
        {
            if (Player.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                prbTimeLine.Maximum = (int)Player.Ctlcontrols.currentItem.duration;
                prbTimeLine.Value = (int)Player.Ctlcontrols.currentPosition;
            }
            lblTimeValue.Text = Player.Ctlcontrols.currentPositionString;
            CurrectSongTime = prbTimeLine.Value;
            
        }

        private void btnAddVoulme_Click(object sender, EventArgs e)
        {
            int tmp = trbVolume.Value + 5;

            if (tmp > 100)
                trbVolume.Value = 100;
            else
                trbVolume.Value = tmp;

            Player.settings.volume = trbVolume.Value;

            lblAudioVolume.Text = trbVolume.Value.ToString() + "%";
        }

        private void btnSubtractVolume_Click(object sender, EventArgs e)
        {

            int tmp = trbVolume.Value - 5;

            if (tmp < 0)
                trbVolume.Value = 0;
            else
                trbVolume.Value = tmp;

            Player.settings.volume = trbVolume.Value;

            lblAudioVolume.Text = trbVolume.Value.ToString() + "%";
        }

        #endregion

        #region Timers

        private void timerButtonSound_Tick(object sender, EventArgs e)
        {
            timerButtonSound.Stop();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Exit exit = new Exit(this);
            exit.ShowDialog();
        }

        private void btnMinimalise_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void timerSettingsMode_Tick(object sender, EventArgs e)
        {
            TimerSettingCounting++;

            if (BlinksCounting >= 3 && IsSettingsMode == false)
            {
                timerSettingsMode.Stop();
                BlinksCounting = 0;
                TimerSettingCounting = 0;
                IsSettingsMode = true;
                SetSettingsMode();
            }
            else if (BlinksCounting >= 3 && IsSettingsMode == true)
            {
                timerSettingsMode.Stop();
                BlinksCounting = 0;
                TimerSettingCounting = 0;
                IsSettingsMode = false;
                btnPlay_Click(sender, e);
                SetSettingsMode();
            }

            if (TimerSettingCounting == 2)
            {
                timerSettingsMode.Stop();
                TimerSettingCounting = 0;
                BlinksCounting = 0;
            }

        }
        #endregion 
    }
}