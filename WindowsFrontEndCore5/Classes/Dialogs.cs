using System.Windows.Forms;

namespace WindowsFrontEndCore5.Classes
{
    public static class Dialogs
    {
        public static bool Question(string Text)
        {
            return (MessageBox.Show(Text, "Question", 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, 
                MessageBoxDefaultButton.Button2) == DialogResult.Yes);
        }
    }
}
