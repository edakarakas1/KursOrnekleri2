using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopAracGalerisi
{
    public class AracGalerisi
    {
        public Marka Markasi { get; set; }
        public Model Modeli { get; set; }
        public AracTuru AracinTuru { get; set; }
        public SanzimanTuru Sanzimani { get; set; }
        public YakitTuru YakitTipi { get; set; }
        public KasaTipi KasaTip { get; set; }
        public bool isGaranti { get; set; }
        public Color Renk { get; set; }
        public Image AracResmi { get; set; }
        int yil = DateTime.Today.Year;
        private int _ModelYili;
        public int ModelYili
        {
            get { return _ModelYili; }
            set
            {
                if (value < 2005 || value > yil)
                {
                    throw new Exception("2002 yılından küçük araç işlem görmemektedir");
                }
                else
                {
                    _ModelYili = value;
                }

                ;
            }
        }//2005 yılından küçük araç işlem görmemektedir
        private int _MotorGucu;
        public int MotorGucu
        {
            get { return _MotorGucu; }

            set
            {
                if (value <1000)
                {
                    throw new Exception("Motor Gücü en az 1000 olabilir");
                }
                else
                {
                    _MotorGucu = value;
                }

                ;
            }
        }//Motor Gücü en az 1000 olabilir
        public override string ToString()
        {
            StringBuilder sb=new StringBuilder();
            sb.Append(Markasi);
            sb.Append(" ");
            sb.Append(Modeli);
            sb.Append(" ");
            sb.Append(AracinTuru);
            sb.Append(" ");
            sb.Append(YakitTipi);
            return sb.ToString();

        }

        public AracGalerisi()
        {
           
        }
        public AracGalerisi(Marka marka,Model model)
        {
                this.Markasi= marka;
                this.Modeli = model;
        }
        public AracGalerisi(Color renk,int Modelyili,Image Aracresmi,
                            AracTuru _aracTuru=AracTuru.Ticari,
                            Marka _marka=Marka.VOLKSWAGEN,
                            Model _model=Model.CiViC,
                            SanzimanTuru _sanziman=SanzimanTuru.Otomatik,
                            YakitTuru _YakitTipi=YakitTuru.Dizel,
                            KasaTipi _kasaTipi=KasaTipi.Kamyonet,
                            bool _isgaranti=true)
        {
            this.Renk = renk;
            this.ModelYili = _ModelYili;
            this.AracResmi = Aracresmi;
            this.AracinTuru = _aracTuru;
            this.Markasi = _marka;
            this.Modeli = _model;
            this.Sanzimani = _sanziman;
            this.YakitTipi = _YakitTipi;
            this.KasaTip = _kasaTipi;
            this.isGaranti= _isgaranti;



        }

        //marka model bütün alanlar
        

    }
}
