/* Adam Bockhorst
 * 2/26/2022
 * Converting IPv4 Addresses to binary
 * Converting binary numbers to IPv4 Addresses
 */
using System;

namespace IPv4_Conversions
{
    /// <summary>
    /// This class checks to see if the IP address is valid
    /// </summary>
    class IPChecker
    {
        /// <summary>
        /// Checks to see if the IP Address is valid
        /// </summary>
        /// <param name="ipAddress">Th IP Address to be checked</param>
        /// <returns>True if the IP Address is valid, false otherwise</returns>
        public Boolean ipChecker(string ipAddress)
        {
            //Set a Boolean to true
            Boolean isValid = true;

            //Declare and instantiate an Array to know how to seperate the ipAddress
            //The ipAddress will be seperated after every '.' period
            char[] delimiterChars = { '.' };

            //Declare and instantiate an Array to hold the parts of the seperated IP address
            //Split the IP address into 4 parts
            string[] seperatedIP = ipAddress.Split(delimiterChars);

            //foreach loop to loop through each part of the seperated IP address
            foreach (string testIP in seperatedIP)
            {
                int digit = 0;

                //Try to cast the testIP string  to integers to be compared
                //Else set isValid to false
                if (!int.TryParse(testIP, out digit))
                {
                    isValid = false;
                }
                
                //If the digit in the section of the address is greater than 255: isValid = false
                //If the digit in the section of the address is less thatn 0: isValid = false
                //Break from loop
                if (digit > 255 ^ digit < 0)
                {
                    isValid = false;
                    break;
                }
            }

            if (isValid == true)
            {
                //If the seperatedIP length is not 4: isValid  = false;
                if (seperatedIP.Length != 4)
                {
                    isValid = false;
                }
            }
            return isValid;
        }
    }
}
