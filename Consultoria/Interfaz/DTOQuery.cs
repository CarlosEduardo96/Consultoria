using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultoria.Interfaz
{
    interface DTOQuery<Model>
    {
        List<Model> FindAll();
        Model Insert(Model type);
        Model Update(Model type);
        Model Delete(int idModel);
        Model Find(int idModel);
        List<Model> Search(string search);
    }
}
