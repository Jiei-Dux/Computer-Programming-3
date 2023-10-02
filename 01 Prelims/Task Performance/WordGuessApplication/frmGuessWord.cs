using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WordGuessApplication
{
    public partial class frmGuessWord : Form
    {

        public frmGuessWord()
        {
            InitializeComponent();
        }

        string[] WordsArray = File.ReadAllLines("Database/wordsSorted.txt");
        string[] wrongGuessesArray = new string[5];

        int Array1Num = 0;
        int Array2Num = 0;
        Random rnd = new Random();

        private void frmGuessWord_Load(object sender, EventArgs e)
        {
            guessBtn.BackColor = Color.DarkSeaGreen;
            chooseWord();

            NextBtn.Enabled = false;
        }

        private void chooseWord()
        {
            NextBtn.Enabled = false;

            Array1Num = rnd.Next(WordsArray.Length);

            int ArrayPos1 = rnd.Next(WordsArray[Array1Num].Length);
            int ArrayPos2 = rnd.Next(WordsArray[Array1Num].Length);

            string chosenWord = WordsArray[Array1Num];

            chosenWord = chosenWord.Remove(ArrayPos1, 1).Insert(ArrayPos1, " _ ");
            chosenWord = chosenWord.Remove(ArrayPos2, 1).Insert(ArrayPos2, " _ ");

            daWord.Text = chosenWord;
        }

        private void checkWord()
        {
            if (guessTxtBox.Text.Equals(WordsArray[Array1Num]))
            {
                daWord.Text = WordsArray[Array1Num];
                guessBtn.BackColor = Color.LightGreen;
                NextBtn.Enabled = true;
                guessBtn.Enabled = false;
            }

            if (guessTxtBox.Text != WordsArray[Array1Num])
            {
                guessBtn.BackColor = Color.Red;
                wrongGuessesArray[Array2Num] = guessTxtBox.Text;
                Array2Num++;
                wrongGuesses.Text = string.Join("\n", wrongGuessesArray);
            }

            if (Array2Num > 4)
            {
                const string message =
                    "Too bad... You've used up 5 tries... Try again?";
                const string caption = "You've Failed.";
                var result = MessageBox.Show(message, caption, MessageBoxButtons.YesNo);

                if (result == DialogResult.No)
                {
                    Environment.Exit(0);
                }

                RESET();
            }
        }

        private void guessBtn_Click(object sender, EventArgs e)
        {
            checkWord();
        }

        private void NextBtn_Click(object sender, EventArgs e)
        {
            if (Array1Num < WordsArray.Length - 1)
            {
                Array1Num++;
                chooseWord();
            }

            guessBtn.BackColor = Color.DarkSeaGreen;
            guessBtn.Enabled = true;

            Array.Clear(wrongGuessesArray, 0, wrongGuessesArray.Length);
            wrongGuesses.Text = "";

            Array2Num = 0;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu BACK = new MainMenu();
            BACK.Closed += (s, args) => this.Close();
            BACK.Show();
        }

        private void RESET()
        {
            Array1Num = 0;
            Array2Num = 0;

            Array.Clear(wrongGuessesArray, 0, wrongGuessesArray.Length);
            wrongGuesses.Text = "";

            chooseWord();
        }
    }
}
