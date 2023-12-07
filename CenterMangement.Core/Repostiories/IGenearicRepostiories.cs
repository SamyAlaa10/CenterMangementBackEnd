using CenterMangement.Core.Entities;
using CenterMangement.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Repostiories
{
    public interface IGenearicRepostiories<T> where T : BaseEntity
    {
        Task<IReadOnlyList<T>> GetAllAsynce();
        Task<T> GetByIdAsync(long id);

        Task<IEnumerable<T>> GetAllWithSpecAsynce(ISpacification<T> spec);
        Task<T> GetByIdWithSpecAsync(ISpacification<T> spec);

        Task AddAsync(T entity);
        Task AddRangeAsync(IEnumerable<T> entity);

        void Update(T entity);
        void UpdateRange(IEnumerable<T> entitys);

        void Delete(T entity);
        void DeleteReange(IEnumerable<T> entitys);
    }
}
