using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using OneDotLearnCore.Essential;
using OneDotLearnCore.Logging;

namespace OneDotLearnData
{
    public class LoggingDataRepository<TEntity> where TEntity : LogEntity
    {
        #region Data Members
        internal DbSet<TEntity> dbSet;
        #endregion

        #region Constructors
        public LoggingDataRepository(LoggingDataContext ctx)
        {
            DbCtx = ctx; dbSet = DbCtx.Set<TEntity>();
        }
        #endregion

        #region Properties
        public LoggingDataContext DbCtx { get; set; }
        #endregion

        #region Methods
        public virtual async Task<IEnumerable<TEntity>> GetAsync(
            Expression<Func<TEntity, bool>> filter,
            Func<IQueryable<TEntity>, IOrderedQueryable<TEntity>> orderBy = null,
            string includeProps = "")
        {
            IQueryable<TEntity> query = dbSet;

            try
            {
                if (query != null && await query.AnyAsync())
                {
                    if (filter != null)
                        query = query.Where(filter);

                    if (!string.IsNullOrWhiteSpace(includeProps))
                        foreach (var incProp in
                                includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                            query = query.Include(incProp);

                    if (orderBy != null)
                        return await orderBy(query).ToListAsync();
                    else
                        return await query.ToListAsync();
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<List<TEntity>> GetAllAsync()
        {
            IQueryable<TEntity> query = dbSet;

            try
            {
                //await LoggerDataHelper.Instance.LogDebugAsync($"Into {typeof(TEntity).Name}_GetAllAsync...");

                if (query != null && await query.AnyAsync())
                    return await query.ToListAsync();
                else
                    return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<List<TEntity>> GetPageAsync(int pageIndex, int pageSize)
        {
            IQueryable<TEntity> query = dbSet;

            try
            {
                if (query != null && await query.AnyAsync())
                    return await query.Skip(pageIndex * pageSize).Take(pageSize).ToListAsync();
                else
                    return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<int> GetCountAsync()
        {
            try
            {
                return await dbSet.CountAsync();
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<int> GetCountAsync(Expression<Func<TEntity, bool>> filter)
        {
            try
            {
                IQueryable<TEntity> query = dbSet;

                if (query != null && await query.AnyAsync())
                    query = query.Where(filter);

                return query != null && await query.AnyAsync() ? await query.CountAsync() : 0;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<TEntity> GetFirstAsync(
                        Expression<Func<TEntity, bool>> filter, string includeProps = "")
        {
            IQueryable<TEntity> query = dbSet;
            
            try
            {
                if (query != null && await query.AnyAsync())
                {
                    if (!string.IsNullOrWhiteSpace(includeProps))
                        foreach (var incProp in
                                includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                            query = query.Include(incProp);

                    return await query.FirstOrDefaultAsync(filter);
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<TEntity> GetLastAsync(
                        Expression<Func<TEntity, bool>> filter, string includeProps = "")
        {
            IQueryable<TEntity> query = dbSet;

            try
            {
                if (query != null && await query.AnyAsync())
                {
                    if (!string.IsNullOrWhiteSpace(includeProps))
                        foreach (var incProp in
                                includeProps.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries))
                            query = query.Include(incProp);

                    return await query.LastOrDefaultAsync(filter);
                }
                else
                    return null;
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<TEntity> GetByIdAsync(int id)
        {
            try
            {
                return await dbSet.FindAsync(id);
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task AddAsync(TEntity newEnt)
        {
            try
            {
                await dbSet.AddAsync(newEnt);
                var nRec = await DbCtx.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<OpResult> AddRangeAsync(IEnumerable<TEntity> newEntries)
        {
            try
            {
                await dbSet.AddRangeAsync(newEntries);
                var nRec = await DbCtx.SaveChangesAsync();

                return new OpResult() { IsSuccessful = nRec > 0 };
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<OpResult> UpdateAsync(TEntity modifiedEntity)
        {
            try
            {
                dbSet.Attach(modifiedEntity); DbCtx.Entry(modifiedEntity).State = EntityState.Modified;

                var nRec = await DbCtx.SaveChangesAsync();

                return new OpResult() { IsSuccessful = nRec > 0 };
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<OpResult> DeleteAsync(int id)
        {
            try
            {
                var ent = await dbSet.FindAsync(id);

                return ent != null 
                            ? await DeleteAsync(ent) 
                            : new OpResult() 
                                { 
                                    IsSuccessful = false, 
                                    Error = $"No {ent.GetType().Name} to be deleted!" 
                                };
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }

        public virtual async Task<OpResult> DeleteAsync(TEntity entToDel)
        {
            try
            {
                if (DbCtx.Entry(entToDel).State == EntityState.Detached)
                    dbSet.Attach(entToDel);

                dbSet.Remove(entToDel);

                var nRec = await DbCtx.SaveChangesAsync();

                return new OpResult() { IsSuccessful = nRec > 0 };
            }
            catch (Exception ex)
            {
                await LoggerDataHelper.Instance.LogErrorAsync(ex);
                throw;
            }
        }
        #endregion
    }
}
