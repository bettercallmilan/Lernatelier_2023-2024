namespace Kalender_Forms1
{
    partial class Kalender
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            TerminHinzufuegen = new Button();
            TerminVeraendern = new Button();
            TerminLoeschen = new Button();
            TermineAbrufen = new Button();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.wallpaper;
            pictureBox1.Image = Properties.Resources.wallpaper;
            pictureBox1.Location = new Point(-739, -40);
            pictureBox1.Margin = new Padding(3, 4, 3, 4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1985, 1008);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 50F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(390, 75);
            label1.Name = "label1";
            label1.Size = new Size(373, 112);
            label1.TabIndex = 2;
            label1.Text = "Kalender";
            // 
            // TerminHinzufuegen
            // 
            TerminHinzufuegen.Location = new Point(455, 336);
            TerminHinzufuegen.Margin = new Padding(3, 4, 3, 4);
            TerminHinzufuegen.Name = "TerminHinzufuegen";
            TerminHinzufuegen.Size = new Size(205, 31);
            TerminHinzufuegen.TabIndex = 4;
            TerminHinzufuegen.Text = "Termin hinzufügen";
            TerminHinzufuegen.UseVisualStyleBackColor = true;
            TerminHinzufuegen.Click += TerminHinzufuegen_Click;
            // 
            // TerminVeraendern
            // 
            TerminVeraendern.Location = new Point(455, 395);
            TerminVeraendern.Margin = new Padding(3, 4, 3, 4);
            TerminVeraendern.Name = "TerminVeraendern";
            TerminVeraendern.Size = new Size(205, 31);
            TerminVeraendern.TabIndex = 5;
            TerminVeraendern.Text = "Termin verändern";
            TerminVeraendern.UseVisualStyleBackColor = true;
            TerminVeraendern.Click += TerminVeraendern_Click;
            // 
            // TerminLoeschen
            // 
            TerminLoeschen.Location = new Point(455, 456);
            TerminLoeschen.Margin = new Padding(3, 4, 3, 4);
            TerminLoeschen.Name = "TerminLoeschen";
            TerminLoeschen.Size = new Size(205, 31);
            TerminLoeschen.TabIndex = 6;
            TerminLoeschen.Text = "Termin löschen";
            TerminLoeschen.UseVisualStyleBackColor = true;
            TerminLoeschen.Click += TerminLoeschen_Click;
            // 
            // TermineAbrufen
            // 
            TermineAbrufen.Location = new Point(455, 276);
            TermineAbrufen.Margin = new Padding(3, 4, 3, 4);
            TermineAbrufen.Name = "TermineAbrufen";
            TermineAbrufen.Size = new Size(205, 31);
            TermineAbrufen.TabIndex = 7;
            TermineAbrufen.Text = "Termine abrufen";
            TermineAbrufen.UseVisualStyleBackColor = true;
            TermineAbrufen.Click += TermineAbrufen_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Black;
            label2.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.Transparent;
            label2.Location = new Point(412, 598);
            label2.Name = "label2";
            label2.Size = new Size(273, 35);
            label2.TabIndex = 9;
            label2.Text = "Anzeige Datum/Uhrzeit";
            label2.Click += label2_Click;
            // 
            // Kalender
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1123, 845);
            Controls.Add(label2);
            Controls.Add(TermineAbrufen);
            Controls.Add(TerminLoeschen);
            Controls.Add(TerminVeraendern);
            Controls.Add(TerminHinzufuegen);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Kalender";
            Text = "Kalender";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Button TerminHinzufuegen;
        private Button TerminVeraendern;
        private Button TerminLoeschen;
        private Button TermineAbrufen;
        private Label label2;
    }
}