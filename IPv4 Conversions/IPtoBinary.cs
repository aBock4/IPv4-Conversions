/* Adam Bockhorst
 * 2/26/2022
 * Converting IPv4 Addresses to binary
 * Converting binary numbers to IPv4 Addresses
 */
using System;

namespace IPv4_Conversions
{
    class IPtoBinary
    {
        /// <summary>
        /// Convert an IPv4 address into binary
        /// </summary>
        /// <param name="ipAddress">IP address to convert to binary</param>
        /// <returns>The binary number</returns>
        public string binaryIP(string ipAddress)
        {
            //Set binaryNumber as an empty string
            string binaryNumber = "";

            //Declare and instantiate an Array to know how to seperate the ipAddress
            //The ipAddress will be seperated after every '.' period
            char[] delimiterChars = { '.' };

            //Declare and instantiate an Array to hold the parts of the seperated IP address
            //Split the IP address into 4 parts
            string[] seperatedIP = ipAddress.Split(delimiterChars);

            //foreach loop to loop through each part of the seperated IP address
            foreach (string ipPart in seperatedIP)
            {
                //Cast the string to an integer
                //Need to put IP Address through IPChecker else will break here if not valid address
                int digits = Int32.Parse(ipPart);

                //Set the binaryNumber to 128
                int bit = 128;

                //Set a counter to 0
                int counter = 0;

                while (counter < 8)
                {
                    //If the digit of the IP address is greater than or equal to the binaryNumber
                    //Change the first bit in the binaryNumber to a 1 and subtract the digit from the current bit

                    if (digits >= bit)
                    {
                        binaryNumber += "1";
                        digits -= bit;

                    }
                    //Else set the bit in the binaryNumberto a 0
                    else { binaryNumber += "0"; };

                    //Add 1 to the counter
                    //Divite the bit by 2
                    counter += 1;
                    bit /= 2;
                }
                //Format the binaryNumber
                binaryNumber += ".";
            }
            //Trim the period off of the final binaryNumber
            binaryNumber = binaryNumber.TrimEnd('.');

            //Return the binaryNmber
            return binaryNumber;
        }
    }
}
