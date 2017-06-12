using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal_PrograIII
{
    class Gastos
    {
        string idGastos;
        string descripcion;
        int monto;
        string tipo_gasto;

        public string IdGastos
        {
            get
            {
                return idGastos;
            }

            set
            {
                idGastos = value;
            }
        }

        public string Descripcion
        {
            get
            {
                return descripcion;
            }

            set
            {
                descripcion = value;
            }
        }

        public string Tipo_gasto
        {
            get
            {
                return tipo_gasto;
            }

            set
            {
                tipo_gasto = value;
            }
        }

        public int Monto
        {
            get
            {
                return monto;
            }

            set
            {
                monto = value;
            }
        }
    }
}
