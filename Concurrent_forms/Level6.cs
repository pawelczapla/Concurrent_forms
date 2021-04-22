using System;
using System.Drawing;
using System.Windows.Forms;

namespace Concurrent_forms
{
    public partial class Level6 : Form
    {
        /// <summary>
        /// konstruktor klasy formularza
        /// </summary>
        public Level6()
        {
            InitializeComponent();
        }

        public void Level6_Load(object sender, EventArgs e)
        {
            victory.Hide();
            nextlvl.Hide();
            slot1.AllowDrop = true;
            slot2.AllowDrop = true;
            slot4.AllowDrop = true;
            slot5.AllowDrop = true;
        }
        /// <summary>
        /// umożliwia przeciąganie elementu 
        /// </summary>
        public void slot1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        /// <summary>
        /// realizuje skutek przeciągnięcia w wyznaczony slot
        /// </summary>
        public void slot1_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot1.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        /// <summary>
        /// umożliwia przeciąganie elementu 
        /// </summary>
        public void slot2_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        /// <summary>
        /// realizuje skutek przeciągnięcia w wyznaczony slot
        /// </summary>
        public void slot2_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot2.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        /// <summary>
        /// umożliwia przeciąganie elementu 
        /// </summary>
        public void slot4_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        /// <summary>
        /// realizuje skutek przeciągnięcia w wyznaczony slot
        /// </summary>
        public void slot4_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot4.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        /// <summary>
        /// umożliwia przeciąganie elementu 
        /// </summary>
        public void slot5_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = e.AllowedEffect;
        }
        /// <summary>
        /// realizuje skutek przeciągnięcia w wyznaczony slot
        /// </summary>
        public void slot5_DragDrop(object sender, DragEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "click.wav";
            click.Play();
            slot5.Image = (Bitmap)e.Data.GetData(DataFormats.Bitmap);
        }
        /// <summary>
        /// realizuje skutek kliknięcia oraz przytrzymania elementu
        /// </summary>
        public void pictureBox7_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.resistor_icon;
            richTextBox1.Text = "      Rezystory są komponentami pasywnymi, co oznacza, że tylko zużywają energię, bez jej wytwarzania. Używa się ich do ograniczania prądu i dzielenia napięć. Są zwykle dodawane do obwodów, w których uzupełniają aktywne komponenty, takie jak wzmacniacze operacyjne i układy scalone. \r\n     Są parowane ze sobą przez cały czas w elektronice, zwykle w układzie szeregowym lub równoległym . Kiedy rezystory są połączone, tworzą całkowitą rezystancję, którą można obliczyć za pomocą jednego z dwóch równań. Znajomość sposobu łączenia wartości rezystorów przydaje się, jeśli trzeba utworzyć określoną wartość rezystora. Nie będzie to jednak potrzebne w rozgrywce.";
            pictureBox7.DoDragDrop(pictureBox7.Image, DragDropEffects.Move);
        }
        /// <summary>
        /// realizuje skutek kliknięcia oraz przytrzymania elementu
        /// </summary>
        public void pictureBox8_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.capacitor_icon;
            richTextBox1.Text = "      W pewnym sensie kondensator przypomina trochę baterię. Chociaż działają one na zupełnie inne sposoby, oba magazynują energię elektryczną.   Kondensator jest znacznie prostszy niż bateria, ponieważ nie może wytwarzać nowych elektronów - tylko je przechowuje.\r\n       Po pełnym naładowaniu kondensator ma takie samo napięcie jak źródło napięcia. Jeżeli  kondensator będzie w obwodzie zamkniętym, w szeregu z żarówką i baterią będzie ona świecić coraz silniej, aż kondensator w pełni się naładuje. Ważną właściwością kondensatora jest to że blokuje prąd stały, a przepuszcza przebiegi prądu zmiennego";
            pictureBox8.DoDragDrop(pictureBox8.Image, DragDropEffects.Move);
        }
        /// <summary>
        /// realizuje skutek kliknięcia oraz przytrzymania elementu
        /// </summary>
        public void pictureBox9_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.inductor_icon;
            richTextBox1.Text = "      Cewkę charakteryzuje odmienne zachowanie do kondensatora. Przykładowo, przy równoległym podłączeniu żarówki i cewki, po zamknięciu obwodu i zasilaniu baterią żarówka będzie stopniowo przygasać. Kiedy prąd zaczyna płynąć w cewce, chce ona wytworzyć pole magnetyczne. \r\n      Podczas budowy pola cewka hamuje przepływ prądu. Cewka indukcyjna może magazynować energię w swoim polu magnetycznym. W odróżnieniu do kondensatora, hamują prąd zmienny a przepuszczają stały.";
            pictureBox9.DoDragDrop(pictureBox9.Image, DragDropEffects.Move);
        }
        /// <summary>
        /// realizuje skutek kliknięcia oraz przytrzymania elementu
        /// </summary>
        public void pictureBox10_MouseDown(object sender, MouseEventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            infobox_img.Image = Properties.Resources.diode_icon;
            richTextBox1.Text = "      Dioda jest urządzeniem elektryczne pozwala prądu , aby przejść przez niego tylko w jednym kierunku.  Dioda może być traktowana jako przełącznik : „zamknięta”, gdy jest odwrócona do przodu i „otwarta”, gdy jest spolaryzowana do tyłu. \r\n      Początkowo, nie brzmi to zbyt użytecznie, ponieważ większość z nas wyobraża sobie przepływ prądu jako stały,  jednak diody są niezwykle przydatne w tzw. prostowaniu napięcia zmiennego, a także w przetwarzaniu analogowych sygnałów np. w demodulacji.";
            pictureBox10.DoDragDrop(pictureBox10.Image, DragDropEffects.Move);
        }
        /// <summary>
        /// animuje obraz i dźwięk najechania na przycisk
        /// </summary>
        public void pictureBox5_MouseHover(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox5.Image = Properties.Resources.check_keyin;
        }
        /// <summary>
        /// przywraca domyślny wygląd przycisku
        /// </summary>
        public void pictureBox5_MouseLeave(object sender, EventArgs e)
        {
            pictureBox5.Image = Properties.Resources.check_default;
        }
        /// <summary>
        /// sprawdza poprawność wyboru i odblokowuje następny poziom
        /// </summary>
        public void pictureBox5_Click(object sender, EventArgs e)
        {
            try
            {
                if ((slot1.Image.Equals(pictureBox7.Image)) && (slot2.Image.Equals(pictureBox7.Image)) && (slot4.Image.Equals(pictureBox7.Image)) && (slot5.Image.Equals(pictureBox10.Image)))
                {
                    System.Media.SoundPlayer click = new System.Media.SoundPlayer();
                    click.SoundLocation = "applause.wav";
                    click.Play();
                    infobox_img.Image = Properties.Resources.tick;
                    //nextlvl.Show();
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
        /// <summary>
        /// przechodzi do menu głównego
        /// </summary>
        public void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Dispose();
            main_menu menu = new main_menu();
            menu.StartPosition = FormStartPosition.CenterScreen;
            menu.ShowDialog();
        }
        /// <summary>
        /// wyświetla opis obwodu
        /// </summary>
        public void pictureBox2_Click(object sender, EventArgs e)
        {
            infobox_img.Image = Properties.Resources.information;
            richTextBox1.Text = "      Komparator porównuje jeden poziom napięcia analogowego z innym poziomie napięcia analogowego lub jakieś napięcie odniesienia ustawiony, V REF i generuje sygnał wyjściowy na podstawie tego porównania napięcia. Innymi słowy, komparator napięcia wzmacniacza operacyjnego porównuje wielkości dwóch wejść napięciowych i określa, która z nich jest największa.\r\n     Obwód 2 jest obwodem tworzący napięcie odniesienia, które jest podstawą działania przetworników analogowo-cyfrowych. Dioda Zenera to element elektroniczny zapewniający stabilne i określone napięcie. W rezultacie obwody diody Zenera są często używane w zasilaczach, gdy potrzebne są regulowane wyjścia. Diody Zenera są czasami nazywane diodami referencyjnymi, ponieważ są w stanie zapewnić stabilne napięcie odniesienia dla wielu obwodów elektronicznych.";
        }
        /// <summary>
        /// animuje obraz i dźwięk najechania na przycisk
        /// </summary>
        public void nextlvl_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            nextlvl.Image = Properties.Resources.dalej_keyin; // Podświetlenie klawisza
        }
        /// <summary>
        /// przywraca domyślny wygląd przycisku
        /// </summary>
        public void nextlvl_MouseLeave(object sender, EventArgs e)
        {
            nextlvl.Image = Properties.Resources.dalej_default; // Podświetlenie klawisza
        }
        /// <summary>
        /// animuje obraz i dźwięk najechania na przycisk
        /// </summary>
        public void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox2.Image = Properties.Resources.help_keyin; // Podświetlenie klawisza
        }
        /// <summary>
        /// przywraca domyślny wygląd przycisku
        /// </summary>
        public void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            pictureBox2.Image = Properties.Resources.help_default; // Podświetlenie klawisza
        }
        /// <summary>
        /// animuje obraz i dźwięk najechania na przycisk
        /// </summary>
        public void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            System.Media.SoundPlayer click = new System.Media.SoundPlayer();
            click.SoundLocation = "clink.wav";
            click.Play();
            pictureBox4.Image = Properties.Resources.leftarrow_keyin; // Podświetlenie klawisza
        }
        /// <summary>
        /// przywraca domyślny wygląd przycisku
        /// </summary>
        public void pictureBox4_MouseLeave(object sender, EventArgs e)
        {
            pictureBox4.Image = Properties.Resources.left_arr_default; // Podświetlenie klawisza
        }
    }
}
