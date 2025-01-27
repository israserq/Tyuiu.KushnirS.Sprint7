namespace Tyuiu.KushnirS.Sprint7.V8
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
            labelText_KS = new Label();
            buttonOK_KS = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // labelText_KS
            // 
            labelText_KS.AutoSize = true;
            labelText_KS.BackColor = Color.LightSlateGray;
            labelText_KS.Font = new Font("Times New Roman", 15F, FontStyle.Bold, GraphicsUnit.Point, 204);
            labelText_KS.ForeColor = SystemColors.ButtonHighlight;
            labelText_KS.Location = new Point(174, 13);
            labelText_KS.Name = "labelText_KS";
            labelText_KS.Size = new Size(236, 184);
            labelText_KS.TabIndex = 1;
            labelText_KS.Text = "Разработчик: Кушнир С.\r\n\r\n\r\n\r\n\r\nГруппа: ИБКСб-24-1\r\n \r\n\r\n";
            labelText_KS.Click += labelText_KS_Click;
            // 
            // buttonOK_KS
            // 
            buttonOK_KS.BackColor = Color.AliceBlue;
            buttonOK_KS.Font = new Font("Times New Roman", 9F, FontStyle.Regular, GraphicsUnit.Point, 204);
            buttonOK_KS.Location = new Point(13, 174);
            buttonOK_KS.Margin = new Padding(3, 2, 3, 2);
            buttonOK_KS.Name = "buttonOK_KS";
            buttonOK_KS.Size = new Size(87, 21);
            buttonOK_KS.TabIndex = 2;
            buttonOK_KS.Text = "ОК";
            buttonOK_KS.UseVisualStyleBackColor = true;
            buttonOK_KS.Click += buttonOK_KS_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(426, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(166, 175);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(604, 206);
            Controls.Add(pictureBox1);
            Controls.Add(buttonOK_KS);
            Controls.Add(labelText_KS);
            Font = new Font("Times New Roman", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormAbout";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Справка";
            Load += FormAbout_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelText_KS;
        private Button buttonOK_KS;
        private PictureBox pictureBox1;
    }
}
