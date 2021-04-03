using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;

namespace RPG.BLL
{
    public class SupplierManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddSupplier(Supplier supplier)
        {
            UnitOfWork.SupplierRepository.Add(supplier);
        }

        public Supplier GetSupplierById(int supplierId)
        {
            return UnitOfWork.SupplierRepository.GetById(supplierId);
        }

        public void UpdateSupplier(Supplier supplier)
        {
            UnitOfWork.SupplierRepository.Update(supplier);
        }

        public IQueryable<Supplier> GetAllSuppliers()
        {
            return UnitOfWork.SupplierRepository.GetAll();
        }

        public void DeleteSupplier(int supplierId)
        {
            DeleteSupplier(GetSupplierById(supplierId));
        }

        public void DeleteSupplier(Supplier supplier)
        {
            UnitOfWork.SupplierRepository.Delete(supplier);
        }

        public List<string> GetAllSuppliersNames()
        {
            return GetAllSuppliers().Select(supplier => supplier.Name).ToList();
        }

        public int GetSupplierIdByName(string supplierName)
        {
            return UnitOfWork.SupplierRepository.Get(supplier => supplier.Name == supplierName).FirstOrDefault()?.Id ??
                   0;
        }

        #endregion
    }
}