using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service
{
    public interface IEntityService<TEntity> where TEntity : class
    {
        void Create(TEntity entity);
        void Delete(TEntity entity);
        IEnumerable<TEntity> GetAll();
        void Update(TEntity entity);
    }
}
