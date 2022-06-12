using System.Collections.Generic;
using WarGame.Entities.Concrete;

namespace WarGame.Core.Concrete.MapObject
{
    public class Vahsi_Bati : MapRepository
    {

        // alanda 3 adet düşman üretilmiştir. bu haritanın özelliği 3 adet düşman üretilmesidir. 


        public Vahsi_Bati() : base("Vahsi Bati")
        {
            List<Enemies> dusman = new List<Enemies>
            {
                new Enemies() , new Enemies() , new Enemies()
            };
            this.Enemies = dusman;

        }
    }
}
