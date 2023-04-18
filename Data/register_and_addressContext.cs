using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Register_with_address.Models;

namespace Register_with_address.Data
{
    public partial class register_and_addressContext : DbContext
    {
        public register_and_addressContext()
        {
        }

        public register_and_addressContext(DbContextOptions<register_and_addressContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb4_0900_ai_ci")
                .HasCharSet("utf8mb4");

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);

        DbSet<Pessoa> Pessoas { get; set; } = default!;
        DbSet<Endereço> Endereço { get; set; } = default!;
    }
}
