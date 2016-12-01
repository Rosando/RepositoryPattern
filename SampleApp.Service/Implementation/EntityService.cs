using SampleApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp.Service
{
    public abstract class EntityService<TEntity> : IEntityService<TEntity> where TEntity : class
    {
        IUnitOfWork _unitOfWork;
        IRepository<TEntity> _repository;

        public EntityService(IUnitOfWork unitOfWork, IRepository<TEntity> repository)
        {
            _unitOfWork = unitOfWork;
            _repository = repository;
        }

        public void Create(TEntity entity)
        {
            if(entity == null)
            {
                throw new ArgumentException("entity");
            }
            _repository.Add(entity);
            _unitOfWork.complete();
        }

        public void Delete(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("entity");
            }
            _repository.Delete(entity);
            _unitOfWork.complete();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public void Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentException("entity");
            }
            _repository.Edit(entity);
            _unitOfWork.complete();
        }
    }
}
