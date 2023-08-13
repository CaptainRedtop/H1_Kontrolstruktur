namespace Morsekoden
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Morsecode";

            Console.WriteLine("Write some text and press Enter to convert to Morsecode");
            string userText = Convert.ToString(Console.ReadLine()).ToUpper();
            string morseCode = "";

            foreach (char x in userText)
            {
                switch (x)
                {
                    case 'A':
                        {
                            morseCode += "· — ";
                            break;
                        }
                    case 'B':
                        {
                            morseCode += "— · · · ";
                            break;
                        }
                    case 'C':
                        {
                            morseCode += "— · — · ";
                            break;
                        }
                    case 'D':
                        {
                            morseCode += "— · · ";
                            break;
                        }
                    case 'E':
                        {
                            morseCode += "· ";
                            break;
                        }
                    case 'F':
                        {
                            morseCode += "· · — · ";
                            break;
                        }
                    case 'G':
                        {
                            morseCode += "— — · ";
                            break;
                        }
                    case 'H':
                        {
                            morseCode += "· · · · ";
                            break;
                        }
                    case 'I':
                        {
                            morseCode += "· · ";
                            break;
                        }
                    case 'J':
                        {
                            morseCode += "· — — — ";
                            break;
                        }
                    case 'K':
                        {
                            morseCode += "· — ";
                            break;
                        }
                    case 'L':
                        {
                            morseCode += "· — · · ";
                            break;
                        }
                    case 'N':
                        {
                            morseCode += "— · ";
                            break;
                        }
                    case 'M':
                        {
                            morseCode += "— — ";
                            break;
                        }
                    case 'O':
                        {
                            morseCode += "— — — ";
                            break;
                        }
                    case 'P':
                        {
                            morseCode += "· — — · ";
                            break;
                        }
                    case 'Q':
                        {
                            morseCode += "— — · — ";
                            break;
                        }
                    case 'R':
                        {
                            morseCode += "· — · ";
                            break;
                        }
                    case 'S':
                        {
                            morseCode += "· · · ";
                            break;
                        }
                    case 'T':
                        {
                            morseCode += "— ";
                            break;
                        }
                    case 'U':
                        {
                            morseCode += "· · — ";
                            break;
                        }
                    case 'V':
                        {
                            morseCode += "· · · — ";
                            break;
                        }
                    case 'W':
                        {
                            morseCode += "· — — ";
                            break;
                        }
                    case 'X':
                        {
                            morseCode += "— · · — ";
                            break;
                        }
                    case 'Y':
                        {
                            morseCode += "— · — — ";
                            break;
                        }
                    case 'Z':
                        {
                            morseCode += "— — · · ";
                            break;
                        }
                    case 'Æ':
                        {
                            morseCode += "· — · — ";
                            break;
                        }
                    case 'Ø':
                        {
                            morseCode += "— — — · ";
                            break;
                        }
                    case 'Å':
                        {
                            morseCode += "· — — · — ";
                            break;
                        }
                    case ' ':
                        {
                            morseCode += "       ";
                            break;
                        }
                    case '0':
                        {
                            morseCode += "— — — — — ";
                            break;
                        }
                    case '1':
                        {
                            morseCode += "· — — — — ";
                            break;
                        }
                    case '2':
                        {
                            morseCode += "· · — — — ";
                            break;
                        }
                    case '3':
                        {
                            morseCode += "· · · — — ";
                            break;
                        }
                    case '4':
                        {
                            morseCode += "· · · · — ";
                            break;
                        }
                    case '5':
                        {
                            morseCode += "· · · · · ";
                            break;
                        }
                    case '6':
                        {
                            morseCode += "— · · · · ";
                            break;
                        }
                    case '7':
                        {
                            morseCode += "— — · · · ";
                            break;
                        }
                    case '8':
                        {
                            morseCode += "— — — · · ";
                            break;
                        }
                    case '9':
                        {
                            morseCode += "— — — — · ";
                            break;
                        }
                    case '.':
                        {
                            morseCode += "· — · — · — ";
                            break;
                        }
                    case ',':
                        {
                            morseCode += " — · · — — ";
                            break;

                        }
                    case ':':
                        {
                            morseCode += "— — — · · · ";
                            break;
                        }
                    case '?':
                        {
                            morseCode += "· · — — · · ";
                            break;
                        }
                    case '-':
                        {
                            morseCode += "— · · · · — ";
                            break;
                        }
                    case '/':
                        {
                            morseCode += "— · · — · ";
                            break;
                        }
                    case '(':
                        {
                            morseCode += "— · — — · ";
                            break;
                        }
                    case ')':
                        {
                            morseCode += "— · — — · — ";
                            break;
                        }
                    case '"':
                        {
                            morseCode += "· — · · — · ";
                            break;
                        }
                    case '@':
                        {
                            morseCode += "· — — · — · ";
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            Console.WriteLine(morseCode);
            Console.ReadKey();
        }
    }
}