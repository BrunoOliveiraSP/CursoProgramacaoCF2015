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
            // CLASSE PARA ABRIR A JANELA E PESQUISAR O ARQUIVO
            string fileName;
            OpenFileDialog janela = new OpenFileDialog();

            // SE O USUARIO ESCOLHEU UM ARQUIVO, PEGAR O CAMINHO DO ARQUIVO
            DialogResult result = janela.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = janela.FileName;

                // CHAMAR O MÉTODO PARA LISTAR OS CONTATOS NA GRID
                ListarContatos(fileName);
            }
        }

        public void ListarContatos(string fileName)
        {
            // VALIDAÇÃO PARA VER SE A EXTENSÃO DO ARQUIVO É CSV
            if (System.IO.Path.GetExtension(fileName) != ".csv")
            {
                MessageBox.Show("Escolha um arquivo CSV");
                return;
            }

            // LEITURA DO ARQUIVO CSV
            List<Contato> contatos = LerContatos(fileName);

            // EXIBE CONTATOS NA GRID
            gvContatos.DataSource = contatos;
            lblArquivo.Text = fileName;
        }

        public List<Contato> LerContatos(string fileName)
        {
            List<Contato> contatos = new List<Contato>();

            // CLASSE PARA LER LINHA A LINHA DO ARQUIVO
            System.IO.StreamReader reader = new System.IO.StreamReader(fileName);

            // ENQUANTO NÃO ESTIVER NO FINAL DO ARQUIVO, LER LINHA
            int count = 0;
            while (!reader.EndOfStream)
            {
                // DESCONSIDERA A PRIMEIRA LINHA, PQ É CABEÇALHO
                if (count == 0)
                {
                    count++;
                    reader.ReadLine();
                    continue;
                }

                // CRIA UM VETOR DAS COLUNAS DO ARQUIVO, QUEBRANDO POR VÍRGULA (,)
                string[] colunas = reader.ReadLine().Split(',');

                // CRIA A CLASSE PARA ARMAZENAR AS INFORMAÇÕES DO CONTATO
                Contato contato = new Contato();

                // PEGA A PRIMEIRA POSIÇÃO DO ARRAY E ADICIONA COMO 'NOME'
                contato.Nome = colunas[0];

                // PEGA A POSIÇÃO 28 DO ARRAY E ADICIONAR COMO E-MAIL
                contato.Email = colunas[28];

                // DESAFIO 1 - NOME AO CONTRARIO
                contato.NomeR = string.Join(string.Empty, contato.Nome.Reverse());

                // DESAFIO 2 - DOMINIO DO EMAIL
                int indexArroba = contato.Email.IndexOf("@");
                int indexPonto = contato.Email.IndexOf(".", indexArroba);
                contato.Dominio = contato.Email.Substring(indexArroba + 1, indexPonto - indexArroba - 1);

                contatos.Add(contato);
            }
            // ENCERRA A LEITURA
            reader.Close();

            return contatos;
        }
    }
}
