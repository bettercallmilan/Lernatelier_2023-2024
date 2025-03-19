namespace Kalender_Forms1
{
    partial class EditEventForm
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
            txtEventText = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtEventText
            // 
            txtEventText.Location = new Point(285, 111);
            txtEventText.Name = "txtEventText";
            txtEventText.Size = new Size(225, 27);
            txtEventText.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(285, 193);
            button1.Name = "button1";
            button1.Size = new Size(112, 29);
            button1.TabIndex = 2;
            button1.Text = "Speichern";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(403, 193);
            button2.Name = "button2";
            button2.Size = new Size(107, 29);
            button2.TabIndex = 3;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(292, 45);
            label1.Name = "label1";
            label1.Size = new Size(211, 46);
            label1.TabIndex = 4;
            label1.Text = "Bitte einen neuen Namen \r\nfür den Termin eingeben:";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // EditEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(txtEventText);
            Name = "EditEventForm";
            Text = "Termin verändern";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtEventText;
        private Button button1;
        private Button button2;
        private Label label1;
    }
}