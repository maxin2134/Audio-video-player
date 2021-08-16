using System;
using System.Threading;
using System.Windows.Forms;

namespace thinkgear_form
{
    public partial class Welcome : Form
    {
        public Welcome()
        {
            InitializeComponent();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Thread.Sleep(500);
            AudioVideoPlayer audioVideoGUI = new AudioVideoPlayer();
            audioVideoGUI.ShowDialog();
            this.Close();
        }
    }
}