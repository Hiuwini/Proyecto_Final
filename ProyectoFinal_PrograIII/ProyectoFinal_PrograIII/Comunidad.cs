using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PrograIII
{
    class Comunidad
    {
        int codigo_comunidad;
        string nombre_comunidad;
        string poblacion;

        public int Codigo_comunidad
        {
            get
            {
                return codigo_comunidad;
            }

            set
            {
                codigo_comunidad = value;
            }
        }

        public string Nombre_comunidad
        {
            get
            {
                return nombre_comunidad;
            }

            set
            {
                nombre_comunidad = value;
            }
        }

        public string Poblacion
        {
            get
            {
                return poblacion;
            }

            set
            {
                poblacion = value;
            }
        }
    }
}
