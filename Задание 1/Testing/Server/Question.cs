namespace Server
{
    [Serializable]
    public class Question
    {
        public string? question;
        public string? answer;

        public Question() { }
        public Question(string question, string answer)
        {
            this.question = question;
            this.answer = answer;
        }
    }
}
