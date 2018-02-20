using System.Linq;
using RBG.BLL.Infrastructure;
using RBG.DAL.Model;

namespace RBG.BLL
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

        public void DeleteMaterial(Material material)
        {
            UnitOfWork.MaterialRepository.Delete(material);
        }

        public void DeleteMaterial(int materialId)
        {
            DeleteMaterial(UnitOfWork.MaterialRepository.GetById(materialId));
        }

        public void UpdateMaterial(Material material)
        {
            UnitOfWork.MaterialRepository.Update(material);
        }

        public Material GetMaterialById(int materialId)
        {
            return UnitOfWork.MaterialRepository.GetById(materialId);
        }

        #endregion
    }
}