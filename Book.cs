namespace CSharpBasicsSession02
{
    internal class Book
    {
        public string Title = string.Empty;

        public int Pages;

        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}