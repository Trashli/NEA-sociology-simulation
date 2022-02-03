using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
namespace NEA_sociology_simulation
{
    public partial class Form5 : Form
    {
        #region sets up lists for use in questions
        List<Panel> panels = new List<Panel>();
        List<Label[]> labels = new List<Label[]>(); 
        List<RadioButton[]> Buttons = new List<RadioButton[]>();
        List<int> correctnos = new List<int>();
        int NoOfQuesions;
        Form Quizloader = QuizMakingForm.ActiveForm;
        #endregion

        #region initialiser
        public Form5()
        {
            InitializeComponent();

        }
        #endregion

        private void Form5_Load(object sender, EventArgs e)
        {
            string readdata = "";
            string[] directories = Directory.GetFiles("Quizzes/Scores/" + QuizSelectionForm.Quizfilename, "*", SearchOption.TopDirectoryOnly);//gets all /scores/ deirectories

            #region reads all user scores and displays them in textbox
            for (int x = 0; x < directories.Length; x++)
            {
                using (BinaryReader reader = new BinaryReader(new FileStream(directories[x], FileMode.Open)))
                {
                    readdata = readdata + reader.ReadString() + ":" + (reader.ReadInt16()).ToString() + Environment.NewLine;
                    ScoreList.Text = ScoreList.Text + readdata;
                    readdata = "";
                }
            }
            #endregion

            using (BinaryReader reader = new BinaryReader(new FileStream("Quizzes/" + QuizSelectionForm.Quizfilename, FileMode.Open)))
            {
                NoOfQuesions = Convert.ToInt16(reader.ReadString()); //reads indicator of how many loops needed to get all questions

                for (int x = 0; x < NoOfQuesions; x++)
                {
                    #region creates all objects used this loop
                    panels.Add(new Panel());
                    labels.Add(new Label[4]);
                    labels[x][0] = new Label();
                    labels[x][1] = new Label();
                    labels[x][2] = new Label();
                    labels[x][3] = new Label();
                    Buttons.Add(new RadioButton[3]);
                    Buttons[x][0] = new RadioButton();
                    Buttons[x][1] = new RadioButton();
                    Buttons[x][2] = new RadioButton();
                    #endregion

                    correctnos.Add(Convert.ToInt16(reader.ReadString()));//gets the correct answer for later use

                    #region Adds the question, answers, and buttons to the form
                    panels[x].Location = new Point(15, x * 80);//puts panel in the correct spot

                    panels[x].Size = new Size(1100, 80);//sets panel to correct size




                    labels[x][1].Text = reader.ReadString();//
                    labels[x][2].Text = reader.ReadString();//reads answer options and makes them the labeltext
                    labels[x][3].Text = reader.ReadString();//

                    labels[x][0].Text = reader.ReadString();//reads the question and makes it the labeltext

                    
                    labels[x][0].Location = new Point(5, 15);//puts question in the right place so they dont overlap
                    labels[x][0].Size = new Size(500, 15);   //makes question labels the correct size to not overlap or cut short

                    labels[x][1].Location = new Point(15, 45); //Puts answer in the right place so they dont overlap
                    labels[x][1].Size = new Size(TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width, 15);     //makes answer labels the correct size to not overlap or cut short
                    labels[x][2].Location = new Point(35 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width, 45);//
                    labels[x][2].Size = new Size(TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width, 15);     //
                    labels[x][3].Location = new Point(55 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width, 45);//
                    labels[x][3].Size = new Size(TextRenderer.MeasureText(labels[x][3].Text, SystemFonts.MessageBoxFont).Width, 15);     //


                    Buttons[x][0].Location = new Point(15, 65); //Puts the radiobutton in the right space
                    Buttons[x][0].Size = new Size(15, 15);      //Makes the radio button really small but just big enough it doesnt cut itself off with its own border because i previously had no idea this was possible and im pretty sure i have substantially less hair now
                    Buttons[x][1].Location = new Point(35 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width, 65);//
                    Buttons[x][1].Size = new Size(15, 15);      //
                    Buttons[x][2].Location = new Point(55 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width, 65);//
                    Buttons[x][2].Size = new Size(15, 15);      //

                    ScoreList.Location = new Point(95 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][3].Text, SystemFonts.MessageBoxFont).Width, ScoreList.Location.Y);
                    AnswerSubmitQuiz.Location = new Point(95 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][3].Text, SystemFonts.MessageBoxFont).Width, AnswerSubmitQuiz.Location.Y);
                    NameInputTextbox.Location = new Point(130 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][3].Text, SystemFonts.MessageBoxFont).Width, NameInputTextbox.Location.Y);
                    label1.Location = new Point(90 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][3].Text, SystemFonts.MessageBoxFont).Width, label1.Location.Y);
                    this.Size = new Size(246 + TextRenderer.MeasureText(labels[x][1].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][2].Text, SystemFonts.MessageBoxFont).Width + TextRenderer.MeasureText(labels[x][3].Text, SystemFonts.MessageBoxFont).Width, this.Size.Height);

                    panels[x].Controls.Add(labels[x][0] as Label);//Adds the labels to the form panel
                    panels[x].Controls.Add(labels[x][1] as Label);//
                    panels[x].Controls.Add(labels[x][2] as Label);//
                    panels[x].Controls.Add(labels[x][3] as Label);//

                    panels[x].Controls.Add(Buttons[x][0] as RadioButton);//Adds the buttons to the panel
                    panels[x].Controls.Add(Buttons[x][1] as RadioButton);//
                    panels[x].Controls.Add(Buttons[x][2] as RadioButton);//
                        
                    Controls.Add(panels[x]);//adds the panel to the form
                    #endregion
                }
            }
        }

        public void Submit(object sender, EventArgs e)
        {
            if (NameInputTextbox.Text != "")//if filename exists
            {

                int answer, total = 0;
                bool[] correct = new bool[NoOfQuesions];
                for (int x = 0; x < NoOfQuesions; x++)
                {
                    answer = 0;
                    #region Check which button was selected
                    if ((panels[x].Controls[4] as RadioButton).Checked)
                    {
                        answer = 1;
                    }
                    else if ((panels[x].Controls[5] as RadioButton).Checked)
                    {
                        answer = 2;
                    }
                    else if ((panels[x].Controls[5] as RadioButton).Checked)
                    {
                        answer = 3;
                    }
                    #endregion

                    #region was that button the correct one?
                    if (answer == correctnos[x])
                    {
                        correct[x] = true;
                        total++;
                    }
                    else
                    {
                        correct[x] = false;
                    }
                    #endregion
                }
                using (BinaryWriter writer = new BinaryWriter(new FileStream("Quizzes/Scores/" + QuizSelectionForm.Quizfilename + "/" + NameInputTextbox.Text, FileMode.Create)))
                {
                    writer.Write(NameInputTextbox.Text);//saves the score and name
                    writer.Write(total);
                }
                this.Close();
            }
        }
    }
}