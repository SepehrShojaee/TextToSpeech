using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using STT = TextToSpeech.Model.SpeechToText;
using TTS = TextToSpeech.Model.TextToSpeech;

namespace SpeechToText_Unit_Test
{
    [TestClass]
    public class SpeechToText
    {

        [TestMethod]
        public void is_Recognize()
        {
            try
            {
                string path = "C:\\temp\\A.wav";
                string recognized_Text = STT.Recognize_From_Audio_File(path);

                Assert.IsNotNull(recognized_Text);
            }
            catch (Exception)
            {

                Assert.Fail(); ;
            }

        }
        [TestMethod]
        public void Compare_Speeched_and_Recognized()
        {

            string path = "C:\\temp\\A.wav";
            string actual_Text = "Hello my friend";
            TTS.Save(actual_Text, path);

            string expected_Text = STT.Recognize_From_Audio_File(path);

            Assert.AreEqual(actual_Text.ToLower().Trim(), expected_Text);


        }

    }
}
