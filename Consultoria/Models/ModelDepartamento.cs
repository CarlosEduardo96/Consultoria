using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria.Models
{
    class ModelDepartamento
    {
        private int folio=0;
        private string nombre;
        private string descripcion;
        private string clave_empresa;
        private string at_date;

        public ModelDepartamento() { }
        public ModelDepartamento(string nombre,string descripcion, string clave_empresa){            
            this.nombre = nombre;
            this.descripcion = descripcion;
            this.clave_empresa = clave_empresa;
            this.at_date = DateTime.Now.ToString();
        }
        public int Folio {
            get => folio;
            set => folio = value;
        }
        public string Nombre{
            get => nombre;
            set => nombre = value;
        }
        public string Descripcion {
            get => descripcion;
            set => descripcion = value;
        }   
        public string Clave_empresa {
            get => clave_empresa;
            set => clave_empresa = value;
        }
        public string At_Date {
            get => at_date;
            set => at_date = value;
        }
    }
}
