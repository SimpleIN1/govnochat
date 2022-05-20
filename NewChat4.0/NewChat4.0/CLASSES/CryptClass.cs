using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;


namespace NewChat4._0
{
    class CryptClass
    {
        private string _dataString;
        public CryptClass(string dataString)
        {
            this._dataString = dataString;
        }
        public string getEncryptingData()
        {
            return getHash();
        }
        private string getHash()
        {
            using (var hash = SHA512.Create())
            {
                return string.Concat(hash.ComputeHash(Encoding.UTF8.
                GetBytes("Q#Ff!#№F+Fef+_(DASd9" + _dataString + "C@@_kp/,dqw[_..<_+LD@Wd")).
                Select(x => x.ToString("X2")));
            }
        }
    }
}
