using System;
using System.Collections.Generic;
using System.Linq;
using SQ.Core.Data;
using NetApiReact.Data.Service;
using NetApiReact.Data.Models;

namespace NetApiReact.Data.Impl
{
    public class UserService : IUserServices
    {
          #region Fields

        private readonly IRepository<User> _UserRepository;

        #endregion

        #region Ctor

        public UserService(IRepository<User> UserRepository
           )
        {
            this._UserRepository = UserRepository;

        }
        #endregion

        public Models.User FindOne(int Id)
        {
            if (Id == 0)
                return null;

            return _UserRepository.GetById(Id);
        }

        public void Delete(Models.User entity)
        {
            if (entity == null)
                throw new ArgumentNullException("User");

            entity.Status = UserStatus.Deleted;
            Update(entity);
        }

        public SQ.Core.Data.IPagedList<Models.User> GetPageList(int pageIndex, int pageSize)
        {
            var query = _UserRepository.Table;
          
            query = query.OrderByDescending(a => a.Id);

            var result = new PagedList<User>(query, pageIndex, pageSize);

            return result;
        }

        public void Insert(Models.User entity)
        {
            if (entity == null)
                throw new ArgumentNullException("User");
            _UserRepository.Insert(entity);
        }

        public void Update(Models.User entity)
        {
            if (entity == null)
                throw new ArgumentNullException("User");

            _UserRepository.Update(entity);
        }

        public IQueryable<Models.User> GetAll()
        {
            return _UserRepository.Table;
        }
    }
}
