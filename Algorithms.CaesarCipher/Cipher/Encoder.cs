using System;
using System.Linq;
using System.Text;
using static System.Char;
using static Algorithms.CaesarCipher.Cipher.Decoder;

namespace Algorithms.CaesarCipher.Cipher
{
    public static class Encoder
    {
        public static string Encode(string text, int shift)
        {
            var decodedAlphabet = DecodeAlphabet(shift);
            var builder = new StringBuilder(text.Length);

            foreach (var item in text)
            {
                if (decodedAlphabet.Contains(ToUpper(item)))
                {
                    var index = Array.IndexOf(decodedAlphabet, ToUpper(item));

                    switch (IsLower(item))
                    {
                        case true:
                            builder.Append(Alphabet[index].ToString().ToLower());
                            break;
                        default:
                            builder.Append(Alphabet[index]);
                            break;
                    }
                    
                    continue;
                }

                builder.Append(item);
            }

            return builder.ToString();
        }
    }
}