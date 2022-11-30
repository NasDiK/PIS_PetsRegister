using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Controllers
{
    internal class DatabaseController
    {
        DatabaseContext db;

        internal DatabaseController()
        {
            db = new DatabaseContext();
        }

        /// <summary>
        /// Возвращает пользователя по логину или номер телефона
        /// </summary>
        /// <param name="login">Логин или номер телефона</param>
        internal User? getUserByLogin(string login) => 
            db.Users.FirstOrDefault(x => x.Username == login || x.PhoneNumber == login);

        internal List<PetCategory> getAllPetCategories() => 
            db.PetCategories.ToList();
        internal List<Settlement> getAllSettlements() => 
            db.Settlements.ToList();

        internal Settlement? getSettlementById(long id) => db.Settlements.FirstOrDefault(x => x.Id == id);

        internal PetCategory? getPetCategoryById(long id) => db.PetCategories.FirstOrDefault(x => x.Id == id);
        internal User? RegisterUser(User user)
        {
            db.Users.Add(user); db.SaveChanges();
            return user;
        }

        internal List<Role> getAllRoles() => db.Roles.ToList();

        internal long getRoleIdByName(string roleName) => 
            db.Roles.First((role) => role.Name == roleName).Id;

        internal Advertisment? createAdvertisment(Advertisment newAdvertisment)
        {
            try
            {
                db.Advertisments.Add(newAdvertisment); db.SaveChanges();
                return newAdvertisment;
            }
            catch
            {
                return null;
            }
        }

        internal List<Advertisment>? getAllAdvertisments() => db.Advertisments.ToList();
    }
}
