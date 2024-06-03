namespace Entities
{
    public class Task : Lesson
    {
        private string description;
        private int questionCount;

        public Task() : base()
        {
        }

        public Task(string title, string description, int questionCount) : base(title)
        {
            this.description = description;
            this.questionCount = questionCount;
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public int QuestionCount
        {
            get { return questionCount; }
            set { questionCount = value; }
        }

        public override int Duration()
        {
            return questionCount * 5 * 60;
        }
    }
}