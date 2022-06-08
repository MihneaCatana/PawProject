using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Furnizori
    {
        string denumireFirma;
        public string DenumireFirma { get{ return denumireFirma; } set { if(value.Length >0) denumireFirma = value; } }

       int durataTransport;
       public int DurataTransport { get { return durataTransport; } set { durataTransport = value; } }

       float pretTransport;

       public float PretTransport { get { return pretTransport; } set { pretTransport = value; } }
       
        public Furnizori(string denumire, int durata, float pret)
        {
            denumireFirma = denumire;
            durataTransport = durata;
            pretTransport = pret;
        }

        public Furnizori()
        {
            denumireFirma = "";
            durataTransport = 0;
            pretTransport = 0;
        }


    }
}
