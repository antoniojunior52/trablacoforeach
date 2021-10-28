using System;

namespace ExGrupo
{
    class Program
    {
        static void Main()
        {
            string[] array = {"SP é São Paulo", "RJ é Rio de Janeiro", "PE é Recife", "AM é Manaus", "GO é Goiânia", "SC é Florianópolis"};

            foreach(string local in array) 
            {
                Console.WriteLine($" A capital de {local}");
            }
        }
    }
}