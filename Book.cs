namespace CSharpBasicsSession02
{
    internal class Book
    {
        public string Title { get; set; } = string.Empty;
        public int Pages { get; set; };
        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}