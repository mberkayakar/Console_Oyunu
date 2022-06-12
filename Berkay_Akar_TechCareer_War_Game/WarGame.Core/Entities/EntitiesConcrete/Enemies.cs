using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarGame.Core.Concrete;
using WarGame.Core.HelperFolders;
using WarGame.Entities.Abstract;

namespace WarGame.Entities.Concrete
{
    public class Enemies : IEntity
    {
        public Enemies()
        {
            _ıd = "WarGame" + Guid.NewGuid().ToString();
            Username = "Emenies "+ Guid.NewGuid().ToString();
            Random rastgele = new Random();
            _health = rastgele.Next(30, 70);  // sağlık değeri sisteme elle verilmemesi açısından bu şekilde 30 ila 70 arasında 
            _weaphones = RandomGunGenerator.GenerateRandomGun();  // random bir silah olarak alabilmesi için gereçkelştirilmiş bir süreçtir. Newleme anında bizlere random olarak silah üretecektir.
         /* Düşman Dinamiğinin sürekli olarak random oluşturulabilmesi adına böyle bir işlem gerçekleştirdim. harita seçimi yapıdıgı anda random düşman ve her düşmana */
            // dandom özellikler aranabilmesi için 



        }



        private readonly string _ıd;  // üretilme esnasında her user in benzersiz bir id si olması gerektiği düşünüğlerek bu şekilde bir tasarım gerçekleştirilmiştir.
        private string _username;
        private int _health;
        private BaseWeaphoneRepository _weaphones;


        public string Id { get { return _ıd; } }
        public string Username { get { return _username; } set { if (value.Trim().ToUpper().Length > 5) { _username = value.Trim().ToUpper(); } } }
        public int Health { get { return _health; } set { _health -= value; } }
        public BaseWeaphoneRepository silahlar { get { return _weaphones; } }



    }
}
