using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToDatabaseWinForms.GUI
{
    internal class DodajDane
    {
        public string dodajRekord_1_pole(string nazwaTabeli, string imie, string nazwisko,
            string wiek, string adres, string kodPocztowy, string imieLabel, string nazwiskoLabel,
            string wiekLabel, string adresLabel, string kodPocztowyLabel)
        {
            string sqlString = null;

            sqlString = "INSERT INTO " + nazwaTabeli + " (" + imieLabel + "," + nazwiskoLabel + "," + wiekLabel + "," + adresLabel + "," + kodPocztowyLabel +
                ") VALUES ('" + imie + "','" + nazwisko + "','" + wiek + "','" + adres + "','" + kodPocztowy + "');";
            
            return sqlString;
        }
    }
}
