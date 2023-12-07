using CenterMangement.DTO.Entities.Account;
using CenterMangement.DTO.Entities.Center;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.User
{
    public class UserW:UserG
    {
        public AccountG AccountNavigation { get; set; }
        public ICollection<CenterG> CenterNavigation { get; set; } = new List<CenterG>();
    }
}
