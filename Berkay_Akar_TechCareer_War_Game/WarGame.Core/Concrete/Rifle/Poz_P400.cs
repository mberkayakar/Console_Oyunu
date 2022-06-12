using System;
using WarGame.Core.Abstract.Repository;

namespace WarGame.Core.Concrete.Rifle
{
    public class Poz_P400 : BaseWeaphoneRepository, IRifleRepository
    {
        public Poz_P400()
        {
            this.Marka = Enum.GetName(typeof(IRifleRepository.WeaphoneName), IRifleRepository.WeaphoneName.Poz);
            this.Model = Enum.GetName(typeof(IRifleRepository.WeaphoneModel), IRifleRepository.WeaphoneModel.P400);
            this.DamagePoint = 15;
            this.number_of_reuses = (int)IRifleRepository.Reload.Bes;
            this.number_of_usability_per_iteration = 1;
        }
    }
}

