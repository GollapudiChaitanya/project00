using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace insuranceDA_lib.Repositories
{
    public interface IRepositoryUser<T> where T : class
    {
        bool RegisterUser(T entity);
        bool LoginUser (T entity);
        List<T> GetUserProfile();
    }
}
