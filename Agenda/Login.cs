using BusinessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Login : Form
    {
        

        public Login()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form registro = new register();
            registro.Show();
            this.Hide();
        }

        

        private void login()
        {
            try
            {
                ClsEntidades cls = new ClsEntidades();
                cls.User1 = txtUser.Text;
                cls.Password1 = txtPass.Text;


                if (txtUser == txtUser)
                {

                    cls.User1.ToString();
                    cls.Password1.ToString();

                    MessageBox.Show($"BIENVENIDO!!");

                    this.Hide();

                    Form FRM = new Contactos();
                    FRM.Show();
                }
                else
                {
                    MessageBox.Show($"DATOS INCORRECTOS... ");
                }
            }
            catch (Exception Error)
            {
                MessageBox.Show($"DATOS INCORRECTOS... {Error.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            login();
        }
    }
}

