namespace BibliotecaDeClases
{
    public class GeneradorId
    {


        private static int ISBN = 0;

        public static int GetNextISBN()
        {

            return ++ISBN;

        }

        
    }
}
