namespace Tyuiu.DonskoiIA.Sprint6.Task2.V29
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            groupBoxWithRequirements = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            groupBoxDataInput = new GroupBox();
            groupBoxEndValue = new GroupBox();
            textBoxEndValue = new TextBox();
            groupBoxStartValue = new GroupBox();
            textBoxStartValue = new TextBox();
            buttonHelp = new Button();
            buttonDone = new Button();
            dataGridViewFunctionTab = new DataGridView();
            DataGridViewFunctionTab_X = new DataGridViewTextBoxColumn();
            DataGridViewFunctionTab_Fx = new DataGridViewTextBoxColumn();
            groupBoxDataOutput = new GroupBox();
            groupBoxResult = new GroupBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxWithRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxDataInput.SuspendLayout();
            groupBoxEndValue.SuspendLayout();
            groupBoxStartValue.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunctionTab).BeginInit();
            groupBoxDataOutput.SuspendLayout();
            groupBoxResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
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
            pictureBoxFormula.Image = Properties.Resources.Screenshot_592;
            pictureBoxFormula.Location = new Point(6, 85);
            pictureBoxFormula.Name = "pictureBoxFormula";
            pictureBoxFormula.Size = new Size(339, 38);
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
            textBoxTask.Text = "Протабулировать фукнцию на заданном диапазоне.\r\nРезультат вывести в DataGridView и построить график функции";
            // 
            // groupBoxDataInput
            // 
            groupBoxDataInput.Controls.Add(groupBoxEndValue);
            groupBoxDataInput.Controls.Add(groupBoxStartValue);
            groupBoxDataInput.Location = new Point(18, 209);
            groupBoxDataInput.Name = "groupBoxDataInput";
            groupBoxDataInput.Size = new Size(224, 93);
            groupBoxDataInput.TabIndex = 1;
            groupBoxDataInput.TabStop = false;
            groupBoxDataInput.Text = "Ввод данных:";
            // 
            // groupBoxEndValue
            // 
            groupBoxEndValue.Controls.Add(textBoxEndValue);
            groupBoxEndValue.Location = new Point(115, 22);
            groupBoxEndValue.Name = "groupBoxEndValue";
            groupBoxEndValue.Size = new Size(103, 65);
            groupBoxEndValue.TabIndex = 1;
            groupBoxEndValue.TabStop = false;
            groupBoxEndValue.Text = "Конец шага";
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
            groupBoxStartValue.Size = new Size(103, 65);
            groupBoxStartValue.TabIndex = 0;
            groupBoxStartValue.TabStop = false;
            groupBoxStartValue.Text = "Старт шага";
            // 
            // textBoxStartValue
            // 
            textBoxStartValue.Location = new Point(0, 22);
            textBoxStartValue.Name = "textBoxStartValue";
            textBoxStartValue.Size = new Size(103, 23);
            textBoxStartValue.TabIndex = 0;
            textBoxStartValue.KeyPress += NumberInput;
            // 
            // buttonHelp
            // 
            buttonHelp.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp.Location = new Point(294, 231);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(66, 43);
            buttonHelp.TabIndex = 2;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.BackColor = Color.LawnGreen;
            buttonDone.Location = new Point(366, 231);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 43);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            buttonDone.MouseDown += buttonDone_MouseDown;
            buttonDone.MouseEnter += buttonDone_MouseEnter;
            buttonDone.MouseLeave += buttonDone_MouseLeave;
            // 
            // dataGridViewFunctionTab
            // 
            dataGridViewFunctionTab.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFunctionTab.Columns.AddRange(new DataGridViewColumn[] { DataGridViewFunctionTab_X, DataGridViewFunctionTab_Fx });
            dataGridViewFunctionTab.Location = new Point(6, 22);
            dataGridViewFunctionTab.Name = "dataGridViewFunctionTab";
            dataGridViewFunctionTab.RowHeadersVisible = false;
            dataGridViewFunctionTab.Size = new Size(120, 246);
            dataGridViewFunctionTab.TabIndex = 4;
            // 
            // DataGridViewFunctionTab_X
            // 
            DataGridViewFunctionTab_X.HeaderText = "X";
            DataGridViewFunctionTab_X.Name = "DataGridViewFunctionTab_X";
            DataGridViewFunctionTab_X.ReadOnly = true;
            DataGridViewFunctionTab_X.Width = 50;
            // 
            // DataGridViewFunctionTab_Fx
            // 
            DataGridViewFunctionTab_Fx.HeaderText = "F(X)";
            DataGridViewFunctionTab_Fx.Name = "DataGridViewFunctionTab_Fx";
            DataGridViewFunctionTab_Fx.ReadOnly = true;
            DataGridViewFunctionTab_Fx.Width = 50;
            // 
            // groupBoxDataOutput
            // 
            groupBoxDataOutput.Controls.Add(groupBoxResult);
            groupBoxDataOutput.Location = new Point(476, 12);
            groupBoxDataOutput.Name = "groupBoxDataOutput";
            groupBoxDataOutput.Size = new Size(541, 290);
            groupBoxDataOutput.TabIndex = 5;
            groupBoxDataOutput.TabStop = false;
            groupBoxDataOutput.Text = "Вывод данных";
            // 
            // groupBoxResult
            // 
            groupBoxResult.Controls.Add(chartResult);
            groupBoxResult.Controls.Add(dataGridViewFunctionTab);
            groupBoxResult.Location = new Point(0, 22);
            groupBoxResult.Name = "groupBoxResult";
            groupBoxResult.Size = new Size(541, 268);
            groupBoxResult.TabIndex = 0;
            groupBoxResult.TabStop = false;
            groupBoxResult.Text = "Результат:";
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chartResult.Legends.Add(legend1);
            chartResult.Location = new Point(132, 22);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(409, 246);
            chartResult.TabIndex = 5;
            chartResult.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 314);
            Controls.Add(groupBoxDataOutput);
            Controls.Add(buttonDone);
            Controls.Add(buttonHelp);
            Controls.Add(groupBoxDataInput);
            Controls.Add(groupBoxWithRequirements);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 2 | Вариант 29 | Донской И. А.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxDataInput.ResumeLayout(false);
            groupBoxEndValue.ResumeLayout(false);
            groupBoxEndValue.PerformLayout();
            groupBoxStartValue.ResumeLayout(false);
            groupBoxStartValue.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFunctionTab).EndInit();
            groupBoxDataOutput.ResumeLayout(false);
            groupBoxResult.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
        private PictureBox pictureBoxFormula;
        private GroupBox groupBoxDataInput;
        private GroupBox groupBoxStartValue;
        private GroupBox groupBoxEndValue;
        private TextBox textBoxStartValue;
        private TextBox textBoxEndValue;
        private Button buttonHelp;
        private Button buttonDone;
        private DataGridView dataGridViewFunctionTab;
        private GroupBox groupBoxDataOutput;
        private GroupBox groupBoxResult;
        private DataGridViewTextBoxColumn DataGridViewFunctionTab_X;
        private DataGridViewTextBoxColumn DataGridViewFunctionTab_Fx;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
    }
}
