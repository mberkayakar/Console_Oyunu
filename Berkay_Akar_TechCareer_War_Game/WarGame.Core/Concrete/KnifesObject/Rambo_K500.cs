using System;
using WarGame.Core.Abstract;

namespace WarGame.Core.Concrete
{
    public class Rambo_K500 : BaseWeaphoneRepository , IKnifeRepository
    {
        public Rambo_K500()
        {
            this.Marka = Enum.GetName(typeof(IKnifeRepository.WeaphoneName), IKnifeRepository.WeaphoneName.Rambo);
            this.Model= Enum.GetName(typeof(IKnifeRepository.WeaphoneModel), IKnifeRepository.WeaphoneModel.K500);
            this.DamagePoint = 5;
            this.number_of_reuses = (int)IKnifeRepository.Reload.Bir;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;


        }

    }
}
