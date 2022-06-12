using System;
using System.Collections.Generic;
using WarGame.Core.Abstract;
using WarGame.Entities.Concrete;

namespace WarGame.Core.Concrete
{
    public class MapRepository: IBaseMapRepository  // sınıfın bir interface açısından açıkta bırakılmamsı için bu şekil bir sınıflandırma yapılmıştır
    {
        public MapRepository(string Name)
        {
            this.Name = Name;
        }

        private string _id = System.Guid.NewGuid().ToString();
        private string _name;
        public string Name { get { return _name; } set { if (value.Trim().ToUpper().Length <= 15 && value.Trim().ToUpper().Length >= 2) { _name = value.Trim().ToUpper(); } else { throw new ArgumentException(" HARİTA UZUNLUGUNU 2 İLE 15 KARAKTER ARASI GİRİNİZ (BOŞLUKLAR DAHİL) "); } } }
        public User player { get; set; }
        public List<Enemies> Enemies { get; set; }





        #region Açıklama

        // bu işlemi silahlar sınıfndaki gibi yapmamamın sebebi ise bir
        // haritanın 15 karakterden uzun olmayacağı söylenmesi sebebi ile
        // bu şekilde bir süreç gerçekleştirdim. iş süreçlerine çok hakim
        // olmasamda herçek hayattta silahlar belirli bir şekli oldugundan
        // ve modifikasyonlara açık olamdıgından kaynaklı olarak her biri
        // için base sınıfın özelliklerini alacak şekilde bir yapı gerçekleştirdim.
        // Gerekli sınıf new lenerek o silahın tüm özelliklerini elde edebilmekyeyiz.

        #endregion

    }
}
