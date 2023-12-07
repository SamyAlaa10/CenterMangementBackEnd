using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Account
{
    public class AccountA
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
    }
}
