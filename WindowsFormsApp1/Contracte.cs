using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Contracte
    {

        int idComanda;

        public int IdComanda { get { return idComanda; } set { idComanda = value; } }

        int nrMateriale;

        public int NrMateriale { get { return nrMateriale; } set { nrMateriale = value; } }

        public Furnizori furnizor;

        public Materiale material;

        public Contracte(int id, int nr, Furnizori f, Materiale m1)
        {
            idComanda = id;
            nrMateriale = nr;
            furnizor = f;
            material = m1;
        }

        public Contracte()
        {
            idComanda=0;
            nrMateriale=0; 
            furnizor=null;
            material=null;

        }


    }
}
