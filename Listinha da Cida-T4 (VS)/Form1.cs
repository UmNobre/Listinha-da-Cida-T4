using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Listinha_da_Cida_T4__VS_
{
    public partial class Form1 : Form
    {
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
            // Criar nosso primeiro contato (um OBJETO da classe Contato).
            Contato objetoContato = new Contato();
            lstContatos.Items.Add(objetoContato.ToString());
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void lstContatos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
