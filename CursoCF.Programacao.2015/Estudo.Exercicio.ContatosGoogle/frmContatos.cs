using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Estudo.Exercicio.ContatosGoogle
{
    public partial class frmContatos : Form
    {
        public frmContatos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName;
            OpenFileDialog janela = new OpenFileDialog();

            DialogResult result = janela.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = janela.FileName;

                ListarContatos(fileName);
            }
        }

        public void ListarContatos(string fileName)
        {
            if (System.IO.Path.GetExtension(fileName) != ".csv")
            {
                MessageBox.Show("Escolha um arquivo CSV");
                return;
            }

            List<Contato> contatos = LerContatos(fileName);

            gvContatos.DataSource = contatos;
            lblArquivo.Text = fileName;
        }

        public List<Contato> LerContatos(string fileName)
        {
            List<Contato> contatos = new List<Contato>();

            System.IO.StreamReader reader = new System.IO.StreamReader(fileName);

            int count = 0;
            while (!reader.EndOfStream)
            {
                if (count == 0)
                {
                    count++;
                    reader.ReadLine();
                    continue;
                }

                string[] campos = reader.ReadLine().Split(',');

                Contato contato = new Contato();
                contato.Nome = campos[0];
                contato.Email = campos[28];
                contato.NomeR = string.Join(string.Empty, contato.Nome.Reverse());

                int indexArroba = contato.Email.IndexOf("@");
                int indexPonto = contato.Email.IndexOf(".", indexArroba);
                contato.Dominio = contato.Email.Substring(indexArroba + 1, indexPonto - indexArroba - 1);

                contatos.Add(contato);
            }
            reader.Close();

            return contatos;
        }
    }
}
