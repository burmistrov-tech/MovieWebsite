using Microsoft.EntityFrameworkCore;

using MovieWebsite.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieWebsite.Data.Implementation
{
    public class PosterRepository : IRepository<Poster>
    {
        private readonly DbSet<Poster> posters;
        private readonly MovieContext context;
        public PosterRepository(MovieContext context)
        {
            posters = context.Posters;
            this.context = context;
        }
        public void Add(Poster entity)
        {
            posters.Add(entity);
            context.SaveChanges();
        }

        public void Delete(Poster entity)
        {
            posters.Remove(entity);
            context.SaveChanges();
        }

        public Poster GetById(int Id)
        {
            return posters.Find(Id);
        }

        public void Update(Poster entity)
        {
            posters.Update(entity);
            context.SaveChanges();
        }
    }
}
