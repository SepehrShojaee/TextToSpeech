using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TextToSpeech.View.WinForm;

namespace WinForm_UnitTest
{
    [TestClass]
    public class WinFormTest
    {
        [TestMethod]
        public void FormObjectTest()
        {
            frm_Main_Speech form = new frm_Main_Speech();
            Assert.IsNotNull(form);
            Assert.IsInstanceOfType(form, typeof(frm_Main_Speech));
        }
    }
}
