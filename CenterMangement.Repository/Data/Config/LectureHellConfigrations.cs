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
    public class LectureHellConfigrations : IEntityTypeConfiguration<LectureHell>
    {
        public void Configure(EntityTypeBuilder<LectureHell> E)
        {
            E.HasMany(r => r.SessionsNavigation).WithOne(r => r.LectureHellNavigation).HasForeignKey(r => r.IdLectureHell).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
