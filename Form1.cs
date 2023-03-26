using System.Reflection.Metadata.Ecma335;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        int secretNumber = 0;
        int guessCount = 0;

        public Form1()
        {
            InitializeComponent();
           
           
        }

        private void btnGuess_Click(object sender, EventArgs e)
        {
           
          
            if (int.TryParse(txtInput.Text, out int guessNumber))
            {           
                guessCount++;
                lblTitle.Text = "Try number " + guessCount.ToString();

                if (guessNumber < secretNumber)
                {
                    MessageBox.Show("you guess too low");
                }
                else if (guessNumber > secretNumber)
                {
                    MessageBox.Show("you guess was too high");
                }
                else
                {
                    MessageBox.Show("You won at try number " + guessCount);
                }
            }
            else
            {
                MessageBox.Show("the number is invalid");
            }
            txtInput.Text = "";
            txtInput.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // when the form is Load or ready

            Random random = new Random(); // for generate random numbers
            secretNumber = random.Next(1, 100); // I am generating a number fom 1 to 100

            lblTitle.Text ="Enter a number from 1 to 100" ;

            MessageBox.Show("Guess the number");
        }



        private void btnRestart_Click(object sender, EventArgs e)
        {
            Random random = new Random(); // for generate random numbers
            secretNumber = random.Next(1, 100); // I am generating a number fom 1 to 100


            lblTitle.Text = "Enter a number from 1 to 100";
            txtInput.Text = "";

            MessageBox.Show("Guess the number");
        }
    }
}



