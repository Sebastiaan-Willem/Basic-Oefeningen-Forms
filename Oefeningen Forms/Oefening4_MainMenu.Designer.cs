
namespace Oefeningen_Forms
{
    partial class Oefening4_MainMenu
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
            this.btnOef1 = new System.Windows.Forms.Button();
            this.btnOef2 = new System.Windows.Forms.Button();
            this.btnOef3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOef1
            // 
            this.btnOef1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOef1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOef1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOef1.Location = new System.Drawing.Point(197, 106);
            this.btnOef1.Name = "btnOef1";
            this.btnOef1.Size = new System.Drawing.Size(396, 73);
            this.btnOef1.TabIndex = 0;
            this.btnOef1.Text = "1. Rommelzin";
            this.btnOef1.UseVisualStyleBackColor = false;
            this.btnOef1.Click += new System.EventHandler(this.btnOef1_Click);
            // 
            // btnOef2
            // 
            this.btnOef2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOef2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOef2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOef2.Location = new System.Drawing.Point(197, 204);
            this.btnOef2.Name = "btnOef2";
            this.btnOef2.Size = new System.Drawing.Size(396, 73);
            this.btnOef2.TabIndex = 1;
            this.btnOef2.Text = "2. HowOld";
            this.btnOef2.UseVisualStyleBackColor = false;
            this.btnOef2.Click += new System.EventHandler(this.btnOef2_Click);
            // 
            // btnOef3
            // 
            this.btnOef3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.btnOef3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOef3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOef3.Location = new System.Drawing.Point(197, 303);
            this.btnOef3.Name = "btnOef3";
            this.btnOef3.Size = new System.Drawing.Size(396, 73);
            this.btnOef3.TabIndex = 2;
            this.btnOef3.Text = "3. NumbersQuiz";
            this.btnOef3.UseVisualStyleBackColor = false;
            this.btnOef3.Click += new System.EventHandler(this.btnOef3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(174, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(437, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Selecteer een van onderstaande oefeningen";
            
            // 
            // Oefening4_MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOef3);
            this.Controls.Add(this.btnOef2);
            this.Controls.Add(this.btnOef1);
            this.Name = "Oefening4_MainMenu";
            this.Text = "Oefening4_MainMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOef1;
        private System.Windows.Forms.Button btnOef2;
        private System.Windows.Forms.Button btnOef3;
        private System.Windows.Forms.Label label1;
    }
}