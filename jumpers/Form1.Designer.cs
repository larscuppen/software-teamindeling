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
            NaamTB = new TextBox();
            LeeftijdTB = new TextBox();
            toevoegenBTN = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // TeamsLB
            // 
            TeamsLB.BackColor = SystemColors.MenuBar;
            TeamsLB.FormattingEnabled = true;
            TeamsLB.Location = new Point(12, 9);
            TeamsLB.Name = "TeamsLB";
            TeamsLB.Size = new Size(186, 279);
            TeamsLB.TabIndex = 0;
            TeamsLB.SelectedIndexChanged += TeamsLB_SelectedIndexChanged;
            // 
            // SpelersLB
            // 
            SpelersLB.BackColor = SystemColors.Menu;
            SpelersLB.FormattingEnabled = true;
            SpelersLB.Location = new Point(204, 9);
            SpelersLB.Name = "SpelersLB";
            SpelersLB.Size = new Size(571, 429);
            SpelersLB.TabIndex = 1;
            // 
            // NaamTB
            // 
            NaamTB.ForeColor = SystemColors.WindowFrame;
            NaamTB.Location = new Point(12, 330);
            NaamTB.Name = "NaamTB";
            NaamTB.PlaceholderText = "Naam";
            NaamTB.Size = new Size(186, 31);
            NaamTB.TabIndex = 2;
            // 
            // LeeftijdTB
            // 
            LeeftijdTB.ForeColor = SystemColors.WindowFrame;
            LeeftijdTB.Location = new Point(12, 367);
            LeeftijdTB.MaxLength = 2;
            LeeftijdTB.Name = "LeeftijdTB";
            LeeftijdTB.PlaceholderText = "Leeftijd";
            LeeftijdTB.ShortcutsEnabled = false;
            LeeftijdTB.Size = new Size(186, 31);
            LeeftijdTB.TabIndex = 3;
            LeeftijdTB.WordWrap = false;
            // 
            // toevoegenBTN
            // 
            toevoegenBTN.Location = new Point(12, 404);
            toevoegenBTN.Name = "toevoegenBTN";
            toevoegenBTN.Size = new Size(186, 34);
            toevoegenBTN.TabIndex = 4;
            toevoegenBTN.Text = "Toevoegen";
            toevoegenBTN.UseVisualStyleBackColor = true;
            toevoegenBTN.Click += toevoegenBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 302);
            label1.Name = "label1";
            label1.Size = new Size(152, 25);
            label1.TabIndex = 5;
            label1.Text = "Speler Toevoegen";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(toevoegenBTN);
            Controls.Add(LeeftijdTB);
            Controls.Add(NaamTB);
            Controls.Add(SpelersLB);
            Controls.Add(TeamsLB);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox TeamsLB;
        private ListBox SpelersLB;
        private TextBox NaamTB;
        private TextBox LeeftijdTB;
        private Button toevoegenBTN;
        private Label label1;
    }
}
