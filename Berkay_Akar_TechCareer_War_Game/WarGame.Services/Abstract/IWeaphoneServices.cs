using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;

namespace WarGame.Services.Abstract
{
    public interface IWeaphoneServices
    {
        void AddWeaphoneForUser(User user , BaseWeaphoneRepository weaphone);
        void DeleteWeaphoneForUser(User user, string name);
        void GetWeaphoneDetail(BaseWeaphoneRepository weaphone);
        void SelectDefaultWeaphone(User user, string Name);


    }
}
