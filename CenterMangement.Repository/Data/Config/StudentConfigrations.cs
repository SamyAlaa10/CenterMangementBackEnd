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
    internal class StudentConfigrations : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> E)
        {
            E.HasMany(r => r.LogsNavigation).WithOne(r => r.StudentNavigation).HasForeignKey(r => r.IdStudent).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
