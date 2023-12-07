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
    public class SessionConfigrations : IEntityTypeConfiguration<Session>
    {
        public void Configure(EntityTypeBuilder<Session> E)
        {
            E.HasMany(r => r.RelBookSessions).WithOne(r => r.SessionNavigation).HasForeignKey(r => r.IdSession).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.RelSessionVideosNavigation).WithOne(r => r.SessionNavigation).HasForeignKey(r => r.IdSession).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.LogsNavigation).WithOne(r => r.SessionNavigation).HasForeignKey(r => r.IdSession).OnDelete(DeleteBehavior.Restrict);

        }
    }
}
