using CenterMangement.DTO.Entities.Account;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Payment
{
    public class PaymentW:PaymentG
    {
        public AccountG AccountNavigation { get; set; }
    }
}
