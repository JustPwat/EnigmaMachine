using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnigmaInterfaceINF1433
{
    public partial class Enigma : Form
    {
        public Enigma()
        {
            InitializeComponent();
        }

        Rotors Rotor1 = new Rotors();
        Rotors Rotor2 = new Rotors();
        Rotors Rotor3 = new Rotors();

        string encryptionMessage;
        string decryptionMessage;
        char[] encryptionChars;
        char[] decryptionChars;

        int compteEncrypt = 0;
        int compteDecrypt = 0;
        int positionr1;
        int positionr2;
        int positionr3;

        int decalR1;
        int decalR2;
        int decalR3;
        int[] positionRotor;



        public List<Label> reflecteur = new List<Label>();
        Label[] rotor1Hautt = new Label[25];
        public List<Label> rotor1Haut = new List<Label>();
        Label[] rotor1Bass = new Label[25];
        public List<Label> rotor1Bas = new List<Label>();

        Label[] rotor2Hautt = new Label[25];
        public List<Label> rotor2Haut = new List<Label>();
        Label[] rotor2Bass = new Label[25];
        public List<Label> rotor2Bas = new List<Label>();

        Label[] rotor3Hautt = new Label[25];
        public List<Label> rotor3Haut = new List<Label>();
        Label[] rotor3Bass = new Label[25];
        public List<Label> rotor3Bas = new List<Label>();

        Label[] lettre = new Label[25];
        public List<Label> lettres = new List<Label>();


        // Initialisation des listes de Labels
        public void initialiseReflecteur()
        {
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "reflecteur" + i).FirstOrDefault();
                if (label != null)
                    reflecteur.Add(label);
            }
        }

        public void initialiseRotor1Haut()
        {
           /* for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "rotor1Haut" + i).FirstOrDefault();
                if (label != null)
                    rotor1Haut.Add(label);
            }*/
           for(int i = 0;i < 25; i++)
            {
                rotor1Hautt[i] = rotor1Haut[i];
                rotor1Bass[i] = rotor1Bas[i];
                rotor2Hautt[i] = rotor2Haut[i];
                rotor2Bass[i] = rotor2Bas[i];
                rotor3Hautt[i] = rotor3Haut[i];
                rotor3Bass[i] = rotor3Bas[i];
            }
        }

        public void initialiseRotor1Bas()
        {
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "rotor1Bas" + i).FirstOrDefault();
                if (label != null)
                    rotor1Bas.Add(label);
            }
        }

        public void initialiseRotor2Haut()
        {
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "rotor2Haut" + i).FirstOrDefault();
                if (label != null)
                    rotor2Haut.Add(label);
            }
        }

        public void initialiseRotor2Bas()
        {
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "rotor2Bas" + i).FirstOrDefault();
                if (label != null)
                    rotor2Bas.Add(label);
            }
        }

        public void initialiseRotor3Haut()
        {
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "rotor3Haut" + i).FirstOrDefault();
                if (label != null)
                    rotor3Haut.Add(label);
            }
        }

        public void initialiseRotor3Bas()
        {
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "rotor3Bas" + i).FirstOrDefault();
                if (label != null)
                    rotor3Bas.Add(label);
            }
        }
        
        public void initialiseLettres()
        {
            char[] chars = { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
            for (int i = 0; i < 25; i++)
            {
                var label =
                this.Controls.OfType<Label>().Where(lb => lb.Name == "label" + chars[i]).FirstOrDefault();
                if (label != null)
                    lettres.Add(label);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label117_Click(object sender, EventArgs e)
        {

        }

        private void rotor2Haut13_Click(object sender, EventArgs e)
        {

        }

        private void label148_Click(object sender, EventArgs e)
        {

        }

        public void configureRotor()
        {

        }

        
        // Decalage des Rotors respectifs
        private void decalageR1_ValueChanged(object sender, EventArgs e)
        {
            int decalage = (int)decalageR1.Value;
            Rotor1.Decalage = decalage;
            decalR1 = decalage;
        }

        private void decalageR2_ValueChanged(object sender, EventArgs e)
        {
            int decalage = (int)decalageR2.Value;
            Rotor2.Decalage = decalage;
            decalR2 = decalage;
        }

        private void decalageR3_ValueChanged(object sender, EventArgs e)
        {
            int decalage = (int)decalageR3.Value;
            Rotor3.Decalage = decalage;
            decalR3 = decalage;
        }

        // Position des Rotors
        private void configurerRotor1_ValueChanged(object sender, EventArgs e)
        {
             int rotor1 = (int)configurerRotor1.Value;
            Rotor1.Position = rotor1;
            positionr1 = rotor1;
        }

        private void configurerRotor2_ValueChanged(object sender, EventArgs e)
        {
            int rotor2 = (int)configurerRotor2.Value;
            Rotor2.Position = rotor2;
            positionr2 = rotor2;
        }

        private void configurerRotor3_ValueChanged(object sender, EventArgs e)
        {
            int rotor3 = (int)configurerRotor3.Value;
            Rotor3.Position = rotor3;
            positionr3 = rotor3;
        }

        // CheckBox Gauche ou Droite selectionner
        private void checkBoxG1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkG = false;
            if (checkBoxG1.Checked)
            {
                checkG = true;
                Rotor1.GaucheOuDroite = checkG;
                checkBoxD1.Checked = false;
            }
            
        }

        private void checkBoxD1_CheckedChanged(object sender, EventArgs e)
        {
            bool checkD = false;
            if (checkBoxD1.Checked)
            {
                checkD = true;
                Rotor1.GaucheOuDroite = checkD;
                checkBoxG1.Checked = false;
            }
        }

        private void checkBoxG2_CheckedChanged(object sender, EventArgs e)
        {
            bool checkG = false;
            if (checkBoxG2.Checked)
            {
                checkG = true;
                Rotor2.GaucheOuDroite = checkG;
                checkBoxD2.Checked = false;
            }

        }

        private void checkBoxD2_CheckedChanged(object sender, EventArgs e)
        {
            bool checkD = false;
            if (checkBoxD2.Checked)
            {
                checkD = true;
                Rotor2.GaucheOuDroite = checkD;
                checkBoxG2.Checked = false;
            }
        }

        private void checkBoxG3_CheckedChanged(object sender, EventArgs e)
        {
            bool checkG = false;
            if (checkBoxG3.Checked)
            {
                checkG = true;
                Rotor3.GaucheOuDroite = checkG;
                checkBoxD3.Checked = false;
            }
        }

        private void checkBoxD3_CheckedChanged(object sender, EventArgs e)
        {
            bool checkD = false;
            if (checkBoxD3.Checked)
            {
                checkD = true;
                Rotor3.GaucheOuDroite = checkD;
                checkBoxG3.Checked = false;
            }
        }

        // CheckBox Positif ou Negatif selectionner
        private void checkBox1plus_CheckedChanged(object sender, EventArgs e)
        {
            bool positif = false;
            if (checkBox1plus.Checked)
            {
                positif = true;
                Rotor1.PositifOuNegatif = positif;
                checkBox1minus.Checked = false;
            }
        }

        private void checkBox1minus_CheckedChanged(object sender, EventArgs e)
        {
            bool negatif = false;
            if (checkBox1minus.Checked)
            {
                negatif = false;
                Rotor1.PositifOuNegatif = negatif;
                checkBox1plus.Checked = false;
            }
        }

        private void checkBox2plus_CheckedChanged(object sender, EventArgs e)
        {
            bool positif = false;
            if (checkBox2plus.Checked)
            {
                positif = true;
                Rotor2.PositifOuNegatif = positif;
                checkBox2minus.Checked = false;
            }
        }

        private void checkBox2minus_CheckedChanged(object sender, EventArgs e)
        {
            bool negatif = false;
            if (checkBox2minus.Checked)
            {
                negatif = false;
                Rotor2.PositifOuNegatif = negatif;
                checkBox2plus.Checked = false;
            }
        }

        private void checkBox3plus_CheckedChanged(object sender, EventArgs e)
        {
            bool positif = false;
            if (checkBox2plus.Checked)
            {
                positif = true;
                Rotor2.PositifOuNegatif = positif;
                checkBox2minus.Checked = false;
            }
        }

        private void checkBox3minus_CheckedChanged(object sender, EventArgs e)
        {
            bool negatif = false;
            if (checkBox3minus.Checked)
            {
                negatif = false;
                Rotor3.PositifOuNegatif = negatif;
                checkBox3plus.Checked = false;
            }
        }

        private void textEncrypter_TextChanged(object sender, EventArgs e)
        {
            string messageEncrypter = textEncrypter.Text;
            encryptionMessage = messageEncrypter;
            encryptionChars = messageEncrypter.ToCharArray();
        }

        private void textDecrypter_TextChanged(object sender, EventArgs e)
        {
            string messageDecrypter = textDecrypter.Text;
            decryptionMessage = messageDecrypter;
            decryptionChars = messageDecrypter.ToCharArray();
        }

        private void encrypterButton_Click(object sender, EventArgs e)
        {
            while (encrypterButton.Enabled == true && compteEncrypt < encryptionMessage.Length)
            {
                textDecrypter.Text += encryptionMessage[compteEncrypt];
                compteEncrypt++;
                encrypterButton.Enabled = false;
                nextStep.Enabled = true;
            }
           
            
        }

        private void decrypterButton_Click(object sender, EventArgs e)
        {
            while (decrypterButton.Enabled == true && compteDecrypt < decryptionMessage.Length)
            {
                textEncrypter.Text += decryptionMessage[compteDecrypt];
                compteDecrypt++;
                decrypterButton.Enabled = false;
                nextStep.Enabled = true;
            }

        }

        private void nextStep_Click(object sender, EventArgs e)
        {
            nextStep.Enabled = false;
            encrypterButton.Enabled = true;
            decrypterButton.Enabled = true;
        }
        //List<Label> rotor1, List<Label>rotor2, List<Label>rotor3
        private void DecalageRotors(List<Label> rotor1Bas, List<Label> rotor2Bas, List<Label> rotor3Bas,
                                    List<Label> rotor1Haut, List<Label> rotor2Haut, List<Label> rotor3Haut)
        {
            
            for (int i = 0; i < rotor1Bas.Capacity; i++)
            {

            }
            

        }

        private void configRotor_Click(object sender, EventArgs e)
        {
            var rotor1Bass0 = rotor2Bass[0].Text;
            if (Rotor1.PositifOuNegatif == false)
            {
                for (int i = 0; i < rotor2Bass.Length; i++)
                {


                    rotor1Bass[i].Text = rotor1Bass[(i - decalR1)%25 ].Text;
                    //rotor2Bass[i].Text = rotor2Bass[i - decalR2].Text;
                    //rotor3Bass[i].Text = rotor3Bass[i - decalR3].Text;

                    rotor1Hautt[i].Location = rotor1Hautt[(i - decalR2)% 25].Location;
                    //rotor2Hautt[i].Text = rotor2Hautt[i - decalR2].Text;
                    // rotor3Hautt[i].Text = rotor3Hautt[(i - decalR3 + 26) % 26].Text;



                }
            }
                
            
        }
    }
    
    
}

