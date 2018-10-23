using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InformationCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Message message = new Message();
            Information(message);
            message.DateOfSendingTheMessage = DateTime.Now;

            Console.WriteLine("Data nadania wiadomości to: " + message.DateOfSendingTheMessage);
            EnigmaCaesar CaesarsCipher = new EnigmaCaesar();
            EnigmaMors MorsCipher = new EnigmaMors();

            ChoiceTypeOfEncryption(message, CaesarsCipher, MorsCipher);
            
            Console.Read();
        }

        static void Information(Message message) 
        {
            string yourInformation = "";

            do
            {
                Console.WriteLine("Podaj informację do zaszyfrowania do 20 znaków");
                yourInformation = Console.ReadLine();

                if (yourInformation.Length > 20)
                {
                    Console.WriteLine("Twoja informacja może zawierać tylko 20 znaków!");
                }
                else if (yourInformation.Length == 0)
                {
                    Console.WriteLine("Aby zaszyfrować informacje musi zawierać znaki");
                }
                else if (yourInformation == " ")
                {
                    Console.WriteLine("Informacja nie może składać się tylko ze spacji");
                }
            } while (yourInformation.Length == 0 || yourInformation == " " || yourInformation.Length > 20);

            message.InformationToEncrypt = yourInformation;
        }

        static void ChoiceTypeOfEncryption(Message message, EnigmaCaesar caesarsCipher, EnigmaMors morsCipher)
        {
            

            int userSelection;
            bool leavetheLoop = false;
            do
            {
                Console.WriteLine("Wybierz jakim szyfrem chcesz zakodować swoją informację: ");
                Console.WriteLine("1. Szyfr Cezara");
                Console.WriteLine("2. Szyfr Morse'a");
                Console.WriteLine("3. Zakończ program");

                userSelection = int.Parse(Console.ReadLine());

                switch (userSelection)
                {
                    case 1:
                        
                        Console.WriteLine("Zaszyfrowana wiadomość szyfrem Cezara: " + caesarsCipher.encryptInformation(message));
                        break;
                    case 2:
                        Console.WriteLine("Zaszyfrowana wiadomość kodem Morse'a: " + morsCipher.encryptInformation(message));
                        break;
                    case 3:
                        leavetheLoop = true;
                        break;
                    default:
                        Console.WriteLine("Niestety, na liście nie ma takiego wyboru :(");
                        break;
                }
            } while (leavetheLoop != true);
        }
    }
}
