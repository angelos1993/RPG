using RPG.DAL.Model;

namespace RPG.DAL.Repositories.Infrastructure
{
    public class RgbContext
    {
        private static RPGEntities _instance;

        private RgbContext()
        {
        }

        public static RPGEntities Instance => _instance ?? (_instance = new RPGEntities());
    }
}