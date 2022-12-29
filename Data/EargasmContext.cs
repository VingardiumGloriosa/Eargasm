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
                new Playlist() { Id = 1, Created = DateTime.Now, Url = "https://open.spotify.com/playlist/1t7Mlal8U3EkGA1KjVtWPg?si=0350ceb077104333x", Title = "Feeling Cozy", UserId = "9bd1471a-b7db-4578-92f9-81fa4346f6d4", imageUrl = "https://i.scdn.co/image/ab67706c0000bebb9e0a4f504a0c39f5452371df" },
            new Playlist() { Id = 3, Created = DateTime.Now, Url = "https://open.spotify.com/playlist/0az16dieCF3dhJZmsCCUSb?si=bc1d022017e54189", Title = "Heavy Leg Day", UserId = "9bd1471a-b7db-4578-92f9-81fa4346f6d4", imageUrl = "https://mosaic.scdn.co/640/ab67616d0000b273b96b08f972a3f1e925a69fedab67616d0000b273bbdafec608fc5329ec2ad831ab67616d0000b273cd8176d1d53fb8c345375866ab67616d0000b273d2de49f423eb924c79a155d2" }
    );
        }
    }
}