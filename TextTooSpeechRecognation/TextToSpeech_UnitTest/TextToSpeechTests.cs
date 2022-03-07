using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TTS = TextToSpeech.Model.TextToSpeech;
using STT = TextToSpeech.Model.SpeechToText;
namespace TexToSpeech_Unit_Test
{

    [TestClass]
    public class TextToSpeech
    {
        [TestMethod]
        public void Is_Speaked()
        {
            bool is_Speaked_Result = TTS.Speak("Hello");
            Assert.IsTrue(is_Speaked_Result);
        }
        [TestMethod]
        public void iS_Audio_Saved()
        {
            bool is_Saved_Result = TTS.Save("my name", "C:\\temp\\A.wav");
            Assert.IsTrue(is_Saved_Result);
        }

    }


}
