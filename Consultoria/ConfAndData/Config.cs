using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Consultoria.ConfAndData
{
    class Config
    {
        protected SQLiteConnection con=null;
        public void Conectar(){
            if (con == null)
            {
                try
                {
                    con = new SQLiteConnection(@"Data Source=ConfAndData\Test.db; Version=3;");
                    con.Open();
                }
                catch (SQLiteException e)
                {
                    MessageBox.Show(e.Message, "Error con el servidor de base de datos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else {
                if (con != null)
                {
                    con.Close();
                    con = null;
                }
            }
        }

        public void Desconectar() {
            if (con!=null) {                
                con.Close();
                con = null;
            }
        }
    }
}
