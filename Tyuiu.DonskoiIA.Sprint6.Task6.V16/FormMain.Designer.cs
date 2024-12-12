namespace Tyuiu.DonskoiIA.Sprint6.Task6.V16
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
            buttonDone = new Button();
            buttonFileLoad = new Button();
            groupBoxTask = new GroupBox();
            textBoxTask = new TextBox();
            groupBoxIn = new GroupBox();
            textBoxIn = new TextBox();
            groupBoxOut = new GroupBox();
            textBoxOut = new TextBox();
            panelLeft = new Panel();
            splitter1 = new Splitter();
            panelRight = new Panel();
            openFileDialogTask = new OpenFileDialog();
            toolTip = new ToolTip(components);
            panelUp.SuspendLayout();
            groupBoxTask.SuspendLayout();
            groupBoxIn.SuspendLayout();
            groupBoxOut.SuspendLayout();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelUp
            // 
            panelUp.Controls.Add(buttonHelp);
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
            buttonHelp.Image = Properties.Resources.HelpButton1;
            buttonHelp.Location = new Point(737, 0);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(60, 60);
            buttonHelp.TabIndex = 2;
            toolTip.SetToolTip(buttonHelp, "Сведения о программе");
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonDone
            // 
            buttonDone.Image = Properties.Resources.RunButton;
            buttonDone.Location = new Point(69, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(60, 60);
            buttonDone.TabIndex = 1;
            toolTip.SetToolTip(buttonDone, "Запуск");
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonFileLoad
            // 
            buttonFileLoad.Image = Properties.Resources.FileSeatchImage;
            buttonFileLoad.Location = new Point(3, 0);
            buttonFileLoad.Name = "buttonFileLoad";
            buttonFileLoad.Size = new Size(60, 60);
            buttonFileLoad.TabIndex = 0;
            toolTip.SetToolTip(buttonFileLoad, "Открыть файл\r\nВыберите нужный файл для обработки");
            buttonFileLoad.UseVisualStyleBackColor = true;
            buttonFileLoad.Click += buttonFileLoad_Click;
            // 
            // groupBoxTask
            // 
            groupBoxTask.Controls.Add(textBoxTask);
            groupBoxTask.Dock = DockStyle.Top;
            groupBoxTask.Location = new Point(0, 60);
            groupBoxTask.Name = "groupBoxTask";
            groupBoxTask.Size = new Size(800, 63);
            groupBoxTask.TabIndex = 0;
            groupBoxTask.TabStop = false;
            groupBoxTask.Text = "Условие:";
            // 
            // textBoxTask
            // 
            textBoxTask.Dock = DockStyle.Fill;
            textBoxTask.Location = new Point(3, 19);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(794, 41);
            textBoxTask.TabIndex = 0;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // groupBoxIn
            // 
            groupBoxIn.Controls.Add(textBoxIn);
            groupBoxIn.Dock = DockStyle.Fill;
            groupBoxIn.Location = new Point(0, 0);
            groupBoxIn.Name = "groupBoxIn";
            groupBoxIn.Size = new Size(395, 327);
            groupBoxIn.TabIndex = 1;
            groupBoxIn.TabStop = false;
            groupBoxIn.Text = "Ввод";
            // 
            // textBoxIn
            // 
            textBoxIn.Dock = DockStyle.Fill;
            textBoxIn.Location = new Point(3, 19);
            textBoxIn.Multiline = true;
            textBoxIn.Name = "textBoxIn";
            textBoxIn.ReadOnly = true;
            textBoxIn.ScrollBars = ScrollBars.Vertical;
            textBoxIn.Size = new Size(389, 305);
            textBoxIn.TabIndex = 0;
            // 
            // groupBoxOut
            // 
            groupBoxOut.Controls.Add(textBoxOut);
            groupBoxOut.Dock = DockStyle.Fill;
            groupBoxOut.Location = new Point(0, 0);
            groupBoxOut.Name = "groupBoxOut";
            groupBoxOut.Size = new Size(402, 327);
            groupBoxOut.TabIndex = 2;
            groupBoxOut.TabStop = false;
            groupBoxOut.Text = "Вывод";
            // 
            // textBoxOut
            // 
            textBoxOut.Dock = DockStyle.Fill;
            textBoxOut.Location = new Point(3, 19);
            textBoxOut.Multiline = true;
            textBoxOut.Name = "textBoxOut";
            textBoxOut.ReadOnly = true;
            textBoxOut.ScrollBars = ScrollBars.Vertical;
            textBoxOut.Size = new Size(396, 305);
            textBoxOut.TabIndex = 0;
            // 
            // panelLeft
            // 
            panelLeft.Controls.Add(groupBoxIn);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 123);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(395, 327);
            panelLeft.TabIndex = 1;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(395, 123);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 327);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panelRight
            // 
            panelRight.Controls.Add(groupBoxOut);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(398, 123);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(402, 327);
            panelRight.TabIndex = 2;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // toolTip
            // 
            toolTip.ToolTipIcon = ToolTipIcon.Info;
            toolTip.ToolTipTitle = "Подсказка";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelRight);
            Controls.Add(splitter1);
            Controls.Add(panelLeft);
            Controls.Add(groupBoxTask);
            Controls.Add(panelUp);
            MinimumSize = new Size(645, 320);
            Name = "FormMain";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Спринт 6 | Таск 6 | Вариант 16 | Донской И. А.";
            panelUp.ResumeLayout(false);
            groupBoxTask.ResumeLayout(false);
            groupBoxTask.PerformLayout();
            groupBoxIn.ResumeLayout(false);
            groupBoxIn.PerformLayout();
            groupBoxOut.ResumeLayout(false);
            groupBoxOut.PerformLayout();
            panelLeft.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelUp;
        private Button buttonHelp;
        private Button buttonDone;
        private Button buttonFileLoad;
        private GroupBox groupBoxTask;
        private TextBox textBoxTask;
        private GroupBox groupBoxIn;
        private GroupBox groupBoxOut;
        private Panel panelLeft;
        private Splitter splitter1;
        private Panel panelRight;
        private OpenFileDialog openFileDialogTask;
        private ToolTip toolTip;
        private TextBox textBoxIn;
        private TextBox textBoxOut;
    }
}
