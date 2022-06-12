namespace WarGame.Core.Abstract.Repository
{
    public interface IExplosiveRepository : IBaseWeaphoneRepository
    {
        public enum WeaphoneName
        {
            Rot,
            Guny,
        }


        public enum WeaphoneModel
        {
            R100,
            G200,
        }
    }
}
