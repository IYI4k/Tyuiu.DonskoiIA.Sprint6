namespace Tyuiu.DonskoiIA.Sprint6.Task4.V15
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxWithRequirements = new GroupBox();
            pictureBoxFormula = new PictureBox();
            textBoxTask = new TextBox();
            groupBoxDataInput = new GroupBox();
            groupBoxEndValue = new GroupBox();
            textBoxEndValue = new TextBox();
            groupBoxStartValue = new GroupBox();
            textBoxStartValue = new TextBox();
            buttonDone = new Button();
            buttonHelp = new Button();
            panelUp = new Panel();
            groupBoxTable = new GroupBox();
            textBoxTable = new TextBox();
            chartResult = new System.Windows.Forms.DataVisualization.Charting.Chart();
            buttonSave = new Button();
            panelLeft = new Panel();
            panelRight = new Panel();
            splitterBetweenTableAndChart = new Splitter();
            groupBoxWithRequirements.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).BeginInit();
            groupBoxDataInput.SuspendLayout();
            groupBoxEndValue.SuspendLayout();
            groupBoxStartValue.SuspendLayout();
            panelUp.SuspendLayout();
            groupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).BeginInit();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxWithRequirements
            // 
            groupBoxWithRequirements.Controls.Add(pictureBoxFormula);
            groupBoxWithRequirements.Controls.Add(textBoxTask);
            groupBoxWithRequirements.Location = new Point(12, 12);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Size = new Size(351, 129);
            groupBoxWithRequirements.TabIndex = 1;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // pictureBoxFormula
            // 
            pictureBoxFormula.Image = Properties.Resources.Sprint6Task4V15Formula;
            pictureBoxFormula.Location = new Point(6, 75);
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
            textBoxTask.Size = new Size(339, 91);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Протабулировать фукнцию на заданном диапазоне.\r\nРезультат вывести в TextBox, построить график функции и сохранить в файл по нажатию кнопки\r\n";
            // 
            // groupBoxDataInput
            // 
            groupBoxDataInput.Controls.Add(groupBoxEndValue);
            groupBoxDataInput.Controls.Add(groupBoxStartValue);
            groupBoxDataInput.Location = new Point(369, 12);
            groupBoxDataInput.Name = "groupBoxDataInput";
            groupBoxDataInput.Size = new Size(212, 67);
            groupBoxDataInput.TabIndex = 2;
            groupBoxDataInput.TabStop = false;
            groupBoxDataInput.Text = "Ввод данных:";
            // 
            // groupBoxEndValue
            // 
            groupBoxEndValue.Controls.Add(textBoxEndValue);
            groupBoxEndValue.Location = new Point(109, 22);
            groupBoxEndValue.Name = "groupBoxEndValue";
            groupBoxEndValue.Size = new Size(103, 45);
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
            groupBoxStartValue.Location = new Point(0, 22);
            groupBoxStartValue.Name = "groupBoxStartValue";
            groupBoxStartValue.Size = new Size(103, 45);
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
            // buttonDone
            // 
            buttonDone.BackColor = Color.LawnGreen;
            buttonDone.Location = new Point(587, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(98, 67);
            buttonDone.TabIndex = 5;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.FromArgb(128, 255, 255);
            buttonHelp.Location = new Point(940, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(66, 67);
            buttonHelp.TabIndex = 6;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // panelUp
            // 
            panelUp.Controls.Add(buttonSave);
            panelUp.Controls.Add(groupBoxWithRequirements);
            panelUp.Controls.Add(buttonHelp);
            panelUp.Controls.Add(groupBoxDataInput);
            panelUp.Controls.Add(buttonDone);
            panelUp.Dock = DockStyle.Top;
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(1018, 142);
            panelUp.TabIndex = 7;
            // 
            // groupBoxTable
            // 
            groupBoxTable.Controls.Add(textBoxTable);
            groupBoxTable.Dock = DockStyle.Fill;
            groupBoxTable.Location = new Point(0, 0);
            groupBoxTable.Name = "groupBoxTable";
            groupBoxTable.Padding = new Padding(5);
            groupBoxTable.Size = new Size(201, 353);
            groupBoxTable.TabIndex = 0;
            groupBoxTable.TabStop = false;
            groupBoxTable.Text = "Вывод";
            // 
            // textBoxTable
            // 
            textBoxTable.Dock = DockStyle.Fill;
            textBoxTable.Location = new Point(5, 21);
            textBoxTable.Multiline = true;
            textBoxTable.Name = "textBoxTable";
            textBoxTable.ReadOnly = true;
            textBoxTable.ScrollBars = ScrollBars.Vertical;
            textBoxTable.Size = new Size(191, 327);
            textBoxTable.TabIndex = 0;
            // 
            // chartResult
            // 
            chartArea1.Name = "ChartArea1";
            chartResult.ChartAreas.Add(chartArea1);
            chartResult.Dock = DockStyle.Fill;
            chartResult.Location = new Point(0, 0);
            chartResult.Name = "chartResult";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Name = "Series1";
            chartResult.Series.Add(series1);
            chartResult.Size = new Size(817, 353);
            chartResult.TabIndex = 1;
            chartResult.Text = "chart1";
            title1.Name = "Title1";
            title1.Text = "График функции";
            chartResult.Titles.Add(title1);
            // 
            // buttonSave
            // 
            buttonSave.BackColor = SystemColors.HotTrack;
            buttonSave.Location = new Point(691, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(74, 67);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = false;
            buttonSave.Click += buttonSaveClick;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = SystemColors.Control;
            panelLeft.Controls.Add(groupBoxTable);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 142);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(201, 353);
            panelLeft.TabIndex = 8;
            // 
            // panelRight
            // 
            panelRight.BackColor = SystemColors.Control;
            panelRight.Controls.Add(chartResult);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(201, 142);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(817, 353);
            panelRight.TabIndex = 9;
            // 
            // splitterBetweenTableAndChart
            // 
            splitterBetweenTableAndChart.Location = new Point(201, 142);
            splitterBetweenTableAndChart.Name = "splitterBetweenTableAndChart";
            splitterBetweenTableAndChart.Size = new Size(3, 353);
            splitterBetweenTableAndChart.TabIndex = 10;
            splitterBetweenTableAndChart.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1018, 495);
            Controls.Add(splitterBetweenTableAndChart);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            Controls.Add(panelUp);
            MinimizeBox = false;
            MinimumSize = new Size(865, 250);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 4 | Вариант 15 | Донской И. А.";
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula).EndInit();
            groupBoxDataInput.ResumeLayout(false);
            groupBoxEndValue.ResumeLayout(false);
            groupBoxEndValue.PerformLayout();
            groupBoxStartValue.ResumeLayout(false);
            groupBoxStartValue.PerformLayout();
            panelUp.ResumeLayout(false);
            groupBoxTable.ResumeLayout(false);
            groupBoxTable.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartResult).EndInit();
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxWithRequirements;
        private PictureBox pictureBoxFormula;
        private TextBox textBoxTask;
        private GroupBox groupBoxDataInput;
        private GroupBox groupBoxEndValue;
        private TextBox textBoxEndValue;
        private GroupBox groupBoxStartValue;
        private TextBox textBoxStartValue;
        private Button buttonDone;
        private Button buttonHelp;
        private Panel panelUp;
        private Splitter splitterBetweenTableAndGraph;
        private Button buttonSave;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartResult;
        private GroupBox groupBoxTable;
        private TextBox textBoxTable;
        private Panel panelLeft;
        private Panel panelRight;
        private Splitter splitterBetweenTableAndChart;
    }
}
