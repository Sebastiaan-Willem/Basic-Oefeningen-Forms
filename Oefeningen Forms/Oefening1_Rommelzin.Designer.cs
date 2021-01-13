
namespace Oefeningen_Forms
{
    partial class Oefening1_Rommelzin
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
            this.txtName = new System.Windows.Forms.Label();
            this.txtFilm = new System.Windows.Forms.Label();
            this.txtKleur = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.Label();
            this.txtInstruction = new System.Windows.Forms.Label();
            this.txtNormal = new System.Windows.Forms.Label();
            this.txtRommel = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxFilm = new System.Windows.Forms.TextBox();
            this.textBoxColour = new System.Windows.Forms.TextBox();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.numericAge = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.txtName.Location = new System.Drawing.Point(32, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(35, 13);
            this.txtName.TabIndex = 0;
            this.txtName.Text = "Name";
            // 
            // txtFilm
            // 
            this.txtFilm.AutoSize = true;
            this.txtFilm.Location = new System.Drawing.Point(32, 99);
            this.txtFilm.Name = "txtFilm";
            this.txtFilm.Size = new System.Drawing.Size(66, 13);
            this.txtFilm.TabIndex = 1;
            this.txtFilm.Text = "Favorite film:";
            // 
            // txtKleur
            // 
            this.txtKleur.AutoSize = true;
            this.txtKleur.Location = new System.Drawing.Point(32, 132);
            this.txtKleur.Name = "txtKleur";
            this.txtKleur.Size = new System.Drawing.Size(78, 13);
            this.txtKleur.TabIndex = 2;
            this.txtKleur.Text = "Favorite Colour";
            // 
            // txtAge
            // 
            this.txtAge.AutoSize = true;
            this.txtAge.Location = new System.Drawing.Point(32, 166);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(26, 13);
            this.txtAge.TabIndex = 3;
            this.txtAge.Text = "Age";
            // 
            // txtInstruction
            // 
            this.txtInstruction.AutoSize = true;
            this.txtInstruction.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInstruction.Location = new System.Drawing.Point(36, 18);
            this.txtInstruction.Name = "txtInstruction";
            this.txtInstruction.Size = new System.Drawing.Size(226, 19);
            this.txtInstruction.TabIndex = 4;
            this.txtInstruction.Text = "Please enter the following data:";
            // 
            // txtNormal
            // 
            this.txtNormal.AutoSize = true;
            this.txtNormal.Location = new System.Drawing.Point(32, 243);
            this.txtNormal.Name = "txtNormal";
            this.txtNormal.Size = new System.Drawing.Size(0, 13);
            this.txtNormal.TabIndex = 5;
            this.txtNormal.Visible = false;
            this.txtNormal.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRommel
            // 
            this.txtRommel.AutoSize = true;
            this.txtRommel.Location = new System.Drawing.Point(32, 279);
            this.txtRommel.Name = "txtRommel";
            this.txtRommel.Size = new System.Drawing.Size(0, 13);
            this.txtRommel.TabIndex = 6;
            this.txtRommel.Visible = false;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(120, 64);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(230, 20);
            this.textBoxName.TabIndex = 7;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // textBoxFilm
            // 
            this.textBoxFilm.Location = new System.Drawing.Point(120, 96);
            this.textBoxFilm.Name = "textBoxFilm";
            this.textBoxFilm.Size = new System.Drawing.Size(230, 20);
            this.textBoxFilm.TabIndex = 8;
            this.textBoxFilm.TextChanged += new System.EventHandler(this.textBoxFilm_TextChanged);
            // 
            // textBoxColour
            // 
            this.textBoxColour.Location = new System.Drawing.Point(120, 132);
            this.textBoxColour.Name = "textBoxColour";
            this.textBoxColour.Size = new System.Drawing.Size(230, 20);
            this.textBoxColour.TabIndex = 9;
            this.textBoxColour.TextChanged += new System.EventHandler(this.textBoxColour_TextChanged);
            // 
            // btnGenerate
            // 
            this.btnGenerate.BackColor = System.Drawing.SystemColors.Control;
            this.btnGenerate.Enabled = false;
            this.btnGenerate.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.Tomato;
            this.btnGenerate.Location = new System.Drawing.Point(389, 60);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(288, 123);
            this.btnGenerate.TabIndex = 11;
            this.btnGenerate.Text = "GENERATE";
            this.btnGenerate.UseVisualStyleBackColor = false;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // numericAge
            // 
            this.numericAge.Location = new System.Drawing.Point(120, 166);
            this.numericAge.Name = "numericAge";
            this.numericAge.Size = new System.Drawing.Size(230, 20);
            this.numericAge.TabIndex = 12;
            this.numericAge.ValueChanged += new System.EventHandler(this.numericAge_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.numericAge);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.textBoxColour);
            this.Controls.Add(this.textBoxFilm);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.txtRommel);
            this.Controls.Add(this.txtNormal);
            this.Controls.Add(this.txtInstruction);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.txtKleur);
            this.Controls.Add(this.txtFilm);
            this.Controls.Add(this.txtName);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericAge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.Label txtFilm;
        private System.Windows.Forms.Label txtKleur;
        private System.Windows.Forms.Label txtAge;
        private System.Windows.Forms.Label txtInstruction;
        private System.Windows.Forms.Label txtNormal;
        private System.Windows.Forms.Label txtRommel;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxFilm;
        private System.Windows.Forms.TextBox textBoxColour;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.NumericUpDown numericAge;
    }
}

