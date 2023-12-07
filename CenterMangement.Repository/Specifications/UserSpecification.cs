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
    public class UserSpecification : BaseSpecification<User>
    {
        public UserSpecification(long Id):base(x=>x.Id== Id)
        {
            IncludesForIt();
        }
        public UserSpecification(Expression<Func<User, bool>> expression):base(expression)
        {
            IncludesForIt();
        }
        public UserSpecification() {
            IncludesForIt();
        }
        void IncludesForIt()
        {
            Includes.Add(a => a.CenterNavigation);
            Includes.Add(a => a.LectureHellNavigation);
            Includes.Add(a => a.GradesNavigation);
            Includes.Add(a => a.BooksNavigation);
            Includes.Add(a => a.SubjectsNavigation);
            Includes.Add(a => a.TeatchersNavigation);
            Includes.Add(a => a.ParentsNavigation);
            Includes.Add(a => a.StudentsNavigation);
            Includes.Add(a => a.SessionsNavigation);

            Includes.Add(a => a.RelBooksSessionsNavigation);
            Includes.Add(a => a.RelPermeationsUsersNavigation);
            Includes.Add(a => a.RelSessionVideosNavigation);
            Includes.Add(a => a.RelUsersCentersNavigation);

            Includes.Add(u => u.AccountNavigation);
        }
    }
}
