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
    public class AccountConfigrations : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> E)
        {
            E.HasMany(r => r.CentersNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.StudentsNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.SessionsNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.ParentsNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.UsersNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.TeatchersNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.paymentsNavigation).WithOne(r => r.AccountNavigation).HasForeignKey(r => r.IdAccount).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
