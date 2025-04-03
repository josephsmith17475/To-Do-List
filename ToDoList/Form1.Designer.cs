namespace ToDoList
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.DeleteTask = new System.Windows.Forms.CheckBox();
            this.BackToList = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.SaveName = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.SaveFileName = new System.Windows.Forms.TextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.LoadSavedList = new System.Windows.Forms.Button();
            this.LoadFileName = new System.Windows.Forms.TextBox();
            this.SaveList = new System.Windows.Forms.Button();
            this.LoadList = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.MainMenuButton = new System.Windows.Forms.Button();
            this.OptionsButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.TaskListBox = new System.Windows.Forms.CheckedListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1213, 591);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(224, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(744, 76);
            this.label1.TabIndex = 3;
            this.label1.Text = "To Do List Application";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(224, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(744, 85);
            this.button1.TabIndex = 2;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.MainMenuButton_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.SaveList);
            this.panel2.Controls.Add(this.LoadList);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.Controls.Add(this.MainMenuButton);
            this.panel2.Controls.Add(this.OptionsButton);
            this.panel2.Controls.Add(this.RemoveButton);
            this.panel2.Controls.Add(this.AddButton);
            this.panel2.Controls.Add(this.TaskListBox);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1213, 591);
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.DeleteTask);
            this.panel3.Controls.Add(this.BackToList);
            this.panel3.Controls.Add(this.checkBox1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1212, 591);
            this.panel3.TabIndex = 7;
            // 
            // DeleteTask
            // 
            this.DeleteTask.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DeleteTask.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteTask.Location = new System.Drawing.Point(230, 151);
            this.DeleteTask.Name = "DeleteTask";
            this.DeleteTask.Size = new System.Drawing.Size(349, 29);
            this.DeleteTask.TabIndex = 9;
            this.DeleteTask.Text = "Delete tasks when they are Checked";
            this.DeleteTask.UseVisualStyleBackColor = true;
            this.DeleteTask.CheckedChanged += new System.EventHandler(this.DeleteTask_CheckedChanged);
            // 
            // BackToList
            // 
            this.BackToList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BackToList.Location = new System.Drawing.Point(33, 517);
            this.BackToList.Name = "BackToList";
            this.BackToList.Size = new System.Drawing.Size(75, 51);
            this.BackToList.TabIndex = 8;
            this.BackToList.Text = "Back to list";
            this.BackToList.UseVisualStyleBackColor = true;
            this.BackToList.Click += new System.EventHandler(this.BackToList_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(230, 116);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(580, 29);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Add items to front of list ( if unchecked it adds them to the back )";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 37);
            this.label3.TabIndex = 0;
            this.label3.Text = "Options";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.SaveName);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.SaveFileName);
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1213, 591);
            this.panel4.TabIndex = 10;
            // 
            // SaveName
            // 
            this.SaveName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveName.Location = new System.Drawing.Point(503, 284);
            this.SaveName.Name = "SaveName";
            this.SaveName.Size = new System.Drawing.Size(204, 66);
            this.SaveName.TabIndex = 2;
            this.SaveName.Text = "Save";
            this.SaveName.UseVisualStyleBackColor = true;
            this.SaveName.Click += new System.EventHandler(this.SaveName_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(326, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Enter the name ( Only Letters ) of the save file below and click the save button " +
    "below";
            // 
            // SaveFileName
            // 
            this.SaveFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveFileName.Location = new System.Drawing.Point(329, 240);
            this.SaveFileName.Name = "SaveFileName";
            this.SaveFileName.Size = new System.Drawing.Size(569, 20);
            this.SaveFileName.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.label6);
            this.panel5.Controls.Add(this.LoadSavedList);
            this.panel5.Controls.Add(this.LoadFileName);
            this.panel5.Location = new System.Drawing.Point(1, 1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1212, 590);
            this.panel5.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(326, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(317, 18);
            this.label6.TabIndex = 2;
            this.label6.Text = "Enter the name of the saved file below to load it";
            // 
            // LoadSavedList
            // 
            this.LoadSavedList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadSavedList.Location = new System.Drawing.Point(503, 284);
            this.LoadSavedList.Name = "LoadSavedList";
            this.LoadSavedList.Size = new System.Drawing.Size(203, 82);
            this.LoadSavedList.TabIndex = 3;
            this.LoadSavedList.Text = "Load";
            this.LoadSavedList.UseVisualStyleBackColor = true;
            this.LoadSavedList.Click += new System.EventHandler(this.LoadSavedList_Click);
            // 
            // LoadFileName
            // 
            this.LoadFileName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoadFileName.Location = new System.Drawing.Point(329, 243);
            this.LoadFileName.Name = "LoadFileName";
            this.LoadFileName.Size = new System.Drawing.Size(568, 20);
            this.LoadFileName.TabIndex = 3;
            // 
            // SaveList
            // 
            this.SaveList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.SaveList.Location = new System.Drawing.Point(33, 110);
            this.SaveList.Name = "SaveList";
            this.SaveList.Size = new System.Drawing.Size(75, 51);
            this.SaveList.TabIndex = 9;
            this.SaveList.Text = "Save list";
            this.SaveList.UseVisualStyleBackColor = true;
            this.SaveList.Click += new System.EventHandler(this.SaveList_Click);
            // 
            // LoadList
            // 
            this.LoadList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.LoadList.Location = new System.Drawing.Point(33, 190);
            this.LoadList.Name = "LoadList";
            this.LoadList.Size = new System.Drawing.Size(75, 51);
            this.LoadList.TabIndex = 8;
            this.LoadList.Text = "Load list";
            this.LoadList.UseVisualStyleBackColor = true;
            this.LoadList.Click += new System.EventHandler(this.LoadList_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(875, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(321, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter name of task below then press add or remove buttons above";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Location = new System.Drawing.Point(896, 266);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(271, 20);
            this.textBox1.TabIndex = 5;
            // 
            // MainMenuButton
            // 
            this.MainMenuButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.MainMenuButton.Location = new System.Drawing.Point(13, 517);
            this.MainMenuButton.Name = "MainMenuButton";
            this.MainMenuButton.Size = new System.Drawing.Size(96, 61);
            this.MainMenuButton.TabIndex = 4;
            this.MainMenuButton.Text = "Back To Main Menu";
            this.MainMenuButton.UseVisualStyleBackColor = true;
            this.MainMenuButton.Click += new System.EventHandler(this.MainMenuButton_Click_1);
            // 
            // OptionsButton
            // 
            this.OptionsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OptionsButton.Location = new System.Drawing.Point(1100, 517);
            this.OptionsButton.Name = "OptionsButton";
            this.OptionsButton.Size = new System.Drawing.Size(96, 61);
            this.OptionsButton.TabIndex = 3;
            this.OptionsButton.Text = "List Options";
            this.OptionsButton.UseVisualStyleBackColor = true;
            this.OptionsButton.Click += new System.EventHandler(this.OptionsButton_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveButton.Location = new System.Drawing.Point(896, 94);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(271, 51);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove Task";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.RemoveButton_Click_1);
            // 
            // AddButton
            // 
            this.AddButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.AddButton.Location = new System.Drawing.Point(896, 37);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(271, 51);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add Task";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click_1);
            // 
            // TaskListBox
            // 
            this.TaskListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TaskListBox.BackColor = System.Drawing.Color.White;
            this.TaskListBox.FormattingEnabled = true;
            this.TaskListBox.Location = new System.Drawing.Point(182, 38);
            this.TaskListBox.Name = "TaskListBox";
            this.TaskListBox.Size = new System.Drawing.Size(667, 499);
            this.TaskListBox.TabIndex = 0;
            this.TaskListBox.SelectedIndexChanged += new System.EventHandler(this.TaskListBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1237, 615);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button MainMenuButton;
        private System.Windows.Forms.Button OptionsButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.CheckedListBox TaskListBox;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button BackToList;
        private System.Windows.Forms.CheckBox DeleteTask;
        private System.Windows.Forms.Button LoadList;
        private System.Windows.Forms.Button SaveList;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox SaveFileName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button SaveName;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox LoadFileName;
        private System.Windows.Forms.Button LoadSavedList;
    }
}

