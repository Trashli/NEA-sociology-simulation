using System;
using System.IO;
using System.Windows.Forms;
/// <summary>
/// Saves game data to a binary file
/// </summary>
namespace NEA_sociology_simulation
{
    public partial class SaveSimulationForm : Form
    {
        #region Form Loaders
        public SaveSimulationForm()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
        #endregion

        private void FinalSave_Click(object sender, EventArgs e)
        {
            bool donotexecute = false;
            #region no double saves
            if (textBox1.Text.Length > 0)
            {
                for (int x = 0; x < Directory.GetFiles("saves", "*", SearchOption.TopDirectoryOnly).Length; x++)
                {
                    string checkfilename = Directory.GetFiles("saves", "*", SearchOption.TopDirectoryOnly)[x].Substring(0, Directory.GetFiles("saves", "*", SearchOption.TopDirectoryOnly)[x].Length - 4);
                    if ("saves\\" + textBox1.Text == checkfilename)
                    {
                        textBox1.Text = "save file name taken";
                        donotexecute = true;
                        break;
                    }
                }
            }
            #endregion

            #region saving script
            if (!donotexecute)
            {
                #region Text file writer - deprecated
                //using (StreamWriter writer = new StreamWriter("saves/" + textBox1.Text + ".txt")) ///+ Directory.GetFiles("saves", "*", SearchOption.TopDirectoryOnly).Length.ToString() + ".txt")
                //{
                //    writer.WriteLine(Form1.Counters.year);
                //    writer.WriteLine(Form1.Agent.instanceCount);

                //    writer.WriteLine(Form1.Counters.agents.Count);
                //    for (int x = 0; x < Form1.Counters.agents.Count; x++)
                //    {
                //        writer.WriteLine(
                //            Form1.Counters.agents[x].GetName()
                //            + "," + Form1.Counters.agents[x].GetAge()
                //            + "," + Form1.Counters.agents[x].GetBirthYear()
                //            + "," + Form1.Counters.agents[x].GetID()
                //            + "," + Form1.Counters.agents[x].GetIncome()
                //            + "," + Form1.Counters.agents[x].GetFunds()
                //            );
                //    }
                //    writer.WriteLine(Form1.Counters.housingsupply);
                //    writer.WriteLine(Form2.Reproductionchance);
                //    writer.WriteLine(Form2.minincome);
                //    writer.WriteLine(Form2.maxincome);
                //    writer.WriteLine(Form2.deathchancemod);
                //    this.Hide();
                //}
                #endregion

                #region binary file writer - in use
                using (BinaryWriter writer = new BinaryWriter(new FileStream("saves/" + textBox1.Text, FileMode.Create)))
                {
                    writer.Write(Form1.Counters.year);
                    writer.Write(Form1.Agent.instanceCount);

                    writer.Write(Form1.Counters.agents.Count);
                    for (int x = 0; x < Form1.Counters.agents.Count; x++)
                    {
                        writer.Write(
                            Form1.Counters.agents[x].GetName()
                            + "," + Form1.Counters.agents[x].GetAge()
                            + "," + Form1.Counters.agents[x].GetID()
                            + "," + Form1.Counters.agents[x].GetIncome()
                            + "," + Form1.Counters.agents[x].GetFunds()
                            );
                    }
                    writer.Write(Form1.Counters.housingsupply);
                    writer.Write(AdvancedOptionsForm.Reproductionchance);
                    writer.Write(AdvancedOptionsForm.minincome);
                    writer.Write(AdvancedOptionsForm.maxincome);
                    writer.Write(AdvancedOptionsForm.deathchancemod);
                    this.Hide();
                }
                #endregion
            }
            #endregion
        }
    }
}
