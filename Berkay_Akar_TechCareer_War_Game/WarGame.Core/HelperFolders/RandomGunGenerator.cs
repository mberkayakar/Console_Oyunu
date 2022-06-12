using System;
using System.Collections.Generic;
using WarGame.Core.Concrete;
using WarGame.Core.Concrete.ExplosiveWeaphoneObject;
using WarGame.Core.Concrete.PistolObject;
using WarGame.Core.Concrete.Rifle;

namespace WarGame.Core.HelperFolders
{
    public static class RandomGunGenerator
    {
        public static List<BaseWeaphoneRepository> Gunlist = new List<BaseWeaphoneRepository>()
        {

            // Patlayıcı silahlar
            new Guny_G200() , new Rot_R100(), 
            // Biçaklar
            new KST_K100(), new Rambo_K500(), new Rambo_K500(),
            // Tabancalar
            new Altipatlar_A300(), new SU_S1000(),
            // Agir Makineli Tüfekler 
            new Poz_P400(), new Tara_T600()
        };

          


        public static BaseWeaphoneRepository GenerateRandomGun()
        {

            Random rastgele = new Random();
            int sayi = rastgele.Next(8);
            var model = Gunlist[sayi];
            return model;

        }
    }
}
