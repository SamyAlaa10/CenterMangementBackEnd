using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Book : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [DataType(DataType.Currency)]
        public decimal PriceDefault { get; set; } = 0;
        public string? filePath { get; set; }


        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
        public long IdGrade { get; set; }
        public Grade GradeNavigation { get; set; }

        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }
        public ICollection<RelBookSession> RelBookSessions { get; set; } = new List<RelBookSession>();
    }
}
