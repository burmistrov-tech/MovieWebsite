using MovieWebsite.Data;

using System;
using System.ComponentModel.DataAnnotations;

namespace MovieWebsite.Models
{
    public class Film : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Title { get; set; }
        [MaxLength(1024)]
        public string Description { get; set; }        
        public DateTime ReleaseDate { get; set; }
        public string Director { get; set; }
        public User Publisher { get; set; }
        public Poster Poster { get; set; }
    }
}
