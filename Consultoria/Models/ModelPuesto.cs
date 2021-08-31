using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria.Models
{
    class ModelPuesto
    {
        private int clave_puesto = 0;
        private string nombre;
        private string descripcion;
        private int id_empresa;
        private int folio_departamento;
        private string at_date;

        public ModelPuesto() { }
        public ModelPuesto(string nombre, string descripcion, int id_empresa, int folio_departamento) {
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.id_empresa = id_empresa;
            this.folio_departamento = folio_departamento;
            this.at_date = DateTime.Now.ToString();
        }
        public int Clave_Puesto {
            get => clave_puesto;
            set => clave_puesto=value;
        }
        public string Nombre {
            get => nombre;
            set => nombre = value;
        }

        public string Descipcion {
            get => descripcion;
            set => descripcion = value;
        }

        public int Id_Empresa {
            get => id_empresa;
            set => id_empresa = value;
        }
        public int Folio_Departamento{
            get => folio_departamento;
            set => folio_departamento = value;
        }

        public string At_Date {
            get => at_date;
            set => at_date = value;
        }
    }
}
