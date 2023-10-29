/* Paso 1: Definir una palabra oculta

Elije una palabra que el jugador deba adivinar. Puedes comenzar con una palabra corta y simple, como "gato" o "casa".
Paso 2: Mostrar la longitud de la palabra oculta

Muestra al jugador la longitud de la palabra oculta con guiones bajos que representen las letras no adivinadas. Por ejemplo, si la palabra oculta es "gato", muéstrala como "_ _ _ _".
Paso 3: Permitir al jugador adivinar letras

Pide al jugador que ingrese una letra por turno.
Verifica si la letra ingresada está en la palabra oculta.
Si la letra está en la palabra oculta, reemplaza los guiones bajos correspondientes en la palabra adivinada por la letra.
Si la letra no está en la palabra oculta, resta un intento al jugador.
Paso 4: Establecer un límite de intentos

Establece un número máximo de intentos permitidos (por ejemplo, 6 intentos).
Muestra el número de intentos restantes después de cada intento.
Paso 5: Terminar el juego

El juego termina cuando el jugador adivina la palabra completa o se quedan sin intentos.
Si el jugador adivina la palabra, muestra un mensaje de victoria.
Si se quedan sin intentos, muestra un mensaje de derrota y revela la palabra oculta.
Este enfoque simplificado te permite crear un juego de adivinanza de palabras en C# sin necesidad de código más avanzado. A medida que te sientas más cómodo, puedes agregar funcionalidades adicionales y mejorar la interfaz de usuario.*/
using System;


namespace ChatApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] hiddenWords = new string[] { "gato", "perro", "casa", "conejo", "azucar" };
            Random rnd = new Random();
            string hiddenWord = hiddenWords[rnd.Next(0, 5)];
           for(int i = 0; i < hiddenWord.Length; i++){
             Console.Write("_ ");
           };
        }
    }
}
