using System;
namespace interface_ornek
{
    public class Lancer : IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
            return Marka.Mitsubishi;
        }

        public int KacTekerlektenOlusur()
        {
            return 4;
        }

        public Renk StandartRengiNe()
        {
            return Renk.Siyah;
        }
    }
}