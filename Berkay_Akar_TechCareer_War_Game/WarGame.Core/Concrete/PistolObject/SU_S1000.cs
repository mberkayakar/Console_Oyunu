using System;
using WarGame.Core.Abstract.BasedAbstract;

namespace WarGame.Core.Concrete.PistolObject
{
    public class SU_S1000 : BaseWeaphoneRepository, IPistolRepository
    {
        public SU_S1000()
        {
            this.Marka = Enum.GetName(typeof(IPistolRepository.WeaphoneName), IPistolRepository.WeaphoneName.Su);
            this.Model = Enum.GetName(typeof(IPistolRepository.WeaphoneModel), IPistolRepository.WeaphoneModel.S1000);
            this.DamagePoint = 8;
            this.number_of_reuses = (int)IPistolRepository.Reload.OnBes;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;

        }
    }
}
