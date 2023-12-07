using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Parent : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        [MaxLength(100)]
        public string Address { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }
        public ICollection<Student> StudentsNavigation { get; set; } = new List<Student>();
    }
}
