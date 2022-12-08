using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class AdvertismentsController
    {
        internal Advertisment? createAdvertisment(Advertisment newAdvertisment)
        {
            //todo присосать валидатор
            try
            {
                DatabaseService.createAdvertisment(newAdvertisment);
                return newAdvertisment;
            }
            catch { return null; }
        }

        internal List<Advertisment>? getAllAdvertisments() =>
            DatabaseService.getAllAdvertisments()?.ToList();

        internal bool UpdateAdvertisment(Advertisment advertisment)
        {
            var advert = DatabaseService.getAdvertismentById(advertisment.Id);

            if (advert == null)
                throw new Exception("advert is null");

            try
            {
                advert.PetCategoryId = advertisment.PetCategoryId;
                advert.PetName = advertisment.PetName;
                advert.PetBirthDate = advertisment.PetBirthDate;
                advert.SettlementId = advertisment.SettlementId;
                advert.RegisterDate = advertisment.RegisterDate;
                advert.PetPassportNumber = advertisment.PetPassportNumber;
                advert.BreedName = advertisment.BreedName;
                advert.PetSex = advertisment.PetSex;
                advert.AdditionalInformation = advertisment.AdditionalInformation;

                DatabaseService.UpdateAdvertisment(advertisment);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        internal Advertisment? getAdvertismentById(long Id) =>
            DatabaseService.getAdvertismentById(Id);

        internal bool DeleteAdvertisment(long advertismentId)
        {
            try
            {
                var advert = DatabaseService.getAdvertismentById(advertismentId);

                if (advert == null)
                    throw new Exception("advert was null");

                DatabaseService.DeleteAdvertisment(advert);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }
        }
    }
}
