namespace CSharpBasicsSession02
{
    internal class Book
    {
        public string Title = string.Empty;
        public int Pages = 0;
        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}