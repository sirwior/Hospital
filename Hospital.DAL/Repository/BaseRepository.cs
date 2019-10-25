using Hospital.DAL.EF;
using Hospital.DAL.Entities;
using Hospital.DAL.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository
{
    public class BaseRepository<TEntity> : IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        private readonly HospitalContext _context;

        public BaseRepository(HospitalContext context)
        {
            _context = context;
        }

        public int Add(TEntity entity)
        {
            _context.Set<TEntity>().Add(entity);

            int id = entity.Id;
            _context.SaveChanges();
            return id;
        }

        public List<TEntity> GetAll()
        {
            var list = _context.Set<TEntity>().ToList();
            return list;
        }

        public TEntity GetById(int id)
        {
            var entity = _context.Set<TEntity>().FirstOrDefault(x => x.Id == id);
            _context.SaveChanges();
            return entity;
        }

        public void Remove(int id)
        {
            var entity = GetById(id);
            _context.Set<TEntity>().Remove(entity);
            _context.SaveChanges();
        }
    }
}
