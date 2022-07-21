using System;

namespace RSA
{
    class RSA
    {
        public static BigInteger Encrypt(BigInteger M, BigInteger E, BigInteger N)
        {
            return BigInteger.ModOfPower(M, E, N);
        }

        public static BigInteger Decrypt(BigInteger EofM, BigInteger D, BigInteger N)
        {
            return BigInteger.ModOfPower(EofM, D, N);
        }

        //====================
        // *BONUS* Your Code is Here:
        //===================
        /// <summary>
        /// TODO: *BONUS* Adjust RSA to work with strings rather than integers. Note that string size is unknown
        /// This function takes a string to encrypt(along with required parameters for RSA encryption algorithm)
        /// The function should return the encrypted message as string
        /// </summary>
        /// <param name="M">a string, the text message to encrypt</param>
        /// <param name="E">a big integer, the public key</param>
        /// <param name="N">a big integer, the modulus</param>
        /// <returns>a string, the ecrypted message</returns>
        public static string EncryptText(string M, BigInteger E, BigInteger N)
        {
            throw new NotImplementedException();
        }


        //====================
        // *BONUS* Your Code is Here:
        //===================
        /// <summary>
        /// TODO: *BONUS* Adjust RSA to work with strings rather than integers. Note that string size is unknown
        /// This function takes a string to decrypt (along with required parameters for RSA encryption algorithm)
        /// The function should return the decrypted message as string
        /// </summary>
        /// <param name="EofM">a string, the encrypted message to decrypt</param>
        /// <param name="D">a big integer, the private key</param>
        /// <param name="N">a big integer, the modulus</param>
        /// <returns>a string, the decrypted message</returns>
        public static BigInteger Decrypt(string EofM, BigInteger D, BigInteger N)
        {
            throw new NotImplementedException();
        }
    }
}
