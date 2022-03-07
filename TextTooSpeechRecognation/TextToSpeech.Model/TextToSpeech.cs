using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;

namespace TextToSpeech.Model
{

    public class TextToSpeech
    {

        #region Properties
        private static SpeechSynthesizer _speech_Enginge { get; set; }
        #endregion
        public string input_Text { get; set; }

        public virtual bool Speak()
        {
            try
            {
                using (_speech_Enginge = new SpeechSynthesizer())
                {
                    _speech_Enginge.SetOutputToDefaultAudioDevice();

                    _speech_Enginge.Speak(input_Text.Trim());
                    return true;

                };

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                _speech_Enginge.Dispose();
            }
            
        }
        public static bool Speak( string text)
        {

           
            try
            {
                using (_speech_Enginge = new SpeechSynthesizer())
                {
                    _speech_Enginge.SetOutputToDefaultAudioDevice();
                    
                    _speech_Enginge.Speak(text.Trim());
                    return true;

                };

            }
            catch (Exception)
            {

                return false;
            }
            finally
            {
                _speech_Enginge.Dispose();
            }
        }

        public static bool Save(string text,string path)
        {
            try
            {
                using (_speech_Enginge = new SpeechSynthesizer())
                {
                    _speech_Enginge.SetOutputToWaveFile(path);
                    _speech_Enginge.Speak(text.Trim());
                    return true;
                };

            }
            catch (Exception ex)
            {
                Console.WriteLine("An error has occured: " + ex.Message);
                return false;
            }
            finally
            {
                //speech.Dispose();
            }

        }



    }
}
