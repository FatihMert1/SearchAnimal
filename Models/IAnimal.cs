namespace SearchAnimal.Models{

    public interface IAnimal {
        public string GetName();
        public string GetType();
        public int GetAge();
    }
}