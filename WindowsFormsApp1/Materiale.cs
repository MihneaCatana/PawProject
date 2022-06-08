using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Materiale
    {
        string denumireMaterial { get; set; }
        public string DenumireMaterial { get { return denumireMaterial; } set { if(value.Length>0) denumireMaterial = value; } }

        int stoc;
        public int Stoc { get { return stoc; } set { if (value >= 0) stoc = value; else stoc = 0; } }

        float pretBucata;
        public float PretBucata { get { return pretBucata; } set { pretBucata = value; } }

        public Materiale()
        {
            denumireMaterial = "";
            stoc = 0;
            pretBucata = 0;
        }

        public Materiale(string d, int s, float p)
        {
            denumireMaterial = d;
            stoc = s;
            pretBucata = p;
        }

         public override string ToString()
        {
            return denumireMaterial + "        " + stoc + "         " + pretBucata;
        }
    }
}
