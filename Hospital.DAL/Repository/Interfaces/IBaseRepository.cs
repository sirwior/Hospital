using Hospital.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hospital.DAL.Repository.Interfaces
{
    public interface IBaseRepository<TEntity> where TEntity : BaseEntity
    {
        int Add(TEntity entity);
        List<TEntity> GetAll();
        TEntity GetById(int id);
        void Remove(int id);
    }
}
