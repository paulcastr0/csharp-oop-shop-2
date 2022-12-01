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
        private int litri;
        private double ph;
        private string sorgente;
        private double litriDaBere;

        //COSTRUTTORE
        public Acqua(int litri, double ph, string sorgente,double litriDaBere)
        {
            this.litri = litri;
            this.ph= ph;
            this.sorgente = sorgente;
            this.litriDaBere = litriDaBere;
        }

        //GETTERs
        public int GetLitri()
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

        //SETTERs
        public int SetLitri()
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
            if (litriDaBere <= litri )
            {
                litriDaBere = litri - litriDaBere;
                Console.Write( litriDaBere );
            }
        }
    }
}
