/* Adam Bockhorst
 * 2/26/2022
 * Converting IPv4 Addresses to binary
 * Converting binary numbers to IPv4 Addresses
 */namespace IPv4_Conversions
{
    /// <summary>
    /// This class converts binary to IPv4 address
    /// </summary>
    class BinarytoIP
    {
        /// <summary>
        /// Convert binary to IPv4
        /// </summary>
        /// <param name="binary">The binary number to convert to IP address</param>
        /// <returns>The ipAddress</returns>
        public string binaryConversion(string binary)
        {
            //Set the ipAddress to an empty string
            string ipAddress = "";

            //Declare and instantiate an Array to know how to seperate the binary
            //The binary number will be seperated after every period (.), comma (,), space ( ), or dash (-)
            char[] delimiterChars = {'.'};

            //Declare and instantiate an Array to hold the parts of the seperated binary number
            //Split the binary number into 4 parts
            string[] seperatedBinary = binary.Split(delimiterChars);

            //foreach loop to loop through each part of the seperated binary number
            foreach (string section in seperatedBinary)
            {
                //Set the bit to 128
                int bit = 128;

                //Set the IPsection to 0
                int IPsection = 0;

                //Declare an Array
                //Instantiate the Array to split the section into single characters
                char[] character = section.ToCharArray();

                //For loop to step through every character
                for (int i = 0; i < 8; i++)
                {
                    //Work left to right following a binary number chart
                    //If the character is a 1 then add the bit size to the IPsection
                    //Divide the bit by 2
                    if (character[i].Equals('1'))
                    {
                        IPsection += bit;
                        bit /= 2;
                    }
                    //If the character is not a 1, just divide the bit by 2
                    else
                    {
                        bit /= 2;
                    }
                }
                //Format the ipAddress with a period (.)
                ipAddress += IPsection + ".";
            }
            //Trim the period off of the final ipAddress
            ipAddress = ipAddress.TrimEnd('.');

            return ipAddress;
        }
    }
}
