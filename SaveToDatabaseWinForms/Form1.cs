using SaveToDatabaseWinForms.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaveToDatabaseWinForms
{
    public partial class Form1 : Form
    {
        Poprawnosc poprawnosc = new Poprawnosc();
        DodajDane dodajDane = new DodajDane();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            labelImie.Text = NazwyObiektow.LabelImie;
            labelNazwisko.Text = NazwyObiektow.LabelNazwisko;
            labelWiek.Text = NazwyObiektow.LabelWiek;
            labelAdres.Text = NazwyObiektow.LabelAdres;
            labelKod.Text = NazwyObiektow.LabelKod;
        }

        private void buttonPrzekazDane_Click(object sender, EventArgs e)
        {
            if (poprawnosc.sprawdz(textBoxImie.Text, textBoxNazwisko.Text, textBoxWiek.Text, textBoxAdres.Text, textBoxKod.Text))
            {
                BazaLaczkaRozlaczka bazaLaczkaRozlaczka = new BazaLaczkaRozlaczka();
                DodajDane dodajDane = new DodajDane();
                SQLiteCommand sql_cmd = bazaLaczkaRozlaczka.Polacz();

                sql_cmd.CommandText = dodajDane.dodajRekord_1_pole(BazaDanychOpis.BAZADANYCH_TABELA_DaneOsobowe, textBoxImie.Text, textBoxNazwisko.Text, textBoxWiek.Text, textBoxAdres.Text, textBoxKod.Text, "imie","nazwisko","wiek","adres","kodPocztowy");
                SQLiteDataReader kursor1 = sql_cmd.ExecuteReader();
                bazaLaczkaRozlaczka.Rozlacz();

                MessageBox.Show("Database entry added.");

                textBoxImie.Text = textBoxNazwisko.Text = textBoxWiek.Text = textBoxAdres.Text = textBoxKod.Text = "";
            }
            else
            {
                MessageBox.Show("Incorrect data provided.");
            }
        }
    }
}