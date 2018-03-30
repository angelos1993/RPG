using RPG.DAL.Model;

namespace RPG.DAL.Repositories.Infrastructure
{
    public class RpgContext
    {
        private static RPGEntities _instance;

        private RpgContext()
        {
        }

        public static RPGEntities Instance => _instance ?? (_instance = new RPGEntities());
    }
}