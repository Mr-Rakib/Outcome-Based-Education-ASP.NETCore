using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OBETools.BLL.Interface
{
    interface ICRUD<T>
    {
        List<T> FindAll(string CurrentUsername);
        T FindById(int id, string CurrentUsername);
        string Save(T user, string CurrentUsername);
        string Update(T user, string CurrentUsername);
        string Delete(int Id, string CurrentUsername);
    }
}
