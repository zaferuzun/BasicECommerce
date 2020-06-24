using BasicECommerce.DAL.Abstract;
using BasicECommerce.DAL.Concrete.EntityFramework.Context;
using BasicECommerce.Entity.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Linq.Expressions;

namespace BasicECommerce.DAL.Concrete.EntityFramework.Repository
{
    public class EfUsersRepository : IUsersDAL
    {
        BasicECommerceContext BasicECommerceContext = new BasicECommerceContext();
        public Users Create(Users G_entity)
        {
            //Ekle ve satırı geri döndür
            BasicECommerceContext.Users.Add(G_entity);
            BasicECommerceContext.SaveChanges();
            return G_entity;
        
        }

        public bool Delete(int G_id)
        {
            var P_user = Detail(G_id);
            BasicECommerceContext.Users.Remove(P_user);
            return BasicECommerceContext.SaveChanges() > 0;

        }

        public Users Delete(Users G_entity)
        {
            var P_user = Detail(G_entity.UserId);
            BasicECommerceContext.Users.Remove(P_user);
            BasicECommerceContext.SaveChanges();
            return P_user;
        }
        //public bool Sil(int id)
        //{
        //    //var stk= SiparisTakipContext.Stok.AsNoTracking().Where(x => x.StokID == id).SingleOrDefault();
        //    var stok = Getir(id);
        //    return Sil(stok);
        //}


        //public bool Sil(Stok entity)
        //{
        //    SiparisTakipContext.Stok.Remove(entity);
        //    return SiparisTakipContext.SaveChanges() > 0;
        //}
        public Users Detail(int G_id)
        {
            //SingleOrDefault tek satır döndür yoksa null
            return BasicECommerceContext.Users.Where(x => x.UserId == G_id).SingleOrDefault();
        }

        public bool Update(Users G_entity)
        {
            BasicECommerceContext.Users.AddOrUpdate(G_entity);
            return Convert.ToBoolean(BasicECommerceContext.SaveChanges());
             
        }

        public List<Users> UserList()
        {
            return BasicECommerceContext.Users.ToList();
        }

        public List<Users> UserList(Expression<Func<Users, bool>> G_predicate)
        {
            return BasicECommerceContext.Users.Where(G_predicate).ToList();
        }


    }
}
