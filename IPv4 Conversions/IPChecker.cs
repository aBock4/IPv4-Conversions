/* Adam Bockhorst
 * 2/26/2022
 * Converting IPv4 Addresses to binary
 * Converting binary numbers to IPv4 Addresses
 */
using System;

namespace IPv4_Conversions
{
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

            //Set a counter to 0
            int counter = 0;

            //Declare and instantiate an Array to hold the parts of the seperated IP address
            //Split the IP address into 4 parts
            string[] seperatedIP = ipAddress.Split(delimiterChars);

            //foreach loop to loop through each part of the seperated IP address
            foreach (string testIP in seperatedIP)
            {
                //Set digits to 0;
                int digit = 0;

                //Try to cast the testIP string  to integers to be compared
                //Else through set isValid to false
                try
                {
                    digit = Int32.Parse(testIP);
                }
                catch
                {
                    isValid = false;
                }
                
                //If the digit in the section of the address is greater than 255: isValid = false
                //If the digit in the section of the address is less thatn 0: isValid = false
                //Break from loop
                if (digit > 255 | digit < 0)
                {
                    isValid = false;
                    break;
                }
            }
            if (isValid == true)
            {
                //foreach loop to loop through each part of the seperated Ip address
                //Add 1 to counter each time through loop
                foreach (string test in seperatedIP)
                {
                    counter += 1;
                }
                //If the counter is greater than 4 or less than 4: isValid = false
                if (counter < 4 | counter > 4)
                {
                    isValid = false;
                }
            }
            //Return isValid
            return isValid;
        }
    }
}
