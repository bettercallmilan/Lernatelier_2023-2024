namespace Kalender_Forms1
{
    partial class ManageEvent
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
            listBoxEvents = new ListBox();
            btnEditEvent = new Button();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // listBoxEvents
            // 
            listBoxEvents.FormattingEnabled = true;
            listBoxEvents.ItemHeight = 20;
            listBoxEvents.Location = new Point(251, 117);
            listBoxEvents.Name = "listBoxEvents";
            listBoxEvents.Size = new Size(282, 244);
            listBoxEvents.TabIndex = 0;
            // 
            // btnEditEvent
            // 
            btnEditEvent.Location = new Point(251, 381);
            btnEditEvent.Name = "btnEditEvent";
            btnEditEvent.Size = new Size(134, 29);
            btnEditEvent.TabIndex = 1;
            btnEditEvent.Text = "Auswählen";
            btnEditEvent.UseVisualStyleBackColor = true;
            btnEditEvent.Click += btnEditEvent_Click_1;
            // 
            // button1
            // 
            button1.Location = new Point(399, 381);
            button1.Name = "button1";
            button1.Size = new Size(134, 29);
            button1.TabIndex = 2;
            button1.Text = "Abbrechen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(189, 9);
            label1.Name = "label1";
            label1.Size = new Size(436, 67);
            label1.TabIndex = 3;
            label1.Text = "Termine verändern";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(298, 82);
            label2.Name = "label2";
            label2.Size = new Size(189, 20);
            label2.TabIndex = 4;
            label2.Text = "Bitte ein Termin auswählen:";
            // 
            // ManageEvent
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(btnEditEvent);
            Controls.Add(listBoxEvents);
            Name = "ManageEvent";
            Text = "Termine verändern";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBoxEvents;
        private Button btnEditEvent;
        private Button button1;
        private Label label1;
        private Label label2;
    }
}