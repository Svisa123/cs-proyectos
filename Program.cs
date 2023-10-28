using System;

namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Chat App - Ingrese su nombre:");
            string username = Console.ReadLine();

            Console.WriteLine($"Bienvenido, {username}!");
            Console.WriteLine("Escriba 'exit' para salir.");

            string message;


            do
            {
                message = Console.ReadLine();
                Console.WriteLine($"{username}: {message}");
            } while (message != "exit");

            // while ((message = Console.ReadLine()) != "exit")
            // {
            //     Console.WriteLine($"{username}: {message}");
            // }
        }
    }
}
