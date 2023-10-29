namespace ChatApp
{
    public class Round
    {
        public static char RoundHandler()
        {
            char letterInput;
            do
            {
                Console.WriteLine("Ingrese una letra por ronda: ");

                try
                {
                    string userInput = Console.ReadLine();

                    if (userInput.Length == 1 && char.IsLetter(userInput[0]))
                    {
                        letterInput = userInput[0];
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Entrada no válida. Debe ingresar un  carácter válido.");
                    }
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine("Se ha producido un error: " + ex.Message);
                }

            } while (true);

            return letterInput;
        }
    }
}