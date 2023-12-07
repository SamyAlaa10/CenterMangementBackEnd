using CenterMangement.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Specifications
{
    public class BaseSpecification<T> : ISpacification<T> where T : BaseEntity
    {
        public Expression<Func<T, bool>> Criteria { get; set; }
        public List<Expression<Func<T, object>>> Includes { get; set; } = new List<Expression<Func<T, object>>>();
        public Expression<Func<T, object>> OrderBy { get; set; }
        public Expression<Func<T, object>> OrderByDescending { get; set; }

        public BaseSpecification(Expression<Func<T, bool>> criteriaExpression)
        {
            Criteria = criteriaExpression;
        }
        public BaseSpecification()
        {
        }

        public void AddOrderBy(Expression<Func<T, object>> _OrderByExpression)
        {
            OrderBy = _OrderByExpression;
        }

        public void AddOrderByDesc(Expression<Func<T, object>> _OrderByDescExpression)
        {
            OrderByDescending = _OrderByDescExpression;
        }
    }
}
