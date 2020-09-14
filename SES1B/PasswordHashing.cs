using System;
namespace SES1B.Models
{
    public class PasswordHasing
    {
        public PasswordHasing()
        {
        }

        //Source https://www.youtube.com/watch?v=AU-4oLUV5VU 

        pubic String createSalt(int size) {
            var rng = new System.Security.Cryptography.RNGCryptoServiceProvider();
            var buff = new byte[size];
            rng.GetBytes(buff);
            return Convert.ToBase64String(buff);
        }

        


    }

}
