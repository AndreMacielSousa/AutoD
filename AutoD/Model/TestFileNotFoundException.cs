namespace AutoD.Model
{
    using System.IO;

    class TestFileNotFoundException : FileNotFoundException
    {
        public TestFileNotFoundException(string message, string filename) :

            base(message, filename)
        {
        }
    }
        
}
