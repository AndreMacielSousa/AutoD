namespace AutoD.Model
{
    using System.IO;

    class Data
    {
        public void Verify()
        {

            if (!File.Exists(@"Content\text98.txt"))
                throw new FileNotFoundException("Ficheiro de configuração não encontrado!", "text99.txt");

            if (!File.Exists(@"Content\car1.xnb"))
                throw new FileNotFoundException("Ficheiro de configuração não encontrado!", "car1.xnb");

            if (!File.Exists(@"Content\car2.xnb"))
                throw new FileNotFoundException("Ficheiro de configuração não encontrado!", "car2.xnb");

            if (!File.Exists(@"Content\Board.xnb"))
                throw new FileNotFoundException("Ficheiro de configuração não encontrado!", "Board.xnb");

        }
    }
}


