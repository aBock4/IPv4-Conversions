/* Adam Bockhorst
 * 2/26/2022
 * Converting IPv4 Addresses to binary
 * Converting binary numbers to IPv4 Addresses
 */
using System;

namespace IPv4_Conversions
{
    class Program
    {
        /// <summary>
        /// Main testing two conversions
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            //Test IP to binary conversion
            IPtoBinarytest();

            //Test binary to IP conversion
            BinarytoIPtest();
        }

        /// <summary>
        /// IP to binary conversion
        /// </summary>
        public static void IPtoBinarytest()
        {
            //Reference the IPtoBinary class
            IPtoBinary IPtoBinary = new IPtoBinary();

            //Reference the IPChecker class
            IPChecker IPChecker = new IPChecker();

            //Set the IP address
            string ipAddress = "123.255.1.2";

            //Declare the binary number as empty string
            string binaryNumber = "";

            //Declare a Boolean
            //Instantiate it as the return value from the ipChecker method in the IPChecker class
            Boolean isValid = IPChecker.ipChecker(ipAddress);

            if (isValid)
            {
                //Instantiate binaryNumber to the return value from the binaryIP method in the IPtoBinary class
                binaryNumber = IPtoBinary.binaryIP(ipAddress);

                //Print the binaryNumber to console
                Console.WriteLine(binaryNumber);
            }
            else
            {
                //Print an error message to console
                Console.WriteLine("Please enter a valid IPv4 IP  Address!");
            }
        }
        /// <summary>
        /// Binary to IP conversion
        /// </summary>
        public static void BinarytoIPtest()
        {
            //Reference to the BinarytoIP class
            BinarytoIP BinarytoIP = new BinarytoIP();

            //Reference to the BinaryChecker class
            BinaryChecker BinaryChecker = new BinaryChecker();

            //Set the binaryNumber
            string binaryNumber = "01111011.11111111.00000001.00000010";

            //Set the ipAddress to an empty string
            string ipAddress = "";

            //Declare a Boolean
            //Instantiate it as the return value from the binaryChecker method in the BinaryChecker class
            Boolean isValid = BinaryChecker.binaryChecker(binaryNumber);

            if (isValid)
            {
                //Instantiate ipAddress to the return value from the binaryConversion method in the BinarytoIP class
                ipAddress = BinarytoIP.binaryConversion(binaryNumber);

                //Print the ipAddress to console
                Console.WriteLine(ipAddress);
            }
            else
            {
                //Print an error message to console
                Console.WriteLine("Please enter a valid 32 bit binary number!");
            }


        }
    }
}
