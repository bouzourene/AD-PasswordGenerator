using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PasswordGenerator
{
    public partial class PasswordGenerator : Form
    {
        public PasswordGenerator()
        {
            InitializeComponent();
        }

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
            string password = "";
            string[] chars;
            chars = new string[8];
            Random r = new Random();

            // Fixer la taille du mot de passe
            int taille = 8;

            // Fixer le nombre de lettres avant les chiffres
            int letters = 4;

            // Le nombre de chiffres se calcule automatiquement en fonction
            // de la longueur du mot de passe et du nombre de lettres
            int numbers = taille - letters;

            // Incrémentation tableau "chars"
            int j = 0;

            // Génération des lettres
            for(int i = 0; i < letters; i++)
            {
                chars[j] = RandomLetter.GetLetter().ToString();
                
                // Première lettre en majuscule
                if(i == 0)
                {
                    chars[j] = chars[j].ToUpper();
                }
                else
                {
                    // On ne veut pas deux fois la même lettre à la suite
                    while (chars[j].Equals(chars[j-1].ToLower()))
                    {
                        //Console.Write(chars[j - 1] + chars[j]);
                        chars[j] = RandomLetter.GetLetter().ToString();
                        //Console.WriteLine(" -> " + chars[j - 1] + chars[j]);
                    }
                }

                j++;
            }

            // Génération des chiffres
            for (int i = 0; i < numbers; i++)
            {
                chars[j] = r.Next(0, 10).ToString();

                if (j > letters)
                {
                    // On ne veut pas deux fois le même chiffre à la suite
                    while (chars[j].Equals(chars[j - 1]))
                    {
                        //Console.Write(chars[j - 1] + chars[j]);
                        chars[j] = r.Next(0, 10).ToString();
                        //Console.WriteLine(" -> " + chars[j - 1] + chars[j]);
                    }
                }

                j++;
            }

            // Transformer le tableau "chars" en un string "password"
            for (int i = 0; i < 8; i++)
            {
                password = password + chars[i];
            }

            // Copier le mot de passe dans le presse papier
            Clipboard.SetText(password);

            // Afficher le mot de passe dans la fenêtre
            textBox1.Text = password;
        }

        private void PasswordGenerator_Load(object sender, EventArgs e)
        {
            // Afficher ce texte dans le champ mot de passe
            textBox1.Text = "-------------";
        }
    }
}
