using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formato
{
    public partial class parada : Form
    {
       public String FormatoID;
        public String IDparo;
        DBlite db = new DBlite();
        public parada()
        {
            InitializeComponent();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            int seGUardo = 0;

            if (fecha_txt.Text !="" && hora_txt.Text !="" && accion_txt.Text!="" && motivo_txt.Text !="" )
            {

           
            if (btn_guardar.Text == "Re-guardar")
            {
                seGUardo = db.editaParo(Convert.ToInt32(IDparo), fecha_txt.Text, hora_txt.Text,
                     ubicacion_txt.Text, accion_txt.Text, motivo_txt.Text, evolucion.Text, resultado_txt.Text,
                     observaciones_txt.Text);

                if (seGUardo > 0)
                {
                    MessageBox.Show("Se guardo Correctamente");
                    btn_guardar.Text = "Guardar";
                    limpiar();


                }
                else
                {
                    MessageBox.Show("no se pudo guardar");
                }
            }
            else
            {
                seGUardo = db.registraParo(Convert.ToInt32(FormatoID), fecha_txt.Text, hora_txt.Text,
                     ubicacion_txt.Text, accion_txt.Text, motivo_txt.Text, evolucion.Text, resultado_txt.Text,
                     observaciones_txt.Text);

                if (seGUardo > 0)
                {
                    MessageBox.Show("Se guardo Correctamente");

                    limpiar();


                }
                else
                {
                    MessageBox.Show("no se pudo guardar");
                }

            }

            }
            else
            {
                MessageBox.Show("Por favor completa datos del por el paro");
            }

        }

        public void limpiar()
        {
            fecha_txt.Text = "";
            hora_txt.Text = "";
            ubicacion_txt.Text = "";
            accion_txt.Text = "";
            motivo_txt.Text = "";
            evolucion.Text = "";
            resultado_txt.Text = "";
            observaciones_txt.Text = "";
            db.consultaParos(Baseparo, Convert.ToInt32(FormatoID));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
         
        }

        private void BaseFormatos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void parada_Load(object sender, EventArgs e)
        {
            fecha_txt.Text = DateTime.Now.ToShortDateString();
            hora_txt.Text = DateTime.Now.ToString("HH:mm:ss");

            db.consultaParos(Baseparo, Convert.ToInt32(FormatoID));
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btn_motivo_Click(object sender, EventArgs e)
        {
            try
            {

            

            if (Baseparo.SelectedRows.Count > 0)
            {
                btn_guardar.Text = "Re-guardar";
                    try
                    {
                        IDparo = this.Baseparo.CurrentRow.Cells["IDparo"].Value.ToString();
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");

                    }
              

                fecha_txt.Text = this.Baseparo.CurrentRow.Cells["fecha"].Value.ToString();
                hora_txt.Text = this.Baseparo.CurrentRow.Cells["hora"].Value.ToString();
                ubicacion_txt.Text = this.Baseparo.CurrentRow.Cells["ubicacion"].Value.ToString();
                accion_txt.Text = this.Baseparo.CurrentRow.Cells["accion"].Value.ToString();
                motivo_txt.Text = this.Baseparo.CurrentRow.Cells["motivo"].Value.ToString();
                evolucion.Text = this.Baseparo.CurrentRow.Cells["evolucion"].Value.ToString();
                resultado_txt.Text = this.Baseparo.CurrentRow.Cells["resultado"].Value.ToString();
                observaciones_txt.Text = this.Baseparo.CurrentRow.Cells["observaciones"].Value.ToString();

            }
            else
            {
                MessageBox.Show("Selecciona una por favor");
            }


            }
            catch (Exception)
            {

                Console.WriteLine("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            try
            {

            

            if (Baseparo.SelectedRows.Count >0)
            {
                try
                {

                
                IDparo = this.Baseparo.CurrentRow.Cells["IDparo"].Value.ToString();
                }
                catch (Exception)
                {

                    MessageBox.Show("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
                }

                int elimino=  db.eliminaParo(Convert.ToInt32(IDparo));

                if (elimino >0)
                {
                    MessageBox.Show("eliminado corrctamente");
                    db.consultaParos(Baseparo, Convert.ToInt32(FormatoID));
                }
                else
                {
                    MessageBox.Show("No se pudo eliminar");
                }
            }
            else
            {
                MessageBox.Show("Selecciona un dato a eliminar");
            }

            }
            catch (Exception)
            {

              Console.WriteLine("Error al seleccionar los datos posiblemente no hay datos por favor selecciona los datos correctos o verifique que tenga datos registrados");
            }

        }

        private void fecha_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
