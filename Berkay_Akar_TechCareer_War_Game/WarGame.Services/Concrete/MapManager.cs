using System;
using System.Collections.Generic;
using System.Linq;
using WarGame.Core.Abstract;
using WarGame.Core.Concrete;
using WarGame.Entities.Concrete;
using WarGame.Services.Abstract;

namespace WarGame.Services.Concrete
{
    public class MapManager : IMapService
    {

        IWeaphoneServices weaphoneServices = new WeaphoneManager();
        IDuelService duelservice = new DuelManager();

        public MapRepository GetMapİnformation(MapRepository map)
        {
            System.Console.WriteLine("Map İsmi : "+map.Name);
            System.Console.WriteLine(" ");
            System.Console.WriteLine("Map Düşman Sayısı :  " + map.Enemies.Count);
            System.Console.WriteLine("");
            foreach (var item in map.Enemies)
            {
                System.Console.WriteLine("Düşman İD"+item.Id);
                System.Console.WriteLine("Düşman Username" + item.Username);
                System.Console.WriteLine("Düşman Sağlığı " + item.Health);
                System.Console.WriteLine("Düşman Silah Bilgileri : ");
                weaphoneServices.GetWeaphoneDetail(item.silahlar);
                System.Console.WriteLine("\n\n\n\n\n");
            }

            return map;


        }

        public void SavasaBasla(User user, MapRepository map)
        {
            if (user == null)
            {
                throw new ArgumentException("bir user sisteme dahil ediniz.");
            }
            if (user.silahlar == null || user.silahlar.Count == 0)
            {
                throw new ArgumentException("user a e az bir silah dahil ediniz.");
            }
            if (map.Enemies == null || map.Enemies.Count <= 2)
            {
                throw new ArgumentException("Yeterli Sayıda Düşman Elde Edilemedi.");
            }
            if (user.silahlar.FirstOrDefault(x=> x.FirstGun == true) == null)
            {
                Console.WriteLine("Mücadeleye Başlamanız için bir silah seçimi yapınız ");

                foreach (var  item in user.silahlar)
                {
                    Console.WriteLine("Silah İsmi :"+item.Marka + " Model :" + item.Model);
                }
                Console.WriteLine("LÜTFEN BİR SİLAH İSMİ GİRİNİZ (MARKA OLARAK) ");
                while (true)
                {
                    Console.WriteLine("Varsayılan Olarak Seçeceginiz Silahın Adını Giriniz ");
                    string name = Console.ReadLine();
                    if (name != null)
                        weaphoneServices.SelectDefaultWeaphone(user, name);
                    if (user.silahlar.FirstOrDefault(x => x.FirstGun == true) != null)
                    {
                        break;
                    }
                }
                map.player = user;

                duelservice.StartDuello(map);

            }


        }

        
    }
}
