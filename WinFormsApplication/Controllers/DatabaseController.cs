using WinFormsApplication.Models.Entities;

namespace WinFormsApplication.Controllers
{
    static internal class DatabaseController
    {
        static DatabaseContext db = new DatabaseContext();
        /// <summary>
        /// Возвращает пользователя по логину или номер телефона
        /// </summary>
        /// <param name="login">Логин или номер телефона</param>
        static internal User? getUserByLogin(string login)
        {

            var user = db.Users.FirstOrDefault(x => x.Username == login || x.PhoneNumber == login);
            return user;
        }

        static internal List<PetCategory> getAllPetCategories() => db.PetCategories.ToList();
        static internal List<Settlement> getAllSettlements() => db.Settlements.ToList();
    }
}
