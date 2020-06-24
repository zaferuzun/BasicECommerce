using BasicECommerce.DAL.Abstract;
using BasicECommerce.Interfaces.Users;
using System;
using System.Collections.Generic;
namespace BasicECommerce.BLL.Users
{
    public class UsersManager : IUsersService
    {
        //ilkel yöntem DALdan nesne oluşturup metodlara gidilebilir.
        //tavsiye edilmiyor.
        //EfUsersRepository userRepository = new EfUsersRepository();
        IUsersDAL _userDal;
        public UsersManager(IUsersDAL G_userDal)
        {
            this._userDal = G_userDal;
        }

        public BasicECommerce.Entity.Models.Users Create(BasicECommerce.Entity.Models.Users G_entity)
        {
            return _userDal.Create(G_entity);
        }

        public bool Delete(int G_id)
        {
            return _userDal.Delete(G_id);
        }

        public BasicECommerce.Entity.Models.Users Delete(BasicECommerce.Entity.Models.Users G_entity)
        {
            return _userDal.Delete(G_entity);
        }

        public BasicECommerce.Entity.Models.Users Detail(int G_id)
        {
            return _userDal.Detail(G_id);
        }

        public bool Update(BasicECommerce.Entity.Models.Users G_entity)
        {
            return _userDal.Update(G_entity);
        }

        public List<BasicECommerce.Entity.Models.Users> UserList()
        {
            return _userDal.UserList();
        }

        public List<BasicECommerce.Entity.Models.Users> UserList(System.Linq.Expressions.Expression<Func<BasicECommerce.Entity.Models.Users, bool>> G_predicate)
        {
            return _userDal.UserList(G_predicate);
        }
    }
}
