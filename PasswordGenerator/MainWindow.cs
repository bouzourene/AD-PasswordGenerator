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

        private void button1_Click(object sender, EventArgs e)
        {
            PassGenerator gen = new PassGenerator();
            String password = "";

            password = gen.getPassword();

            // Copy password in clipboard
            Clipboard.SetText(password);

            // Show password in the textbox
            textBox1.Text = password;
            
            // Enable "Copy" button if disabled
            if (button2.Enabled == false) button2.Enabled = true;
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            // Show this text when no password is generated yet
            textBox1.Text = "-------------";
            
            // Disable "Copy" button until the password is generated
            button2.Enabled = false;
        }
        
		void Button2Click(object sender, EventArgs e)
		{
			 // Copy password in clipboard
            Clipboard.SetText(textBox1.Text);
		}
    }
}
