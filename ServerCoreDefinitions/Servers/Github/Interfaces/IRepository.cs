using EasyITCenter.GitServer.Models;
using System.Linq.Expressions;

namespace EasyITCenter.GitServer.Interfaces {

    public interface IGitRepository<T> where T : GithubBaseEntity {

        T GetById(int id);

        IEnumerable<T> List();

        IEnumerable<T> List(Expression<Func<T, bool>> predicate);

        void Add(T entity);

        void Delete(T entity);

        void Edit(T entity);
    }
}