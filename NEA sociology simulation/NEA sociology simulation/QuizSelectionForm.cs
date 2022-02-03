using System;
using System.Windows.Forms;

namespace NEA_sociology_simulation
{
    public partial class QuizSelectionForm : Form
    {
        public static string Quizfilename;

        #region initialiser
        public QuizSelectionForm()
        {
            InitializeComponent();
        }
        
        private void Form6_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Quizfilename = QuizComboBox.Items[QuizComboBox.SelectedIndex].ToString();//stores the data selected in the drop down for later use
            }
            catch { }
            

            Form5 PlayQuiz = new Form5();
            PlayQuiz.Show(); //creates and opens a new instance of the quiz form
            this.Hide();
        }
    }
}