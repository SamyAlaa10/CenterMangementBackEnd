using CenterMangement.Core.Entities;
using CenterMangement.DTO.Entities.Center;
using CenterMangement.DTO.Entities.Payment;
using CenterMangement.DTO.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Account
{
    public class AccountW:AccountG
    {
        public ICollection<PaymentG> paymentsNavigation { get; set; } = new List<PaymentG>();
        public ICollection<UserG> UsersNavigation { get; set; } = new List<UserG>();
        public ICollection<CenterG> CentersNavigation { get; set; } = new List<CenterG>();
    }
}
