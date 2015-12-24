using System.Linq;
using SQ.Core.Data;
using NetApiReact.Data.Models;


namespace NetApiReact.Data.Service
{
    public interface IUserServices
    {
        User FindOne(int Id);

        void Delete(User entity);

        IPagedList<User> GetPageList(int pageIndex, int pageSize);

        void Insert(User entity);

        void Update(User entity);

        IQueryable<User> GetAll();
    }
}
