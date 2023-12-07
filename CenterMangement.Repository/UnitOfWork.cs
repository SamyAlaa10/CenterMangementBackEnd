using CenterMangement.Core.Entities;
using CenterMangement.Core.Repostiories;
using CenterMangement.Repository.Data;
using CenterMangement.Repository.Specifications;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Repository
{
    public class UnitOfWork : IUnitOfWork
    {

        private Hashtable _repositories;
        private readonly CenterMangementContext _context;

        public UnitOfWork(CenterMangementContext context)
        {
            _context = context;
        }
        public async Task<int> Complete()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

        public IGenearicRepostiories<TEntity> Repository<TEntity>() where TEntity : BaseEntity
        {
            if (_repositories == null)
                _repositories = new Hashtable();

            var type = typeof(TEntity).Name;

            if (!_repositories.ContainsKey(type))
            {
                var repository = new GenaricRepository<TEntity>(_context);
                _repositories.Add(type, repository);
            }

            return (IGenearicRepostiories<TEntity>)_repositories[type];
        }

        public async ValueTask DisposeAsync()
        {
            await _context.DisposeAsync();
        }
    }
}
