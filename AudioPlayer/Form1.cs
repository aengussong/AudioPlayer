using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioPlayer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if(playListBox.Items.Count != 0 && playListBox.SelectedIndex != -1)
            {
                String current = Res.files[playListBox.SelectedIndex];
                BassController.play(current, BassController.volume);

                label1.Text = TimeSpan.FromSeconds(BassController.getPosOfStream(BassController.Stream)).ToString();
                label2.Text = TimeSpan.FromSeconds(BassController.getStreamTime(BassController.Stream)).ToString();

                lengthScrollBar.Value = BassController.getPosOfStream(BassController.Stream);
                lengthScrollBar.Maximum = BassController.getStreamTime(BassController.Stream);

                BassController.setStreamVolume(BassController.Stream, volumeScrollBar.Value);

                timer1.Enabled = true;
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {
            Res.files.Add(openFileDialog1.FileName);
            playListBox.Items.Add(Res.getFileName(openFileDialog1.FileName));

            playListBox.SelectedIndex = playListBox.Items.Count - 1;
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            BassController.stop();
            timer1.Enabled = false;
            label1.Text = "00:00:00";
            lengthScrollBar.Value = 0;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = TimeSpan.FromSeconds(BassController.getPosOfStream(BassController.Stream)).ToString();
            lengthScrollBar.Value = BassController.getPosOfStream(BassController.Stream);
        }

        private void lengthScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            BassController.setStreamPosition(BassController.Stream, lengthScrollBar.Value);
        }

        private void volumeScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            BassController.setStreamVolume(BassController.Stream, volumeScrollBar.Value);
        }
    }
}
