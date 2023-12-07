using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Log : BaseEntity
    {
        public long IdSession { get; set; }
        public Session SessionNavigation { get; set; }
        public long IdStudent { get; set; }
        public Student StudentNavigation { get; set; }
        [DataType(DataType.Currency)]
        public decimal PayeeBook { get; set; } = 0;
        [DataType(DataType.Currency)]
        public decimal Payee { get; set; } = 0;
        public DateTime DateBook { set; get; } = DateTime.Now;
        public DateTime DateCome { set; get; } = DateTime.Now;
        public float GradeValue { get; set; } = 0;
        public bool BuyBook { set; get; } = true;
        public bool Active { get; set; } = true;
        public long? IdUser { get; set; }
        public User? UserNavigation { get; set; }
    }
}
