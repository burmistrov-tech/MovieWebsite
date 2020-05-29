using Microsoft.EntityFrameworkCore;

using MovieWebsite.Models;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Data.Implementation
{
    public class FilmRepository : IRepository<Film>
    {
        private readonly DbSet<Film> films;
        private readonly MovieContext context;
        public FilmRepository(MovieContext context)
        {
            films = context.Films;
            this.context = context;
        }

        public void Add(Film entity)
        {
            films.Add(entity);
            context.SaveChanges();            
        }

        public void Delete(Film entity)
        {
            films.Remove(entity);
            context.SaveChanges();
        }

        public Film GetById(int Id)
        {
            return films.Find(Id);
        }

        public void Update(Film entity)
        {
            films.Update(entity);
            context.SaveChanges();
        }
    }
}
