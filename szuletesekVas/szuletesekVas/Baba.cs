using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuletesekVas
{
    public enum Nem {férfi, nő }

    class Baba
    {
        string kodsor;
        public Nem nem;
        public DateTime Szul { get; }
        public int Sorsz { get; }
        public int Kod { get; }

        public Baba(string adatsor)
        {
            //1-980227-1258
            kodsor = adatsor.Remove(8, 1).Remove(1,1);
            switch (adatsor[0])
            {
               case '1':
                    nem = Nem.férfi;
                    Szul = new DateTime(1900 + int.Parse(adatsor.Substring(2, 2)), int.Parse(adatsor.Substring(4, 2)), int.Parse(adatsor.Substring(6, 2)));
                    break;
                case '2':
                    nem = Nem.nő;
                    Szul = new DateTime(1900 + int.Parse(adatsor.Substring(2, 2)), int.Parse(adatsor.Substring(4, 2)), int.Parse(adatsor.Substring(6, 2)));
                    break;
                case '3':
                    nem = Nem.férfi;
                    Szul = new DateTime(2000 + int.Parse(adatsor.Substring(2, 2)), int.Parse(adatsor.Substring(4, 2)), int.Parse(adatsor.Substring(6, 2)));
                    break;
                case '4':
                    nem = Nem.nő;
                    Szul = new DateTime(2000 + int.Parse(adatsor.Substring(2, 2)), int.Parse(adatsor.Substring(4, 2)), int.Parse(adatsor.Substring(6, 2)));
                    break;

            }
            Sorsz = int.Parse(adatsor.Substring(9, 3));
            Kod = int.Parse(adatsor.Substring(12,1));
        }

        public bool CdvEll
        {
            get
            {
                int x = 0;
                for (int i = 0; i < 10; i++)
                {
                    x += (10 - i) * kodsor[i];
                }
                x %= 11;
                return Kod==x;
            }
        }



    }
}
