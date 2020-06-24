using BasicECommerce.Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace BasicECommerce.DAL.Abstract
{
    public interface IUsersDAL
    {
        Users Create(Users entity);
        List<Users> UserList();
        //Tüm kombinasyonlara göre filtreleme
        //Users tablosundaki tüm varyasyonlara göre
        List<Users> UserList(Expression<Func<Users, bool>> predicate);
        Users Detail(int id);
        bool Update(Users entity);
        bool Delete(int id);
        Users Delete(Users entity);


    }
}
