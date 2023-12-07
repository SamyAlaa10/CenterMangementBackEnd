using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Core.Entities
{
    public class Permeation:BaseEntity
    {
        [MaxLength(30)]
        public string Name { get; set; }
        public ICollection<RelPermeationUser> RelPermeationUserNavigation { get; set; } = new List<RelPermeationUser>();
    }
}
