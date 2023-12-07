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
    public class CenterSpecification :BaseSpecification<Center>
    {
        public CenterSpecification(long Id) : base(x => x.Id == Id)
        {
            IncludesForIt();
        }
        public CenterSpecification(Expression<Func<Center, bool>> expression) : base(expression)
        {
            IncludesForIt();
        }
        public CenterSpecification()
        {
            IncludesForIt();
        }
        void IncludesForIt()
        {
            Includes.Add(a => a.AccountNavigation);
            Includes.Add(a => a.UserNavigation);
            Includes.Add(a => a.LectureHellsNavigation);
            Includes.Add(a => a.RelUsersCentersNavigation);
            Includes.Add(a => a.GradesNavigation);
        }
    }
}
