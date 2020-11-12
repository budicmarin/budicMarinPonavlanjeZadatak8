using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budicMarinPonavlanjeZadatak8
{
    class Sport
    {
        private string Naziv;
        private bool IgraLiSeLoptom;
        private byte BrojIgraca;
        public Sport(string naziv)
        {
            Naziv = naziv;
        }
        public Sport(string naziv,bool igra)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igra;
        }
        public Sport(string naziv, bool igra,byte broj)
        {
            Naziv = naziv;
            IgraLiSeLoptom = igra;
            BrojIgraca = broj;
        }
    }
}
