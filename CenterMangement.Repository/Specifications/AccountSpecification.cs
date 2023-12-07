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
    public class AccountSpecification : BaseSpecification<Account>
    {
        public AccountSpecification(long Id) : base(x => x.Id == Id)
        {
            IncludesForIt();
        }
        public AccountSpecification(Expression<Func<Account, bool>> expression):base(expression)
        {
            IncludesForIt();
        }
        public AccountSpecification() {
            IncludesForIt();
        }
        void IncludesForIt()
        {
            Includes.Add(a => a.ParentsNavigation);
            Includes.Add(a => a.UsersNavigation);
            Includes.Add(a => a.SessionsNavigation);
            Includes.Add(a => a.CentersNavigation);
            Includes.Add(a => a.paymentsNavigation);
            Includes.Add(a => a.StudentsNavigation);
            Includes.Add(a => a.TeatchersNavigation);
        }
    }
}
