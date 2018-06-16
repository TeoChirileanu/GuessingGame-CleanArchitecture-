namespace BusinessRules {
    public interface IGame {
        int CorrectNumber { get; set; }
        void Check(int number);
    }
}