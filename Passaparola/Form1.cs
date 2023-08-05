using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Passaparola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0, dogru = 0, yanlis = 0;

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                switch (soruno)
                {
                    case 1:
                        if (textBox1.Text == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button1.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                    case 2:
                        if (textBox1.Text == "kırklareli")
                        {
                            button2.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 3:
                        if (textBox1.Text == "fenerbahçe")
                        {
                            button3.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 4:
                        if (textBox1.Text == "diyarbakır")
                        {
                            button4.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 5:
                        if (textBox1.Text == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 6:
                        if (textBox1.Text == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 7:
                        if (textBox1.Text == "güneş")
                        {
                            button7.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 8:
                        if (textBox1.Text == "ısparta")
                        {
                            button8.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 9:
                        if (textBox1.Text == "selimiye")
                        {
                            button9.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 10:
                        if (textBox1.Text == "kiraz")
                        {
                            button10.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 11:
                        if (textBox1.Text == "malatya")
                        {
                            button11.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 12:
                        if (textBox1.Text == "cuma")
                        {
                            button12.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 13:
                        if (textBox1.Text == "temmuz")
                        {
                            button13.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 14:
                        if (textBox1.Text == "kırmızı yeşil,yeşil kırmızı")
                        {
                            button14.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 15:
                        if (textBox1.Text == "8 kasım")
                        {
                            button15.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 16:
                        if (textBox1.Text == "ozan")
                        {
                            button16.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 17:
                        if (textBox1.Text == "7,yedi")
                        {
                            button17.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 18:
                        if (textBox1.Text == "adana")
                        {
                            button18.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 19:
                        if (textBox1.Text == "ramazan")
                        {
                            button19.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 20:
                        if (textBox1.Text == "tarkan")
                        {
                            button20.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 21:
                        if (textBox1.Text == "van")
                        {
                            button21.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 22:
                        if (textBox1.Text == "yıldırım")
                        {
                            button22.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 23:
                        if (textBox1.Text == "edirne")
                        {
                            button23.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button23.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;
                    case 24:
                        if (textBox1.Text == "alex de souza")
                        {
                            button24.BackColor = Color.Green;
                            dogru++;
                            label1.Text = dogru.ToString();
                        }
                        else
                        {
                            button24.BackColor = Color.Red;
                            yanlis++;
                            label2.Text = yanlis.ToString();
                        }
                        break;

                }
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button21_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.Text = "Sonraki";
            soruno++;
            this.Text = soruno.ToString();
            if (soruno == 1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmında ki kıyı bölgesi hangi bölgemizdir?";
                button1.BackColor = Color.Tan;
            }
            if (soruno == 2)
            {
                richTextBox1.Text = "39 Numaraları plaka kodumuz hangi ile aittir ?";
                button2.BackColor = Color.Tan;
            }
            if (soruno == 3)
            {
                richTextBox1.Text = "Maskotu 'Kanarya' olarak bilinen Türk futbol takımı hangisidir?";
                button3.BackColor = Color.Tan;
            }
            if (soruno == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü olan ilimiz hangisidir?";
                button4.BackColor = Color.Tan;
            }
            if (soruno == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamı?";
                button5.BackColor = Color.Tan;
            }
            if (soruno == 6)
            {
                richTextBox1.Text = "Padişahın emirlerinin yazılı hali nedir?";
                button6.BackColor = Color.Tan;
            }
            if (soruno == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Tan;
            }
            if (soruno == 8)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz hangisidir ?";
                button8.BackColor = Color.Tan;
            }
            if (soruno == 9)
            {
                richTextBox1.Text = "Edirne'de bulunan ünlü camiinin ismi nedir?";
                button9.BackColor = Color.Tan;
            }
            if (soruno == 10)
            {
                richTextBox1.Text = "Her yıl bahar aylarında düzenlenen meşhur çiçek festivalinin adı nedir?";
                button10.BackColor = Color.Tan;
            }
            if (soruno == 11)
            {
                richTextBox1.Text = "Malatya'nın meşhur meyvesi nedir?";
                button11.BackColor = Color.Tan;
            }
            if (soruno == 12)
            {
                richTextBox1.Text = "Müslümanların kutsal günü hangisidir?";
                button12.BackColor = Color.Tan;
            }
            if (soruno == 13)
            {
                richTextBox1.Text = "Yılın 7.ayı hangisidir?";
                button13.BackColor = Color.Tan;
            }
            if (soruno == 14)
            {
                richTextBox1.Text = "Lüleburgazspor'un renkleri hangileridir?";
                button14.BackColor = Color.Tan;
            }
            if (soruno == 15)
            {
                richTextBox1.Text = "Lüleburgazın kurtuluşu hangi gündür?";
                button15.BackColor = Color.Tan;
            }
            if (soruno == 16)
            {
                richTextBox1.Text = "Halk şairine ne ad verilir?";
                button16.BackColor = Color.Tan;
            }
            if (soruno == 17)
            {
                richTextBox1.Text = "Ülkemiz kaç bölgeden oluşur?";
                button17.BackColor = Color.Tan;
            }
            if (soruno == 18)
            {
                richTextBox1.Text = "Ülkemizin en sıcak olarak bilinen şehiri hangisidir?";
                button18.BackColor = Color.Tan;
            }
            if (soruno == 19)
            {
                richTextBox1.Text = "11 ayın sultanı ?";
                button19.BackColor = Color.Tan;
            }
            if (soruno == 20)
            {
                richTextBox1.Text = "Türkiyenin MegaStar'ı olarak bilinen sanatçımız?";
                button20.BackColor = Color.Tan;
            }
            if (soruno == 21)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz?";
                button21.BackColor = Color.Tan;
            }
            if (soruno == 22)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı?";
                button22.BackColor = Color.Tan;
            }
            if (soruno == 23)
            {
                richTextBox1.Text = "Tava Ciğeri ile meşhur olan ilimiz?";
                button23.BackColor = Color.Tan;
            }
            if (soruno == 24)
            {
                richTextBox1.Text = "Fenerbahçenin efsane 10 numarası?";
                button24.BackColor = Color.Tan;
            }
        }
    }
}
