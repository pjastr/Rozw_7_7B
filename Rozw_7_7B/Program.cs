using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rozw_7_7B
{
    class Program
    {
        static void Main(string[] args)
        {
            Pociag pociag = new Pociag();
            pociag.DodajPasazera("Jan");
            pociag.DodajPasazera("Anna");
        }
    }

    class Pasazer
    {
        private string imie;

        public Pasazer(string imie)
        {
            this.imie = imie;
        }
    }

    class Pociag
    {
        private List<Pasazer> pasazerowie = new List<Pasazer>();

        public Pociag()
        {

        }

        public void DodajPasazera(string imie)
        {
            pasazerowie.Add( new Pasazer(imie));
        }


    }
}
