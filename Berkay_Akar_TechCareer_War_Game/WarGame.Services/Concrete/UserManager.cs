using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;
using WarGame.Services.Abstract;

namespace WarGame.Services.Concrete
{
    public class UserManager : IUserServices
    {
        IWeaphoneServices weaphoneServices = new WeaphoneManager();



        public void AddWeaphoneToUser(User user, BaseWeaphoneRepository weaphone)
        {
            user.silahlar.Add(weaphone);
        }
        
        // sürekli olarak sizin UI katmannda User oluşturmamanız için oluşturdugum bir adet fonksiyon yani çok fazla bi işlevi yok
        public User BirDefaultUserObjesiOluşturma()
        {
            string username = "BerkayAkar10";
            string name = "Berkay";
            string surname = "Akar";
            User character = new User(username, name, surname);
            return character;
        }

        public User CreateUser(string username, string name, string surname)
        {
            User user = new User(username, name, surname);
            return user;
        }

        public void GetInformationToUserObject(User user)
        {
            System.Console.WriteLine("Karakter Bilgileri :");
            System.Console.WriteLine("\n\n");
            System.Console.WriteLine("ID : "+user.Id);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("UserName : " + user.Username);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Name : " + user.Name);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Surname : " + user.Surname);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("Health: " + user.Health);
            System.Console.WriteLine("\n");
            System.Console.WriteLine("User Weaphones: ");

            if (user.silahlar != null || user.silahlar.Count != 0)
            {
                System.Console.WriteLine("Oluşturdugunuz oyuncunun silah bilgileri : \n\n\n");
                foreach (var item in user.silahlar)
                {
                    weaphoneServices.GetWeaphoneDetail(item);
                }
            }

            System.Console.WriteLine("Toplamda Bu karaktere Ait "+user.silahlar.Count+" Adet Silah Bulunmuştur");

        }
    }
}
