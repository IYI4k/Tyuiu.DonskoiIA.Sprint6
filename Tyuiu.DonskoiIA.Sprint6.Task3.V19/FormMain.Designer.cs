﻿namespace Tyuiu.DonskoiIA.Sprint6.Task3.V19
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
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxWithRequirements = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxWithRequirements.SuspendLayout();
            SuspendLayout();
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LawnGreen;
            buttonDone.Location = new Point(690, 395);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 4;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp.Location = new Point(618, 395);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(66, 43);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            // 
            // groupBoxWithRequirements
            // 
            groupBoxWithRequirements.Controls.Add(textBoxTask);
            groupBoxWithRequirements.Location = new Point(12, 12);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Size = new Size(205, 426);
            groupBoxWithRequirements.TabIndex = 6;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Font = new Font("Consolas", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(193, 398);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Дана матрица 5 на 5\r\n  4  32 -20  27  21\r\n 17  15  -1  -2  -1\r\n -3  18  12 -10  29\r\n  7 -15   2  -8  12\r\n-10  25   5  27  21\r\nОтсортировать её 5 столбец по возрастанию";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxWithRequirements);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            Name = "FormMain";
            Text = "Form1";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
    }
}
