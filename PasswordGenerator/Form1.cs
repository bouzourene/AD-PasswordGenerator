using System;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

        // https://www.dotnetperls.com/random-lowercase-letter
        static class RandomLetter
        {
            static Random _random = new Random();

            public static char GetLetter()
            {
                // This method returns a random lowercase letter.
                // ... Between 'a' and 'z' inclusize.
                int num = _random.Next(0, 26); // Zero to 25
                char let = (char)('a' + num);
                return let;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Set how many letters and numbers you want
            int letters = 4;
            int numbers = 4;

            // Initialize variables
            int j = 0;
            string password = "";
            string[] chars;
            chars = new string[8];
            Random r = new Random();

            // Letters generation
            for (int i = 0; i < letters; i++)
            {
                chars[j] = RandomLetter.GetLetter().ToString();
                
                // First letter is upper 
                if(i == 0)
                {
                    chars[j] = chars[j].ToUpper();
                }
                else
                {
                    // We don't want the same chars to be next to each other
                    while (chars[j].Equals(chars[j-1].ToLower()))
                    {
                        chars[j] = RandomLetter.GetLetter().ToString();
                    }
                }

                j++;
            }

            // Numbers generation
            for (int i = 0; i < numbers; i++)
            {
                chars[j] = r.Next(0, 10).ToString();

                if (j > letters)
                {
                    // We don't want the same numbers to be next to each other
                    while (chars[j].Equals(chars[j - 1]))
                    {
                        chars[j] = r.Next(0, 10).ToString();
                    }
                }

                j++;
            }

            // Transform chars array in a single string
            for (int i = 0; i < 8; i++)
            {
                password = password + chars[i];
            }

            // Copy password in clipboard
            Clipboard.SetText(password);

            // Show password in the textbox
            textBox1.Text = password;
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            // Show this text when no password is generated yet
            textBox1.Text = "-------------";
        }
    }
}
