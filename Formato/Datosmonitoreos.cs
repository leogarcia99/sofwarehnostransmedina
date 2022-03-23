using Formulario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Microsoft.Office.Interop.Excel;
using objExel = Microsoft.Office.Interop.Excel;

namespace Formato
{
    public partial class Datosmonitoreos : Form
    {
        DBlite db = new DBlite();
        public Datosmonitoreos()
        {
            InitializeComponent();
        }

        private void Datosmonitoreos_Load(object sender, EventArgs e)
        {
            db.consultarMonitoreos(BaseFormatos);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try { 
            if (BaseFormatos.SelectedRows.Count > 0)
            {

                String id = this.BaseFormatos.CurrentRow.Cells["IDFormato"].Value.ToString();

                int elimino = db.eliminaFormato(Convert.ToInt32(id));

                if (elimino > 0)
                {
                    MessageBox.Show("Se elimino con exito");
                    db.consultarMonitoreos(BaseFormatos);

                }
                else
                {
                    MessageBox.Show("no se pudo eliminar");
                }
            }
            else
            {
                MessageBox.Show("por favor selecciona el formato a eliminar");
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
            if (BaseFormatos.SelectedRows.Count>0)
            {
                RegistraFormato rf = new RegistraFormato();
                rf.btn_guardar.Text = "Re-guardar";
                rf.btn_cancelar.Visible = true;
                rf.btn_motivo.Visible = true;

                try { 
                rf.IDformato = this.BaseFormatos.CurrentRow.Cells["IDFormato"].Value.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
                }

                rf.IDoperador= this.BaseFormatos.CurrentRow.Cells["idOperador"].Value.ToString();
                rf.operador_txt.Text = this.BaseFormatos.CurrentRow.Cells["nombre"].Value.ToString();
                rf.Cel_txt.Text = this.BaseFormatos.CurrentRow.Cells["cel"].Value.ToString();
                rf.economico_txt.Text= this.BaseFormatos.CurrentRow.Cells["economico"].Value.ToString();
                rf.placas_txt.Text= this.BaseFormatos.CurrentRow.Cells["placas"].Value.ToString();
                rf.origen_txt.Text = this.BaseFormatos.CurrentRow.Cells["origen"].Value.ToString();
                rf.destino_txt.Text = this.BaseFormatos.CurrentRow.Cells["destino"].Value.ToString();
                rf.cliente_txt.Text = this.BaseFormatos.CurrentRow.Cells["cliente"].Value.ToString();
                rf.contenedores_txt.Text = this.BaseFormatos.CurrentRow.Cells["contenedores"].Value.ToString();
                rf.Fsalida_txt.Text = this.BaseFormatos.CurrentRow.Cells["fechaS"].Value.ToString();
                rf.fCita_txt.Text = this.BaseFormatos.CurrentRow.Cells["citaA"].Value.ToString();
                rf.fArribo_txt.Text = this.BaseFormatos.CurrentRow.Cells["fechaD"].Value.ToString();
                rf.modalidad_txt.Text = this.BaseFormatos.CurrentRow.Cells["modalidad"].Value.ToString();
                rf.movimientoTipo_txt.Text = this.BaseFormatos.CurrentRow.Cells["tipomovimiento"].Value.ToString();
                rf.DireccionEntrega_txt.Text = this.BaseFormatos.CurrentRow.Cells["direccion"].Value.ToString();

                rf.ShowDialog();

            }
            else
            {
                MessageBox.Show("selecciona un formato por favor");
            }

            }
            catch (Exception)
            {

               Console.WriteLine("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BaseFormatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

           
            String ruta;
            if (BaseFormatos.SelectedRows.Count >0)
            {

                    //dataGridview
                    String ideformato= this.BaseFormatos.CurrentRow.Cells["IDFormato"].Value.ToString(); ;
                    db.consultaParos(dataGridView1, Convert.ToInt32(ideformato));

                    //proceso de exel
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = ("archivos *.xlsx|*.xlsx");
                save.Title = "Guardar";
                if (save.ShowDialog()==DialogResult.OK)
                {
                    ruta = save.FileName;
                    objExel.Application objetoAplicacion = new objExel.Application();
                    Workbook libro = objetoAplicacion.Workbooks.Add(XlSheetType.xlWorksheet);
                    Worksheet objetoHoja = (Worksheet)objetoAplicacion.ActiveSheet;

                    objetoAplicacion.Visible = false;

                    
                    objetoHoja.Cells[1, 1] = "Nombre";
                    objetoHoja.Cells[1, 2] = "Cel";
                    objetoHoja.Cells[1, 3] = "Economico";
                    objetoHoja.Cells[1, 4] = "placas";
                    objetoHoja.Cells[1, 5] = "origen";
                    objetoHoja.Cells[1, 6] = "destino";
                    objetoHoja.Cells[1, 7] = "Cliente";
                    objetoHoja.Cells[1, 8] = "Contenedores";
                    objetoHoja.Cells[1, 9] = "Fecha y hora de salida";
                    objetoHoja.Cells[1, 10] = "Fecha y hora de cita";
                    objetoHoja.Cells[1, 11] = "Fecha y hora de destino";
                    objetoHoja.Cells[1, 12] = "Modalidad";
                    objetoHoja.Cells[1, 13] = "Tipo de movimiento";
                    objetoHoja.Cells[1, 14] = "Direccion";

                   
                    objetoHoja.Cells[2, 1] = this.BaseFormatos.CurrentRow.Cells["nombre"].Value.ToString();
                    objetoHoja.Cells[2, 2] = this.BaseFormatos.CurrentRow.Cells["cel"].Value.ToString();
                    objetoHoja.Cells[2, 3] = this.BaseFormatos.CurrentRow.Cells["economico"].Value.ToString();
                    objetoHoja.Cells[2, 4] = this.BaseFormatos.CurrentRow.Cells["placas"].Value.ToString();
                    objetoHoja.Cells[2, 5] = this.BaseFormatos.CurrentRow.Cells["origen"].Value.ToString();
                    objetoHoja.Cells[2, 6] = this.BaseFormatos.CurrentRow.Cells["destino"].Value.ToString();
                    objetoHoja.Cells[2, 7] = this.BaseFormatos.CurrentRow.Cells["cliente"].Value.ToString();
                    objetoHoja.Cells[2, 8] = this.BaseFormatos.CurrentRow.Cells["contenedores"].Value.ToString();
                    objetoHoja.Cells[2, 9] = this.BaseFormatos.CurrentRow.Cells["fechaS"].Value.ToString();
                    objetoHoja.Cells[2, 10] = this.BaseFormatos.CurrentRow.Cells["citaA"].Value.ToString();
                    objetoHoja.Cells[2, 11] = this.BaseFormatos.CurrentRow.Cells["fechaD"].Value.ToString();
                    objetoHoja.Cells[2, 12] = this.BaseFormatos.CurrentRow.Cells["modalidad"].Value.ToString();
                    objetoHoja.Cells[2, 13] = this.BaseFormatos.CurrentRow.Cells["tipomovimiento"].Value.ToString();
                    objetoHoja.Cells[2, 14] = this.BaseFormatos.CurrentRow.Cells["direccion"].Value.ToString();


                        foreach (DataGridViewColumn Columna in dataGridView1.Columns)
                        {
                            objetoHoja.Cells[4, Columna.Index + 1] = Columna.HeaderText;

                            foreach (DataGridViewRow Fila in dataGridView1.Rows)
                            {
                                objetoHoja.Cells[Fila.Index + 5, Columna.Index + 1] = Fila.Cells[Columna.Index].Value;
                            }
                        }


                    libro.SaveAs(ruta);
                    libro.Close();
                    objetoAplicacion.Quit();

                }

                save.Dispose();
               
            }
            else
            {
                MessageBox.Show("Por favor selecciona docuemnto a exportar");
            }
            }
            catch (Exception)
            {

                MessageBox.Show("error al generar archivo exel verifica que tengas datos " +
                    "registrados o es posible que intentes remplazar el archivo por otro de ser " +
                    "asi verifica que ese archivo este cerrado");
            }
        }
    }
}
