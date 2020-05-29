using Microsoft.EntityFrameworkCore;

using MovieWebsite.Models;

using System;
using System.Linq;

namespace MovieWebsite.Data.Implementation
{
    public class UserRepository : IRepository<User>
    {
        private readonly DbSet<User> users;
        private readonly MovieContext context;
        public UserRepository(MovieContext context)
        {
            users = context.Users;
            this.context = context;
        }

        public void Add(User entity)
        {
            users.Add(entity);
            context.SaveChanges();
        }

        public void Delete(User entity)
        {
            users.Remove(entity);
            context.SaveChanges();
        }

        public User GetById(int Id)
        {
            return users.Find(Id);
        }
        public User Get(Func<User, bool> func)
        {
            return users.Where(func).FirstOrDefault();
        }
        public void Update(User entity)
        {
            users.Update(entity);
            context.SaveChanges();
        }
    }
}
