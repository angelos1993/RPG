using System.Collections.Generic;
using System.Linq;
using RPG.BLL.Infrastructure;
using RPG.DAL.Model;
using RPG.DAL.VMs;

namespace RPG.BLL
{
    public class MaterialManager : BaseManager
    {
        #region Properties

        #endregion

        #region Methods

        public void AddMaterial(Material material)
        {
            UnitOfWork.MaterialRepository.Add(material);
        }

        public bool IsMaterialCodeExists(string materialCode)
        {
            return UnitOfWork.MaterialRepository.Get(material => material.Code == materialCode).Any();
        }

        public bool IsMaterialNameExists(string materialName)
        {
            return UnitOfWork.MaterialRepository.Get(material => material.Name == materialName).Any();
        }

        public IQueryable<Material> GetAllMaterials()
        {
            return UnitOfWork.MaterialRepository.GetAll();
        }

        public IQueryable<Material> GetAllUnArchivedMaterials()
        {
            return GetAllMaterials().Where(material => !material.IsArchived);
        }

        public void UpdateMaterial(Material material)
        {
            UnitOfWork.MaterialRepository.Update(material);
        }

        public Material GetMaterialById(int materialId)
        {
            return UnitOfWork.MaterialRepository.GetById(materialId);
        }

        public void UpdateQuantitiesAfterCreatingInvoice(List<InvoiceItemVm> invoiceItemVms)
        {
            foreach (var invoiceItemVm in invoiceItemVms)
            {
                var material = GetMaterialById(invoiceItemVm.MaterialId);
                material.Quantity -= invoiceItemVm.Quantity;
                UpdateMaterial(material);
            }
        }

        #endregion
    }
}