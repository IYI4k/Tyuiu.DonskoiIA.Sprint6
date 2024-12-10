namespace Tyuiu.DonskoiIA.Sprint6.Task3.V19
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
            components = new System.ComponentModel.Container();
            buttonDone = new Button();
            buttonHelp = new Button();
            groupBoxWithRequirements = new GroupBox();
            textBoxTask = new TextBox();
            dataGridViewResult = new DataGridView();
            dataGridViewDataInput = new DataGridView();
            formMainBindingSource = new BindingSource(components);
            groupBoxWithRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)formMainBindingSource).BeginInit();
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
            buttonDone.Click += buttonDone_Click;
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
            buttonHelp.Click += buttonHelp_Click;
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
            textBoxTask.Text = "Дана матрица 5 на 5.\r\nОтсортировать её 5 столбец по возрастанию";
            // 
            // dataGridViewResult
            // 
            dataGridViewResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult.Location = new Point(510, 12);
            dataGridViewResult.Name = "dataGridViewResult";
            dataGridViewResult.ReadOnly = true;
            dataGridViewResult.Size = new Size(278, 278);
            dataGridViewResult.TabIndex = 7;
            // 
            // dataGridViewDataInput
            // 
            dataGridViewDataInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewDataInput.Location = new Point(217, 12);
            dataGridViewDataInput.Name = "dataGridViewDataInput";
            dataGridViewDataInput.Size = new Size(278, 278);
            dataGridViewDataInput.TabIndex = 8;
            dataGridViewDataInput.EditingControlShowing += dataGridViewDataInput_EditingControlShowing;
            // 
            // formMainBindingSource
            // 
            formMainBindingSource.DataSource = typeof(FormMain);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewDataInput);
            Controls.Add(dataGridViewResult);
            Controls.Add(groupBoxWithRequirements);
            Controls.Add(buttonHelp);
            Controls.Add(buttonDone);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 3 | Вариант 19 | Донской И. А.";
            Load += FormMain_Load;
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewDataInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)formMainBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonDone;
        private Button buttonHelp;
        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
        private DataGridView dataGridViewResult;
        private DataGridView dataGridViewDataInput;
        private BindingSource formMainBindingSource;
    }
}
