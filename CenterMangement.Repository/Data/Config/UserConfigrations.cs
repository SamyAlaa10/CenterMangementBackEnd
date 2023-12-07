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
    public class UserConfigrations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> E)
        {
            E.HasMany(r => r.RelUsersCentersNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.RelBooksSessionsNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.RelPermeationsUsersNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.RelSessionVideosNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.BooksNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.SessionsNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.StudentsNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.TeatchersNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.GradesNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.CenterNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.LectureHellNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.SubjectsNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.ParentsNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
            E.HasMany(r => r.LogsNavigation).WithOne(r => r.UserNavigation).HasForeignKey(r => r.IdUser).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
