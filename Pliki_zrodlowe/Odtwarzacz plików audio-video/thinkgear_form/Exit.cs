using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace thinkgear_form
{
    public partial class Exit : Form
    {
        AudioVideoPlayer AUdioVideoPlayer;

        public Exit(AudioVideoPlayer audioVideoPlayer)
        {
            AUdioVideoPlayer = audioVideoPlayer;
            InitializeComponent();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            AUdioVideoPlayer.ApplicationExitChoose(true);
            this.Close();
        }
    }
}