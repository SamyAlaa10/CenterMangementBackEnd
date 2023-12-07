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
    public class TeatcherConfigrations : IEntityTypeConfiguration<Teatcher>
    {
        public void Configure(EntityTypeBuilder<Teatcher> E)
        {
            E.HasMany(r => r.SessionsNavigation).WithOne(r => r.TeatcherNavigation).HasForeignKey(r => r.IdTeatcher).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
