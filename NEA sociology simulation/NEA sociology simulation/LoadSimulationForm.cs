using System;
using System.Windows.Forms;
using System.IO;

/// <summary>
/// Loads save data from a binary file
/// </summary>

namespace NEA_sociology_simulation
{
    public partial class LoadSimulationForm : Form
    {
        #region form loaders
        public LoadSimulationForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
        
        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region File Loader
        private void Load_Click(object sender, EventArgs e)
        {
            AdvancedOptionsForm options = new AdvancedOptionsForm();
            Form1 main = new Form1();
            string[] agentdata;
            if (LoadComboBox.SelectedIndex != -1)
            {
                Form1.Counters.agents.Clear();

                #region Text file reader - deprecated
                //using (StreamReader reader = new StreamReader(toolStripComboBox1.Items[toolStripComboBox1.SelectedIndex].ToString()))
                //{
                //    Form1.Counters.year = Convert.ToInt32(reader.ReadLine());
                //    Form1.Agent.instanceCount = Convert.ToInt32(reader.ReadLine());
                //    int agentnum = Convert.ToInt32(reader.ReadLine());
                //    for (int x = 0; x < agentnum; x++)
                //    {
                //        agentdata = reader.ReadLine().Split(',');
                //        Form1.Agent agent = new Form1.Agent(Convert.ToInt32(agentdata[3]), Convert.ToInt32(agentdata[4]), agentdata[0]);
                //        agent.SetAge(Convert.ToInt32(agentdata[1]));
                //        agent.Setbirthyear(Convert.ToInt32(agentdata[2]));
                //        agent.SetFunds(Convert.ToInt32(agentdata[5]));
                //    }
                //    options.Housingsupplyinput.Text = reader.ReadLine();
                //    options.Reproductionchanceinput.Text = reader.ReadLine();
                //    options.Minincomeinput.Text = reader.ReadLine();
                //    options.Maxincomeinput.Text = reader.ReadLine();
                //    options.Deathchancemodinput.Text = reader.ReadLine();
                //}
                //this.Hide();
                #endregion

                #region binary file reader - in use
                using (BinaryReader reader = new BinaryReader(new FileStream(LoadComboBox.Items[LoadComboBox.SelectedIndex].ToString(), FileMode.Open)))
                {
                    Form1.Counters.year = reader.ReadInt32();
                    Form1.Agent.instanceCount = reader.ReadInt32();
                    int agentnum = reader.ReadInt32();
                    for (int x = 0; x < agentnum; x++)
                    {
                        agentdata = reader.ReadString().Split(',');
                        Form1.Agent agent = new Form1.Agent(Convert.ToInt32(agentdata[3]), Convert.ToInt32(agentdata[4]), agentdata[0]);
                        agent.SetAge(Convert.ToInt32(agentdata[1]));
                        agent.SetFunds(Convert.ToInt32(agentdata[5]));
                    }
                    options.Housingsupplyinput.Text = reader.ReadInt32().ToString();
                    options.Reproductionchanceinput.Text = reader.ReadInt32().ToString();
                    options.Minincomeinput.Text = reader.ReadInt32().ToString();
                    options.Maxincomeinput.Text = reader.ReadInt32().ToString();
                    options.Deathchancemodinput.Text = reader.ReadInt32().ToString();
                }
                this.Hide();
                #endregion
            }
        }
        #endregion
    }
}
