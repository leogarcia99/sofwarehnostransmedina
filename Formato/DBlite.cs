using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SQLite;
using System.Windows.Forms;
using System.Data;

namespace Formato
{
    class DBlite
    {
        private static String cadena = ConfigurationManager.ConnectionStrings["cadena"].ConnectionString;

        public int guardaOperador(String nombre, String cel, String economico, String placas)
        {
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand guarda = new SQLiteCommand("insert into operadores(nombre, cel, economico, placas) values(@nombre, @cel, @economico, @placas)", conexion);
                guarda.Parameters.AddWithValue("@nombre", nombre);
                guarda.Parameters.AddWithValue("@cel", cel);
                guarda.Parameters.AddWithValue("@economico", economico);
                guarda.Parameters.AddWithValue("@placas", placas);
                try
                {
                    respuesta = guarda.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }

                conexion.Close();
            }


            return respuesta;
        }

        public void consultaOperador(DataGridView datoscliente)
        {

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                SQLiteCommand verOperadores = new SQLiteCommand("select * from operadores", conexion);
                SQLiteDataAdapter datosc = new SQLiteDataAdapter(verOperadores);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                datoscliente.DataSource = dccliente.Tables[0];

                conexion.Close();
            }
        }

        public int eliminaOperador(int ID)
        {
            int eliminado = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                SQLiteCommand verOperadores = new SQLiteCommand("delete from operadores where ID=@ID", conexion);
                verOperadores.Parameters.AddWithValue("@ID", ID);
                try
                {
                    eliminado = verOperadores.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }
                conexion.Close();
            }

            return eliminado;

        }

        public int edita(int ID, String nombre, String cel, String economico, String placas)
        {
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand guarda = new SQLiteCommand("update operadores set nombre=@nombre, cel=@cel, economico=@economico, placas=@placas where ID=@ID", conexion);
                guarda.Parameters.AddWithValue("@nombre", nombre);
                guarda.Parameters.AddWithValue("@cel", cel);
                guarda.Parameters.AddWithValue("@economico", economico);
                guarda.Parameters.AddWithValue("@placas", placas);
                guarda.Parameters.AddWithValue("@ID", ID);
                try
                {
                    respuesta = guarda.ExecuteNonQuery();
                }
                catch (Exception)
                {

                    throw;
                }

                conexion.Close();
            }
            return respuesta;

        }

        public int GuardaMonitoreo(int IDoperador, String nombre, String cel, String economico, String placas, String origen,
            String destino, String cliente, String contenedores, String fechaSalida, String citaA, String fechaDestino,
            String modalidad, String tipomovimiento, String direccion)
        {
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand guarda = new SQLiteCommand("insert into formato(idOperador, nombre, cel, economico, placas, origen, destino, cliente, contenedores, fechaS, citaA, fechaD, modalidad, tipomovimiento, direccion) values(@IDoperador, @nombre, @cel, @economico, @placas, @origen, @destino, @cliente, @contenedores, @fechaSalida, @citaA, @fechaDestino, @modalidad, @tipomovimiento, @direccion)", conexion);
                guarda.Parameters.AddWithValue("@IDoperador", IDoperador);
                guarda.Parameters.AddWithValue("@nombre", nombre);
                guarda.Parameters.AddWithValue("@cel", cel);
                guarda.Parameters.AddWithValue("@economico", economico);
                guarda.Parameters.AddWithValue("@placas", placas);
                guarda.Parameters.AddWithValue("@origen", origen);
                guarda.Parameters.AddWithValue("@destino", destino);
                guarda.Parameters.AddWithValue("@cliente", cliente);
                guarda.Parameters.AddWithValue("@contenedores", contenedores);
                guarda.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                guarda.Parameters.AddWithValue("@citaA", citaA);
                guarda.Parameters.AddWithValue("@fechaDestino", fechaDestino);
                guarda.Parameters.AddWithValue("@modalidad", modalidad);
                guarda.Parameters.AddWithValue("@tipomovimiento", tipomovimiento);
                guarda.Parameters.AddWithValue("@direccion", direccion);

                try
                {
                    respuesta = guarda.ExecuteNonQuery();

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }

                conexion.Close();
            }


            return respuesta;
        }

        public void consultarMonitoreos(DataGridView datoscliente)
        {

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                SQLiteCommand verOperadores = new SQLiteCommand("select * from formato", conexion);
                SQLiteDataAdapter datosc = new SQLiteDataAdapter(verOperadores);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                datoscliente.DataSource = dccliente.Tables[0];

                conexion.Close();
            }
        }

        public int eliminaFormato(int ID)
        {
            int eliminado = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                SQLiteCommand verOperadores = new SQLiteCommand("delete from formato where IDFormato=@ID", conexion);
                verOperadores.Parameters.AddWithValue("@ID", ID);
                try
                {
                    eliminado = verOperadores.ExecuteNonQuery();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
                conexion.Close();
            }

            return eliminado;

        }

        public int editaFormato(int ID, String nombre, String cel, String economico, String placas, String origen,
            String destino, String cliente, String contenedores, String fechaSalida, String citaA, String fechaDestino,
            String modalidad, String tipomovimiento, String direccion)
        {
            int respuesta = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand guarda = new SQLiteCommand("update formato set nombre=@nombre, cel=@cel, economico=@economico, placas=@placas, origen=@origen," +
                    "destino=@destino, cliente=@cliente, contenedores=@contenedores, fechaS=@fechaSalida, citaA=@citaA, fechaD=@fechaDestino," +
                    "modalidad=@modalidad, tipomovimiento=@tipomovimiento, direccion=@direccion where IDFormato=@ID", conexion);
                guarda.Parameters.AddWithValue("@nombre", nombre);
                guarda.Parameters.AddWithValue("@cel", cel);
                guarda.Parameters.AddWithValue("@economico", economico);
                guarda.Parameters.AddWithValue("@placas", placas);
                guarda.Parameters.AddWithValue("@origen", origen);
                guarda.Parameters.AddWithValue("@destino", destino);
                guarda.Parameters.AddWithValue("@cliente", cliente);
                guarda.Parameters.AddWithValue("@contenedores", contenedores);
                guarda.Parameters.AddWithValue("@fechaSalida", fechaSalida);
                guarda.Parameters.AddWithValue("@citaA", citaA);
                guarda.Parameters.AddWithValue("@fechaDestino", fechaDestino);
                guarda.Parameters.AddWithValue("@modalidad", modalidad);
                guarda.Parameters.AddWithValue("@tipomovimiento", tipomovimiento);
                guarda.Parameters.AddWithValue("@direccion", direccion);
                guarda.Parameters.AddWithValue("@ID", ID);
                try
                {
                    respuesta = guarda.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);

                }

                conexion.Close();
            }
            return respuesta;

        }

        public int registraParo(int IDformato, String fecha, String hora, String ubicacion, String accion, String motivo, String evolucion, String resultado, String observaciones)
        {
            int registro = 0;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand guarda = new SQLiteCommand("insert into paro(IDformato, fecha, hora, ubicacion, accion, motivo, evolucion, resultado, observaciones) values(@IDformato, @fecha, @hora, @ubicacion, @accion, @motivo, @evolucion, @resultado, @observaciones)", conexion);
                guarda.Parameters.AddWithValue("@IDformato", IDformato);
                guarda.Parameters.AddWithValue("@fecha", fecha);
                guarda.Parameters.AddWithValue("@hora", hora);
                guarda.Parameters.AddWithValue("@ubicacion", ubicacion);
                guarda.Parameters.AddWithValue("@accion", accion);
                guarda.Parameters.AddWithValue("@motivo", motivo);
                guarda.Parameters.AddWithValue("@evolucion", evolucion);
                guarda.Parameters.AddWithValue("@resultado", resultado);
                guarda.Parameters.AddWithValue("@observaciones", observaciones);

                try
                {
                    registro = guarda.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

                conexion.Close();
            }

            return registro;
        }


        public void consultaParos(DataGridView datoscliente, int ID)
        {

            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                SQLiteCommand verOperadores = new SQLiteCommand("select * from paro where IDformato=@ID", conexion);
                verOperadores.Parameters.AddWithValue("@ID", ID);
                SQLiteDataAdapter datosc = new SQLiteDataAdapter(verOperadores);
                DataSet dccliente = new DataSet();
                datosc.Fill(dccliente);
                datoscliente.DataSource = dccliente.Tables[0];

                conexion.Close();
            }
        }


        public int editaParo(int IDparo, String fecha, String hora, String ubicacion, String accion, String motivo, String evolucion, String resultado, String observaciones)
        {
            int registro = 0;


            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {
                conexion.Open();

                SQLiteCommand guarda = new SQLiteCommand("update paro set fecha=@fecha, hora=@hora, ubicacion=@ubicacion, accion=@accion, motivo=@motivo, evolucion=@evolucion, resultado=@resultado, observaciones=@observaciones where IDparo=@IDparo ", conexion);

                guarda.Parameters.AddWithValue("@fecha", fecha);
                guarda.Parameters.AddWithValue("@hora", hora);
                guarda.Parameters.AddWithValue("@ubicacion", ubicacion);
                guarda.Parameters.AddWithValue("@accion", accion);
                guarda.Parameters.AddWithValue("@motivo", motivo);
                guarda.Parameters.AddWithValue("@evolucion", evolucion);
                guarda.Parameters.AddWithValue("@resultado", resultado);
                guarda.Parameters.AddWithValue("@observaciones", observaciones);
                guarda.Parameters.AddWithValue("@IDparo", IDparo);

                try
                {
                    registro = guarda.ExecuteNonQuery();
                }
                catch (Exception e)
                {

                    MessageBox.Show(e.Message);
                }

                conexion.Close();
            }

            return registro;
        }

        public int eliminaParo(int ID)
        {
            int eliminado = 0;
            using (SQLiteConnection conexion = new SQLiteConnection(cadena))
            {

                conexion.Open();
                SQLiteCommand verOperadores = new SQLiteCommand("delete from paro where IDparo=@ID", conexion);
                verOperadores.Parameters.AddWithValue("@ID", ID);
                try
                {
                    eliminado = verOperadores.ExecuteNonQuery();
                }
                catch (Exception ee)
                {

                    MessageBox.Show(ee.Message);
                }
                conexion.Close();
            }

            return eliminado;

        }
    }
}
