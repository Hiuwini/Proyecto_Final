using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ProyectoFinal_PrograIII
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Comunidad> Comunidades = new List<Comunidad>();
        List<TipoGasto> TiposGastos = new List<TipoGasto>();
        List<Propiedades> Propiedad = new List<Propiedades>();
        List<Propietarios> Propietario = new List<Propietarios>();
        List<Gastos> Gasto = new List<Gastos>();

        int cont_propiedad = 0;
        int cont_propietario = 0;
        string contenido;
        int total_gastos = 0;
        void LeerComunidad()
        {
            string fileName = @"C:\Users\Hiuwini\Source\Repos\Proyecto_Final\ProyectoFinal_PrograIII\ProyectoFinal_PrograIII\obj\Comunidades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Comunidad temp = new Comunidad();
                temp.Codigo_comunidad = Convert.ToInt32(reader.ReadLine());
                temp.Nombre_comunidad = reader.ReadLine();
                temp.Poblacion = reader.ReadLine();
                Comunidades.Add(temp);
            }

            reader.Close();

           // dataGridView1.DataSource = Comunidades;
        }

        void LeerTipoGasto()
        {
            string fileName = @"C:\Users\Hiuwini\Source\Repos\Proyecto_Final\ProyectoFinal_PrograIII\ProyectoFinal_PrograIII\obj\TipoGastos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                TipoGasto temp = new TipoGasto();
                temp.Codigo_gasto = reader.ReadLine();
                temp.Nombre_gasto = reader.ReadLine();
                temp.Tipo_gasto = reader.ReadLine();
                
                TiposGastos.Add(temp);
            }

            reader.Close();

            //dataGridView1.DataSource = TiposGastos;
            
        }

        void LeerPropiedades()
        {
            string fileName = @"C:\Users\Hiuwini\Source\Repos\Proyecto_Final\ProyectoFinal_PrograIII\ProyectoFinal_PrograIII\obj\Propiedades.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Propiedades temp = new Propiedades();
                temp.Tipo_propiedad = reader.ReadLine();
                temp.Codigo_propiedad = reader.ReadLine();
                temp.Metros_propiedad = Convert.ToInt32(reader.ReadLine());
                temp.Codigo_comunidad = Convert.ToInt32(reader.ReadLine());
                temp.Nit_propietario = reader.ReadLine();
                temp.Porcentaje_gasto = reader.ReadLine();
                temp.Infoespe1 = reader.ReadLine();
                temp.Infoespe2 = reader.ReadLine();
                Propiedad.Add(temp);
            }

            reader.Close();

           // dataGridView1.DataSource = Propiedad;

        }

        void LeerPropietarios()
        {
            string fileName = @"C:\Users\Hiuwini\Source\Repos\Proyecto_Final\ProyectoFinal_PrograIII\ProyectoFinal_PrograIII\obj\Propietarios.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Propietarios temp = new Propietarios();
                temp.Nombre_propietario = reader.ReadLine();
                temp.Nit_propietario = reader.ReadLine();
                temp.Email_propietario= reader.ReadLine();
                Propietario.Add(temp);
            }

            reader.Close();
            //dataGridView1.DataSource = Propietario;
        }

        void LeerGastos()
        {
            string fileName = @"C:\Users\Hiuwini\Source\Repos\Proyecto_Final\ProyectoFinal_PrograIII\ProyectoFinal_PrograIII\obj\Gastos.txt";
            FileStream stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);
            while (reader.Peek() > -1)
            {
                Gastos temp = new Gastos();
                temp.IdGastos = reader.ReadLine();
                temp.Descripcion = reader.ReadLine();
                temp.Monto = Convert.ToInt32(reader.ReadLine());
                temp.Tipo_gasto = reader.ReadLine();
                Gasto.Add(temp);
            }

            reader.Close();

           // dataGridView1.DataSource = Gasto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            LeerComunidad();
            LeerTipoGasto();
            LeerPropiedades();
            LeerPropietarios();
            LeerGastos();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBox1.Text == "Las Flores") {
                cont_propiedad = 0;
                cont_propietario = 0;
                contenido = "";
                total_gastos = 0;
                foreach (Propiedades x in Propiedad)
                {
                    if (x.Codigo_comunidad == 1) {
                        cont_propiedad++;
                        cont_propietario++;
                        contenido = x.Porcentaje_gasto;
                    }
                    string[] arreglo = contenido.Split('-');

                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if ("E" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "E")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("G" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                      contenido = "";
                    }
                }

                label1.Text = "COMUNIDAD: LAS FLORES";
                label2.Text = "PROPIEDADES: " + cont_propiedad;
                label3.Text = "PROPIETARIOS: " + cont_propietario;
                label4.Text = "TOTAL GASTOS: "+total_gastos;
            }

            if (comboBox1.Text == "Colonia del Maestro")
            {
                cont_propiedad = 0;
                cont_propietario = 0;
                contenido = "";
                total_gastos = 0;

                foreach (Propiedades x in Propiedad)
                {
                    if (x.Codigo_comunidad == 2)
                    {
                        cont_propiedad++;
                        cont_propietario++;
                        contenido = x.Porcentaje_gasto;
                    }
                    string[] arreglo = contenido.Split('-');

                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if ("E" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "E")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("G" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("C" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        contenido = "";
                    }
                }

                label1.Text = "COMUNIDAD: Colonia del Maestro";
                label2.Text = "PROPIEDADES: " + cont_propiedad;
                label3.Text = "PROPIETARIOS: " + cont_propietario;
                label4.Text = "TOTAL GASTOS: " + total_gastos;
            }

            if (comboBox1.Text == "Los Montes Altos")
            {
                cont_propiedad = 0;
                cont_propietario = 0;
                contenido = "";
                total_gastos = 0;

                foreach (Propiedades x in Propiedad)
                {
                    if (x.Codigo_comunidad == 3)
                    {
                        cont_propiedad++;
                        cont_propietario++;
                        contenido = x.Porcentaje_gasto;
                    }
                    string[] arreglo = contenido.Split('-');

                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if ("E" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "E")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("G" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("C" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        contenido = "";
                    }
                }

                label1.Text = "COMUNIDAD: Los Montes Altos";
                label2.Text = "PROPIEDADES: " + cont_propiedad;
                label3.Text = "PROPIETARIOS: " + cont_propietario;
                label4.Text = "TOTAL GASTOS: " + total_gastos;
            }


            if (comboBox1.Text == "La Floresta")
            {
                cont_propiedad = 0;
                cont_propietario = 0;
                contenido = "";
                total_gastos = 0;

                foreach (Propiedades x in Propiedad)
                {
                    if (x.Codigo_comunidad == 4)
                    {
                        cont_propiedad++;
                        cont_propietario++;
                        contenido = x.Porcentaje_gasto;
                    }
                    string[] arreglo = contenido.Split('-');

                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if ("E" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "E")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("G" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("C" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        contenido = "";
                    }
                }

                label1.Text = "COMUNIDAD: La Floresta";
                label2.Text = "PROPIEDADES: " + cont_propiedad;
                label3.Text = "PROPIETARIOS: " + cont_propietario;
                label4.Text = "TOTAL GASTOS: " + total_gastos;
            }
            if (comboBox1.Text == "Las Lomas")
            {
                cont_propiedad = 0;
                cont_propietario = 0;
                contenido = "";
                total_gastos = 0;

                foreach (Propiedades x in Propiedad)
                {
                    if (x.Codigo_comunidad == 5)
                    {
                        cont_propiedad++;
                        cont_propietario++;
                        contenido = x.Porcentaje_gasto;
                    }
                    string[] arreglo = contenido.Split('-');

                    for (int i = 0; i < arreglo.Length; i++)
                    {
                        if ("E" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "E")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("G" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        if ("C" == arreglo[i])
                        {
                            foreach (Gastos n in Gasto)
                            {
                                if (n.Tipo_gasto == "G")
                                    total_gastos = total_gastos + n.Monto;
                            }
                        }
                        contenido = "";
                    }
                }

                label1.Text = "COMUNIDAD: Las Lomas";
                label2.Text = "PROPIEDADES: " + cont_propiedad;
                label3.Text = "PROPIETARIOS: " + cont_propietario;
                label4.Text = "TOTAL GASTOS: " + total_gastos;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataGridViewTextBoxColumn columna1 = new DataGridViewTextBoxColumn();
            columna1.HeaderText = "Codigo";
            columna1.Width = 60;
            columna1.ReadOnly = true;

            DataGridViewTextBoxColumn columna2 = new DataGridViewTextBoxColumn();
            columna2.HeaderText = "Mts.2";
            columna2.Width = 60;
            columna2.ReadOnly = true;

            DataGridViewTextBoxColumn columna3 = new DataGridViewTextBoxColumn();
            columna3.HeaderText = "Nombre Propietario";
            columna3.Width = 120;
            columna3.ReadOnly = true;

            DataGridViewTextBoxColumn columna4 = new DataGridViewTextBoxColumn();
            columna4.HeaderText = "Cuotas";
            columna4.Width = 75;
            columna4.ReadOnly = true;

            DataGridViewTextBoxColumn columna5 = new DataGridViewTextBoxColumn();
            columna5.HeaderText = "Info. Adicional";
            columna5.Width = 250;
            columna5.ReadOnly = true;

            dataGridView1.Columns.Add(columna1);
            dataGridView1.Columns.Add(columna2);
            dataGridView1.Columns.Add(columna3);
            dataGridView1.Columns.Add(columna4);
            dataGridView1.Columns.Add(columna5);

            foreach (Propiedades x in Propiedad)
            {
                foreach (Propietarios i in Propietario)
                {
                    if (x.Nit_propietario == i.Nit_propietario)
                    {
                        if (x.Infoespe1 == "VH") x.Infoespe1 = "Vivienda Habitada";
                        if (x.Infoespe1 == "VN") x.Infoespe1 = "Vivienda No Habitada";
                        if (x.Infoespe1 == "A") x.Infoespe1 = "Garaje Abierto";
                        if (x.Infoespe2 == "N") x.Infoespe2 = "No Bodega";
                        if (x.Infoespe1 == "C") x.Infoespe1 = "Garaje Cerrado";
                        if (x.Infoespe2 == "S") x.Infoespe2 = "Si Bodega";
                        dataGridView1.Rows.Add(x.Codigo_propiedad, x.Metros_propiedad.ToString(),
                    i.Nombre_propietario, x.Porcentaje_gasto, x.Infoespe1 +"  "+ x.Infoespe2);
                    }
                }
                
            }

        }
    }
}
