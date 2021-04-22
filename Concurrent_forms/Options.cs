using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Concurrent_forms
{
    public partial class Options : Form
    {
        public Options()
        {
            InitializeComponent();
        }
        public void exit_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            main_menu menu = new main_menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
        }
        public void volume_bar_Scroll(object sender, EventArgs e)
        {
            main_menu.player.settings.volume = volume_bar.Value;
            if (volume_bar.Value.Equals(0))
            {
                sound_btn.Image = Properties.Resources.soundoff;
            }
            else 
            {
                sound_btn.Image = Properties.Resources.soundon;
            }
        }
        public void exit_btn_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            exit_btn.Image = Properties.Resources.leftarrow_keyin;
        }
        public void exit_btn_MouseLeave(object sender, EventArgs e)
        {
            exit_btn.Image = Properties.Resources.left_arr_default;
        }
    }
}
