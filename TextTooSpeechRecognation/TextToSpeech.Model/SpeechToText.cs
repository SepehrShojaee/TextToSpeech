using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Recognition;

namespace TextToSpeech.Model
{
    public abstract class SpeechToText
    {
        private static SpeechRecognitionEngine _speech_Enginge { get; set; }
        public static string Recognize_From_Audio_File(string path)
        {
            using (_speech_Enginge = new SpeechRecognitionEngine())
            {
                try
                {
                    Grammar gr = new DictationGrammar();
                    _speech_Enginge.LoadGrammar(gr);
                    _speech_Enginge.SetInputToWaveFile(path);
                    RecognitionResult result = _speech_Enginge.Recognize();
                    return result.Text.ToLower();

                }
                catch (Exception ex)
                {
                    Console.WriteLine("An Error Occured: " + ex.Message);
                    return null;

                }
                finally
                {
                    _speech_Enginge.Dispose();

                }
            };

        }
        public static string Recognize_From_Audio_Device()
        {

            using ( _speech_Enginge =new SpeechRecognitionEngine(new System.Globalization.CultureInfo("en-US")))
                try
                {
                    {

                        // Create and load a dictation grammar.  
                        _speech_Enginge.LoadGrammar(new DictationGrammar());

                        _speech_Enginge.SetInputToDefaultAudioDevice();

                        RecognitionResult recognitionResult = _speech_Enginge.Recognize();
                        // Start asynchronous, continuous speech recognition.  

                        // Keep the console window open.  
                        return recognitionResult.Text;

                    }
                }
                catch (Exception ex)
                {

                    return ex.Message;
                }
                finally
                {
                    _speech_Enginge.Dispose();
                }

        }

    }
}
