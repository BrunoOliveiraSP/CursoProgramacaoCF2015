using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estudo.Variaveis.String
{
    public partial class frmStrings : Form
    {
        public frmStrings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //texto = texto.Replace("think", "sleep");

            //texto = texto.Reverse().ToString();

            //texto = texto.ToUpper();

            //texto = texto.ToLower();

            //texto = texto.Trim();

            //texto = texto.TrimStart();

            //texto = texto.TrimEnd();

            //bool r = texto.StartsWith("I");

            //texto = texto.Substring(6);

            //string[] palavras = texto.Split(' ');

            //r = texto.EndsWith("think");

            //r = texto.Contains("you");

            //int caracteres = texto.Length;

            //texto = texto.PadLeft(30, '*');

            //texto.PadRight(30, '*');

            //texto = string.Format("Meu ator favorito é: ", "Jony Dep");

            

        }

        private void btnReplace_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.Replace("a", "*");

            lblResultado.Text = resultado;
        }

        private void btnReverse_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = string.Join(string.Empty, texto.Reverse());

            lblResultado.Text = resultado;
        }

        private void btnIsNullOrEmpty_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            if (string.IsNullOrEmpty(texto))
                resultado = "Está vazio";
            else
                resultado = "Não está vazio";

            lblResultado.Text = resultado;
        }

        private void btnConcat_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = string.Concat(texto, " - alterado ás ", DateTime.Now);

            lblResultado.Text = resultado;
        }

        private void btnStartsWith_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            if (texto.StartsWith("Digite"))
                resultado = "Começa com 'Digite'";
            else
                resultado = "Não começa com 'Digite'";

            lblResultado.Text = resultado;
        }

        private void btnEndsWith_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            if (texto.EndsWith("^^"))
                resultado = "Começa com '^^'";
            else
                resultado = "Não começa com '^^'";


            lblResultado.Text = resultado;
        }

        private void btnContains_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            if (texto.Contains("algum"))
                resultado = "Possui a palavra 'algum'";
            else
                resultado = "Não possui a palavra 'algum'";


            lblResultado.Text = resultado;
        }

        private void btnSubstring_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.Substring(7, 4);

            lblResultado.Text = "Pulando as 7 primeiras letras e pegando as próximas 4: " + resultado;
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            string[] palavras = texto.Split(' ');

            foreach (string item in palavras)
            {
                resultado = string.Concat(resultado, " | ", item);
            }
            
            lblResultado.Text = resultado;
        }

        private void btnToUpper_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.ToUpper();

            lblResultado.Text = resultado;
        }

        private void btnToLower_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.ToLower();

            lblResultado.Text = resultado;
        }

        private void btnTrim_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.Trim();

            lblResultado.Text = resultado;
        }

        private void btnTrimStart_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.TrimStart();

            lblResultado.Text = resultado;
        }

        private void btnTrimEnd_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.TrimEnd();

            lblResultado.Text = resultado;
        }

        private void btnLength_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.Length.ToString();

            lblResultado.Text = resultado;
        }

        private void btnPadRight_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.PadRight(30, '-'); ;

            lblResultado.Text = resultado;
        }

        private void btnPadLeft_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = texto.PadLeft(30, '-');

            lblResultado.Text = resultado;
        }

        private void btnFormat_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            resultado = string.Format("Texto: {0} - Alterado ás: {1}", texto, DateTime.Now);

            lblResultado.Text = resultado;
        }

        private void btnIntToString_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            int valor = 100;

            resultado = valor.ToString();

            lblResultado.Text = resultado;
        }

        private void btnDecToStr_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            decimal valor = 4.1M;

            resultado = valor.ToString("00.00");

            lblResultado.Text = resultado;
        }

        private void btnDtToStr_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            DateTime agora = DateTime.Now;

            resultado = agora.ToString("dd/MM/yyyy HH:mm:ss");

            lblResultado.Text = resultado;
        }

        private void btnBoolToStr_Click(object sender, EventArgs e)
        {
            string resultado = string.Empty;
            string texto = txtTexto.Text;

            bool valor = false;

            resultado = valor.ToString();

            lblResultado.Text = resultado;
        }
    }
}
