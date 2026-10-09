namespace GamePlusik_2026
{
    public partial class FormGame : Form
    {
        int TargetNum = 21;
        int UserNum = 1;
        int CountStep = 0;


        public FormGame()
        {
            InitializeComponent();
            labelTarget.Text = TargetNum.ToString();
        }

        int Optimum(int k)
        {
            int steps = 0;
            while (k != 1)
            {
                if (k % 2 == 0)
                {
                    k = k / 2;
                }
                else
                {
                    k = k - 1;
                }
                steps++;
            }
            return steps;
        }

        private void pictureBoxPlus_Click(object sender, EventArgs e)
        {
            //UserNum = UserNum + 1;
            UserNum++;
            CountStep++;
            labelUserNumber.Text = UserNum.ToString();
            labelCountStep.Text = CountStep.ToString();
            if (UserNum == TargetNum)
            {
                if (CountStep == Optimum(TargetNum))
                    MessageBox.Show("Выиграл");
                else
                    MessageBox.Show("Но можно было быстрее!");
            }
            else if (UserNum > TargetNum)
                MessageBox.Show("Проиграл!");
        }

        private void pictureBoxMult_Click(object sender, EventArgs e)
        {
            //UserNum = UserNum * 2;
            UserNum *= 2;
            CountStep++;
            labelUserNumber.Text = UserNum.ToString();
            labelCountStep.Text = CountStep.ToString();
            if (UserNum == TargetNum)
            {
                if (CountStep == Optimum(TargetNum))
                    MessageBox.Show("Выиграл");
                else
                    MessageBox.Show("Но можно было быстрее!");
            }
            else if (UserNum > TargetNum)
                MessageBox.Show("Проиграл!");
        }
    }
}
