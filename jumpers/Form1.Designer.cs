namespace jumpers
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
            TeamsLB = new ListBox();
            SpelersLB = new ListBox();
            SuspendLayout();
            // 
            // TeamsLB
            // 
            TeamsLB.FormattingEnabled = true;
            TeamsLB.Location = new Point(12, 9);
            TeamsLB.Name = "TeamsLB";
            TeamsLB.Size = new Size(186, 429);
            TeamsLB.TabIndex = 0;
            TeamsLB.SelectedIndexChanged += TeamsLB_SelectedIndexChanged;
            // 
            // SpelersLB
            // 
            SpelersLB.FormattingEnabled = true;
            SpelersLB.Location = new Point(204, 9);
            SpelersLB.Name = "SpelersLB";
            SpelersLB.Size = new Size(571, 429);
            SpelersLB.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SpelersLB);
            Controls.Add(TeamsLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private ListBox TeamsLB;
        private ListBox SpelersLB;
    }
}
