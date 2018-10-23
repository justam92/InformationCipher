using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationCipher
{
    class EnigmaMors : IEnigma
    {
        public string encryptInformation(Message message)
        {
            Dictionary<char, string> dictionary = new Dictionary<char, string>();
            dictionary.Add('a', "*-");
            dictionary.Add('ą', "*-*-");
            dictionary.Add('b', "-***");
            dictionary.Add('c', "-*-*");
            dictionary.Add('ć', "-*-**");
            dictionary.Add('d', "-**");
            dictionary.Add('e', "*");
            dictionary.Add('ę', "**-**");
            dictionary.Add('f', "**-*");
            dictionary.Add('g', "--*");
            dictionary.Add('h', "****");
            dictionary.Add('i', "**");
            dictionary.Add('j', "*---");
            dictionary.Add('k', "-*-");
            dictionary.Add('l', "*-**");
            dictionary.Add('ł', "*-**-");
            dictionary.Add('m', "--");
            dictionary.Add('n', "-*");
            dictionary.Add('ń', "--*--");
            dictionary.Add('o', "---");
            dictionary.Add('ó', "---*");
            dictionary.Add('p', "*--*");
            dictionary.Add('q', "--*-");
            dictionary.Add('r', "*-*");
            dictionary.Add('s', "***");
            dictionary.Add('ś', "***-***");
            dictionary.Add('t', "-");
            dictionary.Add('u', "**-");
            dictionary.Add('v', "***-");
            dictionary.Add('w', "*--");
            dictionary.Add('x', "-**-");
            dictionary.Add('y', "-*--");
            dictionary.Add('z', "--**");
            dictionary.Add('ź', "--**-");
            dictionary.Add('ż', "--**-*");
            dictionary.Add(' ', " ");

            message.InformationToEncrypt = message.InformationToEncrypt.ToLower();
            Console.WriteLine("Twoja wiadomość to: " + message.InformationToEncrypt);
            char[] messageToEncrypt = message.InformationToEncrypt.ToCharArray();

            char messageElement;
            string morsCodeElement = "";
            string encryptedMessageWithMorsCode = "";

            for(int counter = 0; counter < messageToEncrypt.Length; counter++)
            {
                messageElement = messageToEncrypt[counter];
                morsCodeElement = dictionary[messageElement];

                encryptedMessageWithMorsCode += morsCodeElement;
                
            }
            return encryptedMessageWithMorsCode;
        }
    }
}
