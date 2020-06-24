using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BasicECommerce.Interfaces
{
    public interface IGenericService<T>
    {
        T Create(T G_entity);
        List<T> UserList();
        //Tüm kombinasyonlara göre filtreleme
        //T tablosundaki tüm varyasyonlara göre
        List<T> UserList(Expression<Func<T, bool>> G_predicate);
        T Detail(int G_id);
        bool Update(T G_entity);
        bool Delete(int G_id);
        T Delete(T G_entity);
    }
}
