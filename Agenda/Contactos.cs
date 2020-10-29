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
    public partial class Contactos : Form
    {
        private ServiceItem servicio;
        private int index;
        public Contactos()
        {
            servicio = new ServiceItem();
            index = 0;
            InitializeComponent();
        }

        

        private void add()
        {
            Client cliente = new Client();
            cliente.Name = txtname.Text;
            cliente.LastName = txtlastname.Text;
            cliente.Phone = txtphone.Text;
            cliente.PhoneJob = txtphonejob.Text;
            cliente.Direction = txtdirection.Text;

            servicio.Agregar(cliente);

            LoadData();
            ClearData();
        }

        private void ClearData()
        {
            txtname.Clear();
            txtlastname.Clear();
            txtdirection.Clear();
            txtphone.Clear();
            txtphonejob.Clear();


        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (index < 0) {
                
                add();
            }
            else
            {
                edit();
            }
        }

        private void LoadData()
        {
            BindingSource bindingsource = new BindingSource();
            bindingsource.DataSource = servicio.GetAll();

            DGV.DataSource = bindingsource;
            DGV.ClearSelection();
        }

        private void edit()
        {
            Client cliente = new Client();
            cliente.Name = txtname.Text;
            cliente.LastName = txtlastname.Text;
            cliente.Phone = txtphone.Text;
            cliente.PhoneJob = txtphonejob.Text;
            cliente.Direction = txtdirection.Text;

            servicio.Editar(index, cliente);
            LoadData();
            ClearData();



        }
        

        private void Contactos_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                index = e.RowIndex;

                txtname.Text = DGV.Rows[index].Cells[0].Value.ToString();
                txtlastname.Text = DGV.Rows[index].Cells[0].Value.ToString();
                txtdirection.Text = DGV.Rows[index].Cells[0].Value.ToString();
                txtphone.Text = DGV.Rows[index].Cells[0].Value.ToString();
                txtphonejob.Text = DGV.Rows[index].Cells[0].Value.ToString();
            }


        }

        private void Delete()
        {
            servicio.Borrar(index);
            LoadData();
            ClearData();
            
        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cerrarSesionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
