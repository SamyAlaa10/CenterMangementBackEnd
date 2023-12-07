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
    public class SubjectConfigrations : IEntityTypeConfiguration<Subject>
    {
        public void Configure(EntityTypeBuilder<Subject> E)
        {
            E.HasMany(r => r.SessionsNavigation).WithOne(r => r.SubjectNavigation).HasForeignKey(r => r.IdSubject).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
