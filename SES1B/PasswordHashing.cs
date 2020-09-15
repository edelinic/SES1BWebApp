using System;
using System.Security.Cryptography;
using System.Text;

namespace SES1B.Models
{
    public class PasswordHasing
    {
        public PasswordHasing()
        {
        }

        //Source https://www.youtube.com/watch?v=AU-4oLUV5VU 

        //Source is likely to change, just wanted to get a start on this. 

      //Creates the salt (random data) that is necessary to hash passwords.
      //Basically, salt is used to add random data to the input of a hash function to guarantee a unique output(in this case, a hashed password)

        public string createSalt(int size) {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        public string GenerateHash(string input, string salt)
        { 
            byte[] bytes = Encoding.UTF8.GetBytes(input + salt);
            SHA256Managed sHA256ManagedString = new SHA256Managed();
            byte[] hash = sHA256ManagedString.ComputeHash(bytes);
            Console.WriteLine(Convert.ToBase64String(hash));
            return Convert.ToBase64String(hash);

        }

        



    }

}
