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
    public class PermationConfigrations : IEntityTypeConfiguration<Permeation>
    {
        public void Configure(EntityTypeBuilder<Permeation> E)
        {
            E.HasMany(r => r.RelPermeationUserNavigation).WithOne(r => r.PermeationNavigation).HasForeignKey(r => r.IdPermeation).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
