using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ToDoList.Classes;
using System.Text.RegularExpressions;

namespace ToDoList
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
            panel2.Visible = false;
            panel3.Visible = false;
            panel4.Visible = false;
            panel5.Visible = false;
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        //This is the button for the main menu to enter the To Do List Program
        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
        }

        //A button to go back to the main menu
        private void MainMenuButton_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
        }

        //Add button to add a item to the To Do List
        private void AddButton_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Input is invalid, please write text in the box.");
                return;
            }
            string UserInput = textBox1.Text;
            AddTextToList(UserInput);
        }

        private void TaskListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DeleteTask.Checked)
            {
                for(int i = TaskListBox.Items.Count - 1; i >= 0; i--)
                {
                    if (TaskListBox.GetItemChecked(i))
                    {
                        TaskListBox.Items.RemoveAt(i);
                    }
                }
            }
        }
  
        private void AddTextToList(string Text)
        {
            if (!checkBox1.Checked) 
            {
                TaskListBox.Items.Add(Text);
            }
            else
            {
                TaskListBox.Items.Insert(0, Text);
            }
        }
        // Next time im working on it, focus on working on some exception handling

        private void RemoveButton_Click_1(object sender, EventArgs e)
        {
            string UserInput = textBox1.Text;
            RemoveTextFromList(UserInput);
        }
        private void RemoveTextFromList(string Text)
        {
            if (!TaskListBox.Items.Contains(Text))
            {
                MessageBox.Show("Input is invalid, the text entered didnt match the name of a task to remove.");
                return;
            }
            TaskListBox.Items.Remove(Text);
            MessageBox.Show("Input is valid, task has been removed from list");
        }

        private void OptionsButton_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void BackToList_Click(object sender, EventArgs e)
        {
            panel3.Visible = false;
        }

        private void DeleteTask_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void LoadList_Click(object sender, EventArgs e)
        {
            panel5.Visible = true;
        }

        private void SaveList_Click(object sender, EventArgs e)
        {
            panel4.Visible = true;
        }

        private void SaveName_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(SaveFileName.Text,@"^[a-zA-Z]+$"))
            {
                string FilePath = GetSavedListsDirectory(SaveFileName.Text);

                Console.WriteLine(FilePath);
                List<string> StrTaskList = new List<string>();

                for (int i = 0; i < TaskListBox.Items.Count; i++)
                {
                    if (TaskListBox.GetItemChecked(i))
                    {
                        StrTaskList.Add(TaskListBox.Items[i].ToString() + "-1");
                    }
                    else
                    {
                        StrTaskList.Add(TaskListBox.Items[i].ToString() + "-0");
                    }
                }

                if (File.Exists(FilePath + ".txt"))
                {
                    MessageBox.Show("Already existing file has been overwritten.");
                }
                else
                {
                    MessageBox.Show("File has been saved in: " + FilePath);
                }


                File.WriteAllLines(FilePath + ".txt", StrTaskList);
            }
            else
            {
                MessageBox.Show("Input is invalid, please enter a name which only contains letters.");
            }
            panel4.Visible = false;

        }

        private void LoadSavedList_Click(object sender, EventArgs e)
        {
            try
            {
                string PathFile = GetSavedListsDirectory(LoadFileName.Text);
                TaskListBox.Items.Clear();

                var Lines = File.ReadLines(PathFile + ".txt");
                int i = 0;
                foreach (string Line in Lines)
                {
                    string[] temp = Line.Split('-');
                    TaskListBox.Items.Add(temp[0]);
                    if (temp[1] == "0")
                    {
                        TaskListBox.SetItemChecked(i, false);
                    }
                    if (temp[1] == "1")
                    {
                        TaskListBox.SetItemChecked(i, true);
                    }
                    i++;
                }
                
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found, please enter the name of a file that exists.");
            }
            panel5.Visible = false;
        }

        private string GetSavedListsDirectory(string NameOfNewFile)
        {
            // This line gets the path of the project directory
            string ProjectDirectory = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;

            // This line combines the ProjectDirectory variable and savedlists string into one
            string SavedListPath = Path.Combine(ProjectDirectory, "SavedLists");

            // Finally this line combines the SavedListPath and the SaveFileName.Text into one to get the intended path
            string FilePath = Path.Combine(SavedListPath, NameOfNewFile);
            return FilePath;
        }
    }
}
