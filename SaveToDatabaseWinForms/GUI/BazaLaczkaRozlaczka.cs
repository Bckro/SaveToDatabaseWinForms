using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveToDatabaseWinForms
{
    class BazaLaczkaRozlaczka
    {
        public static SQLiteConnection sql_con;
        private SQLiteCommand sql_cmd;
        public static string BAZA_DANYCH_KSIAZKA_NAD_PLIK = "dane.db";
        public static string BAZA_DANYCH_KSIAZKA_NAD_LACZKA = "Data Source= " + BAZA_DANYCH_KSIAZKA_NAD_PLIK + ";Version=3;New=False;Compress=True;";

        public SQLiteCommand Polacz()
        {
            try
            {
                sql_con = new SQLiteConnection(BAZA_DANYCH_KSIAZKA_NAD_LACZKA);
                sql_con.Open();
                sql_cmd = sql_con.CreateCommand();
            }
            catch
            {
                MessageBox.Show("Nie mozna polaczyc sie z baza danych.");
            }
            return sql_cmd;
        }

        public void Rozlacz()
        {
            try
            {
                sql_con.Close();
            }
            catch
            {
                MessageBox.Show("Nie mozna polaczyc sie z baza danych.");
            }
        }
    }
}
