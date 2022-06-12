using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;

namespace WarGame.Services.Abstract
{
    public interface IUserServices
    {
        User CreateUser(string username, string name, string surname);
        User BirDefaultUserObjesiOluşturma();

        void GetInformationToUserObject(User user);
        
        void AddWeaphoneToUser(User user , BaseWeaphoneRepository weaphone);

    }
}
