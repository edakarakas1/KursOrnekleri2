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
        int soruNo = 0, dogru = 0, yanlıs = 0;
        string cevap = null;
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if (e.KeyChar == (char)13)
            {   
                textBox1.Enabled = false;
                cevap = textBox1.Text.ToLower();
                switch (soruNo)
                { case 1:
                        if (cevap == "akdeniz")
                        {
                            button1.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else {
                            button1.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;

                    case 2:
                        if (cevap == "bursa")
                        {
                            button2.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button2.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 3:
                        if (cevap == "bursa")
                        {
                            button3.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button3.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 4:
                        if (cevap == "bursa")
                        {
                            button4.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button4.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 5:
                        if (cevap == "eski")
                        {
                            button5.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button5.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 6:
                        if (cevap == "ferman")
                        {
                            button6.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button6.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 7:
                        if (cevap == "bursa")
                        {
                            button7.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button7.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 8:
                        if (cevap == "halı")
                        {
                            button8.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button8.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 9:
                        if (cevap == "ısparta")
                        {
                            button9.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button9.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 10:
                        if (cevap == "jandarma")
                        {
                            button10.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button10.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 11:
                        if (cevap == "kayısı")
                        {
                            button11.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button11.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 12:
                        if (cevap == "lale")
                        {
                            button12.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button12.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 13:
                        if (cevap == "mart")
                        {
                            button13.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button13.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 14:
                        if (cevap == "ney")
                        {
                            button14.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button14.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 15:
                        if (cevap == "ozan")
                        {
                            button15.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button15.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 16:
                        if (cevap == "pırasa")
                        {
                            button16.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button16.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 17:
                        if (cevap == "ramazan")
                        {
                            button17.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button17.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 18:
                        if (cevap == "sneke")
                        {
                            button18.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button18.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 19:
                        if (cevap == "bursa")
                        {
                            button19.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button19.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 20:
                        if (cevap == "umut")
                        {
                            button20.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button20.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 21:
                        if (cevap == "van")
                        {
                            button21.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button21.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                    case 22:
                        if (cevap == "yıldırım")
                        {
                            button22.BackColor = Color.Green;
                            dogruarttır();
                        }
                        else
                        {
                            button22.BackColor = Color.Red;
                            yanlısarttır();
                        }
                        break;
                }
            }
        }
        private void dogruarttır()
            {
            dogru++;
            label2.Text = dogru.ToString();
            }

        private void yanlısarttır()
        {
            yanlıs++;
            label4.Text = yanlıs.ToString();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            soruNo++;
            textBox1.Clear();   
            linkLabel1.Text = "SONRAKİ";
            this.Text = soruNo.ToString();
            textBox1.Enabled = true;
            if (soruNo==1)
            {
                richTextBox1.Text = "Ülkemizin güney kısmındaki kıyı bölgesi?";
                button1.BackColor = Color.Yellow;
                btnHarf.Text = button1.Text;
            }
            else if (soruNo==2)
            {
                richTextBox1.Text = "Yeşilliğiyle ünlü marmara ilimiz?";
                button2.BackColor = Color.Yellow;
                btnHarf.Text = button2.Text;
            }
            else if (soruNo==3)
            {
                richTextBox1.Text = "Müslümanların kutsal günü?";
                button3.BackColor=Color.Yellow;
                btnHarf.Text= button3.Text; 
            }
            else if (soruNo == 4)
            {
                richTextBox1.Text = "Karpuzuyla ünlü ilimiz?";
                button4.BackColor = Color.Yellow;
                btnHarf.Text = button4.Text;
            }
            else if (soruNo == 5)
            {
                richTextBox1.Text = "Yeni kelimesinin zıt anlamlısı?";
                button5.BackColor = Color.Yellow;
                btnHarf.Text = button5.Text;
            }
            else if (soruNo == 6)
            {
                richTextBox1.Text = "Padişahin emirlerinin yazılı hali?";
                button6.BackColor = Color.Yellow;
                btnHarf.Text = button6.Text;
            }
            else if (soruNo == 7)
            {
                richTextBox1.Text = "Dünyanın ısı kaynağı?";
                button7.BackColor = Color.Yellow;
                btnHarf.Text = button7.Text;
            }
            else if (soruNo == 8)
            {
                richTextBox1.Text = "Öğrencilerin kötü karne aldığı zaman baktığı yer?";
                button8.BackColor = Color.Yellow;
                btnHarf.Text = button8.Text;
            }
            else if (soruNo == 9)
            {
                richTextBox1.Text = "Gülüyle ünlü ilimiz?";
                button9.BackColor = Color.Yellow;
                btnHarf.Text = button9.Text;
            }
            else if (soruNo == 10)
            {
                richTextBox1.Text = "Askeri bir topluluk?";
                button10.BackColor = Color.Yellow;
                btnHarf.Text = button10.Text;
            }
            else if (soruNo == 11)
            {
                richTextBox1.Text = "Malatyanın meşhur meyvesi?";
                button11.BackColor = Color.Yellow;
                btnHarf.Text = button11.Text;
            }
            else if (soruNo == 12)
            {
                richTextBox1.Text = "Her yıl bahar aylarında? ";
                button12.BackColor = Color.Yellow;
                btnHarf.Text = button12.Text;
            }
            else if (soruNo == 13)
            {
                richTextBox1.Text = "Yılın 3.ayı?";
                button13.BackColor = Color.Yellow;
                btnHarf.Text = button13.Text;
            }
            else if (soruNo == 14)
            {
                richTextBox1.Text = "Üflemeli bir müzük aleti?";
                button14.BackColor = Color.Yellow;
                btnHarf.Text = button14.Text;
            }
            else if (soruNo == 15)
            {
                richTextBox1.Text = "Halk şairi?";
                button15.BackColor = Color.Yellow;
                btnHarf.Text = button15.Text;
            }
            else if (soruNo == 16)
            {
                richTextBox1.Text = "Çocukların pek sevmediği pirinç havuç gibi sebzelerden yapılan yemek";
                button16.BackColor = Color.Yellow;
                btnHarf.Text = button16.Text;
            }
            else if (soruNo == 17)
            {
                richTextBox1.Text = "11 ayın sultanı";
                button17.BackColor = Color.Yellow;
                btnHarf.Text = button17.Text;
            }
            else if (soruNo == 18)
            {
                richTextBox1.Text = "İngilizcede yılan";
                button18.BackColor = Color.Yellow;
                btnHarf.Text = button18.Text;
            }
            else if (soruNo == 19)
            {
                richTextBox1.Text = "Türkiyenin mega starı";
                button19.BackColor = Color.Yellow;
                btnHarf.Text = button19.Text;
            }
            else if (soruNo == 20)
            {
                richTextBox1.Text = "Ümit kelimesinin eş anlamlısı";
                button20.BackColor = Color.Yellow;
                btnHarf.Text = button20.Text;
            }
            else if (soruNo == 21)
            {
                richTextBox1.Text = "Kahvaltısı ile ünlü ilimiz";
                button21.BackColor = Color.Yellow;
                btnHarf.Text = button21.Text;
            }
            else if (soruNo == 22)
            {
                richTextBox1.Text = "Şimşek kelimesinin eş anlamlısı";
                button22.BackColor = Color.Yellow;
                btnHarf.Text = button22.Text;
            }
           
        }
    }
}
