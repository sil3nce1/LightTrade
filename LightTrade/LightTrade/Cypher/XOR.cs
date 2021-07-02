using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LightTrade.Cypher
{
    public static class XOR
    {
        public static string EncryptDecrypt(string szPlainText, Int64 szEncryptionKey)
        {
            StringBuilder szInputStringBuild = new StringBuilder(szPlainText);
            StringBuilder szOutStringBuild = new StringBuilder(szPlainText.Length);
            char Textch;
            for (int iCount = 0; iCount < szPlainText.Length; iCount++)
            {
                Textch = szInputStringBuild[iCount];
                Textch = (char)(Textch ^ szEncryptionKey);
                szOutStringBuild.Append(Textch);
            }
            return szOutStringBuild.ToString();
        }

        public static string EncryptDecrypt(string szPlainText, string secretKey)
        {
            return EncryptDecrypt(szPlainText, Alphabet.GetAlphabetScore(secretKey));
        }
    }
}
