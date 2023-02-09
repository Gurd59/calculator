using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulkulačka
{
    class kalkulacka
    {

        public Operace Operace { get; set; }

        public double? cislo1 { get; set; }

        public double? cislo2 { get; set; }

        public double? Vysledek { get; private set; }


        public void Vypocitej()
        {
            if (cislo1 == null || cislo2 == null ||
                Operace == Operace.Zadna)
                return;

            switch (Operace)
            {
                case Operace.Soucet:
                    Vysledek = cislo1 + cislo2;
                    break;
                case Operace.Rozdil:
                    Vysledek = cislo1 - cislo2;
                    break;
                case Operace.Soucin:
                    Vysledek = cislo1 * cislo2;
                    break;
                case Operace.Podil:
                    {
                        if (cislo2 == 0)
                            throw new Exception("Nulou nelze dělit!");
                        else
                            Vysledek = cislo1 / cislo2;
                    }
                    break;
            }

            Operace = Operace.Zadna;
        }

        public void Resetuj()
        {
            Operace = Operace.Zadna;
            cislo1 = null;
            cislo2 = null;
            Vysledek = null;
        }

    }
}
