using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using SC.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;

namespace SC.Repository
{
    public class Repository<T> : IRepository<T> where T : AuditDetail
    {
        private readonly ApplicationContext context;
        private DbSet<T> entities;
        string errorMessage = string.Empty;
        private readonly IHttpContextAccessor _contextAccessor;
        public Repository(ApplicationContext context,IHttpContextAccessor httpContextAccessor)
        {
            this.context = context;
            entities = context.Set<T>();
            _contextAccessor = httpContextAccessor;
        }
        public IQueryable<T> GetAll()
        {
            return entities.AsQueryable().Where(x=>x.Status>0).OrderByDescending(x => x.Id);
        }

        public T Get(long id)
        {
            return entities.Find(id);
        }
        public IQueryable<T> GetQueryable()
        {
            return entities.AsQueryable().Where(x => x.Status > 0).OrderByDescending(x => x.Id);
        }
        public IQueryable<T> GetQueryable(long id)
        {
            return entities.Where(x=>x.Id==id).OrderByDescending(x => x.Id).AsQueryable();
        }
        public T Insert(T entity)
        {
            IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());
            var ip = heserver.AddressList[1].ToString();            
            long UserId = 1;
            if (_contextAccessor.HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(_contextAccessor.HttpContext.Session.GetString("UserId"));
            }
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entity.ModifiedUserId = UserId;
            entity.IpAddress = ip;
            entity.CreatedUserId = entity.CreatedUserId>0? entity.CreatedUserId : UserId;
            entities.Add(entity);
            SaveChange();
            return entity;
        }

        public void Update(T entity)
        {
            IPHostEntry heserver = Dns.GetHostEntry(Dns.GetHostName());
            var ip = heserver.AddressList[1].ToString();
            long UserId = 1;
            if (_contextAccessor.HttpContext.Session.GetString("UserId") != null)
            {
                UserId = int.Parse(_contextAccessor.HttpContext.Session.GetString("UserId"));
            }
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }           
            entity.ModifiedUserId = UserId;
            entity.IpAddress = ip;
            entity.ModifiedDate = DateTime.Now;            
            context.Entry(entity).State = EntityState.Modified;
            context.Entry(entity).Property(nameof(entity.CreatedUserId)).IsModified = false;
            context.Entry(entity).Property(nameof(entity.CreatedDate)).IsModified = false;
            SaveChange();
        }

        public void Delete(T entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            entities.Remove(entity);
            SaveChange();
        }
        private void SaveChange()
        {
            context.SaveChanges();
        }
    }
}
