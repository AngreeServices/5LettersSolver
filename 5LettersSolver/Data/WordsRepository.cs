namespace _5LettersSolver.Data
{
    public class WordsRepository:IWordsRepository
    {
        public async Task<List<WordDB>> GetAll()
        {
            using (var context = new WordsContext())
            {
                return context.Words.ToList();
            }
        }
    }
}
