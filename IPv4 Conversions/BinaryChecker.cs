/* Adam Bockhorst
 * 2/26/2022
 * Converting IPv4 Addresses to binary
 * Converting binary numbers to IPv4 Addresses
 */
using System;

namespace IPv4_Conversions
{
    /// <summary>
    /// This class checks to see if the binary number is valid
    /// </summary>
    class BinaryChecker
    {
        /// <summary>
        /// Checks to see if the binary number is valid
        /// </summary>
        /// <param name="binaryNumber">The binary number to be checked</param>
        /// <returns>True if the binary number is valid, false otherwise</returns>
        public Boolean binaryChecker(string binaryNumber)
        {
            ////Set a Boolean to true
            Boolean isValid = true;

            //Declare and instantiate an Array to know how to seperate the binary
            //The binary number will be seperated after every period (.), comma (,), space ( ), or dash (-)
            char[] delimiterChars = {'.'};

            //Declare and instantiate an Array to hold the parts of the seperated binary number
            //Split the binary number into 4 parts
            string[] seperatedIP = binaryNumber.Split(delimiterChars);

            //foreach loop to loop through each part of the seperated binary number
            foreach (string section in seperatedIP)
            {
                //Declare an Array
                //Instantiate the Array to split the section into single characters
                char[] character = section.ToCharArray();
                
                //If the section length is greater than 8: isValid = false
                //If the section length is less than 0: isValid = true
                if (character.Length > 8 | character.Length < 1)
                {
                    isValid = false;
                    break;
                }
                if (isValid == true)
                {
                    //for loop to loop through the section
                    for (int i = 0; i < 8; i++)
                    {
                        //If the character in the section at i equals 1 or 0: isValid = true
                        //Else isValid = false and break from loop
                        if (character[i].Equals('1') | character[i].Equals('0'))
                        {
                            isValid = true;
                        }
                        else
                        {
                            isValid = false;
                            break;
                        }
                    }
                }
            }
            return isValid;
        }
    }
}
