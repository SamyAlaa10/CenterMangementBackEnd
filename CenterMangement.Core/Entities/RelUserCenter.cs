using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class RelUserCenter : BaseEntity
    {
        //working in center
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
        public long IdCenter { get; set; }
        public Center CenterNavigation { get; set; }
    }
}
