using WinFormsApplication.Models.Entities;
using WinFormsApplication.Services.Database;

namespace WinFormsApplication.Controllers
{
    internal class PhotographiesController
    {
        internal bool UploadPhotographies(long advertId, IEnumerable<string>? guidFileNames)
        {
            try
            {
                var photographies = guidFileNames?.Select((filename) =>
                {
                    return new Photography()
                    {
                        AdvertismentId = advertId,
                        Filepath = filename
                    };
                }).ToArray();
                DatabaseService.UploadPhotographies(photographies);
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
                return false;
            }


        }

        internal Photography[]? getPhotographiesFilenames(long? advertID) =>
            DatabaseService.getPhotographiesFilenames(advertID)?.ToArray();

        internal bool DeletePhotography(long photoId)
        {
            try
            {
                var photo = DatabaseService.getPhotographyById(photoId);

                if (photo == null)
                    throw new Exception("photo was null");

                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
