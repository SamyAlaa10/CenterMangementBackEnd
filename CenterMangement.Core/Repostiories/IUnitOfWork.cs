using CenterMangement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Repostiories
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IGenearicRepostiories<TEntity> Repository<TEntity>() where TEntity : BaseEntity;

        Task<int> Complete();


    }
}
