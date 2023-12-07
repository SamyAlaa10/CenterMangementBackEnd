using CenterMangement.Core.Entities;
using CenterMangement.Core.Repostiories;
using CenterMangement.Core.Specifications;
using CenterMangement.Repository.Data;
using CenterMangement.Repository.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Repository
{
    public class GenaricRepository<T> : IGenearicRepostiories<T> where T : BaseEntity
    {
        private readonly CenterMangementContext _dbContext;
        public GenaricRepository(CenterMangementContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<IReadOnlyList<T>> GetAllAsynce() => await _dbContext.Set<T>().ToListAsync();

        public async Task<IEnumerable<T>> GetAllWithSpecAsynce(ISpacification<T> spec) => await ApplySpecifcation(spec).ToListAsync();

        public async Task<T> GetByIdAsync(long id) => await _dbContext.Set<T>().FindAsync(id);

        public async Task<T> GetByIdWithSpecAsync(ISpacification<T> spec) => await ApplySpecifcation(spec).FirstOrDefaultAsync();

        private IQueryable<T> ApplySpecifcation(ISpacification<T> spec) => SpecificationEvalutor<T>.GetQuery(_dbContext.Set<T>(), spec);

        public async Task AddAsync(T entity) => await _dbContext.Set<T>().AddAsync(entity);

        public void Update(T entity) => _dbContext.Set<T>().Update(entity);
        public void UpdateRange(IEnumerable<T> entitys) => _dbContext.Set<T>().UpdateRange(entitys);

        public void Delete(T entity) => _dbContext.Set<T>().Remove(entity);

        public async Task AddRangeAsync(IEnumerable<T> entitys) => await _dbContext.Set<T>().AddRangeAsync(entitys);

        public void DeleteReange(IEnumerable<T> entitys) => _dbContext.Set<T>().RemoveRange(entitys);
    }
}
