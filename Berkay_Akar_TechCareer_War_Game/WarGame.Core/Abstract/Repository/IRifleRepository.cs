namespace WarGame.Core.Abstract.Repository
{
    public interface IRifleRepository : IBaseWeaphoneRepository
    {
        public enum WeaphoneName
        {
            Poz,
            Tara,
        }


        public enum WeaphoneModel
        {
            P400,
            T600,
        }

    }
}
