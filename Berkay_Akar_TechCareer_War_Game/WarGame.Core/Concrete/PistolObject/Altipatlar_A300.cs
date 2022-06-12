using System;
using WarGame.Core.Abstract.BasedAbstract;

namespace WarGame.Core.Concrete.PistolObject
{
    public class Altipatlar_A300 : BaseWeaphoneRepository, IPistolRepository
    {
        public Altipatlar_A300()
        {
            this.Marka = Enum.GetName(typeof(IPistolRepository.WeaphoneName), IPistolRepository.WeaphoneName.Altıpatlar);
            this.Model = Enum.GetName(typeof(IPistolRepository.WeaphoneModel), IPistolRepository.WeaphoneModel.A300);
            this.DamagePoint = 8;
            this.number_of_reuses = (int)IPistolRepository.Reload.Alti;
            this.number_of_usability_per_iteration = 1;
            this.FirstGun = false;

        }
    }
}
