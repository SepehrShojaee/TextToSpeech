using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;
using STT = TextToSpeech.Model.SpeechToText;
using TTS = TextToSpeech.Model.TextToSpeech;

namespace TextTooSpeechRecognation
{
    class Program
    {

        static void Main(string[] args)
        {
            string input_Text;
            string path;
            while (true)
            {
                MainMenu:
                Console.Clear();
                Console.WriteLine("Welcome to Text To Speech:");
                Console.WriteLine("-----------Speech To Text----------");
                Console.WriteLine("For text to speech (TTS) Press 1:");
                Console.WriteLine("For save speech to .Wav file press 2:");
                Console.WriteLine("-----------Text To Speech----------");
                Console.WriteLine("For speech to text from .Wav file (STT) recognizer press 3:");
                Console.WriteLine("For speech to text from Mic (STT) recognizer press 4:");
                Console.WriteLine("EXIT press 5:");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Enter the Text:");
                        input_Text = Console.ReadLine();
                        TTS.Speak(input_Text);
                        Console.WriteLine("Text Speaked Successfully.\nPress Any Key to go to MainMenu....");
                        Console.ReadKey();
                        goto MainMenu;
                        
                    case "2":
                        Console.WriteLine("Enter the Text:");
                        input_Text = Console.ReadLine();
                        Console.WriteLine("Enter Path:");
                        path = Console.ReadLine();
                        if (TTS.Save(input_Text, path) == true)
                        {
                            Console.WriteLine($"Text Saved Successfully in {path} .\nPress Any Key to go to MainMenu....");

                        }

                        Console.ReadKey();

                        goto MainMenu;
                    case "3":
                        Console.WriteLine("Enter the Path:");
                        path = Console.ReadLine();
                        input_Text = STT.Recognize_From_Audio_File(path);
                        if (input_Text!=null || input_Text!="")
                        {
                            Console.WriteLine($"Recognized  '{input_Text}'\nPress Any Key to go to MainMenu....");

                        }
                        Console.ReadKey();
                        goto MainMenu;

                    case "4":
                        Console.WriteLine("Recognizing");
                        Recognizing:
                        input_Text = STT.Recognize_From_Audio_Device();
                        if (input_Text != null || input_Text != "")
                        {
                            Console.WriteLine($"Recognized  '{input_Text}'\nPress Any Key to go to MainMenu....");

                        }else
                        {
                            Console.WriteLine("Try Again.");
                            Console.ReadKey();
                            goto Recognizing;

                        }
                        Console.ReadKey();

                        goto MainMenu;
                    case "5":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Option");
                        goto MainMenu;
                }
            }

             
        }


}
}
