
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore.Abstract
{
    public interface IEntityRepository<T>
        where T : class, new()
    {
        List<T> GetAll(Expression<Func<T, bool>> expression = null);
        Task<T> Get(Expression<Func<T, bool>> expression);
        Task<bool> Add(T entity);
        Task<bool> Update(T entity);
        Task<bool> Delete(T entity);
    }
}
