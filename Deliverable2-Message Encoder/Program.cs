using System;

namespace Deliverable2_Message_Encoder
{
    class Program
    {
        /*
         ANDRES TORRES
         DELIVERABLE # 2 - Message Encoder
        */
        static void Main(string[] args)
        {
            string input;
            string message = ""; // hold the encoded string
            ulong checksum = 0; // hold the total Unicode value of "input"

            Console.Write("What is your message? ");
            input = Console.ReadLine();

            for (int i = 0; i < input.Length; i++)
            {
                uint unicodeValue = input[i];

                // unicode = ASCII for values 'A' to 'Z' and from 'a' to 'z'
                // convert the value from lowercase to uppercase
                if (unicodeValue >= 'a' && unicodeValue <= 'z')
                {
                    // lower case value; convert to upper case
                    unicodeValue = unicodeValue - 'a' + 'A';
                }

                // compute the checksum
                checksum += unicodeValue;

                // encode the alphabetic value (A=1, B=2, etc.)
                uint encodedValue = (unicodeValue - 'A' + 1);

                // build the message for output
                message += encodedValue + "-";
            }

            Console.WriteLine("Your encoded message is " + message);
            Console.WriteLine("Message checksum is " + checksum);
        }
    }
}
