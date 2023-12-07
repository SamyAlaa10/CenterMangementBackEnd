using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class User : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(30)]
        public string JopTittle { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }
        public ICollection<RelPermeationUser> RelPermeationsUsersNavigation { get; set; } = new List<RelPermeationUser>();

        //user Adding Centers or updateing
        public ICollection<Center> CenterNavigation { get; set; } = new List<Center>();
        public ICollection<LectureHell> LectureHellNavigation { get; set; } = new List<LectureHell>();
        public ICollection<Grade> GradesNavigation { get; set; } = new List<Grade>();
        public ICollection<Book> BooksNavigation { get; set; } = new List<Book>();
        public ICollection<Subject> SubjectsNavigation { get; set; } = new List<Subject>();
        public ICollection<Teatcher> TeatchersNavigation { get; set; } = new List<Teatcher>();
        public ICollection<Parent> ParentsNavigation { get; set; } = new List<Parent>();
        public ICollection<Student> StudentsNavigation { get; set; } = new List<Student>();
        public ICollection<Session> SessionsNavigation { get; set; } = new List<Session>();
        public ICollection<Log> LogsNavigation { get; set; } = new List<Log>();
        public ICollection<RelBookSession> RelBooksSessionsNavigation { get; set; } = new List<RelBookSession>();
        public ICollection<RelSessionVideo> RelSessionVideosNavigation { get; set; } = new List<RelSessionVideo>();
        //Working in center
        public ICollection<RelUserCenter> RelUsersCentersNavigation { get; set; } = new List<RelUserCenter>();
        
    }
}
