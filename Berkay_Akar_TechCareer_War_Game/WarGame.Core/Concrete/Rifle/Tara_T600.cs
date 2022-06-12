using System;
using WarGame.Core.Abstract.Repository;

namespace WarGame.Core.Concrete.Rifle
{
    public class Tara_T600 : BaseWeaphoneRepository , IRifleRepository
    {
        public Tara_T600()
        {
            this.Marka = Enum.GetName(typeof(IRifleRepository.WeaphoneName), IRifleRepository.WeaphoneName.Tara);
            this.Model = Enum.GetName(typeof(IRifleRepository.WeaphoneModel), IRifleRepository.WeaphoneModel.T600);
            this.DamagePoint = 10;
            this.number_of_reuses = (int)IRifleRepository.Reload.Elli;
            this.number_of_usability_per_iteration = 5;

        }
    }
}


 