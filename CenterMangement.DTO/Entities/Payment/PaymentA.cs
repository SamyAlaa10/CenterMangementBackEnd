using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Payment
{
    public class PaymentA
    {
        public decimal Payee { get; set; } = 0.00m;
        public long IdAccount { get; set; }
    }
}
