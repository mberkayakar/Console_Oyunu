namespace WarGame.Core.Abstract.BasedAbstract
{
    public interface IPistolRepository :  IBaseWeaphoneRepository
    {

        public enum WeaphoneName
        {
            Altıpatlar,
            Su,
        }


        public enum WeaphoneModel
        {
            A300,
            S1000,
        }



    }
}
