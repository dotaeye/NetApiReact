using System.Linq;
using SQ.Core.Data;
using NetApiReact.Data.Models;


namespace NetApiReact.Data.Service
{
    public interface IUserActivitiesServices
    {
        UserActivities FindOne(int Id);

        void Delete(UserActivities entity);

        IPagedList<UserActivities> GetPageList(int pageIndex, int pageSize);

        void Insert(UserActivities entity);

        void Update(UserActivities entity);

        IQueryable<UserActivities> GetAll();
    }
}
