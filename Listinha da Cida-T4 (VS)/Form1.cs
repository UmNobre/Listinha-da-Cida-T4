using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Listinha_da_Cida_T4__VS_
{
    public partial class Form1 : Form
    {
        private Contato[] ListaDeContatos = new Contato[1];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Contato objetoContato = new Contato(txtNome.Text, txtSobrenome.Text, txtTelefone.Text, txtMail.Text);
            lstContatos.Items.Add(objetoContato.ToString());
        }

        private void Escrever(Contato contato)
        {
            StreamWriter escrevedorDeArquivos = new StreamWriter("Contatos.txt");
            escrevedorDeArquivos.WriteLine(ListaDeContatos.Length + 1);
            escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
            escrevedorDeArquivos.WriteLine(contato.Sobrenome);
            escrevedorDeArquivos.WriteLine(contato.Telefone);
            escrevedorDeArquivos.WriteLine(contato.Mail);

            for (int i = 0; i < ListaDeContatos.Length; i++)
            {
                escrevedorDeArquivos.WriteLine(ListaDeContatos.Length + 1);
                escrevedorDeArquivos.WriteLine(contato.PrimeiroNome);
                escrevedorDeArquivos.WriteLine(contato.Sobrenome);
                escrevedorDeArquivos.WriteLine(contato.Telefone);
                escrevedorDeArquivos.WriteLine(contato.Mail);
            }
            escrevedorDeArquivos.Close();
        }


        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void textMail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
