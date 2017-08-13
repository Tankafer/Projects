using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace UsEsquelbecq
{
    class DBconnexion
    {
        public DBconnexion()
        {
            string connexionString = "server=localhost;database=dbusesquelbecq;uid=root;pwd=;SslMode=none";
            MySqlConnection cnn = new MySqlConnection(connexionString);
            try
            {
                cnn.Open();
                MessageBox.Show("Connection Open ! ");
                cnn.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show("Can not open connection ! Retry later");
            }
        }
    }
}
