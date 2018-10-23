using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationCipher
{
    class EnigmaCaesar : IEnigma
    {
        public string encryptInformation(Message message)
        {
            char[] alphabet = { 'a', 'ą', 'b', 'c', 'ć', 'd', 'e', 'ę', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'ł', 'm', 'n', 'ń', 'o', 'ó', 'p', 'q', 'r', 's', 'ś', 't', 'u', 'v', 'w', 'x', 'y', 'z', 'ź', 'ż' };

            message.InformationToEncrypt = message.InformationToEncrypt.ToLower();
            Console.WriteLine("Twoja wiadomość to: " + message.InformationToEncrypt);
            char[] messageToEncrypt = message.InformationToEncrypt.ToCharArray();

            for(int counter = 0; counter < messageToEncrypt.Length; counter++)
            {

                char messageElementToEncrypt = messageToEncrypt[counter];

                for (int alphabetCounter = 0; alphabetCounter < alphabet.Length; alphabetCounter++)
                {

                    char elementOfAlphabet = alphabet[alphabetCounter];

                    if (messageElementToEncrypt == elementOfAlphabet)
                    {

                        if (alphabetCounter == (alphabet.Length - 1))
                        {
                            alphabetCounter -= (alphabet.Length-1);
                            messageToEncrypt[counter] = alphabet[alphabetCounter + 2];
                            break;
                        }
                        else if(alphabetCounter == (alphabet.Length - 2))
                        {
                            alphabetCounter -= (alphabet.Length - 2);
                            messageToEncrypt[counter] = alphabet[alphabetCounter + 1];
                            break;
                        }
                        else if(alphabetCounter == (alphabet.Length - 3))
                        {
                            alphabetCounter -= (alphabet.Length - 3);
                            messageToEncrypt[counter] = alphabet[alphabetCounter];
                            break;
                        }

                        messageToEncrypt[counter] = alphabet[alphabetCounter + 3];
                        break;
                    }
                }
            }
            
            return new string(messageToEncrypt);
        }
    }
}
