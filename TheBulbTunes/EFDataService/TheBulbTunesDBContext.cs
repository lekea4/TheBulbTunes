using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TheBulbTunes.EFDataService.Entities;

namespace TheBulbTunes.EFDataService
{
    public class TheBulbTunesDBContext : DbContext
    {
        string connectionString;
        //Constructor to set up the connection to the DB 
        public TheBulbTunesDBContext()
        {
            connectionString = "Data Source =.; Initial Catalog = TheBulbTunesDB; Integrated Security = True; Pooling = False";
        }

        //DBSet properties, one for each entities 
        public DbSet<User> Users { get; set; }

        public DbSet<Song> Songs { get; set; }

        public DbSet<Favourite> Favourites { get; set; }


        //onConfiguring method 

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(connectionString);
        }


        public void Configure(EntityTypeBuilder<Favourite> builder)
        {

            //Set ID as primary key for favorite entity
            builder.HasKey(f => f.ID);

            // A favorite must have one song as a SelectedSong
            // Conversely a song can appear multiple times as a favorite
            // 
            builder.HasOne(f => f.SelectedSong)
                   .WithMany(s => s.FavouritesList)
                   .HasForeignKey(f => f.SelectedSongID)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

            // A Favorite must have one User as AddedBy
            // Conversely, a User can have multiple Favorites

            builder.HasOne(f => f.AddedBy)
                   .WithMany(u => u.FavouritesList)
                   .HasForeignKey(f => f.AddedByID)
                   .IsRequired()
                   .OnDelete(DeleteBehavior.NoAction);

        }

        public void Configure (EntityTypeBuilder<User> builder)
        {

            //Set UserID as the primary key for User entity

            builder.HasKey(u => u.UserID);
        }

        public void Configure (EntityTypeBuilder<Song> builder)
        {
            //Set SongID as the primary key for son entity

            builder.HasKey(s => s.SongID);
        }

      

    }
}
