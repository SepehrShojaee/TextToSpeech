using System;
using System.Collections.Generic;
using System.Linq;
using System.Speech.Synthesis;
using System.Text;
using System.Threading.Tasks;


namespace TextTooSpeechRecognation
{
    class Program
    {
        static void Main(string[] args)
        {
            string text;
            Console.WriteLine("Enter the text to speech and press Enter:");
            text = Console.ReadLine();
            SpeechSynthesizer speechSynthesizer = new SpeechSynthesizer();
            speechSynthesizer.SetOutputToDefaultAudioDevice();
            
            speechSynthesizer.Speak(text);
            Console.WriteLine("Press any key...");
            Console.ReadKey();
        }
    }
}
