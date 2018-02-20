using RBG.DAL.Model;

namespace RBG.DAL.Repositories.Infrastructure
{
    public class RgbContext
    {
        private static RBGEntities _instance;

        private RgbContext()
        {
        }

        public static RBGEntities Instance => _instance ?? (_instance = new RBGEntities());
    }
}