using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crudexamenfinal.Data
{
    internal class Registro
    {
        private string connectionString = "Server=localhost;Database=examfinalcrud;Uid=root;Pwd=Jhostyn_2;";

        public string ConnectionString { get; internal set; }

        //constructor
        public Registro(string servidor, string usur, string pwd)
        {
            connectionString = "Server=" + servidor + ";Database=examfinalcrud;Uid=" + usur + ";Pwd=" + pwd + ";";
        }
        //prueba de conexion
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }
            }
        }
        public DataTable LeerProductos()
        {
            DataTable personajes = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM productos";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personajes);
                    }
                }
            }

            return personajes;
        }

        public DataTable BuscarPersonajePorId(int id)
        {
            DataTable personaje = new DataTable();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "SELECT * FROM productos WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                    {
                        adapter.Fill(personaje);
                    }
                }
            }

            return personaje;
        }

        public int Crear_pruducto(string producto, string proveedor, int cantidad, float precio_uni, DateTime fechaingreso, string descripcion, string comentario)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "INSERT INTO productos (producto, cantidad, precio_unitario, proveedor, fecha_ingreso, descripcion, Comentario) VALUES(@producto, @cantidad, @precio_unitario, @proveedor, @fecha_ingreso, @descripcion, @Comentario)";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@producto", producto);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@precio_unitario", precio_uni);
                    command.Parameters.AddWithValue("@proveedor", proveedor);
                    command.Parameters.AddWithValue("@fecha_ingreso", fechaingreso);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@Comentario", comentario);

                    return command.ExecuteNonQuery();
                }
            }
        }

        public void ActualizarProducto(int id, string producto, string proveedor, int cantidad, float precio_uni, DateTime fechaingreso, string descripcion, string comentario)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();

                string sql = "UPDATE productos SET producto = @producto, cantidad = @cantidad, precio_unitario = @precio_unitario, proveedor = @proveedor, fecha_ingreso = @fecha_ingreso, descripcion = @descripcion, Comentario = @Comentario WHERE id = @id";
                using (MySqlCommand command = new MySqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@producto", producto);
                    command.Parameters.AddWithValue("@cantidad", cantidad);
                    command.Parameters.AddWithValue("@precio_unitario", precio_uni);
                    command.Parameters.AddWithValue("@proveedor", proveedor);
                    command.Parameters.AddWithValue("@fecha_ingreso", fechaingreso);
                    command.Parameters.AddWithValue("@descripcion", descripcion);
                    command.Parameters.AddWithValue("@Comentario", comentario);
                    command.Parameters.AddWithValue("@id", id);

                    command.ExecuteNonQuery();
                }
            }
        }

        public void EliminarProducto(int id)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = "DELETE FROM productos WHERE id = @id";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            MessageBox.Show("No se encontró ningún producto con el ID proporcionado.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al intentar eliminar el producto: " + ex.Message);
            }
        }
    }
}
