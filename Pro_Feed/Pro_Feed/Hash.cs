using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Pro_Feed
{
    class Hash
    {
        private int saltSize = 16;
        private int hashSize = 20;

        public string HashPassword(string password, int iterations)
        {
            // create salz
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[saltSize]);

            // create hash
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            var hash = pbkdf2.GetBytes(hashSize);

            // combine salt and hash
            var hashBytes = new byte[saltSize + hashSize];
            Array.Copy(salt, 0, hashBytes, 0, saltSize);
            Array.Copy(hash, 0, hashBytes, saltSize, hashSize);

            // convert to base64
            var base64Hash = Convert.ToBase64String(hashBytes);

            // format hash with extra information
            return string.Format("$MYHASH$V1${0}${1}", iterations, base64Hash);
        }

        // Creates Hash DU stinkst Luki
        public string HashPassword(string password)
        {
            return HashPassword(password, 1000);
        }

        // Verify password against a hash
        public bool Verify(string password, string hashedpassword)
        {
            // extract iteration and Base64 string
            var splittedHashString = hashedpassword.Replace("$MYHASH$V1$", "").Split('$');
            var iterations = int.Parse(splittedHashString[0]);
            var base64Hash = splittedHashString[1];

            // get hashbytes
            byte[] hashBytes = Convert.FromBase64String(base64Hash);

            // get salt
            var salt = new byte[saltSize];
            Array.Copy(hashBytes, 0, salt, 0, saltSize);

            // create hash with given salt
            var pbkdf2 = new Rfc2898DeriveBytes(password, salt, iterations);
            byte[] hash = pbkdf2.GetBytes(hashSize);

            // get result
            for (int i = 0; i < hashSize; i++)
            {
                if (hashBytes[i + saltSize] != hash[i])
                {
                    return false;
                }
            }

            return true;
        }
    }
}
