using System;
using System.Linq;
using System.Threading;
using WarGame.Another_Library;
using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;
using WarGame.Services.Abstract;

namespace WarGame.Services.Concrete
{
    public class DuelManager : IDuelService
    {
        IUserServices _userServices = new UserManager();


        public void StartDuello(MapRepository map)
        {



            Console.Clear();
            Console.WriteLine("Düello Başlıyoorrrrr .....");
            EffectClass.LoadingScreen();
            Console.Clear();


            User player = map.player;
            Enemies dusman = map.Enemies.FirstOrDefault();

            while (true)
            {
                if (player.Health >= 0)
                {
                    // ilk olarak oyuncunun varsayılan silahının mermisi kontrol ediliyor. Her atış sırasında tekrar kullanılabilrlik azalacağından ötürü sıradaki silahı varsayılan silah olarak seçtirtmemiz gerekmektedir. 
                    if (!(player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_reuses / player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_usability_per_iteration > 0))
                    {
                        Console.WriteLine("Oyuncumuzun silahının mermisi bitiyor ve başka bir silaha geçiyor");
                        Thread.Sleep(2300);

                        player.Envanterden_Silah_Cikarma(player.silahlar.FirstOrDefault(x => x.FirstGun == true).Marka);
                        if (player.silahlar.Count==0)
                        {
                            Console.WriteLine("Oyuncumuzun Kullanilabilir Bir Silahı Kalmamakta Ve oyunu kaybetmekyedir.");
                            break;
                        }
                        player.silahlar.FirstOrDefault().FirstGun = true; // silah yukarıda atıldı ve sıradaki silah varsayılan silah olarak seçildi.

                        var bilgi = player.silahlar.FirstOrDefault(x => x.FirstGun == true);
                        Console.WriteLine("Geçilen Silah : "+bilgi.Marka+"  "+bilgi.Model);
                        Thread.Sleep(2300);

                    }


                    if (player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_reuses / player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_usability_per_iteration > 0)  // güncellemeden sonra ikinci bir kontrol yapılıyor
                    {
                        Console.WriteLine("Karakterimiz : " + player.Name + " Ateş Etmeye Hazırlanıyor");
                        Thread.Sleep(2300);
                        player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_reuses = player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_reuses - player.silahlar.FirstOrDefault(x => x.FirstGun == true).number_of_usability_per_iteration;
                        dusman.Health = player.silahlar.FirstOrDefault(x => x.FirstGun == true).DamagePoint;
                        Console.WriteLine("Düşman Bir Hasar Aldı . Son Sağlık Değeri :"+dusman.Health);
                        Thread.Sleep(1500);


                    }

                }

                else
                {
                    Console.WriteLine("Oyuncumuz ölmüştür. ");
                    Thread.Sleep(6000);
                    Console.WriteLine("Düşman Takımdan :"+dusman.Id+" bu turnuvayı kazanmıştır.");
                    break;
                }

                if (dusman.Health > 0 )
                {
                    if (!(dusman.silahlar.number_of_reuses / dusman.silahlar.number_of_usability_per_iteration > 0))
                    {
                        map.Enemies.Remove(dusman);
                        dusman = map.Enemies.FirstOrDefault();
                        Console.WriteLine("Düşmanımızın mermisi bitiyor ve bize diğer düşmanıız olan "+dusman.Username+" saldırıya geçiyor ");
                        Thread.Sleep(2300);


                    }


                    if (dusman.silahlar.number_of_reuses / dusman.silahlar.number_of_usability_per_iteration > 0)  // güncellemeden sonra ikinci bir kontrol yapılıyor
                    {
                        Console.WriteLine("Düşmanmınız : " + dusman.Id+ " Ateş Etmeye Hazırlanıyor");
                        Thread.Sleep(2300);
                        dusman.silahlar.number_of_reuses -= dusman.silahlar.number_of_usability_per_iteration;
                        player.Health = dusman.silahlar.DamagePoint;
                        Console.WriteLine("Karakterimiz vuruluyor. Yeni Sağlık değeri :"+player.Health);
                    }
                }
                else
                {
                    if (map.Enemies.Count> 1 )
                    {
                        map.Enemies.Remove(dusman);
                        dusman = map.Enemies.FirstOrDefault();
                    }
                    else
                    {
                        Console.WriteLine("Karşı tarafta hiç düşman kalmadığından kaynaklı olarak oyunu oyuncumuz kazanmıştır. ");
                        Thread.Sleep(2300);
                        Console.WriteLine("Son durumda oyuncumuzun bilgileri ");
                        _userServices.GetInformationToUserObject(player);
                        break;

                    }
                }

               

            }

        }
    }
}
