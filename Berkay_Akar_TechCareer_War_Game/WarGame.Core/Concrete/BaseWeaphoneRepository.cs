using WarGame.Core.Abstract;
using static WarGame.Core.Abstract.IBaseWeaphoneRepository;

namespace WarGame.Core.Concrete
{
    public class BaseWeaphoneRepository : IBaseWeaphoneRepository
    {

        public string Marka { get; set; }
        public string Model { get; set; } // 
        public int DamagePoint { get; set; } // hasar puanı
        public int number_of_reuses { get; set; }
        public int number_of_usability_per_iteration { get ; set ; }
        public bool FirstGun { get; set; }

    }
}
