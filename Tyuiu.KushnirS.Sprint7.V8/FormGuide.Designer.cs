namespace Tyuiu.KushnirS.Sprint7.V8
{
    partial class FormGuide
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGuide));
            buttonClose_KS = new Button();
            labelGuide_KS = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonClose_KS
            // 
            buttonClose_KS.Location = new Point(331, 303);
            buttonClose_KS.Name = "buttonClose_KS";
            buttonClose_KS.Size = new Size(75, 23);
            buttonClose_KS.TabIndex = 1;
            buttonClose_KS.Text = "OK";
            buttonClose_KS.UseVisualStyleBackColor = true;
            buttonClose_KS.Click += buttonClose_KS_Click;
            // 
            // labelGuide_KS
            // 
            labelGuide_KS.AutoSize = true;
            labelGuide_KS.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            labelGuide_KS.ForeColor = SystemColors.ActiveCaptionText;
            labelGuide_KS.Location = new Point(-76, 19);
            labelGuide_KS.Name = "labelGuide_KS";
            labelGuide_KS.Size = new Size(0, 17);
            labelGuide_KS.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 11.25F, FontStyle.Italic, GraphicsUnit.Point, 204);
            label1.Location = new Point(-101, -16);
            label1.Name = "label1";
            label1.Size = new Size(789, 306);
            label1.TabIndex = 2;
            label1.Text = resources.GetString("label1.Text");
            // 
            // FormGuide
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSlateGray;
            ClientSize = new Size(700, 338);
            Controls.Add(label1);
            Controls.Add(labelGuide_KS);
            Controls.Add(buttonClose_KS);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "FormGuide";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Guide";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button buttonClose_KS;
        private Label labelGuide_KS;
        private Label label1;
    }
}
