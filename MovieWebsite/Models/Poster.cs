using MovieWebsite.Data;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MovieWebsite.Models
{
    public class Poster : IEntity
    {
        [Key]
        public int Id { get; set; }
        [MaxLength(255)]
        public string Name { get; set; }
        public string Path { get; set; }
        public ICollection<Film> Films { get; set; }
    }
}
