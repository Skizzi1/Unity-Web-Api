using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace unity_webapi.Interfaces
{
    public interface ICrud<T, V> where T : class  
    { 
        void Create(T create);

        void Update(T update);

        void Delete(V id);

        T GetById(V id);

        List<T> Read();


    }
}
