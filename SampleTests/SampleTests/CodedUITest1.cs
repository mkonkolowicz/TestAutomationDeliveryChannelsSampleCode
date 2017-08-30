using System;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SampleTests
{
    /// <summary>
    /// Launch Notepad Test
    /// </summary>
    [CodedUITest]
    public class NotepadShould
    {
        private string notepadLocation = Environment.ExpandEnvironmentVariables("%windir%") + "\\system32\\notepad.exe";
        System.Diagnostics.Process notepad; 
        public NotepadShould()
        {
        }
        [TestInitialize]
        public void startNotepad()
        {
            notepad = System.Diagnostics.Process.Start(notepadLocation);
        }
        [TestMethod]
        public void Launch()
        {
            Assert.IsTrue(notepad != null);
        }
        [TestCleanup]
        public void killNotepad()
        {
            notepad.Close();
        }

        
    }
}
