namespace Program3
{
    partial class Form1
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
            progressBar1 = new ProgressBar();
            start = new Button();
            zurücksetzen = new Button();
            Schliessen = new Button();
            SuspendLayout();
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(298, 12);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(300, 50);
            progressBar1.Step = 5;
            progressBar1.TabIndex = 0;
            progressBar1.Click += progressBar1_Click;
            // 
            // start
            // 
            start.Location = new Point(12, 12);
            start.Name = "start";
            start.Size = new Size(188, 58);
            start.TabIndex = 1;
            start.Text = "start";
            start.UseVisualStyleBackColor = true;
            start.Click += start_Click;
            // 
            // zurücksetzen
            // 
            zurücksetzen.Location = new Point(12, 143);
            zurücksetzen.Name = "zurücksetzen";
            zurücksetzen.Size = new Size(188, 58);
            zurücksetzen.TabIndex = 2;
            zurücksetzen.Text = "Zurücksetzen";
            zurücksetzen.UseVisualStyleBackColor = true;
            zurücksetzen.Click += zurücksetzen_Click;
            // 
            // Schliessen
            // 
            Schliessen.Location = new Point(12, 79);
            Schliessen.Name = "Schliessen";
            Schliessen.Size = new Size(188, 58);
            Schliessen.TabIndex = 3;
            Schliessen.Text = "Schliessen";
            Schliessen.UseVisualStyleBackColor = true;
            Schliessen.Click += Schliessen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Schliessen);
            Controls.Add(zurücksetzen);
            Controls.Add(start);
            Controls.Add(progressBar1);
            Name = "Form1";
            Text = "Fortschrittsanzeige";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ProgressBar progressBar1;
        private Button start;
        private Button zurücksetzen;
        private Button Schliessen;
    }
}
