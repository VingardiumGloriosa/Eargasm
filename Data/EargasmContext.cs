using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Eargasm.Models;

namespace Eargasm.Data
{
    public class EargasmContext : IdentityDbContext
    {
        public EargasmContext(DbContextOptions<EargasmContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            this.UsersSeed(builder);
            this.SeedPlaylists(builder);
        }

        public DbSet<Playlist> Playlist { get; set; }

        private void UsersSeed(ModelBuilder builder)
        {
            var user1 = new IdentityUser
            {
                Id = "1",
                Email = "chrk@kea.dk",
                EmailConfirmed = true,
                UserName = "chrk@kea.dk",
            };

            var user2 = new IdentityUser
            {
                Id = "2",
                Email = "test@kea.dk",
                EmailConfirmed = true,
                UserName = "test@kea.dk",
            };

            PasswordHasher<IdentityUser> passHash = new PasswordHasher<IdentityUser>();
            user1.PasswordHash = passHash.HashPassword(user1, "aA123456!");
            user2.PasswordHash = passHash.HashPassword(user2, "aA123456!");

            builder.Entity<IdentityUser>().HasData(
                user1, user2
            );
        }
        private void SeedPlaylists(ModelBuilder builder)
        {
            builder.Entity<Playlist>().HasData(
            new Playlist() { Id = 687654, Created = DateTime.Now, Url = "This is playlist 1", Title = "plalylist no 1", UserId = "9bd1471a-b7db-4578-92f9-81fa4346f6d4" },
            new Playlist() { Id = 2, Created = DateTime.Now, Url = "This is playlist 2", Title = "plalylist no 2", UserId = "9bd1471a-b7db-4578-92f9-81fa4346f6d4" }

        );
        }
    }
}