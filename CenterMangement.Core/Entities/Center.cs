using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Center:BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "";
        [MaxLength(15)]
        public string Phone { get; set; } = "";
        [MaxLength(100)]
        public string Address { get; set; } = "";

        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }

        public ICollection<LectureHell> LectureHellsNavigation { get; set; } = new List<LectureHell>();
        public ICollection<Grade> GradesNavigation { get; set; } = new List<Grade>();


        //updating or Creating Effict
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }

        //user Working in mycenter
        public ICollection<RelUserCenter> RelUsersCentersNavigation { get; set; } = new List<RelUserCenter>();
       
    }
}
