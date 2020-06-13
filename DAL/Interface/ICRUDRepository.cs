using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.DAL.Interface
{
    interface ICRUDRepository<T>
    {
        List<T> FindAll();
        bool Save(T Items);
        bool Update(T Items);
        bool Delete(int Id);
    }
}
