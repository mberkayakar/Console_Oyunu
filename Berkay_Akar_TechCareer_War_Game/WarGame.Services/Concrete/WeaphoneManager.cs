using System.Linq;
using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;
using WarGame.Services.Abstract;

namespace WarGame.Services.Concrete
{
    public class WeaphoneManager : IWeaphoneServices
    {
        public void AddWeaphoneForUser(User user, BaseWeaphoneRepository weaphone)
        {
            user.SilahEkle = weaphone;
        }

        public void DeleteWeaphoneForUser(User user, string name)
        {
            user.Envanterden_Silah_Cikarma(name);
        }

        public void GetWeaphoneDetail(BaseWeaphoneRepository weaphone)
        {
            System.Console.WriteLine("İSİM : " + weaphone.Marka);
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("Model : " + weaphone.Model);
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("Tek Kullanımda Hasar : " + weaphone.DamagePoint);
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("Tekrar Kullanılabilirlik Sayisi : " + weaphone.number_of_usability_per_iteration);
            System.Console.WriteLine("**************************");
            System.Console.WriteLine("Jarjör (seri kullanılabilrlik) sayısı : " + weaphone.number_of_reuses);

        }

        public void SelectDefaultWeaphone(User user, string weaphoneid)
        {
            if (user.silahlar.FirstOrDefault(x => x.Marka == weaphoneid) != null)
            {
                user.silahlar.FirstOrDefault(x => x.Marka == weaphoneid).FirstGun = true;

            }
        }
    }
}
