namespace WarGame.Core.Abstract
{
    public interface IBaseWeaphoneRepository
    {
        public enum Reload
        {
            Bir = 1,
            Bes = 5,
            Alti = 6,
            OnBes = 15,
            Elli = 50,

        }
        public int number_of_reuses { get; set; }
        public int number_of_usability_per_iteration { get; set; }




    }
}
