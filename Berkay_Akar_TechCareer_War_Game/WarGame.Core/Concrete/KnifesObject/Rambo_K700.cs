using System;
using WarGame.Core.Abstract;

namespace WarGame.Core.Concrete
{
    public class Rambo_K700 : BaseWeaphoneRepository , IKnifeRepository
    {
        public Rambo_K700()
        {
            this.Marka = Enum.GetName(typeof(IKnifeRepository.WeaphoneName), IKnifeRepository.WeaphoneName.Rambo);
            this.Model= Enum.GetName(typeof(IKnifeRepository.WeaphoneModel), IKnifeRepository.WeaphoneModel.K700);
            this.DamagePoint = 8;
            this.number_of_reuses = (int)IKnifeRepository.Reload.Bir;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;
            

        }

    }
}
