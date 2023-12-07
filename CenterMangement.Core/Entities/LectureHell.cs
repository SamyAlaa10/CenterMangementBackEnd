using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class LectureHell:BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        public long IdCenter { get; set; }
        public Center CenterNavigation { get; set; }
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }
        public ICollection<Session> SessionsNavigation { get; set; } = new List<Session>();
    }
}
