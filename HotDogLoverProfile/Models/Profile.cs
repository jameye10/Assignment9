using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;

namespace HotDogLoverProfile.Models
{
    public class Profile
    {
        public int ID { get; set; }
        [Required]
        public string FavoriteDog { get; set; }
        [Required]
        public string LastAte { get; set; }
        [Required]
        public string EatenDate { get; set; }
        [Required]
        public string PastDog1 { get; set; }
        [Required]
        public string PastDog2 { get; set; }
        [Required]
        public string PastDog3 { get; set; }
    }
     

    public class ProfileDBContext : DbContext
    {
        public DbSet<Profile> Profiles { get; set; }
    }
}