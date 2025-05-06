using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PublicationApi.Models;

namespace PublicationApi.Data
{
    public class PublicationApiContext : DbContext
    {
        public PublicationApiContext(DbContextOptions<PublicationApiContext> options)
            : base(options)
        {
        }

        public DbSet<Publication> Publications { get; set; } = default!;
        public DbSet<User> Users { get; set; } = default!;
        public DbSet<Role> Roles { get; set; } = default!;
        public DbSet<Review> Reviews { get; set; } = default!;
        public DbSet<Author> Authors { get; set; }
        public DbSet<PublicationAuthor> PublicationAuthors { get; set; }
    }
    }
