using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Session : BaseEntity
    {
        [MaxLength(50)]
        public string Name { get; set; } = "Session";

        public DateTime startSession { set; get; } = DateTime.Now;
        public DateTime? EndSession { set; get; }
        public int countStudent { set; get; } = 0;
        public string? Nots { set; get; }
        public long IdSubject { get; set; }
        public Subject SubjectNavigation { get; set; }

        [DataType(DataType.Currency)]
        public decimal PriceSubject { get; set; } = 0;
        public long IdTeatcher { get; set; }
        public Teatcher TeatcherNavigation { get; set; }
        public float PercentTeatcher { get; set; } = 0;
        public bool Active { get; set; } = true;
        public long IdUser { get; set; }
        public User UserNavigation { get; set; }
        public long IdAccount { get; set; }
        public Account AccountNavigation { get; set; }
        public long IdGrade { get; set; }
        public Grade GradeNavigation { get; set; }
        public long IdLectureHell { get; set; }
        public LectureHell LectureHellNavigation { get; set; }
        public ICollection<RelBookSession> RelBookSessions { get; set; }=new List<RelBookSession>();
        public ICollection<RelSessionVideo> RelSessionVideosNavigation { get; set; } = new List<RelSessionVideo>();
        public ICollection<Log> LogsNavigation { get; set; } = new List<Log>();
    }
}
