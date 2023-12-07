using CenterMangement.Core.Entities;
using CenterMangement.Core.Specifications;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Repository.Specifications
{
    public static class SpecificationEvalutor<TEntity> where TEntity : BaseEntity
    {
        public static IQueryable<TEntity> GetQuery(IQueryable<TEntity> inputQuery, ISpacification<TEntity> spec)
        {
            var query = inputQuery; // _dbContext.products
            if (spec.Criteria is not null)
                query = query.Where(spec.Criteria);
            query = spec.Includes.Aggregate(query, (curentQuery, includeExpression) => curentQuery.Include(includeExpression));
            return query;
        }
    }
}
