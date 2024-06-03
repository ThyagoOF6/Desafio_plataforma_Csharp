namespace Entities
{
    public class Video : Lesson
    {
        private string url;
        private int seconds;

        public Video() : base()
        {
        }

        public Video(string title, string url, int seconds) : base(title)
        {
            this.url = url;
            this.seconds = seconds;
        }

        public string Url
        {
            get { return url; }
            set { url = value; }
        }

        public int Seconds
        {
            get { return seconds; }
            set { seconds = value; }
        }

        public override int Duration()
        {
            return Seconds;
        }
    }
}