using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Payment : BaseEntity
    {
        public decimal Payee { get; set; } = 0.00m;
        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }

    }
}
