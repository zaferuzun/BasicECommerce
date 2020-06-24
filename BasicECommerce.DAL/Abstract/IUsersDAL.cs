using BasicECommerce.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BasicECommerce.DAL.Abstract
{
    public interface IUsersDAL
    {
        Users Create(Users G_entity);
        List<Users> UserList();
        //Tüm kombinasyonlara göre filtreleme
        //Users tablosundaki tüm varyasyonlara göre
        List<Users> UserList(Expression<Func<Users, bool>> G_predicate);
        Users Detail(int G_id);
        bool Update(Users G_entity);
        bool Delete(int G_id);
        Users Delete(Users G_entity);


    }
}
