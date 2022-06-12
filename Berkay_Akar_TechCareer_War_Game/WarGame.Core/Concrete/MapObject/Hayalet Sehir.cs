using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Entities.Concrete;

namespace WarGame.Core.Concrete.MapObject
{
    public class Hayalet_Sehir: MapRepository
    {
        public Hayalet_Sehir() : base ("Hayalet Sehir")
        {
            this.Enemies = new List<Entities.Concrete.Enemies>
            {
                new Enemies(),
                new Enemies(),
                new Enemies(),

            };

        }
    }
}
