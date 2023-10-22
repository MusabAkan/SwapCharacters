using System;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Bir string ifade girin: ");
            string inputString = Console.ReadLine();

            string result = SwapCharacters(inputString);
            Console.WriteLine("Sonuç: " + result);
        }
        catch (FormatException)
        {
            Console.WriteLine("Geçersiz giriş.");
        }
    }

    static string SwapCharacters(string input)
    {
        char[] characters = input.ToCharArray();

        for (int i = 0; i < characters.Length - 1; i += 2)
        {
            char temp = characters[i];
            characters[i] = characters[i + 1];
            characters[i + 1] = temp;
        }

        return new string(characters);
    }
}