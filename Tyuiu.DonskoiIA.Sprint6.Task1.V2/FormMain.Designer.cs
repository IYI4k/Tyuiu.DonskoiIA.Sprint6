namespace Tyuiu.DonskoiIA.Sprint6.Task1.V2
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
            groupBoxWithRequirements = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            groupBoxValuesInput = new GroupBox();
            groupBoxEndValue = new GroupBox();
            textBoxEndValue = new TextBox();
            groupBoxStartValue = new GroupBox();
            textBoxStartValue = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxAnswer1 = new GroupBox();
            groupBoxAnswer2 = new GroupBox();
            textBoxResult = new TextBox();
            groupBoxWithRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxValuesInput.SuspendLayout();
            groupBoxEndValue.SuspendLayout();
            groupBoxStartValue.SuspendLayout();
            groupBoxAnswer1.SuspendLayout();
            groupBoxAnswer2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWithRequirements
            // 
            groupBoxWithRequirements.Controls.Add(pictureBoxFormula);
            groupBoxWithRequirements.Controls.Add(textBoxTask);
            groupBoxWithRequirements.Location = new Point(12, 12);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Size = new Size(458, 129);
            groupBoxWithRequirements.TabIndex = 0;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.Screenshot_582;
            pictureBoxFormula.Location = new Point(6, 85);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(186, 38);
            pictureBoxFormula.TabIndex = 1;
            pictureBoxFormula.TabStop = false;
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(446, 101);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат вывести в виде таблицы. ";
            // 
            // groupBoxValuesInput
            // 
            groupBoxValuesInput.Controls.Add(groupBoxEndValue);
            groupBoxValuesInput.Controls.Add(groupBoxStartValue);
            groupBoxValuesInput.Location = new Point(12, 147);
            groupBoxValuesInput.Name = "groupBoxValuesInput";
            groupBoxValuesInput.Size = new Size(224, 93);
            groupBoxValuesInput.TabIndex = 1;
            groupBoxValuesInput.TabStop = false;
            groupBoxValuesInput.Text = "Ввод данных";
            // 
            // groupBoxEndValue
            // 
            groupBoxEndValue.Controls.Add(textBoxEndValue);
            groupBoxEndValue.Location = new Point(115, 22);
            groupBoxEndValue.Name = "groupBoxEndValue";
            groupBoxEndValue.Size = new Size(103, 60);
            groupBoxEndValue.TabIndex = 1;
            groupBoxEndValue.TabStop = false;
            groupBoxEndValue.Text = "Конец шага:";
            // 
            // textBoxEndValue
            // 
            textBoxEndValue.Location = new Point(0, 22);
            textBoxEndValue.Name = "textBoxEndValue";
            textBoxEndValue.Size = new Size(103, 23);
            textBoxEndValue.TabIndex = 0;
            textBoxEndValue.KeyPress += NumberInput;
            // 
            // groupBoxStartValue
            // 
            groupBoxStartValue.Controls.Add(textBoxStartValue);
            groupBoxStartValue.Location = new Point(6, 22);
            groupBoxStartValue.Name = "groupBoxStartValue";
            groupBoxStartValue.Size = new Size(103, 60);
            groupBoxStartValue.TabIndex = 0;
            groupBoxStartValue.TabStop = false;
            groupBoxStartValue.Text = "Старт шага:";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(0, 22);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(103, 23);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.KeyPress += NumberInput;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LawnGreen;
            buttonDone.Location = new Point(372, 197);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 2;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.MediumTurquoise;
            buttonHelp.FlatStyle = FlatStyle.Flat;
            buttonHelp.Location = new Point(300, 197);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(66, 43);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // groupBoxAnswer1
            // 
            groupBoxAnswer1.Controls.Add(groupBoxAnswer2);
            groupBoxAnswer1.Location = new Point(476, 12);
            groupBoxAnswer1.Name = "groupBoxAnswer1";
            groupBoxAnswer1.Size = new Size(232, 292);
            groupBoxAnswer1.TabIndex = 4;
            groupBoxAnswer1.TabStop = false;
            groupBoxAnswer1.Text = "Вывод данных";
            // 
            // groupBoxAnswer2
            // 
            groupBoxAnswer2.Controls.Add(textBoxResult);
            groupBoxAnswer2.Location = new Point(0, 22);
            groupBoxAnswer2.Name = "groupBoxAnswer2";
            groupBoxAnswer2.Size = new Size(232, 270);
            groupBoxAnswer2.TabIndex = 0;
            groupBoxAnswer2.TabStop = false;
            groupBoxAnswer2.Text = "Результат";
            // 
            // textBoxResult
            // 
            textBoxResult.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxResult.Location = new Point(6, 22);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.Size = new Size(220, 242);
            textBoxResult.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(720, 316);
            Controls.Add(groupBoxAnswer1);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Controls.Add(groupBoxValuesInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 1 | Вариант 2 | Донской И. А.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxValuesInput.ResumeLayout(false);
            groupBoxEndValue.ResumeLayout(false);
            groupBoxEndValue.PerformLayout();
            groupBoxStartValue.ResumeLayout(false);
            groupBoxStartValue.PerformLayout();
            groupBoxAnswer1.ResumeLayout(false);
            groupBoxAnswer2.ResumeLayout(false);
            groupBoxAnswer2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxValuesInput;
        private GroupBox groupBoxStartValue;
        private TextBox textBoxStartValue;
        private GroupBox groupBoxEndValue;
        private TextBox textBoxEndValue;
        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxAnswer1;
        private GroupBox groupBoxAnswer2;
        private TextBox textBoxResult;
    }
}
