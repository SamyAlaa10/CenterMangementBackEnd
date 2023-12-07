using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class BaseEntity
    {
        public long Id { get; set; }
        public DateTime? DateAction { get; set; } = DateTime.Now;
    }
}
