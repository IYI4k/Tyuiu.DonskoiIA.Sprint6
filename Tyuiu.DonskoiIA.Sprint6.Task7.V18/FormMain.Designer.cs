namespace Tyuiu.DonskoiIA.Sprint6.Task7.V18
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelUp = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonDone = new Button();
            buttonFileLoad = new Button();
            toolTip = new ToolTip(components);
            openFileDialogLoadFile = new OpenFileDialog();
            groupBoxTask = new GroupBox();
            textBox1 = new TextBox();
            panelLeft = new Panel();
            groupBoxIn = new GroupBox();
            dataGridViewIn = new DataGridView();
            splitterInMiddle = new Splitter();
            panelRight = new Panel();
            groupBoxOut = new GroupBox();
            dataGridViewOut = new DataGridView();
            saveFileDialog = new SaveFileDialog();
            panelUp.SuspendLayout();
            groupBoxTask.SuspendLayout();
            panelLeft.SuspendLayout();
            groupBoxIn.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).BeginInit();
            panelRight.SuspendLayout();
            groupBoxOut.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).BeginInit();
            SuspendLayout();
            // 
            // panelUp
            // 
            panelUp.Controls.Add(buttonHelp);
            panelUp.Controls.Add(buttonSave);
            panelUp.Controls.Add(buttonDone);
            panelUp.Controls.Add(buttonFileLoad);
            panelUp.Dock = DockStyle.Top;
            panelUp.Location = new Point(0, 0);
            panelUp.Name = "panelUp";
            panelUp.Size = new Size(800, 60);
            panelUp.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Image = Properties.Resources.HelpButton;
            buttonHelp.Location = new Point(737, 0);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(60, 60);
            buttonHelp.TabIndex = 2;
            toolTip.SetToolTip(buttonHelp, "Сведения о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Image = Properties.Resources.SaveFileButton;
            buttonSave.Location = new Point(135, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(60, 60);
            buttonSave.TabIndex = 3;
            toolTip.SetToolTip(buttonSave, "Сохранить в...");
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Image = Properties.Resources.RunButton;
            buttonDone.Location = new Point(69, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(60, 60);
            buttonDone.TabIndex = 2;
            toolTip.SetToolTip(buttonDone, "Запуск");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonFileLoad
            // 
            buttonFileLoad.Image = Properties.Resources.FileSearchImage;
            buttonFileLoad.Location = new Point(3, 0);
            buttonFileLoad.Name = "buttonFileLoad";
            buttonFileLoad.Size = new Size(60, 60);
            buttonFileLoad.TabIndex = 1;
            toolTip.SetToolTip(buttonFileLoad, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonFileLoad.UseVisualStyleBackColor = true;
            buttonFileLoad.Click += buttonFileLoad_Click;
            // 
            // toolTip
            // 
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // openFileDialogLoadFile
            // 
            openFileDialogLoadFile.FileName = "openFileDialog1";
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBox1);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 60);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(800, 75);
            groupBoxTask.TabIndex = 1;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(794, 53);
            textBox1.TabIndex = 0;
            textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxIn);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 135);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(395, 315);
            panelLeft.TabIndex = 2;
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(dataGridViewIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(395, 315);
            groupBoxIn.TabIndex = 0;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод:";
            // 
            // dataGridViewIn
            // 
            dataGridViewIn.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewIn.Dock = DockStyle.Fill;
            dataGridViewIn.Location = new Point(3, 19);
            dataGridViewIn.Name = "dataGridViewIn";
            dataGridViewIn.Size = new Size(389, 293);
            dataGridViewIn.TabIndex = 0;
            // 
            // splitterInMiddle
            // 
            splitterInMiddle.Location = new Point(395, 135);
            splitterInMiddle.Name = "splitterInMiddle";
            splitterInMiddle.Size = new Size(3, 315);
            splitterInMiddle.TabIndex = 3;
            splitterInMiddle.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxOut);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(398, 135);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(402, 315);
            panelRight.TabIndex = 4;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(dataGridViewOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(402, 315);
            groupBoxOut.TabIndex = 0;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод:";
            // 
            // dataGridViewOut
            // 
            dataGridViewOut.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOut.Dock = DockStyle.Fill;
            dataGridViewOut.Location = new Point(3, 19);
            dataGridViewOut.Name = "dataGridViewOut";
            dataGridViewOut.Size = new Size(396, 293);
            dataGridViewOut.TabIndex = 0;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRight);
            Controls.Add(splitterInMiddle);
            Controls.Add(panelLeft);
            Controls.Add(groupBoxTask);
            Controls.Add(panelUp);
            MinimumSize = new Size(646, 340);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 7 | Вариант 18 | Донской И. А.";
            panelUp.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            panelLeft.ResumeLayout(false);
            groupBoxIn.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewIn).EndInit();
            panelRight.ResumeLayout(false);
            groupBoxOut.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewOut).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp;
        private Button buttonFileLoad;
        private Button buttonDone;
        private Button buttonSave;
        private Button buttonHelp;
        private ToolTip toolTip;
        private OpenFileDialog openFileDialogLoadFile;
        private GroupBox groupBoxTask;
        private TextBox textBox1;
        private Panel panelLeft;
        private GroupBox groupBoxIn;
        private DataGridView dataGridViewIn;
        private Splitter splitterInMiddle;
        private Panel panelRight;
        private GroupBox groupBoxOut;
        private DataGridView dataGridViewOut;
        private SaveFileDialog saveFileDialog;
    }
}
