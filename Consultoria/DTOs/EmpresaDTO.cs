using Consultoria.ConfAndData;
using Consultoria.Interfaz;
using Consultoria.Models;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria.DTOs
{
    class EmpresaDTO : Config, DTOQuery<ModelEmpresa>
    {
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        public ModelEmpresa Delete(int idModel)
        {
            ModelEmpresa e = Find(idModel);
            DepartamentoDTO dep= new DepartamentoDTO();

            if (e!=null) {
                Conectar();
                string sql = "delete from empresa where id="+idModel;
                command = new SQLiteCommand(sql,con);
                command.ExecuteNonQuery();
                Desconectar();
            }
            return e;
        }

        public ModelEmpresa Find(int idModel)
        {
            ModelEmpresa e = null;
            Conectar();
            string sql = "select * from empresa where id="+idModel;
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    e = new ModelEmpresa();
                    e.Id = int.Parse(reader["id"].ToString());
                    e.Rfc = reader["rfc"].ToString();
                    e.Nombre =reader["nombre"].ToString();
                    e.Direccion =reader["direccion"].ToString();
                    e.At_date =reader["at_date"].ToString();
                }
            }
            Desconectar();
            return e;
            
        }

        public ModelEmpresa Find(string rfc) {
            ModelEmpresa e = null;
            Conectar();
            string sql = string.Format("select * from empresa where rfc='{0}'",
                rfc);

            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {                
                while (reader.Read()) {
                    e = new ModelEmpresa();
                    e.Id = Convert.ToInt32(reader["id"].ToString());
                    e.Rfc = reader["rfc"].ToString();
                    e.Nombre = reader["nombre"].ToString();
                    e.Direccion = reader["direccion"].ToString();
                    e.At_date = reader["at_date"].ToString();
                }
            }
            Desconectar();
            return e;
        }
        public List<ModelEmpresa> FindAll()
        {
            List<ModelEmpresa> lista = null;
            Conectar();
            string sql = "select * from empresa;";
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                lista = new List<ModelEmpresa>();
                while (reader.Read()) {
                    ModelEmpresa e = new ModelEmpresa();
                    e.Id = int.Parse(reader["id"].ToString());
                    e.Rfc = reader["rfc"].ToString();
                    e.Nombre = reader["nombre"].ToString();
                    e.Direccion = reader["direccion"].ToString();
                    e.At_date = reader["at_date"].ToString();
                    lista.Add(e);
                }
            }
            Desconectar();
            return lista;
        }

        public ModelEmpresa Insert(ModelEmpresa type)
        {
            ModelEmpresa e = Find(type.Rfc);
            if (e == null)
            {
                Conectar();
                string sql = string.Format("insert into empresa values(null,'{0}','{1}','{2}','{3}');",
                    type.Rfc, type.Nombre, type.Direccion, type.At_date);
                command = new SQLiteCommand(sql, con);
                type.Id=Convert.ToInt32(command.ExecuteScalar());
                e = type;
                Desconectar();
            }
            else {
                e = null;
            }
            return e;
        }

        public List<ModelEmpresa> Search(string search)
        {
            List<ModelEmpresa> lista = null;
            string sql = string.Format("select * from empresa where rfc like '{0}%'",search);
            Conectar();
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                lista = new List<ModelEmpresa>();
                while (reader.Read()) {
                    ModelEmpresa e = new ModelEmpresa();
                    e.Id = int.Parse(reader["id"].ToString());
                    e.Rfc = reader["rfc"].ToString();
                    e.Nombre = reader["nombre"].ToString();
                    e.Direccion = reader["direccion"].ToString();
                    e.At_date = reader["at_date"].ToString();
                    lista.Add(e);
                }
            }
            Desconectar();
            return lista;
        }

        public ModelEmpresa Update(ModelEmpresa type)
        {
            ModelEmpresa e = Find(type.Rfc);            
            Conectar();
            string sql = string.Format("update empresa set rfc='{0}',nombre='{1}',direccion='{2}', at_date='{3}' where id={4}",
                type.Rfc, type.Nombre, type.Direccion, type.At_date, type.Id);
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            Desconectar();
            return e;
        }
    }
}
