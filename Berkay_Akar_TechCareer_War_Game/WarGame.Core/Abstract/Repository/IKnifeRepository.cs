
using System.Collections.Generic;

namespace WarGame.Core.Abstract
{
    public interface IKnifeRepository : IBaseWeaphoneRepository
    {
        public enum WeaphoneName
        {
            Rambo,
            KST,
        }


        public enum WeaphoneModel
        {
            K500,
            K700,
            K100,

        }


        
    }
}
