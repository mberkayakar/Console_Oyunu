using System;
using WarGame.Core.Abstract;

namespace WarGame.Core.Concrete
{
    public class KST_K100 : BaseWeaphoneRepository , IKnifeRepository
    {
        public KST_K100()
        {
            this.Marka = Enum.GetName(typeof(IKnifeRepository.WeaphoneName), IKnifeRepository.WeaphoneName.KST);
            this.Model= Enum.GetName(typeof(IKnifeRepository.WeaphoneModel), IKnifeRepository.WeaphoneModel.K100);
            this.DamagePoint = 8;
            this.number_of_reuses = (int)IKnifeRepository.Reload.Bir;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;

        }

    }
}
