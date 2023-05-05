using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo_Caro
{
    public partial class frmMP3 : Form
    {
        
        string[] paths, files;
        public frmMP3()
        {
            InitializeComponent();
            wmp1.uiMode = "none";
            wmp1.settings.volume = 50;
        }

        private void frmMP3_Load(object sender, EventArgs e)
        {

        }

        private void btPLAY_Click(object sender, EventArgs e)
        {
            wmp1.Ctlcontrols.play();
        }

        private void btPAUSE_Click(object sender, EventArgs e)
        {
            wmp1.Ctlcontrols.pause();
        }

        private void btSTOP_Click(object sender, EventArgs e)
        {
            wmp1.Ctlcontrols.stop();
        }

        private void btNEXT_Click(object sender, EventArgs e)
        {
            if(track_List.SelectedIndex<track_List.Items.Count-1)
            {
                track_List.SelectedIndex = track_List.SelectedIndex + 1; ;
            }
            else
            {
                track_List.SelectedIndex = 0;
            }
            wmp1.URL = paths[track_List.SelectedIndex];
            wmp1.Ctlcontrols.play();
        }

        private void track_List_SelectedIndexChanged(object sender, EventArgs e)
        {
            wmp1.URL = paths[track_List.SelectedIndex];
            wmp1.Ctlcontrols.play();
        }

        private void btPREVIEW_Click(object sender, EventArgs e)
        {
            if(track_List.SelectedIndex > 0)
            {
                track_List.SelectedIndex = track_List.SelectedIndex-1;
            }
            else
            {
                track_List.SelectedIndex = track_List.Items.Count-1;
            }
            wmp1.URL = paths[track_List.SelectedIndex];
            wmp1.Ctlcontrols.play();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            wmp1.settings.volume = trackBar1.Value;
            lbVOLUME.Text = trackBar1.Value.ToString()+" % ";
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if(wmp1.playState == WMPLib.WMPPlayState.wmppsPlaying)
            {
                pgTIMING.Maximum = (int)wmp1.Ctlcontrols.currentItem.duration;
                pgTIMING.Value = (int)wmp1.Ctlcontrols.currentPosition;
                try
                {
                    lbTRACKSTART.Text = wmp1.Ctlcontrols.currentPositionString;
                    lbENDTRACK.Text = wmp1.Ctlcontrols.currentItem.durationString.ToString();
                }
                catch
                {

                }
            }
        }

        private void pgTIMING_MouseDown(object sender, MouseEventArgs e)
        {
            wmp1.Ctlcontrols.currentPosition = wmp1.currentMedia.duration * e.X/pgTIMING.Width;
        }

        private void frmMP3_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Enabled= false;
        }

        private void btOPEN_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            ofd.Multiselect = true;
            
            if(ofd.ShowDialog() == DialogResult.OK) 
            {
                files = ofd.FileNames;
                paths = ofd.FileNames;
                for(int x=0;x<files.Length;x++)
                {
                    track_List.Items.Add(files[x]);
                }
                /*wmp1.URL = paths[0];
                wmp1.Ctlcontrols.play();*/
            }
        }
    }
}
