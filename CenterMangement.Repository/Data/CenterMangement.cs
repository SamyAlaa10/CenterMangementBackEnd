using CenterMangement.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace CenterMangement.Repository.Data
{
    public class CenterMangementContext : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Permeation> Permeations { get; set; }
        public DbSet<Book> Books { get; set; }
        public DbSet<Center> Centers { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<LectureHell> LectureHells { get; set; }
        public DbSet<Log> Logs { get; set; }
        public DbSet<Parent> Parents { get; set; }
        public DbSet<RelBookSession> RelBooksSessions { get; set; }
        public DbSet<RelPermeationUser> RelPermeationsUsers { get; set; }
        public DbSet<RelSessionVideo> RelSessionsVideos { get; set; }
        public DbSet<RelUserCenter> RelUsersCenters { get; set; }
        public DbSet<Session> Sessions { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Subject> Subjects { get; set; }
        public DbSet<Teatcher> Teatchers { get; set; }
        public CenterMangementContext(DbContextOptions<CenterMangementContext> options) : base(options) { }
        protected override void OnModelCreating(ModelBuilder E)
        {
            base.OnModelCreating(E);
            E.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}
