using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MySql.Data.MySqlClient;

namespace UsEsquelbecq
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBconnexion conn = new DBconnexion();
        }
        public List<string> getPersonneDoc()
        {
            MySqlCommand cmd = new MySqlCommand();
            List<string> personnes = new List<string>();

            MySqlDataReader read;

            cmd.CommandText = "SELECT documents.titre_document FROM documents";
            cmd.CommandType = CommandType.Text;

            read = cmd.ExecuteReader();

            while (read.Read())
            {
                int i = 0;
                personnes.Add(read[i].ToString());
                i++;
            }

            read.Close();
            return personnes;
        }
    }
}
