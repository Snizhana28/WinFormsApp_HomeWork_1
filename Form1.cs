namespace WinFormsApp_HomeWork_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            string name = "Name: Snizhana";
            string surname = "Surname: Kostiuk";
            string age = "Age: 17";
            string education = "Education: incomplete higner";
            string experience = "Work experience: 0";
            string average = "Avarage number of characters per page: ";
            int count = 6;
            int sum = name.Length + surname.Length + age.Length + education.Length + experience.Length + average.Length;
            int averageCount = sum / count;
            MessageBox.Show(name);
            MessageBox.Show(surname);
            MessageBox.Show(age);
            MessageBox.Show(education);
            MessageBox.Show(experience);
            MessageBox.Show(average + " " + averageCount);
        }

        private void bt_guessNum_MouseMove(object sender, MouseEventArgs e)
        {
            Random rand = new Random();
            int num = rand.Next(1, 20);
            int count = 0;
            int guessNum = 0;
            while (guessNum != num)
            {
                guessNum = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox("Enter your number", "Guess the number", "0", 0, 0));
                count++;
                if (guessNum > num)
                {
                    MessageBox.Show("Your number > hidden number");
                }
                else if (guessNum < num)
                {
                    MessageBox.Show("Your number < hidden number");
                }
                else
                {
                    MessageBox.Show("You guessed the number");
                    MessageBox.Show("Number of requests: " + count);
                    DialogResult result = MessageBox.Show("Do you want to play again?", "Guess the number", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        guessNum = 0;
                        count = 0;
                    }
                    else
                    {
                        break;
                    }
                }
            }
        }

        private void label_X_Click(object sender, EventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                Close();
            }
            else
            {
                int x = MousePosition.X;
                int y = MousePosition.Y;
                int x1 = ClientSize.Width;
                int y1 = ClientSize.Height;
                int x2 = x + x1;
                int y2 = y + y1;
                if (x1 < x2)
                {
                    MessageBox.Show("Inside the rectangle");
                }
                else if (x1 > x2)
                {
                    MessageBox.Show("Outside the rectangle");
                }
                else
                {
                    MessageBox.Show("On the border of the rectangle");
                }
            }

        }

        private void label_Y_Click(object sender, EventArgs e)
        {
            int x = ClientSize.Width;
            int y = ClientSize.Height;
            MessageBox.Show("Width = " + x + " Height = " + y);
        }

        private void ptr_Click(object sender, EventArgs e)
        {
            int x = MousePosition.X;
            int y = MousePosition.Y;
            MessageBox.Show("x = " + x + " y = " + y);
        }

        private void bt_clickTheLeftMouse_MouseClick(object sender, MouseEventArgs e)
        {
            


        }
    }
}