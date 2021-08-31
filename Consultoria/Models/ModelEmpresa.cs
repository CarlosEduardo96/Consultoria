using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria.Models
{
    class ModelEmpresa
    {
        private int id=0;
        private string rfc;
        private string nombre;
        private string direccion;
        private string at_date;

        public ModelEmpresa() { }
        public ModelEmpresa(string rfc,string nombre, string direccion) {
            this.rfc = rfc;
            this.nombre = nombre;
            this.direccion = direccion;
            this.at_date = DateTime.Now.ToString();
        }
        public int Id { get => id; set => id = value; }
        public string Rfc { get => rfc; set => rfc = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string At_date { get => at_date; set => at_date = value; }
    }
}