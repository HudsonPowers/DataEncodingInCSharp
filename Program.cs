using System;

namespace DataEncodingInCSharp
{
    class Program
    {

        static void Main(string[] args)
        {

            string filePath = args[0];
            Console.WriteLine($"Loading '{filePath}'.");
        
            Cipher cipher;
            cipher = new Cipher(5);

            Cipher cipher2;
            cipher2 = new Cipher(3);

            string encrypted;
            encrypted = cipher.Encrypt("rosebud");
            // Console.Writeline($"The encrypted message is: '{encrypted}'");

            string decrypted;
            decrypted = cipher.Decrypt(encrypted);
            // Console.WriteLine($"The decripted message is: '{decrypted}'");

            string message;
            message = System.IO.File.ReadAllText(filePath);
            // Console.WriteLine($"The encrypted message is: '{message}'.");

            string Decrypt;
            cipher = new Cipher(3);
            Decrypt = cipher.Decrypt($"{message}");
            Console.WriteLine($"The encrypted message is: '{Decrypt}'");


             int shift;
            shift = 1;
            while(shift <= 10)
            {
                Cipher cipher3;
                cipher3 = new Cipher(shift);
                Decrypt = cipher3.Decrypt(message);
                Console.WriteLine($"The decrypted message is: '{Decrypt}'");
                shift += 1;
                
            }
        }

        // static void Main(string[] args)
        // {
        //     // char ch;
        //     // ch = 'A';
        //     // Console.WriteLine($"ch is storing the value {ch}");

        //     // int ch_decimal;
        //     // ch_decimal = ch;
        //     // Console.WriteLine($"The decimal value of ch is: {ch_decimal}");

        //     // int toConvert;
        //     // Console.Write("Enter an integer: ");
        //     // toConvert = int.Parse(Console.ReadLine());

        //     // char asChar;
        //     // asChar = (char)toConvert;
        //     // Console.WriteLine($"The integer {toConvert} cast to a char is '{asChar}'");

        //     // char b;
        //     // b = (char)('A' + 1);
        //     // Console.WriteLine($"'A' + 1 = '{b}'");

        //     Cipher cipher;
        //     cipher = new Cipher(5);

        //     string encrypted;
        //     encrypted = cipher.Encrypt("rosebud");
        //     Console.WriteLine($"The encrypted message is: '{encrypted}'");
        // }
    }
}
