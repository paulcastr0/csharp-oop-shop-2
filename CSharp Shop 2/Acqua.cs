using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Shop_2
{
    public class Acqua
    {
        //PROPRIETA o ATTRIBUTI
        private double litri;
        private double ph;
        private string sorgente;
        private double litriDaBere;
        private double bottiglia;
        private double litriMessi;

        //COSTRUTTORE
        public Acqua(double litri, double ph, string sorgente,double litriDaBere, double bottiglia, double litriMessi)
        {
            this.litri = litri;
            this.ph= ph;
            this.sorgente = sorgente;
            this.litriDaBere = litriDaBere;
            this.bottiglia = bottiglia;
            this.litriMessi = litriMessi;
        }

        //GETTERs
        public double GetLitri()
        {
            return litri;
        }
        public double GetPh()
        {
            return ph;
        }
        public string GetSorgente()
        {
            return sorgente;
        }
        public double GetLitriDaBere()
        {
            return litriDaBere;
        }
        public double GetBottiglia()
        {
            return bottiglia;
        }

        //SETTERs
        public double SetLitri()
        {
            return this.litri;
        }
        public double SetLitriDaBere()
        {
            return this.litriDaBere;
        }

        //METODI PUBBLICI
        public void Bevi()
        {
            if (litriDaBere <= litri)
            {
                litri = litri - litriDaBere;
            }
        }
        public void Svuota()
        {
            if (litriDaBere >= litri)
            {
                litri = 0;
            }
        }
        public void Riempi()
        {
            if(litriMessi < bottiglia)
            {
                
            }
        }
    }
}
