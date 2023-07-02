using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToDatabaseWinForms.GUI
{
    internal class Poprawnosc
    {
        bool poprawne;

        public bool sprawdz(string imie, string nazwisko, string wiek, string adres, string kodPocztowy)
        {
            if(imie!="" && nazwisko!="" && wiek!="" && adres!="" && kodPocztowy!="")
            {
                poprawne = true;
            }
            else
            {
                poprawne = false;
            }
            return poprawne;
        }
    }
}
