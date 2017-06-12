﻿using System;
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
    }
}
