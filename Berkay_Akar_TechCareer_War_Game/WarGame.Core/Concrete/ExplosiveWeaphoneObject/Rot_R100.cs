using System;
using WarGame.Core.Abstract;
using WarGame.Core.Abstract.Repository;

namespace WarGame.Core.Concrete.ExplosiveWeaphoneObject
{
    public class Rot_R100 : BaseWeaphoneRepository, IExplosiveRepository

    {
        public Rot_R100()
        {
            this.Marka = Enum.GetName(typeof(IExplosiveRepository.WeaphoneName), IExplosiveRepository.WeaphoneName.Rot);
            this.Model = Enum.GetName(typeof(IExplosiveRepository.WeaphoneModel), IExplosiveRepository.WeaphoneModel.R100);
            this.DamagePoint = 40;
            this.number_of_reuses = (int)IExplosiveRepository.Reload.Bir;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;

        }
    }
}
