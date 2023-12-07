using CenterMangement.DTO.Entities.Account;
using CenterMangement.DTO.Entities.User;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Center
{
    public class CenterW:CenterG
    {
        public AccountG AccountNavigation { get; set; }
        public UserG UserNavigation { get; set; }
    }
}
