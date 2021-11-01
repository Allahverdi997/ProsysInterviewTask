using ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ExamProgramCoreLayer.DataAccessLayer.EntityFrameworkCore.Concrete
{
    public class EntityRepository<T> : IEntityRepository<T>
        where T : class, new()
    {
        public ExamProgramDbContext nc { get; set; }
        public EntityRepository(ExamProgramDbContext _context)
        {
            nc = _context;
        }
        public async Task<bool> Add(T entity)
        {
            try
            {
                await nc.Set<T>().AddAsync(entity);
                return true;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return false;
            }

        }

        public async Task<bool> Delete(T entity)
        {
            try
            {
                nc.Set<T>().Remove(entity);
                await nc.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return false;
            }
        }

        public async Task<T> Get(Expression<Func<T, bool>> expression)
        {
            try
            {
                return await nc.Set<T>().FindAsync(expression);
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return null;
            }
        }

        public List<T> GetAll(Expression<Func<T, bool>> expression = null)
        {
            try
            {
                return expression == null ? nc.Set<T>().ToList() : nc.Set<T>().Where(expression).ToList();
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return null;
            }
        }

        public async Task<bool> Update(T entity)
        {
            try
            {
                var modifiedEntity = nc.Entry(entity);
                modifiedEntity.State = EntityState.Modified;
                await nc.SaveChangesAsync();
                return true;
            }
            catch (Exception ex)
            {
                string msj = ex.Message;
                return false;
            }
        }
    }
}
