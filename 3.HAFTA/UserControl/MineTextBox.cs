using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Globalization;

namespace UserControl
{
    public class MineTextBox:TextBox
    {
        public enum TextTuru
        {
            sadeceRakam,sadeceHarf,sadeceMail,buyukHarf,yazimduzeni,tcNumarasi
        }
        public TextTuru _Verituru { get; set; }
        public Color _FocusRengi { get; set; }  //textboxa odaklanınca renk değiştiricez
        public bool _Bosolabilirmi { get; set; }
        protected override void OnEnter(EventArgs e)
        {
            BackColor = _FocusRengi;    
        }
        protected override void OnLeave(EventArgs e)
        {
            BackColor = Color.White;
            if (_Bosolabilirmi==false && string.IsNullOrEmpty(Text))
            {
                Select();//kullanıcı boş bırakırsa dolu olana kadar textboxa geri döner
                throw new Exception("Bu textbox boş geçilemez");
            }
            switch (_Verituru)
            {
                case TextTuru.sadeceMail:
                    //regex kullanımı
                    //regular expersion  
                    Regex mail =new Regex(@"^\w+[\w-\.]*\@\w+((-\w+)|(\w*))\.[a-z]{2,3}$");
                    if (!mail.IsMatch(Text))
                    {
                        Select();
                        throw new Exception("Mail adresini doğru giriniz.");
                    }
                    break;
                case TextTuru.buyukHarf:
                    this.Text = this.Text.ToUpper();
                    break;
                case TextTuru.yazimduzeni:
                    this.Text = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(Text);//sadece ilk harfleri büyük olur.
                    break;
                case TextTuru.tcNumarasi:
                    StringBuilder sb = new StringBuilder();
                    int tennumber, elevennumber;
                    bool dogrumu = isTc(this.Text, out tennumber, out elevennumber);
                    if (!dogrumu&&elevennumber+tennumber!=0)
                    {
                        sb.Append("tn nin 10. hanesi şu olabilir");
                        sb.Append(tennumber.ToString());
                        sb.Append("tn nin 11. hanesi şu olabilir");
                        sb.Append(elevennumber.ToString());
                        MessageBox.Show(sb.ToString());
                        this.Select();
                        throw new Exception("tc yi doğru girdiniz");
                    }
                    break;
            }
        }
        protected override void OnKeyPress(KeyPressEventArgs e)
        {
            switch (_Verituru)
            {
                case TextTuru.sadeceRakam:
                    e.Handled = !(char.IsDigit(e.KeyChar)) || e.KeyChar == ',' || e.KeyChar == (char)Keys.Back;
                    break;
                case TextTuru.sadeceHarf:
                    e.Handled = (char.IsLetter(e.KeyChar)) || e.KeyChar == (char)Keys.Back;
                    break;
               
                case TextTuru.tcNumarasi:
                    StringBuilder sb=new StringBuilder();
                    int tennumber, elevennumber;
                    bool dogrumu = isTc(this.Text, out tennumber, out elevennumber);
                    break;
                default:
                    break;
            }
        }

        private bool isTc(string tcNo, out int tennumber, out int elevennumber)
        {
            if (tcNo.Length != 11 || isNumeric(tcNo) || int.Parse(tcNo.Substring(0, 1)) == 0)
                {
                tennumber = 0;
                elevennumber = 0;
                return false;
                throw new Exception("Tcyi doğru girmediniz");
            }
            else
            {
                int sum13579 = 0;
                int sum2468=0;
                string substringninenumber = tcNo.Substring(0,9);
                sum13579 = int.Parse(tcNo.Substring(0,1))+
                    int.Parse(tcNo.Substring(2, 1)) +
                    int.Parse(tcNo.Substring(4, 1)) +
                    int.Parse(tcNo.Substring(6, 1)) +
                    int.Parse(tcNo.Substring(8, 1));
                sum2468 = int.Parse(tcNo.Substring(1, 1)) +
                    int.Parse(tcNo.Substring(3, 1)) +
                    int.Parse(tcNo.Substring(5, 1)) +
                    int.Parse(tcNo.Substring(7, 1)) ;
                tennumber = ((sum13579 * 7) - sum2468) % 10;
                elevennumber=(sum13579+sum2468 +tennumber)% 10;
                return tcNo == substringninenumber + tennumber + elevennumber;
            }
        }

        private bool isNumeric(string rakam)
        {
            double rakammi = 0;
            return double.TryParse( rakam, out rakammi);
        }
    }
}
