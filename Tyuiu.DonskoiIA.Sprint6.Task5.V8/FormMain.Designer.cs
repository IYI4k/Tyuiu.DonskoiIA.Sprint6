namespace Tyuiu.DonskoiIA.Sprint6.Task5.V8
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
            panelUp = new Panel();
            buttonHelp = new Button();
            buttonFileOpen = new Button();
            buttonDone = new Button();
            groupBoxWithRequirements = new GroupBox();
            textBoxTask = new TextBox();
            panelLeft = new Panel();
            groupBoxTable = new GroupBox();
            dataGridViewTable = new DataGridView();
            panelFill = new Panel();
            chartDiag = new System.Windows.Forms.DataVisualization.Charting.Chart();
            splitter1 = new Splitter();
            panelUp.SuspendLayout();
            groupBoxWithRequirements.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).BeginInit();
            panelFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartDiag).BeginInit();
            SuspendLayout();
            // 
            // panelUp
            // 
            panelUp.Controls.Add(buttonHelp);
            panelUp.Controls.Add(buttonFileOpen);
            panelUp.Controls.Add(buttonDone);
            panelUp.Controls.Add(groupBoxWithRequirements);
            panelUp.Dock = DockStyle.Top;
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(800, 100);
            panelUp.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.BackColor = Color.LightSteelBlue;
            buttonHelp.Location = new Point(706, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(82, 82);
            buttonHelp.TabIndex = 5;
            buttonHelp.Text = "Справка";
            buttonHelp.UseVisualStyleBackColor = false;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonFileOpen
            // 
            buttonFileOpen.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonFileOpen.BackColor = Color.RoyalBlue;
            buttonFileOpen.Location = new Point(618, 12);
            buttonFileOpen.Name = "buttonFileOpen";
            buttonFileOpen.Size = new Size(82, 82);
            buttonFileOpen.TabIndex = 4;
            buttonFileOpen.Text = "Открыть файл";
            buttonFileOpen.UseVisualStyleBackColor = false;
            buttonFileOpen.Click += buttonFileOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone.BackColor = Color.Green;
            buttonDone.Location = new Point(530, 12);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(82, 82);
            buttonDone.TabIndex = 3;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = false;
            buttonDone.Click += buttonDone_Click;
            // 
            // groupBoxWithRequirements
            // 
            groupBoxWithRequirements.Controls.Add(textBoxTask);
            groupBoxWithRequirements.Location = new Point(3, 3);
            groupBoxWithRequirements.Name = "groupBoxWithRequirements";
            groupBoxWithRequirements.Size = new Size(463, 91);
            groupBoxWithRequirements.TabIndex = 2;
            groupBoxWithRequirements.TabStop = false;
            groupBoxWithRequirements.Text = "Условие";
            // 
            // textBoxTask
            // 
            textBoxTask.Location = new Point(6, 22);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(451, 52);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = "Прочитать данные из файла InPutFileTask5V8.txt. Вывести в dataGridView. Вывести все числа, меньше 0. Построить диаграмму по этим значениям. Дробные числа округлять до 3 знаков после запятой";
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxTable);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 100);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(110, 350);
            panelLeft.TabIndex = 0;
            // 
            // groupBoxTable
            // 
            groupBoxTable.Controls.Add(dataGridViewTable);
            groupBoxTable.Dock = DockStyle.Fill;
            groupBoxTable.Location = new Point(0, 0);
            groupBoxTable.Name = "groupBoxTable";
            groupBoxTable.Size = new Size(110, 350);
            groupBoxTable.TabIndex = 0;
            groupBoxTable.TabStop = false;
            groupBoxTable.Text = "Вывод данных:";
            // 
            // dataGridViewTable
            // 
            dataGridViewTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTable.Dock = DockStyle.Fill;
            dataGridViewTable.Location = new Point(3, 19);
            dataGridViewTable.Name = "dataGridViewTable";
            dataGridViewTable.ScrollBars = ScrollBars.Vertical;
            dataGridViewTable.Size = new Size(104, 328);
            dataGridViewTable.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.Controls.Add(chartDiag);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(110, 100);
            panelFill.Name = "panelFill";
            panelFill.Size = new Size(690, 350);
            panelFill.TabIndex = 1;
            // 
            // chartDiag
            // 
            chartArea1.Name = "ChartArea1";
            chartDiag.ChartAreas.Add(chartArea1);
            chartDiag.Dock = DockStyle.Fill;
            legend1.Name = "Legend1";
            chartDiag.Legends.Add(legend1);
            chartDiag.Location = new Point(0, 0);
            chartDiag.Name = "chartDiag";
            series1.ChartArea = "ChartArea1";
            series1.Color = Color.Green;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartDiag.Series.Add(series1);
            chartDiag.Size = new Size(690, 350);
            chartDiag.TabIndex = 0;
            chartDiag.Text = "chart1";
            // 
            // splitter1
            // 
            splitter1.Location = new Point(110, 100);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 350);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(splitter1);
            Controls.Add(panelFill);
            Controls.Add(panelLeft);
            Controls.Add(panelUp);
            MinimumSize = new Size(755, 273);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 5 | Вариант 8 | Донской И. А.";
            panelUp.ResumeLayout(false);
            groupBoxWithRequirements.ResumeLayout(false);
            groupBoxWithRequirements.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewTable).EndInit();
            panelFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartDiag).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp;
        private Panel panelLeft;
        private Panel panelFill;
        private Splitter splitter1;
        private GroupBox groupBoxWithRequirements;
        private TextBox textBoxTask;
        private Button buttonDone;
        private GroupBox groupBoxTable;
        private DataGridView dataGridViewTable;
        private Button buttonHelp;
        private Button buttonFileOpen;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartDiag;
    }
}
