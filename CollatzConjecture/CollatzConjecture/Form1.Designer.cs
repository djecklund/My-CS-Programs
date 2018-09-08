namespace CollatzConjecture
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.userInputTF = new System.Windows.Forms.TextBox();
            this.stepsListBox = new System.Windows.Forms.ListBox();
            this.startCollatzConjectureButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter a starting number:";
            // 
            // userInputTF
            // 
            this.userInputTF.Location = new System.Drawing.Point(137, 6);
            this.userInputTF.Name = "userInputTF";
            this.userInputTF.Size = new System.Drawing.Size(153, 20);
            this.userInputTF.TabIndex = 1;
            this.userInputTF.TextChanged += new System.EventHandler(this.userInputTF_TextChanged);
            // 
            // stepsListBox
            // 
            this.stepsListBox.FormattingEnabled = true;
            this.stepsListBox.Location = new System.Drawing.Point(11, 65);
            this.stepsListBox.Name = "stepsListBox";
            this.stepsListBox.Size = new System.Drawing.Size(279, 264);
            this.stepsListBox.TabIndex = 2;
            // 
            // startCollatzConjectureButton
            // 
            this.startCollatzConjectureButton.Location = new System.Drawing.Point(215, 32);
            this.startCollatzConjectureButton.Name = "startCollatzConjectureButton";
            this.startCollatzConjectureButton.Size = new System.Drawing.Size(75, 23);
            this.startCollatzConjectureButton.TabIndex = 3;
            this.startCollatzConjectureButton.Text = "Start";
            this.startCollatzConjectureButton.UseVisualStyleBackColor = true;
            this.startCollatzConjectureButton.Click += new System.EventHandler(this.startCollatzConjectureButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 343);
            this.Controls.Add(this.startCollatzConjectureButton);
            this.Controls.Add(this.stepsListBox);
            this.Controls.Add(this.userInputTF);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Collatz Conjecture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userInputTF;
        private System.Windows.Forms.ListBox stepsListBox;
        private System.Windows.Forms.Button startCollatzConjectureButton;
    }
}

