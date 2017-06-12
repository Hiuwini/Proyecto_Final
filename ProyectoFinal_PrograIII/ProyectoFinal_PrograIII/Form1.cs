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

            dataGridView1.DataSource = TiposGastos;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LeerTipoGasto();
        }
    }
}
