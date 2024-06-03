using Crudexamenfinal.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Crudexamenfinal
{
    public partial class Form1 : Form
    {
        private Registro registro;
        public Form1()
        {
            InitializeComponent();
            registro = new Registro("localhost", "root", "Jhostyn_2");
        }

        private void buttonconexion_Click(object sender, EventArgs e)
        {
            if (registro.ProbarConexion()) 
            {
                MessageBox.Show("Conexion exitosa");
            }
            else
            {
                MessageBox.Show("Error en la conexion");
            }
        }

        private void buttonguardar_Click(object sender, EventArgs e)
        {
            
        }

        private void buttonverbd_Click(object sender, EventArgs e)
        {
            dataGridViewbd.DataSource = registro.LeerProductos();
        }

        private void buscarPorId()
        {
            int idPersonajeABuscar = int.Parse(textBoxid.Text);

            DataTable personajeEncontrado = registro.BuscarPersonajePorId(idPersonajeABuscar);

            if (personajeEncontrado.Rows.Count > 0)
            {
                // El personaje fue encontrado
                string producto = personajeEncontrado.Rows[0]["producto"].ToString();
                string proveedor = personajeEncontrado.Rows[0]["proveedor"].ToString();
                long cantidad = long.Parse(personajeEncontrado.Rows[0]["cantidad"].ToString());
                float precio_uni = float.Parse(personajeEncontrado.Rows[0]["precio_unitario"].ToString()); 
                string comentario = personajeEncontrado.Rows[0]["comentario"].ToString();
                string descripcion = personajeEncontrado.Rows[0]["descripcion"].ToString();
                DateTime fechaingreso = DateTime.Parse(personajeEncontrado.Rows[0]["fecha_ingreso"].ToString());



                textBoxproduct.Text = producto;
                textBoxprovee.Text = proveedor;
                textBoxcomentario.Text = comentario;
                numericUpDowncantidad.Value = cantidad; 
                textBoxpreciouni.Text = precio_uni.ToString(); 
                dateTimePickeringreso.Value = fechaingreso;
                textBoxdescrip.Text = descripcion;
                textBoxcomentario.Text = comentario;

         
            }
            else
            {
                // El personaje no fue encontrado
                Console.WriteLine("No se encontró el producto con ID: " + idPersonajeABuscar);
            }
        }

        private void buttonbuscar_Click(object sender, EventArgs e)
        {
            buscarPorId();
        }

        private void buttonguardar_Click_1(object sender, EventArgs e)
        {
            string producto = textBoxproduct.Text;
            string proveedor = textBoxprovee.Text;
            int cantidad = (int)numericUpDowncantidad.Value;
            string precio_uni = textBoxpreciouni.Text;
            string comentario = textBoxcomentario.Text;
            string descripcion = textBoxdescrip.Text;
            DateTime fechaingreso = dateTimePickeringreso.Value;

            // Convertir precio_uni a float
            float precio_uni_float;
            if (!float.TryParse(precio_uni, out precio_uni_float))
            {
                MessageBox.Show("El valor de precio unitario no es válido.");
                return;
            }

            int respuesta = registro.Crear_pruducto(producto, proveedor, cantidad, precio_uni_float, fechaingreso, descripcion, comentario);
            if (respuesta > 0)
            {
                MessageBox.Show("Producto creado correctamente");
                dataGridViewbd.DataSource = registro.LeerProductos(); 
            }
            else
            {
                MessageBox.Show("Error al crear el producto");
            }
            }

        private void buttonactualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxid.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            if (int.TryParse(textBoxid.Text, out int id))
            {
                string producto = textBoxproduct.Text;
                string proveedor = textBoxprovee.Text;
                int cantidad = (int)numericUpDowncantidad.Value;
                string precio_uni = textBoxpreciouni.Text;
                string comentario = textBoxcomentario.Text;
                string descripcion = textBoxdescrip.Text;
                DateTime fechaingreso = dateTimePickeringreso.Value;
                float precio_uni_float;
                if (!float.TryParse(precio_uni, out precio_uni_float))
                {
                    MessageBox.Show("El valor de precio unitario no es válido.");
                    return;
                }
                registro.ActualizarProducto(id, producto, proveedor, cantidad, precio_uni_float, fechaingreso, descripcion, comentario); // Pasar el id aquí
                MessageBox.Show("Personaje actualizado con éxito.");
                dataGridViewbd.DataSource = registro.LeerProductos();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
            }
        }

        private void buttoneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxid.Text))
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
                return;
            }

            // Intentar convertir el texto del campo textBoxid a un entero
            if (int.TryParse(textBoxid.Text, out int id))
            {
                // Llamar al método para eliminar el personaje
                registro.EliminarProducto(id);
                MessageBox.Show("Personaje eliminado con éxito.");
                // Actualizar la lista de personajes en el DataGridView
                dataGridViewbd.DataSource = registro.LeerProductos();
            }
            else
            {
                MessageBox.Show("Por favor, ingresa un ID válido.");
            }
        }
    }
}
