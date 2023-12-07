using CenterMangement.Core.Entities;
using CenterMangement.Core.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Repository.Specifications
{
    public class PaymentSpecification:BaseSpecification<Payment>
    {
        public PaymentSpecification(long Id) : base(x => x.Id == Id)
        {
            IncludesForIt();
        }
        public PaymentSpecification(Expression<Func<Payment, bool>> expression) : base(expression)
        {
            IncludesForIt();
        }
        public PaymentSpecification()
        {
            IncludesForIt();
        }
        void IncludesForIt()
        {
            Includes.Add(a => a.AccountNavigation);
        }
    }
}
