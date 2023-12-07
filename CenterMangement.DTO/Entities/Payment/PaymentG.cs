using CenterMangement.DTO.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Payment
{
    public class PaymentG
    {
        public long Id { get; set; }
        public DateTime? DateAction { get; set; } = DateTime.Now;
        public decimal Payee { get; set; } = 0.00m;
        public long IdAccount { get; set; }

    }
}
