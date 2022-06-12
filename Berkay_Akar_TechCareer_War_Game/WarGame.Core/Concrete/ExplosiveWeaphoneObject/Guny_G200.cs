using System;
using WarGame.Core.Abstract.Repository;

namespace WarGame.Core.Concrete.ExplosiveWeaphoneObject
{
    public class Guny_G200 : BaseWeaphoneRepository, IExplosiveRepository
    {
        public Guny_G200()
        {
            this.Marka = Enum.GetName(typeof(IExplosiveRepository.WeaphoneName), IExplosiveRepository.WeaphoneName.Guny);
            this.Model = Enum.GetName(typeof(IExplosiveRepository.WeaphoneModel), IExplosiveRepository.WeaphoneModel.G200);
            this.DamagePoint = 30;
            this.number_of_reuses = (int)IExplosiveRepository.Reload.Bir;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;
        }
    }
}
