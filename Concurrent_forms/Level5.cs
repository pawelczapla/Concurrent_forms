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
    public partial class Level5 : Form
    {
        public Level5()
        {
            InitializeComponent();
        }

        public void Level5_Load(object sender, EventArgs e)
        {
            victory.Hide();
            nextlvl.Hide();
            slot1.AllowDrop = true;
            slot4.AllowDrop = true;
            slot5.AllowDrop = true;
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
        public void slot4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        public void slot4_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        public void slot5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        public void slot5_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
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
            infobox_img.Image = Properties.Resources.transistor_icon;
            richTextBox1.Text = "      Tranzystor to element elektroniczny, który może wykonywać dwie różne czynności. Może pracować jako wzmacniacz lub włącznik. Kiedy działa jako wzmacniacz , pobiera niewielki prąd elektryczny na jednym końcu i wytwarza znacznie większy prąd elektryczny na drugim. Przykładem jest np. wzmacnianie głośności sygnału dźwiękowego.\r\n      Tranzystory mogą również działać jako przełączniki . Niewielki prąd elektryczny przepływający przez jedną część tranzystora może spowodować znacznie większy przepływ prądu przez inną jego część. Innymi słowy, mały prąd włącza większy. W zasadzie tak działają wszystkie chipy komputerowe. Na przykład układ pamięci zawiera setki milionów, a nawet miliardy tranzystorów, z których każdy może być indywidualnie włączany lub wyłączany.\r\n       Ten tranzystor to tranzystor bipolarny, posiadający 3 odnogi, z których jedna kontroluje przepływ prądu przez dwie pozostałe.";
            pictureBox9.DoDragDrop(pictureBox9.Image, DragDropEffects.Move);
        }
        public void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.mosfet_icon;
            richTextBox1.Text = "Tranzystor to element elektroniczny, który może wykonywać dwie różne czynności. Może pracować jako wzmacniacz lub włącznik. Kiedy działa jako wzmacniacz , pobiera niewielki prąd elektryczny na jednym końcu i wytwarza znacznie większy prąd elektryczny na drugim. Przykładem jest np. wzmacnianie głośności sygnału dźwiękowego.\r\n      Tranzystory mogą również działać jako przełączniki . Niewielki prąd elektryczny przepływający przez jedną część tranzystora może spowodować znacznie większy przepływ prądu przez inną jego część. Innymi słowy, mały prąd włącza większy. W zasadzie tak działają wszystkie chipy komputerowe. Na przykład układ pamięci zawiera setki milionów, a nawet miliardy tranzystorów, z których każdy może być indywidualnie włączany lub wyłączany.\r\n       Ten tranzystor to tranzystor MOS, który jest nieco bardziej zaawansowany fizycznie, co wymagało by obszerniejszego wyjaśnienia. Dobrą radą jest jednak, że tranzystory tego samego rodzaju, zwykle lepiej współpracują ze sobą.";
            pictureBox10.DoDragDrop(pictureBox10.Image, DragDropEffects.Move);
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
                if ((slot1.Image.Equals(pictureBox7.Image)) && (slot4.Image.Equals(pictureBox9.Image)) && (slot5.Image.Equals(pictureBox9.Image)))
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
            richTextBox1.Text = "Wzmacniacz operacyjny jest zasadniczo urządzeniem wzmacniającym napięcia przeznaczony do zastosowania z zewnętrznymi elementami zwrotnymi, takie jak rezystory i kondensatory. Te komponenty sprzężenia zwrotnego określają wynikową funkcję lub „działanie” wzmacniacza, a dzięki różnym konfiguracjom sprzężenia zwrotnego, zarówno rezystancyjnym, pojemnościowym, jak i obydwu, wzmacniacz może wykonywać wiele różnych operacji, stąd jego nazwa. \r\n      Wzmacniacz operacyjny jest w zasadzie urządzeniem trzy złącza, który składa się z dwóch wejść wysokiej impedancji. Jedno z wejść to Wejście Odwracające , oznaczone znakiem minus Drugie wejście nazywane jest wejściem nieodwracającym , oznaczonym znakiem plus.\r\n       W obwodzie po lewej,  wzmacniacz operacyjny jest połączony ze sprzężeniem zwrotnym w celu pracy w zamkniętej pętli. Mając do czynienia ze wzmacniaczami operacyjnymi, należy pamiętać o dwóch bardzo ważnych zasadach dotyczących wzmacniaczy odwracających: „Żaden prąd nie płynie do zacisku wejściowego” oraz „V1 zawsze równa się V2”.";
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
        public void nextlvl_Click(object sender, EventArgs e)
        {
            this.Hide();
            Level6 level6 = new Level6();
            level6.StartPosition = FormStartPosition.CenterScreen;
            level6.ShowDialog();
        }
    }
}
