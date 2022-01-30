using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Actividad_1__Aplicacion
{
    public partial class Form1 : Form
    {
        private int parsedCustomerID;

        public Form1()
        {
            InitializeComponent();
        }

        private void cATEGORIABindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cATEGORIABindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'peliculasDataSet.Pelicula' Puede moverla o quitarla según sea necesario.
            this.peliculaTableAdapter.Fill(this.peliculasDataSet.Pelicula);
            // TODO: esta línea de código carga datos en la tabla 'peliculasDataSet.Datos' Puede moverla o quitarla según sea necesario.
            this.datosTableAdapter.Fill(this.peliculasDataSet.Datos);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.CATEGORIA' Puede moverla o quitarla según sea necesario.
            this.cATEGORIATableAdapter.Fill(this.bibliotecaDataSet.CATEGORIA);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.PeliculasConnectionString))
            {
                // Create a SqlCommand, and identify it as a stored procedure.
                using (SqlCommand sqlCommand = new SqlCommand("dbo.PeliculasAñadir", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Add input parameter for the stored procedure and specify what to use as its value.
                    sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    sqlCommand.Parameters["@id"].Value = iDTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@name"].Value = nameTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@description"].Value = descriptionTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                    sqlCommand.Parameters["@fecha"].Value = fechaDateTimePicker.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@genero", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@genero"].Value = generoTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@director", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@director"].Value = directorTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@rating", SqlDbType.Float));
                    sqlCommand.Parameters["@rating"].Value = ratingTextBox.Text;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();

                        // Customer ID is an IDENTITY value from the database.
                        this.peliculaTableAdapter.Fill(peliculasDataSet.Pelicula);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                this.datosTableAdapter.Fill(this.peliculasDataSet.Datos);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.PeliculasConnectionString))
            {
                // Create a SqlCommand, and identify it as a stored procedure.
                using (SqlCommand sqlCommand = new SqlCommand("dbo.PeliculasEliminar", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Add input parameter for the stored procedure and specify what to use as its value.
                    sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    sqlCommand.Parameters["@id"].Value = iDTextBox.Text;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();

                        // Customer ID is an IDENTITY value from the database.
                        this.peliculaTableAdapter.Fill(peliculasDataSet.Pelicula);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                this.datosTableAdapter.Fill(this.peliculasDataSet.Datos);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(Properties.Settings.Default.PeliculasConnectionString))
            {
                // Create a SqlCommand, and identify it as a stored procedure.
                using (SqlCommand sqlCommand = new SqlCommand("dbo.PeliculasModificar", connection))
                {
                    sqlCommand.CommandType = CommandType.StoredProcedure;

                    // Add input parameter for the stored procedure and specify what to use as its value.
                    sqlCommand.Parameters.Add(new SqlParameter("@id", SqlDbType.Int));
                    sqlCommand.Parameters["@id"].Value = iDTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@name", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@name"].Value = nameTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@description"].Value = descriptionTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@fecha", SqlDbType.Date));
                    sqlCommand.Parameters["@fecha"].Value = fechaDateTimePicker.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@genero", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@genero"].Value = generoTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@director", SqlDbType.NVarChar, 50));
                    sqlCommand.Parameters["@director"].Value = directorTextBox.Text;

                    sqlCommand.Parameters.Add(new SqlParameter("@rating", SqlDbType.Float));
                    sqlCommand.Parameters["@rating"].Value = ratingTextBox.Text;

                    try
                    {
                        connection.Open();

                        // Run the stored procedure.
                        sqlCommand.ExecuteNonQuery();

                        // Customer ID is an IDENTITY value from the database.
                        this.peliculaTableAdapter.Fill(peliculasDataSet.Pelicula);
                    }
                    catch
                    {

                    }
                    finally
                    {
                        connection.Close();
                    }

                }
                this.datosTableAdapter.Fill(this.peliculasDataSet.Datos);
            }
        }
    }
    }

