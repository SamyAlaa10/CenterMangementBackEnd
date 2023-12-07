using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.DTO.Entities.Center
{
    public class CenterG
    {
        public long Id { get; set; }
        public DateTime? DateAction { get; set; } = DateTime.Now;
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        [MaxLength(100)]
        public string Address { get; set; } = "";

        public long IdAccount { get; set; }
        public long IdUser { get; set; }
    }
}
