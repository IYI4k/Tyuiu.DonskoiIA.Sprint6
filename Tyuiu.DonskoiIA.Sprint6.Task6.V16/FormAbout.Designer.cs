namespace Tyuiu.DonskoiIA.Sprint6.Task6.V16
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            pictureBoxAvatar = new PictureBox();
            textBoxInfo = new TextBox();
            buttonOK = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxAvatar
            // 
            pictureBoxAvatar.Image = Properties.Resources.FotoResized;
            pictureBoxAvatar.Location = new Point(12, 12);
            pictureBoxAvatar.Name = "pictureBoxAvatar";
            pictureBoxAvatar.Size = new Size(316, 400);
            pictureBoxAvatar.TabIndex = 0;
            pictureBoxAvatar.TabStop = false;
            // 
            // textBoxInfo
            // 
            textBoxInfo.Location = new Point(334, 12);
            textBoxInfo.Multiline = true;
            textBoxInfo.Name = "textBoxInfo";
            textBoxInfo.ReadOnly = true;
            textBoxInfo.Size = new Size(454, 353);
            textBoxInfo.TabIndex = 1;
            textBoxInfo.Text = resources.GetString("textBoxInfo.Text");
            // 
            // buttonOK
            // 
            buttonOK.Location = new Point(716, 376);
            buttonOK.Name = "buttonOK";
            buttonOK.Size = new Size(72, 36);
            buttonOK.TabIndex = 2;
            buttonOK.Text = "OK";
            buttonOK.UseVisualStyleBackColor = true;
            buttonOK.Click += buttonOK_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 424);
            Controls.Add(buttonOK);
            Controls.Add(textBoxInfo);
            Controls.Add(pictureBoxAvatar);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "FormAbout";
            Text = "О программе";
            ((System.ComponentModel.ISupportInitialize)pictureBoxAvatar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBoxAvatar;
        private TextBox textBoxInfo;
        private Button buttonOK;
    }
}