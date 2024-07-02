namespace Comex.Utils
{
    public static class ConsoleUtils
    {
        public static void PararLimparAplicacao()
        {
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
