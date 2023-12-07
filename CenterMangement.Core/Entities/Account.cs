using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Account : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public bool Active { get; set; } = true;
        public ICollection<Payment> paymentsNavigation { get; set; } = new List<Payment>();
        public ICollection<User> UsersNavigation { get; set; } = new List<User>();
        public ICollection<Center> CentersNavigation { get; set; } = new List<Center>();
        public ICollection<Teatcher> TeatchersNavigation { get; set; } = new List<Teatcher>();
        public ICollection<Parent> ParentsNavigation { get; set; } = new List<Parent>();
        public ICollection<Student> StudentsNavigation { get; set; } = new List<Student>();
        public ICollection<Session> SessionsNavigation { get; set; } = new List<Session>();
    }
}
