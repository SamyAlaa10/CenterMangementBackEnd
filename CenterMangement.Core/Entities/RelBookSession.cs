using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class RelBookSession:BaseEntity
    {
        public long IdSession { get; set; }
        public Session SessionNavigation { get; set; }
        public long IdBook { get; set; }
        public Book BookNavigation { get; set; }
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
    }
}
