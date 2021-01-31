using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;

namespace TodoWork
{
    class Sifreleme
    {
        public static byte[] StringToByte(string deger)
        {
            UnicodeEncoding ByteConverter = new UnicodeEncoding();
            return ByteConverter.GetBytes(deger);
        }
        public static byte[] Byte8(string deger)
        {
            char[] arrayChar = deger.ToCharArray();
            byte[] arrayByte = new byte[arrayChar.Length];
            for (int i = 0; i < arrayByte.Length; i++)
            {
                arrayByte[i] = Convert.ToByte(arrayChar[i]);
            }
            return arrayByte;
        }


        public string RijndaelSifrele(string strGiris)
        {
            string sonuc = "";
            if (strGiris == "" || strGiris == null)
            {
                throw new ArgumentNullException("veri yok.");
            }
            else
            {
                byte[] aryKey = Byte8("uesf8CAs");
                byte[] aryIV = Byte8("8+BmFLXOvsImjCTE");
                RijndaelManaged dec = new RijndaelManaged();
                dec.Mode = CipherMode.CBC;
                MemoryStream ms = new MemoryStream();
                CryptoStream cs = new CryptoStream(ms, dec.CreateEncryptor(aryKey, aryIV), CryptoStreamMode.Write);
                StreamWriter writer = new StreamWriter(cs);
                writer.Write(strGiris);
                writer.Flush();
                cs.FlushFinalBlock();
                writer.Flush();
                sonuc = Convert.ToBase64String(ms.GetBuffer(), 0, (int)ms.Length);
                writer.Dispose();
                cs.Dispose();
                ms.Dispose();
            }
            return sonuc;
        }

        //public string RijndaelCoz(string strGiris)
        //{
        //    string strSonuc = "";
        //    if (strGiris == "" || strGiris == null)
        //    {
        //        throw new ArgumentNullException("veri yok.");
        //    }
        //    else
        //    {
        //        byte[] aryKey = Byte8("uesf8CAs");
        //        byte[] aryIV = Byte8("8+BmFLXOvsImjCTE");
        //        RijndaelManaged cp = new RijndaelManaged();
        //        MemoryStream ms = new MemoryStream(Convert.FromBase64String(strGiris));
        //        CryptoStream cs = new CryptoStream(ms, cp.CreateDecryptor(aryKey, aryIV), CryptoStreamMode.Read);
        //        StreamReader reader = new StreamReader(cs);
        //        strSonuc = reader.ReadToEnd();
        //        reader.Dispose();
        //        cs.Dispose();
        //        ms.Dispose();
        //    }
        //    return strSonuc;
        //}
    }
}
