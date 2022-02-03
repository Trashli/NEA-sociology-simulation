using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace NEA_sociology_simulation
{
    public partial class QuizMakingForm : Form
    {
        #region Lists for the questions
        int NoOfQs = 0;
        List<TextBox[]> textboxlist = new List<TextBox[]>();
        List<RadioButton[]> radiobuttonlist = new List<RadioButton[]>();
        Button addbutton = new Button();
        List<Label[]> labellist = new List<Label[]>();
        List<Panel> buttongroups = new List<Panel>();
        List<Panel> Panels = new List<Panel>();
        #endregion
        //will store all the objects placed inside the form

        #region initialiser
        public QuizMakingForm()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            addbutton.Click += new EventHandler(newquestion);//
            addbutton.Text = "+";                            //Creates + button which adds new questions
            Controls.Add(addbutton);                         //
            addbutton.PerformClick();//adds a question
        }
        #endregion

        public void newquestion(object sender, EventArgs e)
        {
            #region sets up a panel
            Panels.Add(new Panel());
            Panels[NoOfQs].Size = new Size(500, 90);
            Panels[NoOfQs].Location = new Point(0, NoOfQs * 100);
            Panels[NoOfQs].Visible = true;
            #endregion
            //The panel is used for placing objects in,
            //this also stops radio buttons from cross connecting

            radiobuttonlist.Add(new RadioButton[3]);//Adds an array capable of holding 3 radio buttons

            #region -Button
            Panels[NoOfQs].Controls.Add(new Button());
            Panels[NoOfQs].Controls[0].Location = new Point(400, 30);
            Panels[NoOfQs].Controls[0].Text = "-";
            Panels[NoOfQs].Controls[0].Click += new EventHandler(deletebuttonpress);
            #endregion
            //Creates and sets up a button to remove this question

            labellist.Add(new Label[5]);
            //Adds an array with 5 labels

            #region Q label
            labellist[NoOfQs][0] = new Label();
            labellist[NoOfQs][0].Location = new Point(0, 17);
            labellist[NoOfQs][0].Text = "Q";
            labellist[NoOfQs][0].Size = new Size(10, 15);
            Panels[NoOfQs].Controls.Add(labellist[NoOfQs][0]);
            #endregion
            //creates a label indicating the question

            #region Correct A label
            labellist[NoOfQs][1] = new Label();
            labellist[NoOfQs][1].Location = new Point(-2, 65);
            labellist[NoOfQs][1].Text = "Correct A:";
            labellist[NoOfQs][1].Size = new Size(55, 15);
            Panels[NoOfQs].Controls.Add(labellist[NoOfQs][1]);
            #endregion
            //Creates a label Indicating the radio buttons

            textboxlist.Add(new TextBox[4]);
            //Adds an array with 4 textboxes

            #region Q Textbox
            textboxlist[NoOfQs][0] = new TextBox();
            textboxlist[NoOfQs][0].Location = new Point(15, 15);
            Panels[NoOfQs].Controls.Add(textboxlist[NoOfQs][0]);
            #endregion
            //Creates a textbox for the question to be entered

            #region A Textboxes and RadioButtons
            for (int x = 1; x < 4; x++)
            {
                textboxlist[NoOfQs][x] = new TextBox();
                textboxlist[NoOfQs][x].Location = new Point(15 + 125 * (x - 1), 40);
                Panels[NoOfQs].Controls.Add(textboxlist[NoOfQs][x]);

                labellist[NoOfQs][x + 1] = new Label();
                labellist[NoOfQs][x + 1].Location = new Point(125 * (x - 1) - 2, 43);
                labellist[NoOfQs][x + 1].Text = "A" + x.ToString();
                labellist[NoOfQs][x + 1].Size = new Size(30, 20);
                Panels[NoOfQs].Controls.Add(labellist[NoOfQs][x + 1]);

                radiobuttonlist[NoOfQs][x - 1] = new RadioButton();
                radiobuttonlist[NoOfQs][x - 1].Location = new Point(55 + 125 * (x - 1), 60);
                Panels[NoOfQs].Controls.Add(radiobuttonlist[NoOfQs][x - 1]);
            }
            #endregion
            //Adds three textboxes for answers with corresponding radiobuttons
            //for designating which of those were correct

            Controls.Add(Panels[NoOfQs]);//adds the above to the form
            addbutton.Location = new Point(250, NoOfQs * 100 + 100);//moves + button down
            ++NoOfQs;//ticks up the total number of questions
        }

        public void deletebuttonpress(object sender, EventArgs e)
        {
            int row = 0;

            #region Remove panel
            for (int x = 0; x < Panels.Count; x++)
            {
                if (Panels[x].Controls[0] == sender as Button)
                {
                    row = x;
                    Controls.Remove(Panels[x]);
                    break;
                }
            }
            #endregion
            //checks all panels contents against this button to find and delete the panel the button is in

            addbutton.Location = new Point(250, addbutton.Location.Y - 100);
            //moves the +Button down 100 pixels

            #region panel corrector
            for (int x = row; x < Panels.Count; ++x)
            {
                Panels[x].Location = new Point(0, Panels[x].Location.Y - 100);
            }
            #endregion
            //moves all the panels below this up 100 pixels

            Controls.Remove(Panels[row]); Panels.RemoveAt(row);//removes the panel
            --NoOfQs;//Decrements the total amount of Questions
        }

        public void savequiz(object sender, EventArgs e)
        {
            bool donotexecute = false;
            #region no double saves
            if (NameInput.Text.Length > 0)
            {
                for (int x = 0; x < Directory.GetFiles("Quizzes", "*", SearchOption.TopDirectoryOnly).Length; x++)
                    //goes through all files in the top directory of Quizzes/
                {
                    string checkfilename = Directory.GetFiles("Quizzes", "*", SearchOption.TopDirectoryOnly)[x].Substring(0, Directory.GetFiles("Quizzes", "*", SearchOption.TopDirectoryOnly)[x].Length - 4);
                    //saves the file name for file x
                    if ("Quizzes\\" + NameInput.Text == checkfilename)//checks if a file name is taken
                    {
                        NameInput.Text = "save file name taken";
                        donotexecute = true;
                        break;
                    }
                }
            }
            #endregion
            //ensures double saves dont occur

            if (!donotexecute)
            {
                #region binary file writer
                bool delete = false;
                Directory.CreateDirectory(@"Quizzes\\Scores\\" + NameInput.Text);
                //creates a scores file for the quiz
                using (BinaryWriter writer = new BinaryWriter(new FileStream("Quizzes/" + NameInput.Text, FileMode.Create)))
                    //creates a quiz file
                {
                    writer.Write(Convert.ToString(Panels.Count));
                    //writes the number of questions to the file

                    for (int x = 0; x < Panels.Count; x++)//checks through all the panels
                    {
                        int correctno = 0;

                        if ((Panels[x].Controls[6] as RadioButton).Checked)
                        {
                            correctno = 1;
                        }
                        else if ((Panels[x].Controls[9] as RadioButton).Checked)
                        {
                            correctno = 2;
                        }
                        else if ((Panels[x].Controls[12] as RadioButton).Checked)
                        {
                            correctno = 3;
                        }
                        //checks for which answer is selected as correct

                        else { delete = true; break; }
                        //checks if an answer is given

                        writer.Write(Convert.ToString(correctno));//
                        writer.Write(Panels[x].Controls[4].Text); //
                        writer.Write(Panels[x].Controls[7].Text); //Writes the question data to the file
                        writer.Write(Panels[x].Controls[10].Text);//
                        writer.Write(Panels[x].Controls[3].Text); //
                    }
                    if (delete == false)
                    {
                        this.Hide();
                    }
                }
                if (delete == true)
                {
                    File.Delete("Quizzes/" + NameInput.Text);
                }
                #endregion
                //writes the data to a binary file
            }
        }
    }
}