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
    public class CenterConfigrations : IEntityTypeConfiguration<Center>
    {
        public void Configure(EntityTypeBuilder<Center> E)
        {
            E.HasMany(r => r.RelUsersCentersNavigation).WithOne(r => r.CenterNavigation).HasForeignKey(r => r.IdCenter).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.LectureHellsNavigation).WithOne(r => r.CenterNavigation).HasForeignKey(r => r.IdCenter).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.GradesNavigation).WithOne(r => r.CenterNavigation).HasForeignKey(r => r.IdCenter).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
