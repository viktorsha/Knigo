using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Knigo.Data.Models;

namespace Knigo.Data
{
    public class AppDBContentShakunVA : IdentityDbContext
    {
        public AppDBContentShakunVA(DbContextOptions<AppDBContentShakunVA> options) : base(options)
        {

        }
        public DbSet<BookShakunVA> Book { get; set; }
        public DbSet<Category> Category{ get; set; }
        public DbSet<AuthorShakunVA> Author { get; set; }
        public DbSet<PublisherShakunVA> Publisher { get; set; }
        public DbSet<RankShakunVA> Rank { get; set; }
        public DbSet<StatusShakunVA> Status { get; set; }

    }
}
