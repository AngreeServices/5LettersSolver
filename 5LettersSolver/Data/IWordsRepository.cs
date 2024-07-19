namespace _5LettersSolver.Data
{
    public interface IWordsRepository
    {
        public Task <List<WordDB>> GetAll();
    }
}
