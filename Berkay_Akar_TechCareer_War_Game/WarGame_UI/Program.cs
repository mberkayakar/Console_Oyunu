using System;
using WarGame.Another_Library;
using WarGame.Core.Concrete;
using WarGame.Core.Concrete.MapObject;
using WarGame.Core.Concrete.PistolObject;
using WarGame.Core.HelperFolders;
using WarGame.Entities.Concrete;
using WarGame.Services.Abstract;
using WarGame.Services.Concrete;

namespace WarGame_UI
{


    


    public class Program
    {
         




        static void Main(string[] args)
        {
            IUserServices userservice = new UserManager();
            IWeaphoneServices silahservice = new WeaphoneManager();
            IMapService mapservice = new MapManager();
            IDuelService duelservice = new DuelManager();




            #region Giriş Ekranı 
            EffectClass.LoadingScreen();
            #endregion

            #region Yeni Bir Oyuncu Yaratma Süreci : 
            //Console.WriteLine("Oyuna Başlamak için Öncelikle Bir oyuncu Yaratmanız gerekmetkedir. ");
            //Console.WriteLine("\n");
            //Console.WriteLine("Lütfen Bir Kullanıcı Adı Giriniz");
            //string username = Console.ReadLine();
            //Console.WriteLine("Lütfen Ad bilgisi giriniz");
            //string name = Console.ReadLine();
            //Console.WriteLine("Lütfen Soyad bilgisi giriniz");
            //string surname = Console.ReadLine();

            //User character = user.CreateUser(username, name, surname);
            //user.GetInformationToUserObject(character);

            //Console.WriteLine("\n \n ");




            #endregion

            #region Silah Üretim Süreci  : 

            //Rambo_K500 rambo_500 = new Rambo_K500();
            //silah.GetWeaphoneDetail(rambo_500);

            //Altipatlar_A300 altipatlar = new Altipatlar_A300();
            //silah.GetWeaphoneDetail(altipatlar);



            #endregion

            #region Yeni Harita Üretim Süreci 

            //Hayalet_Sehir sehir = new Hayalet_Sehir();
            //mapservice.GetMapİnformation(sehir);

            Vahsi_Bati sehir2 = new Vahsi_Bati();
            mapservice.GetMapİnformation(sehir2);

            #endregion

            #region Oluşturulan Karaktere Silah Ekleme Süreçleri :


            // silahların bir mrneği oluşturuluyor. 


            //try
            //{
            //    Rambo_K500 rambo_500 = new Rambo_K500();
            //    Altipatlar_A300 altipatlar = new Altipatlar_A300();
            //    KST_K100 kst = new KST_K100();

            //    var model = user.BirDefaultUserObjesiOluşturma();
            //    model.SilahEkle = rambo_500;
            //    model.SilahEkle = altipatlar;
            //    model.SilahEkle = rambo_500;
            //    model.SilahEkle = rambo_500;
            //    model.SilahEkle = rambo_500;
            //}
            //catch (Exception ex)
            //{

            //    Console.WriteLine(ex.Message);
            //}







            #endregion

            #region Oyuna Başlama Süreci 

            // bu aşamada artık oluşturulan karakter oyuna başlamaktadır. Ama burada çeşitli kontroller yapılacaktır. 

            // * Bir user in en az bir silahı varmı ?

            // * bir user in envanterinde silah olmasına ragmen bu silahlardan birisi en az seçilimi ?

            // yukarıda beyan edilen çeşitli süreçleri gerçekleştirevilmek için farklı senaryolar üzerinden aşağıdaki süreçler gerçekleştirilmiştir. 


            try
            {
                var user = userservice.BirDefaultUserObjesiOluşturma();
                
                // user a bu aşamada random silahlar aldıryıorum. İstersem başka türlü de silahlar alabilrim. bunu tercih ettim.
                for (int i = 0; i < 3; i++)
                {
                    user.SilahEkle = RandomGunGenerator.GenerateRandomGun();
                }


                var harita = new Hayalet_Sehir();

                mapservice.SavasaBasla(user, harita);
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }


            #endregion


            Console.ReadLine();
        }
    }
}
