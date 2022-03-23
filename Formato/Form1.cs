using Formato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Registro_btn_Click(object sender, EventArgs e)
        {
            AbrirFrom(new RegistraFormato());
        }

        private void Laterar1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AbrirFrom(new operadorRegistrer());
        }

        private void AbrirFrom(object formHijo)
        {
            if (this.principal.Controls.Count > 0)
            {
                this.principal.Controls.RemoveAt(0);
            }
                Form fh = formHijo as Form;
                fh.TopLevel = false;
                this.principal.Controls.Add(fh);
                this.principal.Tag = fh;
                fh.Show();
            
        }

        private void principal_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AbrirFrom(new Datosmonitoreos());
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
