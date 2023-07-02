using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SaveToDatabaseWinForms.GUI
{
    internal class PobierzDane
    {
        public string pobierz(int id)
        {
            string sqlString = null;

            sqlString = "SELECT * FROM DaneOsobowe WHERE idOsoby=" + id + ";";

            return sqlString;
        }
    }
}
