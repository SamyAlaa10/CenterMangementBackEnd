using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.User
{
    public class UserG
    {
        public long Id { get; set; }
        public DateTime? DateAction { get; set; } = DateTime.Now;
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(30)]
        public string JopTittle { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        public string Password { get; set; } = "";
        public string Email { get; set; } = "";
        public long IdAccount { get; set; }
    }
}
