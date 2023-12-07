using CenterMangement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Repository.Data.Config
{
    public class ParentConfigrations : IEntityTypeConfiguration<Parent>
    {
        public void Configure(EntityTypeBuilder<Parent> E)
        {
            E.HasMany(r => r.StudentsNavigation).WithOne(r => r.ParentNavigation).HasForeignKey(r => r.IdParent).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
