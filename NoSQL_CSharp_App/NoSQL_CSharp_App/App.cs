using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NoSQL_CSharp_App
{
    public partial class App : Form
    {
        public App()
        {
            InitializeComponent();
        }

        private void limpaFormulario()
        {
            tb_Nome.Clear();
            tb_Idade.Clear();
            tb_Email.Clear();
        }

        private void lb_Email_Click(object sender, EventArgs e)
        {

        }

        private void lb_Nome_Click(object sender, EventArgs e)
        {

        }

        private void lb_Idade_Click(object sender, EventArgs e)
        {

        }

        private void btn_Enviar_Click(object sender, EventArgs e)
        {
            string nome = tb_Nome.Text;
            string idade = tb_Idade.Text;
            string email = tb_Email.Text;

            MessageBox.Show($"Nome: {nome} Idade: {idade}\nEmail: {email}");

            limpaFormulario();
            tb_Nome.Focus();
        }
    }
}
