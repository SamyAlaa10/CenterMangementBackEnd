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
    public class BookConfigrations : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> E)
        {
            E.HasMany(r => r.RelBookSessions).WithOne(r => r.BookNavigation).HasForeignKey(r => r.IdBook).OnDelete(DeleteBehavior.Restrict);
        }
    }
}
