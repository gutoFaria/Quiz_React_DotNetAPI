namespace backend.Models
{
    public class Question
    {
        public int Id { get; set; }
        public string Title { get; set; } = String.Empty;
        public string AnswerOne { get; set; } = String.Empty;
        public string AnswerTwo { get; set; } = String.Empty;
        public string AnswerThree { get; set; } = String.Empty;
        public string AnswerFour { get; set; } = String.Empty;
        public string AnswerCorrect { get; set; } = String.Empty;
        public int TemaId { get; set; }
    }
}