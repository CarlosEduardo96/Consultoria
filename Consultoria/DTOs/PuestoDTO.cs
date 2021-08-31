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

    class PuestoDTO : Config,DTOQuery<ModelPuesto>
    {
        private SQLiteCommand command;
        private SQLiteDataReader reader;
        public ModelPuesto Delete(int idModel)
        {
            ModelPuesto p = Find(idModel);
            if (p != null) {
                string sql = "delete from puesto where clave_puesto="+idModel;
                Conectar();
                command = new SQLiteCommand(sql,con);
                command.ExecuteNonQuery();
                Desconectar();
            }
            return p;
        }
        public void DeleteCascadeDepartamento(int folioDep) {            
            string sql = "delete from puesto where folio_departamento="+folioDep;
            Conectar();
            command = new SQLiteCommand(sql,con);
            command.ExecuteNonQuery();
            Desconectar();
        }

        public void DeleteCascadeEmpresa(int id_empresa)
        {
            string sql = "delete from puesto where id_empresa=" + id_empresa;
            Conectar();
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            Desconectar();
        }

        public ModelPuesto Find(int idModel)
        {
            ModelPuesto p = null;
            string sql = "select * from puesto where clave_puesto=" + idModel;
            Conectar();
            command = new SQLiteCommand(sql, con);
            reader = command.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    p = new ModelPuesto();
                    p.Clave_Puesto = int.Parse(reader["clave_puesto"].ToString());
                    p.Nombre = reader["nombre"].ToString();
                    p.Descipcion =reader["descripcion"].ToString();
                    p.Id_Empresa = int.Parse(reader["id_empresa"].ToString());
                    p.Folio_Departamento = int.Parse(reader["folio_departamento"].ToString());
                    p.At_Date =reader["at_date"].ToString();
                }
            }
            Desconectar();
            return p;

        }
        public ModelPuesto Find(string folio) {
            ModelPuesto p = null;
            string[] value = folio.Split('-');
            string sql = string.Format("select * from puesto where clave_puesto={0} and id_empresa={1} and folio_departamento={2};",
                value[0], value[1], value[2]);

            Conectar();
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                while (reader.Read()) {
                    p = new ModelPuesto();
                    p.Clave_Puesto = int.Parse(reader["clave_puesto"].ToString());
                    p.Nombre = reader["nombre"].ToString();
                    p.Descipcion =reader["descripcion"].ToString();
                    p.Id_Empresa = int.Parse(reader["id_empresa"].ToString());
                    p.Folio_Departamento = int.Parse(reader["folio_departamento"].ToString());
                    p.At_Date = reader["at_date"].ToString();
                }
            }
            Desconectar();
            return p;
        }
        public List<ModelPuesto> FindAll()
        {
            List<ModelPuesto> lista = null;
            Conectar();
            string sql = "select * from puesto;";
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                lista = new List<ModelPuesto>();
                while (reader.Read()) {
                    ModelPuesto p = new ModelPuesto();
                    p.Clave_Puesto = int.Parse(reader["clave_puesto"].ToString());
                    p.Nombre = reader["nombre"].ToString();
                    p.Descipcion =reader["descripcion"].ToString();
                    p.Id_Empresa = int.Parse(reader["id_empresa"].ToString());
                    p.Folio_Departamento = int.Parse(reader["folio_departamento"].ToString());
                    p.At_Date = reader["at_date"].ToString();
                    lista.Add(p);
                }
            }
            Desconectar();
            return lista;
        }

        public ModelPuesto Insert(ModelPuesto type){
            Conectar();
            string sql = string.Format("insert into puesto values(null,'{0}','{1}',{2},{3},'{4}')",
                type.Nombre,type.Descipcion,type.Id_Empresa,type.Folio_Departamento,type.At_Date);
            command = new SQLiteCommand(sql,con);
            type.Clave_Puesto = Convert.ToInt32(command.ExecuteScalar());
            Desconectar();
            return type;
        }

        public List<ModelPuesto> Search(string search)
        {
            List<ModelPuesto> lista = null;
            string sql = string.Format("select * from puesto where nombre like '{0}%';",search);
            Conectar();
            command = new SQLiteCommand(sql,con);
            reader = command.ExecuteReader();
            if (reader.HasRows) {
                lista = new List<ModelPuesto>();
                while (reader.Read()) {
                    ModelPuesto p = new ModelPuesto();
                    p.Clave_Puesto = int.Parse(reader["clave_puesto"].ToString());
                    p.Nombre = reader["nombre"].ToString();
                    p.Descipcion = reader["descripcion"].ToString();
                    p.Id_Empresa = int.Parse(reader["id_empresa"].ToString());
                    p.Folio_Departamento = int.Parse(reader["folio_departamento"].ToString());
                    p.At_Date = reader["at_date"].ToString();
                    lista.Add(p);
                }                
            }
            Desconectar();
            return lista;
        }

        public ModelPuesto Update(ModelPuesto type)
        {
            Conectar();            
            string sql = string.Format("update puesto set nombre='{0}', descripcion='{1}', id_empresa={2}, folio_departamento={3}, at_date='{4}' where clave_puesto={5}",
                type.Nombre, type.Descipcion, type.Id_Empresa, type.Folio_Departamento, type.At_Date, type.Clave_Puesto);
            command = new SQLiteCommand(sql, con);
            command.ExecuteNonQuery();
            Desconectar();

            return type;
        }
    }
}
