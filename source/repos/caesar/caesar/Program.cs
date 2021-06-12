using System;

namespace caesar
{
    class Program
    {
        static void Main(string[] args)
        {
            string tempString = "ABC";
            Console.WriteLine("Starting value: " + tempString);
            tempString = Cypher.Encrypt(tempString, 2);
            Console.WriteLine("Value after encryption: " + tempString);
            tempString = Cypher.Decrypt(tempString, 2);
            Console.WriteLine("Value after decryption: " + tempString);
        }
    }
}
