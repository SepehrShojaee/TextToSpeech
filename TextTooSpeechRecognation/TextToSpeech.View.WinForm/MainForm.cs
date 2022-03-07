using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using TTS=TextToSpeech.Model.TextToSpeech;
using STT = TextToSpeech.Model.SpeechToText;

namespace TextToSpeech.View.WinForm
{
    public partial class frm_Main_Speech : Form
    {
        public frm_Main_Speech()
        {
            InitializeComponent();
        }
        public bool ValidateInputs()
        {
            if (txt_Speech.Text.Trim() != "")
            {
                return true;

            }else
            {
                MessageBox.Show("Please input Text");
                return false;
                
            }
        }
        private void Btn_Speech_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
                TTS.Speak(txt_Speech.Text);
        }



        private void Btn_Save_Click(object sender, EventArgs e)
        {
            if (ValidateInputs())
            { 
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                saveFileDialog1.Filter = "Wav Files|*.wav";
                saveFileDialog1.Title = "Save Text To Audio File";
                DialogResult Result= saveFileDialog1.ShowDialog();
                if (Result==DialogResult.OK)
                {
                    TTS.Save(txt_Speech.Text,saveFileDialog1.FileName);
                    MessageBox.Show("File saved successfully.");

                }
            }


        }




        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Recognize_Click(object sender, EventArgs e)
        {
            txt_Speech.Text = "Recognizing...";
            txt_Speech.Enabled = false;
            txt_Speech.Text = STT.Recognize_From_Audio_Device();
            txt_Speech.Enabled = true;
        }
    }
}
