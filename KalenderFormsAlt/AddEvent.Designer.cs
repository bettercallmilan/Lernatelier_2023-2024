namespace Kalender_Forms1
{
    partial class AddEvent
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
            components = new System.ComponentModel.Container();
            textBoxDate = new TextBox();
            textBoxEvent = new TextBox();
            button1 = new Button();
            button2 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxDate
            // 
            textBoxDate.Location = new Point(266, 127);
            textBoxDate.Name = "textBoxDate";
            textBoxDate.PlaceholderText = "Format: JJJJ-MM-TT";
            textBoxDate.Size = new Size(248, 27);
            textBoxDate.TabIndex = 0;
            // 
            // textBoxEvent
            // 
            textBoxEvent.Location = new Point(266, 222);
            textBoxEvent.Name = "textBoxEvent";
            textBoxEvent.Size = new Size(248, 27);
            textBoxEvent.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(266, 300);
            button1.Name = "button1";
            button1.Size = new Size(121, 29);
            button1.TabIndex = 2;
            button1.Text = "Bestätigen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(393, 300);
            button2.Name = "button2";
            button2.Size = new Size(121, 29);
            button2.TabIndex = 3;
            button2.Text = "Abbrechen";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(324, 104);
            label1.Name = "label1";
            label1.Size = new Size(123, 20);
            label1.TabIndex = 4;
            label1.Text = "Datum eingeben:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(324, 199);
            label2.Name = "label2";
            label2.Size = new Size(123, 20);
            label2.TabIndex = 5;
            label2.Text = "Termin eingeben:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(182, 9);
            label3.Name = "label3";
            label3.Size = new Size(436, 67);
            label3.TabIndex = 6;
            label3.Text = "Termin hinzufügen";
            // 
            // AddEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBoxEvent);
            Controls.Add(textBoxDate);
            Name = "AddEvent";
            Text = "Termin hinzufügen";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxDate;
        private TextBox textBoxEvent;
        private Button button1;
        private Button button2;
        private ContextMenuStrip contextMenuStrip1;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}