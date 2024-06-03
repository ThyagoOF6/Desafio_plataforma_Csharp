namespace Entities
{
    public abstract class Lesson
    {
        private string title;

        public Lesson()
        {
        }

        public Lesson(string title)
        {
            this.title = title;
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public abstract int Duration();
    }
}