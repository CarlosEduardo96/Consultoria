using Consultoria.Interfaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultoria.ConfAndData;
using System.Data.SQLite;
using Consultoria.View.Departamento;
using Consultoria.Models;

namespace Consultoria.DTOs
{
    class DepartamentoDTO : Config, DTOQuery<ModelDepartamento>
    {
        private SQLiteCommand command;
        private SQLiteDataReader reader;

        public ModelDepartamento Delete(int idModel)
        {
            ModelDepartamento d = Find(idModel);
            if (d!=null) { 
                string sql = "delete from departamento where folio="+idModel;
                Conectar();
                command = new SQLiteCommand(sql,con);
                command.ExecuteNonQuery();
                Desconectar();
            }
            return d;
        }

        public void CascadeEmpresa(int idEmpresa,string rfcEmpresa) {
            PuestoDTO p = new PuestoDTO();
            p.DeleteCascadeEmpresa(idEmpresa);
            string sql = string.Format("delete from departamento where clave_empresa='{0}'",rfcEmpresa);
            Conectar();
            command = new SQLiteCommand(sql,con);
            command.ExecuteNonQuery();
            Desconectar();
        }

        public List<ModelDepartamento> FindAll()
        {
            List<ModelDepartamento> lista = null;
            Conectar();
            string sql = "select * from departamento";
            command = new SQLiteCommand(sql, con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                lista = new List<ModelDepartamento>();
                while (reader.Read()) {
                    ModelDepartamento d = new ModelDepartamento();
                    d.Folio = int.Parse(reader["folio"].ToString());
                    d.Nombre = reader["nombre"].ToString();
                    d.Descripcion = reader["descripcion"].ToString();
                    d.Clave_empresa = reader["clave_empresa"].ToString();
                    d.At_Date = reader["at_date"].ToString();
                    lista.Add(d);
                }
            }
            Desconectar();
            return lista;
        }

        public ModelDepartamento Find(int idModel)
        {
            ModelDepartamento d = null;
            string sql = "select * from departamento where folio="+idModel;
            Conectar();
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {                
                while (reader.Read())
                {
                    d = new ModelDepartamento();
                    d.Folio = int.Parse(reader["folio"].ToString());
                    d.Nombre = reader["nombre"].ToString();
                    d.Descripcion = reader["descripcion"].ToString();
                    d.Clave_empresa = reader["clave_empresa"].ToString();
                    d.At_Date = reader["at_date"].ToString();
                }
            }
            Desconectar();
            return d;
        }

        public ModelDepartamento Find(string rfc) {
           
            ModelDepartamento d = null;
            string sql = string.Format("select * from departamento where clave_empresa='{0}'", rfc);
            Conectar();
            command = new SQLiteCommand(sql, con);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    d = new ModelDepartamento();
                    d.Folio = int.Parse(reader["folio"].ToString());
                    d.Nombre = reader["nombre"].ToString();
                    d.Descripcion = reader["descripcion"].ToString();
                    d.Clave_empresa = reader["clave_empresa"].ToString();
                    d.At_Date = reader["at_date"].ToString();
                }
            }
            Desconectar();
            return d;
        }
        public ModelDepartamento Insert(ModelDepartamento type)
        {
            Conectar();
            string sql = string.Format("insert into departamento values(null,'{0}','{1}','{2}','{3}');",
                type.Nombre,type.Descripcion,type.Clave_empresa,type.At_Date);
            command = new SQLiteCommand(sql,con);
            type.Folio = Convert.ToInt32(command.ExecuteScalar());
            Desconectar();
            return type;
        }

        public ModelDepartamento Update(ModelDepartamento type)
        {
            string sql = string.Format("update departamento set nombre='{0}', descripcion='{1}', clave_empresa='{2}', at_date='{3}' where folio={4};",
                type.Nombre,type.Descripcion, type.Clave_empresa,type.At_Date,type.Folio);
            Conectar();
            command = new SQLiteCommand(sql,con);
            command.ExecuteNonQuery();
            Desconectar();
            return type;
        }

        public List<ModelDepartamento> Search(string search)
        {
            List<ModelDepartamento> lista = null;
            string sql = string.Format("select * from departamento where nombre like '{0}%'", search);
            Conectar();
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                lista = new List<ModelDepartamento>();
                while (reader.Read()) {
                    ModelDepartamento d = new ModelDepartamento();
                    d.Folio = int.Parse(reader["folio"].ToString());
                    d.Nombre = reader["nombre"].ToString();
                    d.Descripcion = reader["descripcion"].ToString();
                    d.Clave_empresa = reader["clave_empresa"].ToString();
                    d.At_Date = reader["at_date"].ToString();
                    lista.Add(d);
                }
            }
            Desconectar();
            return lista;
        }
    }
}
