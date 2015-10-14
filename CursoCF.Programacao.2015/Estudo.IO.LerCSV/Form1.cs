using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo.IO.LerCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<Seriado> seriados = Carregar();

            dataGridView1.DataSource = seriados;
        }


        public List<Seriado> Carregar()
        {
            List<Seriado> seriados = new List<Seriado>();

            System.IO.StreamReader reader = new System.IO.StreamReader("seriados.txt");

            string line = string.Empty;
            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();
                string[] campos = line.Split(';');

                Seriado seriado = new Seriado();
                seriado.Nome = campos[0];
                seriado.Estreia = DateTime.Parse(campos[1]);
                seriado.Temporadas = int.Parse(campos[2]);

                seriados.Add(seriado);
            }
            reader.Close();

            return seriados;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.IO.StreamWriter writer = new System.IO.StreamWriter("seriados.txt", true);

            string seriado = string.Format("{0};{1};{2}", txtSeriado.Text, dtpEstreia.Value.ToShortDateString(), txtTemporada.Text);
            writer.WriteLine(seriado);

            writer.Close();
        }
    }
}
