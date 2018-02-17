using RBG.DAL.Repositories.Infrastructure;

namespace RBG.BLL.Infrastructure
{
    public abstract class BaseManager
    {
        private IUnitOfWork _unitOfWork;
        public IUnitOfWork UnitOfWork => _unitOfWork ?? (_unitOfWork = new UnitOfWork());
    }
}