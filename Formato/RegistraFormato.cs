using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SQLite;
using System.Threading;

namespace Formato
{
    public partial class RegistraFormato : Form
    {
        public RegistraFormato()
        {
            InitializeComponent();

        }

        private static String cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;
        public String id;

        public String IDformato, IDoperador;
        private void btn_salida_Click(object sender, EventArgs e)
        {
            Fsalida_txt.Text = calendario_txt.SelectionStart.ToString();
        }

        private void btn_llegada_Click(object sender, EventArgs e)
        {
            fCita_txt.Text = calendario_txt.SelectionStart.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            fArribo_txt.Text = calendario_txt.SelectionStart.ToString();
        }

        private void operador_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand selecciona = new SQLiteCommand("select * from operadores where nombre=@nombre", conexion);
                selecciona.Parameters.AddWithValue("nombre", operador_txt.SelectedItem.ToString());
                SQLiteDataReader operadorNombre = selecciona.ExecuteReader();
                if (operadorNombre.Read() == true)
                {
                    id = operadorNombre["ID"].ToString();
                    id_txt.Text = operadorNombre["ID"].ToString();
                    Cel_txt.Text = operadorNombre["cel"].ToString();
                    economico_txt.Text = operadorNombre["economico"].ToString();
                    placas_txt.Text = operadorNombre["placas"].ToString();
                }
                conexion.Close();
            }
        }

        private void fArribo_txt_TextChanged(object sender, EventArgs e)
        {

        }

        private void RegistraFormato_Load(object sender, EventArgs e)
        {
            origen_txt.Text = "LÁZARO CÁRDENAS, MICHOACAN";
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();
                SQLiteCommand selecciona = new SQLiteCommand("select ID, nombre from operadores", conexion);
                SQLiteDataReader operadorNombre = selecciona.ExecuteReader();
                while (operadorNombre.Read())
                {
                    id_txt.Items.Add(operadorNombre["ID"].ToString());
                    operador_txt.Items.Add(operadorNombre["nombre"].ToString());
                }
                conexion.Close();
            }
            }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            DBlite db = new DBlite();
            if (operador_txt.Text != "" && Cel_txt.Text != "" && economico_txt.Text != "" && placas_txt.Text != "")
            {
                if (origen_txt.Text != "" && destino_txt.Text != "" && cliente_txt.Text != "" &&
                    contenedores_txt.Text != "" && Fsalida_txt.Text != "" && modalidad_txt.Text != ""
                    && movimientoTipo_txt.Text !="" && destino_txt.Text !="")
                {
                     
              

            if (btn_guardar.Text == "Re-guardar")
            {
                loading lol = new loading();
                lol.Show();

                int edito = db.editaFormato(Convert.ToInt32(IDformato), operador_txt.Text, Cel_txt.Text,
                   economico_txt.Text, placas_txt.Text, origen_txt.Text, destino_txt.Text,
                   cliente_txt.Text, contenedores_txt.Text, Fsalida_txt.Text,
                   fCita_txt.Text, fArribo_txt.Text, modalidad_txt.Text, movimientoTipo_txt.Text, DireccionEntrega_txt.Text);

                Task otask1 = new Task(tiempo);
                otask1.Start();
                await otask1;
                lol.Close();

                if (edito > 0)
                {
                    MessageBox.Show("Editado Correctamente");
                }
                else
                {
                    MessageBox.Show("No se pudo editar");
                }

            }
            else
            {

                loading lo = new loading();
                lo.Show();


                int Guardo = db.GuardaMonitoreo(Convert.ToInt32(id), operador_txt.Text, Cel_txt.Text,
                          economico_txt.Text, placas_txt.Text, origen_txt.Text, destino_txt.Text,
                          cliente_txt.Text, contenedores_txt.Text, Fsalida_txt.Text,
                          fCita_txt.Text, fArribo_txt.Text, modalidad_txt.Text, movimientoTipo_txt.Text, DireccionEntrega_txt.Text);

                Task otask = new Task(tiempo);
                otask.Start();
                await otask;
                lo.Close();

                if (Guardo > 0)
                {
                    MessageBox.Show("Monitoreo Guardado Correctamente");
                }
                else
                {
                    MessageBox.Show("no se pudo guardar el monitoreo");
                }

            }

                }
                else
                {
                    MessageBox.Show("por favorcompleta los datos de envio");
                }
            }
            else
            {
                MessageBox.Show("por favor completa datos del operador");
            }

        }

        public void tiempo()
        {
            Thread.Sleep(3000);
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            parada pd = new parada();
            pd.FormatoID = IDformato;
            pd.Show();
        }

        private void id_txt_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand selecciona = new SQLiteCommand("select * from operadores where ID=@ID", conexion);
                selecciona.Parameters.AddWithValue("@ID", id_txt.SelectedItem.ToString());
                SQLiteDataReader operadorNombre = selecciona.ExecuteReader();
                if (operadorNombre.Read() == true)
                {
                    id = operadorNombre["ID"].ToString();
                    operador_txt.Text = operadorNombre["nombre"].ToString();
                    Cel_txt.Text = operadorNombre["cel"].ToString();
                    economico_txt.Text = operadorNombre["economico"].ToString();
                    placas_txt.Text = operadorNombre["placas"].ToString();
                }
                conexion.Close();
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
