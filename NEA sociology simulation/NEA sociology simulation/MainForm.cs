using System;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
/// <summary>
/// Simulation of population and wealth within a dynamic environment using a ranked choice system to simulate social randomness
/// </summary>
namespace NEA_sociology_simulation
{
    public partial class Form1 : Form
    {
        #region Counters&Constructors
        AdvancedOptionsForm advancedoptions = new AdvancedOptionsForm();
        LoadSimulationForm Loader = new LoadSimulationForm();
        SaveSimulationForm savemenu = new SaveSimulationForm();//sets up Forms for access
        Form5 Quiz = new Form5();
        QuizSelectionForm QuizLoader = new QuizSelectionForm();
        QuizMakingForm MakerQuiz = new QuizMakingForm();
        
        private static Random rand = new Random(DateTime.Now.Second);// starts a random number generator seeded with the current time
        public static class Counters //counters for global access
        {
            public static int housingsupply = 100;
            public static int year;
            public static List<Agent> agents = new List<Agent>();
            public static List<Agent> toberemoved = new List<Agent>();
        }
        #endregion

        #region AgentClass
        public class Agent
        {
            public static int instanceCount;
            int Age;
            int ID;
            int Income;
            int Funds;
            string Name;
            float chancewilldie;
            public Agent(int id, int income, string name) //Agent constructor
            {
                Age = 0;
                ID = id;
                Income = income;
                Funds = 0;
                Name = name;
                chancewilldie = (this.Age / AdvancedOptionsForm.deathchancemod);
                ++instanceCount;
                Counters.agents.Add(this);
            }
            #region Gets+Sets
            public void SetAge(int input)
            {
                Age = input;
            }
            public void SetFunds(int input)
            {
                Funds = input;
            }
            public int GetCount()
            {
                return instanceCount;
            }

            public int GetAge()
            {
                return Age;
            }
            public int GetID()
            {
                return ID;
            }
            public int GetIncome()
            {
                return Income;
            }
            public int GetFunds()
            {
                return Funds;
            }
            public string GetName()
            {
                return Name;
            }

            public float GetDeathChance()
            {
                return chancewilldie;
            }
            #endregion //get and set procedures for class variables
            public void Tick() //Ticks over an agent by 1 year
            {
                Age++;

       if (this.Age > 18 && this.Age < 60)
                {
                    Funds = Funds + this.Income;
                }
                chancewilldie = (this.Age / AdvancedOptionsForm.deathchancemod);
            }

        }
        #endregion

        #region Initialiser
        public Form1()
        {
            Counters.year = 0;

            InitializeComponent();

            chart1.Series["Population"].Points.AddXY(0, 0);
            Agent agent = new Agent(0, 20000, GenerateName()); //creates agent 1 "Adam"
            chart1.Legends["Legend1"].CustomItems[0].Color = System.Drawing.ColorTranslator.FromHtml("#418cf0");
            chart1.Legends["Legend1"].CustomItems[1].Color = System.Drawing.ColorTranslator.FromHtml("#fcb441"); //changes colour of labels
            chart1.Legends["Legend1"].CustomItems[2].Color = System.Drawing.ColorTranslator.FromHtml("#e0400a");
            ///Advancedoptions.Name = "Advanced options";
        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #endregion

        #region NameGenerator
        public static string GenerateName()
        {
            int len = rand.Next(1, 10);
            string[] consonants = { "b", "c", "d", "f", "g", "h", "j", "k", "l", "m", "l", "n", "p", "q", "r", "s", "t", "v", "w", "x" };
            string[] vowels = { "a", "e", "i", "o", "u" };
            string Name = "";
            Name += consonants[rand.Next(consonants.Length)].ToUpper();
            Name += vowels[rand.Next(vowels.Length)];
            int x = 2; //x tells how many times a new letter has been added. its 2 right now because the first two letters are already in the name.
            while (x < len)
            {
            
                Name += consonants[rand.Next(consonants.Length)];
                ++x;
                Name += vowels[rand.Next(vowels.Length)];
                ++x;
            }
            return Name;
        }
        #endregion

        #region Charts
        #region Graph refresher
        public void ReplaceCharts()
        {
            this.Refresh(); this.Invalidate();
            this.chart1.Series.Clear();this.chart1.ChartAreas.Clear(); //deletes all the data from the graphs

            this.chart1.ChartAreas.Add("Population Graph");
            this.chart1.ChartAreas.Add("Income DIstribution"); //adds the graph areas back
            this.chart1.ChartAreas.Add("Age Distribution");
            this.chart1.ChartAreas.Add("Dependancy Ratio");

            this.chart1.Series.Add("Population");
            this.chart1.Series.Add("Income Distribution"); //creates the graphs themselves
            this.chart1.Series.Add("Age Distribution"); 
            this.chart1.Series.Add("Dependancy ratio");

            this.chart1.Series["Population"].ChartType = SeriesChartType.Line;
            this.chart1.Series["Income Distribution"].ChartType = SeriesChartType.Column; //sets the graph types
            this.chart1.Series["Age Distribution"].ChartType = SeriesChartType.Column;
            this.chart1.Series["Dependancy ratio"].ChartType = SeriesChartType.Pie;

            this.chart1.Series["Population"].ChartArea = "Population Graph";
            this.chart1.Series["Income Distribution"].ChartArea = "Income DIstribution"; //adds the graphs to the graph areas
            this.chart1.Series["Age Distribution"].ChartArea = "Age Distribution";
            this.chart1.Series["Dependancy ratio"].ChartArea = "Dependancy Ratio";
        }
        #endregion //removes all data from the graphs

        private void UpdateTables()
        {
            Housingavailablelabel.Text = Math.Abs((Counters.agents.Count - Counters.housingsupply) / Convert.ToDouble(Counters.housingsupply)).ToString("0%") + " housing available"; //updates the housing availible statistic

            string Labeltext = "Year:" + Counters.year.ToString() + "\r\nAgents:" + Counters.agents.Count() + "\r\nAll Agents:" + Agent.instanceCount + "\r\nName: Age";
            for (int x = 0; x < Counters.agents.Count(); ++x)
            {
                try
                {
                    Labeltext = Labeltext + "\r\n" + Counters.agents[x].GetName() + ": " + Counters.agents[x].GetAge();
                }
                catch { }
            }
            Agentlist.Text = Labeltext;//gathers the data for the textbox and adds it to it

            chart1.Series["Population"].Points.AddXY(Counters.year, Counters.agents.Count());//adds to the population chart

            chart1.Series["Income Distribution"].Points.Clear();
            chart1.Series["Age Distribution"].Points.Clear();//clears data from the other charts
            chart1.Series["Dependancy ratio"].Points.Clear();

            for (int x = 0; x < 100; ++x)
            {
                chart1.Series["Age Distribution"].Points.AddXY(x, 0); //sets up the age by population graph for data entry
                if (x > 19)
                {
                    chart1.Series["Income Distribution"].Points.AddXY(x, 0);//sets up the income by age graph for data entry
                }
            }

            chart1.Series["Dependancy ratio"].Points.AddXY(0, 0);
            chart1.Series["Dependancy ratio"].Points.AddXY(1, 0);//sets up the pie chart
            chart1.Series["Dependancy ratio"].Points.AddXY(2, 0);

            chart1.Series["Dependancy ratio"].Points[0].ToolTip = "Elderly";
            chart1.Series["Dependancy ratio"].Points[1].ToolTip = "Children";//labels the pie chart
            chart1.Series["Dependancy ratio"].Points[2].ToolTip = "Working Age";

            #region data adding
            for (int x = 0; x < Counters.agents.Count(); ++x)
            {
                for (int y = 0; y < chart1.Series["Age Distribution"].Points.Count(); ++y)
                {
                    if (Counters.agents[x].GetAge() == chart1.Series["Age Distribution"].Points[y].XValue)
                    {
                        ++chart1.Series["Age Distribution"].Points[y].YValues[0];
                    }
                }
                for (int y = 0; y < chart1.Series["Income Distribution"].Points.Count(); ++y)
                {
                    if (Counters.agents[x].GetAge() == chart1.Series["Income Distribution"].Points[y].XValue)
                    {
                        chart1.Series["Income Distribution"].Points[y].YValues[0] = +Counters.agents[x].GetFunds();
                    }
                }
                if (Counters.agents[x].GetAge() > 60)
                {
                    ++chart1.Series["Dependancy ratio"].Points[0].YValues[0];
                }
                else if (Counters.agents[x].GetAge() < 18)
                {
                    ++chart1.Series["Dependancy ratio"].Points[1].YValues[0];
                }
                else
                {
                    ++chart1.Series["Dependancy ratio"].Points[2].YValues[0];
                }
            }
            #endregion//adds data to the graphs
        }
        #endregion

        #region YearCycles
        static void Birthcycle()//procedure to create new agents based on birth rates and housing available
        {
            int count = Counters.agents.Count();///saves the current amount of agents, is accessed instead of counters.agents.count
            List<Agent> toberemoved = new List<Agent>();
            for (int x = 0; x < count; ++x)
            {
                Counters.agents[x].Tick();
                if (rand.Next(1, 100) < AdvancedOptionsForm.Reproductionchance * (1 - (Counters.agents.Count() / Counters.housingsupply)) && 18 < Counters.agents[x].GetAge() && Counters.agents[x].GetAge() < 50) // more likely to be true when further from the limit.
                {
                    Agent agent = new Agent(Counters.agents.Count, rand.Next(AdvancedOptionsForm.minincome, AdvancedOptionsForm.maxincome), GenerateName());
                }
            }
        }
        
        private void Deathcycle()//checks for a deletes agents based on their age
        {
            int count = Counters.agents.Count();///saves the current amount of agents, is accessed instead of counters.agents.count
            Counters.toberemoved.Clear();
            for (int x = 0; x < count; ++x)
            {
                if (rand.Next(1, 50) < Counters.agents[x].GetDeathChance())
                {
                    for (int y = Counters.agents.Count - 1; y > -1; --y)
                    {
                        Agent f = Counters.agents[y];
                        try
                        {
                            if (f.GetID() == Counters.agents[x].GetID())
                            {
                                Counters.toberemoved.Add(f);
                            }
                        }
                        catch { }
                    }
                }
            }
        }
        #endregion

        #region NextYear
        private void TickYear(object sender, EventArgs e)
        {
            int count = Counters.agents.Count();//saves the current amount of agents, is accessed instead of count

            try{Counters.housingsupply = Convert.ToInt32(AdvancedOptionsForm.housingsupply);}catch{}//what is the upper limit the environment can hold

            Thread BirthCycler = new Thread(new ThreadStart(Birthcycle));//creates new agents based on birth rate and weighted choice
            Thread DeathCycler = new Thread(new ThreadStart(Deathcycle));//kills agents based on death rate and weighted choice
            BirthCycler.Start();
            DeathCycler.Start();

            ++Counters.year;

            UpdateTables();

            for (int x = 0; x < Counters.toberemoved.Count(); ++x)//removes dead agents from the list
            {
                Counters.agents.Remove(Counters.toberemoved[x]);
            }
        }
        #endregion

        #region Buttons
        private void button1_Click(object sender, EventArgs e)//starts a timer looping Tickyear()
        {
            if (timer1.Enabled)
            {
                StartBTN.Text = "Start";
                timer1.Enabled = false;
            }
            else
            {
                StartBTN.Text = "Stop";
                timer1.Enabled = true;
            }
        }

        private void AdvancedOptionsToggle_Click(object sender, EventArgs e)//opens/closes the advanced options window
        {
            advancedoptions.Visible = !advancedoptions.Visible;
        }
        private void Save_Click(object sender, EventArgs e)//opens/closes the save window
        {
            savemenu.Visible = !savemenu.Visible;
        }

        private void Loadmenu_Click(object sender, EventArgs e)//opens/closes the load window and puts data into it
        {
            if (!Loader.Visible)
            {
                Loader.Show();
                for (int x = 0; x < Directory.GetFiles("saves", "*", SearchOption.TopDirectoryOnly).Length; x++)
                {
                    Loader.LoadComboBox.Items.Add(Directory.GetFiles("saves", "*", SearchOption.TopDirectoryOnly)[x]);
                }
            }
            ReplaceCharts();
        }

        private void MakeQuiz_Click(object sender, EventArgs e)//opens/closes the Quiz maker window
        {
            int x = 0;
            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == "Form7")//checks if the form exists, if not creates a new one
                {
                    x++;
                }
            }
            if (x == 0)
            {
                QuizMakingForm MakerQuiz = new QuizMakingForm();
                MakerQuiz.Visible = !MakerQuiz.Visible;
            }
            else
            {
                MakerQuiz.Visible = !MakerQuiz.Visible;
            }
        }

        private void LoadQuiz_Click(object sender, EventArgs e)//opens/closes the Quiz loader window and loads data into it
        {
            QuizLoader.QuizComboBox.Items.Clear();
            if (!QuizLoader.Visible)
            {
                QuizLoader.Show();
                for (int x = 0; x < Directory.GetFiles("Quizzes", "*", SearchOption.TopDirectoryOnly).Length; x++)
                {
                    QuizLoader.QuizComboBox.Items.Add(Directory.GetFiles("Quizzes", "*", SearchOption.TopDirectoryOnly)[x].Substring(8));
                }
            }
        }
        #endregion
    }
}