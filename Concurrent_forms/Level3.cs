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
    public partial class Level3 : Form
    {
        public Level3()
        {
            InitializeComponent();
        }

        public void Level3_Load(object sender, EventArgs e)
        {
            victory.Hide();
            nextlvl.Hide();
            slot1.AllowDrop = true;
            slot2.AllowDrop = true;
            slot3.AllowDrop = true;
        }
        public void slot1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        public void slot1_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        public void slot2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        public void slot2_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        public void slot3_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        public void slot3_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot3.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        public void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.resistor_icon;
            richTextBox1.Text = "      Rezystory są komponentami pasywnymi, co oznacza, że tylko zużywają energię, bez jej wytwarzania. Używa się ich do ograniczania prądu i dzielenia napięć. Są zwykle dodawane do obwodów, w których uzupełniają aktywne komponenty, takie jak wzmacniacze operacyjne i układy scalone. \r\n     Są parowane ze sobą przez cały czas w elektronice, zwykle w układzie szeregowym lub równoległym . Kiedy rezystory są połączone, tworzą całkowitą rezystancję, którą można obliczyć za pomocą jednego z dwóch równań. Znajomość sposobu łączenia wartości rezystorów przydaje się, jeśli trzeba utworzyć określoną wartość rezystora. Nie będzie to jednak potrzebne w rozgrywce.";
            pictureBox7.DoDragDrop(pictureBox7.Image, DragDropEffects.Move);
        }
        public void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.capacitor_icon;
            richTextBox1.Text = "      W pewnym sensie kondensator przypomina trochę baterię. Chociaż działają one na zupełnie inne sposoby, oba magazynują energię elektryczną.   Kondensator jest znacznie prostszy niż bateria, ponieważ nie może wytwarzać nowych elektronów - tylko je przechowuje.\r\n       Po pełnym naładowaniu kondensator ma takie samo napięcie jak źródło napięcia. Jeżeli  kondensator będzie w obwodzie zamkniętym, w szeregu z żarówką i baterią będzie ona świecić coraz silniej, aż kondensator w pełni się naładuje. Ważną właściwością kondensatora jest to że blokuje prąd stały, a przepuszcza przebiegi prądu zmiennego";
            pictureBox8.DoDragDrop(pictureBox8.Image, DragDropEffects.Move);
        }
        public void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.diode_icon;
            richTextBox1.Text = "      Dioda jest urządzeniem elektryczne pozwala prądu , aby przejść przez niego tylko w jednym kierunku.  Dioda może być traktowana jako przełącznik : „zamknięta”, gdy jest odwrócona do przodu i „otwarta”, gdy jest spolaryzowana do tyłu. \r\n      Początkowo, nie brzmi to zbyt użytecznie, ponieważ większość z nas wyobraża sobie przepływ prądu jako stały,  jednak diody są niezwykle przydatne w tzw. prostowaniu napięcia zmiennego, a także w przetwarzaniu analogowych sygnałów np. w demodulacji.";
            pictureBox9.DoDragDrop(pictureBox9.Image, DragDropEffects.Move);
        }
        public void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox5.Image = Properties.Resources.check_keyin;
        }
        public void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.check_default;
        }
        public void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((slot1.Image.Equals(pictureBox9.Image)) && (slot2.Image.Equals(pictureBox8.Image)) && (slot3.Image.Equals(pictureBox7.Image)))
                {
                    System.Media.SoundPlayer click = new System.Media.SoundPlayer();
                    click.SoundLocation = "applause.wav";
                    click.Play();
                    infobox_img.Image = Properties.Resources.tick;
                    nextlvl.Show();
                    victory.Show();
                }

                else
                {
                    System.Media.SoundPlayer click = new System.Media.SoundPlayer();
                    click.SoundLocation = "short.wav";
                    click.Play();
                    infobox_img.Image = Properties.Resources.wrong;
                }
            }
            catch (NullReferenceException)
            {
                System.Media.SoundPlayer click = new System.Media.SoundPlayer();
                click.SoundLocation = "short.wav";
                click.Play();
                infobox_img.Image = Properties.Resources.wrong;
            }
        }
        public void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main_menu menu = new main_menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
        }
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            infobox_img.Image = Properties.Resources.information;
            richTextBox1.Text = "      Detektor diodowy jest najprostszą i najbardziej podstawową formą modulacji amplitudy, detektorem sygnału AM i wykrywa obwiednię sygnału AM. Detektor diody AM może być zbudowany tylko z diody i kilku innych komponentów, w wyniku czego jest to bardzo tani blok obwodów w całym odbiorniku.\r\n Dioda w detektorze służy do wzmacniania jednej połowy odbieranego sygnału w stosunku do drugiej.Filtr dolnoprzepustowy jest wymagany do usunięcia elementów o wysokiej częstotliwości, które pozostają w sygnale po wykryciu / demodulacji. ";
        }
        public void nextlvl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level4 level4 = new Level4();
            level4.StartPosition = FormStartPosition.CenterScreen;
            level4.ShowDialog();
        }
        public void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox2.Image = Properties.Resources.help_keyin;   
        }
        public void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.help_default;   
        }
        public void nextlvl_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            nextlvl.Image = Properties.Resources.dalej_keyin;   
        }
        public void nextlvl_MouseLeave(object sender, EventArgs e)
        {
            nextlvl.Image = Properties.Resources.dalej_default;   
        }
        public void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox4.Image = Properties.Resources.leftarrow_keyin;   
        }
        public void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.left_arr_default;   
        }
    }
}
