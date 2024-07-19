using System.ComponentModel.DataAnnotations;
namespace _5LettersSolver.Data
{
    public class WordDB
    {
        [Key]
        public string Text { get; set; }
        public double Score { get; set; }
    }
}
