using Formato;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Formulario
{
    public partial class operadorRegistrer : Form
    {
        DBlite bd = new DBlite();
        public String id;
        public operadorRegistrer()
        {
            InitializeComponent();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void operadorRegistrer_Load(object sender, EventArgs e)
        {
            bd.consultaOperador(BaseOperadores);
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {

                if (nombre_txt.Text !="")
                {
                    if (Cel_txt.Text != "")
                    {
                        if (economico_txt.Text!="")
                        {
                            if (placas_txt.Text!="")
                            {
                                int NumeroDeResgistro = bd.guardaOperador(nombre_txt.Text, Cel_txt.Text, economico_txt.Text, placas_txt.Text);
                                if (NumeroDeResgistro > 0)
                                {
                                    MessageBox.Show("Se registro correctamente");
                                    bd.consultaOperador(BaseOperadores);
                                    nombre_txt.Text = "";
                                    Cel_txt.Text = "";
                                    economico_txt.Text = "";
                                    placas_txt.Text = "";

                                }
                                else
                                {
                                    MessageBox.Show("no se ha podido registar");
                                }
                            }
                            else
                            {
                                MessageBox.Show("por favor coloca las placas");
                            }

                        }
                        else
                        {
                            MessageBox.Show("por favor coloca economico");
                        }
                    }
                    else
                    {
                        MessageBox.Show("por favor coloca un numero");
                    }
                }
                else
                {
                    MessageBox.Show("por favor coloca un nombre");
                }

               
               
            }
            catch (Exception ee)
            {

               MessageBox.Show(ee.Message);
            }
            
        }

        private void BaseOperadores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            if (BaseOperadores.SelectedRows.Count > 0)
            {
               id = this.BaseOperadores.CurrentRow.Cells["ID"].Value.ToString();
             
            int deleted = bd.eliminaOperador(Convert.ToInt32(id));
                if (deleted > 0)
                {
                    MessageBox.Show("Eliminado con exito");
                    bd.consultaOperador(BaseOperadores);
                    button1.Visible = true;
                   
                    button4.Visible = false;
                }
                else
                {
                    MessageBox.Show("no se a podido eliminar este usuario");
                }
            }
            else
            {
                MessageBox.Show("selecciona un dato a eliminar");
            }
            {

            }

            }
            catch (Exception)
            {

                MessageBox.Show("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
            }
        }

        private void btn_salida_Click(object sender, EventArgs e)
        {
            try { 

            if (BaseOperadores.SelectedRows.Count > 0)
            {
                try { 
               
              id = this.BaseOperadores.CurrentRow.Cells["ID"].Value.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
                }
                nombre_txt.Text = this.BaseOperadores.CurrentRow.Cells["nombre"].Value.ToString();
               Cel_txt.Text = this.BaseOperadores.CurrentRow.Cells["cel"].Value.ToString();
               economico_txt.Text = this.BaseOperadores.CurrentRow.Cells["economico"].Value.ToString();
                placas_txt.Text = this.BaseOperadores.CurrentRow.Cells["placas"].Value.ToString();

                button1.Visible = false;
               
                button4.Visible = true;
             
                

            }
            else
            {
                MessageBox.Show("selecciona un dato a eliminar");
            }
            {

            }

            }
            catch (Exception)
            {

                Console.WriteLine("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {

            if (nombre_txt.Text != "")
            {
                if (Cel_txt.Text != "")
                {
                    if (economico_txt.Text != "")
                    {
                        if (placas_txt.Text != "")
                        {

                            DBlite db = new DBlite();
                            int actualizado = db.edita(Convert.ToInt32(id), nombre_txt.Text, Cel_txt.Text, economico_txt.Text, placas_txt.Text);
                            if (actualizado > 0)
                            {
                                MessageBox.Show("se actualizo correctamente los datos");
                                button1.Visible = true;
                               
                                button4.Visible = false;
                                bd.consultaOperador(BaseOperadores);
                            }
                            else
                            {
                                MessageBox.Show("los datos no pudieron ser actualizados");
                            }
                        }
                        else
                        {
                            MessageBox.Show("por favor coloca las placas");
                        }

                    }
                    else
                    {
                        MessageBox.Show("por favor coloca economico");
                    }
                }
                else
                {
                    MessageBox.Show("por favor coloca un numero");
                }
            }
            else
            {
                MessageBox.Show("por favor coloca un nombre");
            }
        }
    }
}
