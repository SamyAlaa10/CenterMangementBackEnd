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
    public class GardeConfigrations : IEntityTypeConfiguration<Grade>
    {
        public void Configure(EntityTypeBuilder<Grade> E)
        {
            E.HasMany(r => r.SubjectsNavigation).WithOne(r => r.GradeNavigation).HasForeignKey(r => r.IdGrade).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.SessionsNavigation).WithOne(r => r.GradeNavigation).HasForeignKey(r => r.IdGrade).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.StudentsNavigation).WithOne(r => r.GradeNavigation).HasForeignKey(r => r.IdGrade).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.BooksNavigation).WithOne(r => r.GradeNavigation).HasForeignKey(r => r.IdGrade).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
