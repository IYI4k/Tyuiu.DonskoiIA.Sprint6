namespace Tyuiu.DonskoiIA.Sprint5.Task0.V12
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxWithRequirements = new GroupBox();
            textBoxTask = new TextBox();
            pictureBoxFormula = new PictureBox();
            groupBoxValuesInput = new GroupBox();
            groupBoxOfValue_x = new GroupBox();
            textBoxValue_x_Input = new TextBox();
            groupBoxWithAnswer = new GroupBox();
            groupBoxResult = new GroupBox();
            textBoxResult = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxWithRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxValuesInput.SuspendLayout();
            groupBoxOfValue_x.SuspendLayout();
            groupBoxWithAnswer.SuspendLayout();
            groupBoxResult.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWithRequirements
            // 
            groupBoxWithRequirements.Controls.Add(textBoxTask);
            groupBoxWithRequirements.Location = new Point(12, 12);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Size = new Size(239, 129);
            groupBoxWithRequirements.TabIndex = 0;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 21);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(233, 102);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Вычислить выражение по формуле";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = (Image)resources.GetObject("pictureBoxFormula.Image");
            pictureBoxFormula.Location = new Point(322, 33);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(147, 68);
            pictureBoxFormula.TabIndex = 2;
            pictureBoxFormula.TabStop = false;
            // 
            // groupBoxValuesInput
            // 
            groupBoxValuesInput.Controls.Add(groupBoxOfValue_x);
            groupBoxValuesInput.Location = new Point(12, 147);
            groupBoxValuesInput.Name = "groupBoxValuesInput";
            groupBoxValuesInput.Size = new Size(304, 93);
            groupBoxValuesInput.TabIndex = 3;
            groupBoxValuesInput.TabStop = false;
            groupBoxValuesInput.Text = "Ввод данных";
            // 
            // groupBoxOfValue_x
            // 
            groupBoxOfValue_x.Controls.Add(textBoxValue_x_Input);
            groupBoxOfValue_x.Location = new Point(6, 22);
            groupBoxOfValue_x.Name = "groupBoxOfValue_x";
            groupBoxOfValue_x.Size = new Size(103, 60);
            groupBoxOfValue_x.TabIndex = 0;
            groupBoxOfValue_x.TabStop = false;
            groupBoxOfValue_x.Text = "Переменная X:";
            // 
            // textBoxValue_x_Input
            // 
            textBoxValue_x_Input.Location = new Point(0, 22);
            textBoxValue_x_Input.Name = "textBoxValue_x_Input";
            textBoxValue_x_Input.Size = new Size(103, 23);
            textBoxValue_x_Input.TabIndex = 0;
            textBoxValue_x_Input.KeyPress += NumberInput;
            // 
            // groupBoxWithAnswer
            // 
            groupBoxWithAnswer.Controls.Add(groupBoxResult);
            groupBoxWithAnswer.Location = new Point(322, 147);
            groupBoxWithAnswer.Name = "groupBoxWithAnswer";
            groupBoxWithAnswer.Size = new Size(147, 93);
            groupBoxWithAnswer.TabIndex = 4;
            groupBoxWithAnswer.TabStop = false;
            groupBoxWithAnswer.Text = "Вывод данных:";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(textBoxResult);
            groupBoxResult.Location = new Point(6, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(135, 45);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Location = new Point(0, 22);
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(135, 23);
            textBoxResult.TabIndex = 0;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(371, 269);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(322, 269);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(43, 43);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "?";
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(481, 324);
            Controls.Add(buttonHelp);
            Controls.Add(pictureBoxFormula);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxWithAnswer);
            Controls.Add(groupBoxValuesInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 0 | Вариант 12 | Донской И. А.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxValuesInput.ResumeLayout(false);
            groupBoxOfValue_x.ResumeLayout(false);
            groupBoxOfValue_x.PerformLayout();
            groupBoxWithAnswer.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            groupBoxResult.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxValuesInput;
        private GroupBox groupBoxWithAnswer;
        private GroupBox groupBoxOfValue_x;
        private TextBox textBoxValue_x_Input;
        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxResult;
        private TextBox textBoxResult;
        private TextBox textBoxTask;
    }
}
