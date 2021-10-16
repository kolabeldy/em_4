using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace em.Models.Base
{
    public interface IDBModel
    {
        List<T> Get<T>();
        int Add(object rec);
        int Delete(string where);
        int Update(object rec);
    }
}
