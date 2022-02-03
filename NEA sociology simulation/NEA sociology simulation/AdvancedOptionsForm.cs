using System;
using System.Windows.Forms;

namespace NEA_sociology_simulation
{
    public partial class AdvancedOptionsForm : Form
    {
        #region variable initialising
        public static int housingsupply = 100;
        public static int Reproductionchance = 25;
        public static int minincome = 20000;
        public static int maxincome = 100000;
        public static int deathchancemod = 10;
        #endregion
        //Default variables

        #region formstarter
        public AdvancedOptionsForm()
        {
            InitializeComponent();
        }
        #endregion

        #region textbox procedures
        private void Intonly(TextBox inputbox)
        {
            try
            {
                Convert.ToInt32(inputbox.Text);
            }
            catch
            {
                inputbox.Text = "";
            }
        }
        
        private void Housingsupplyinput_TextChanged(object sender, EventArgs e)
        {
            Intonly(Housingsupplyinput);
        }
        private void Reproductionchanceinput_TextChanged(object sender, EventArgs e)
        {
            Intonly(Reproductionchanceinput);
        }
        private void Minincomeinput_TextChanged(object sender, EventArgs e)
        {
            Intonly(Minincomeinput);
        }
        private void Maxincomeinput_TextChanged(object sender, EventArgs e)
        {
            Intonly(Maxincomeinput);
        }
        private void Deathchancemodinput_TextChanged(object sender, EventArgs e)
        {
            Intonly(Deathchancemodinput);
        }
        #endregion
        //ensures textbox formatting

        #region submit
        private void Submit_Click(object sender, EventArgs e)
        {
            try { housingsupply = Convert.ToInt32(Housingsupplyinput.Text); } catch { }
            try { Reproductionchance =  Convert.ToInt32(Housingsupplyinput.Text); } catch { }
            try { minincome = Convert.ToInt32(Minincomeinput.Text); } catch { }
            try { maxincome = Convert.ToInt32(Maxincomeinput.Text); } catch { }
            try { deathchancemod = Convert.ToInt32(Deathchancemodinput.Text); } catch { }
            this.Hide();
        }
        #endregion
        //changes the variables to what is in the texboxes
    }
}
