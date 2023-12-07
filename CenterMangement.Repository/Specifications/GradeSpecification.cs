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
    public class GradeSpecification : BaseSpecification<Grade>
    {
        public GradeSpecification(long Id) : base(x => x.Id == Id)
        {
            IncludesForIt();
        }
        public GradeSpecification(Expression<Func<Grade, bool>> expression) : base(expression)
        {
            IncludesForIt();
        }
        public GradeSpecification() {
            IncludesForIt();
        }
        void IncludesForIt()
        {
            Includes.Add(a => a.SessionsNavigation);
            Includes.Add(a => a.StudentsNavigation);
            Includes.Add(a => a.SessionsNavigation);
            Includes.Add(a => a.SubjectsNavigation);
            Includes.Add(a => a.BooksNavigation);
            Includes.Add(a => a.CenterNavigation);
            Includes.Add(a => a.AccountNavigation);
            Includes.Add(a => a.UserNavigation);
        }
    }
}
