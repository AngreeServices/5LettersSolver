using _5LettersSolver.Data;

namespace _5LettersSolver.Core
{
    public interface IWordsServices
    {
        public Task<List<string>> GetNextWords(List<WordResult> wordResults);
    }
}
