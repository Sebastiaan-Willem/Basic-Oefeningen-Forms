
namespace Oefeningen_Forms
{
    partial class Oefening2_HowOld
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
            this.lblInstruction = new System.Windows.Forms.Label();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblGeslacht = new System.Windows.Forms.Label();
            this.lblDatum = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.radioButtonMan = new System.Windows.Forms.RadioButton();
            this.radioButtonVrouw = new System.Windows.Forms.RadioButton();
            this.radioButtonOverige = new System.Windows.Forms.RadioButton();
            this.dateTimePickerGeboorteDatum = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInstruction
            // 
            this.lblInstruction.AutoSize = true;
            this.lblInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInstruction.Location = new System.Drawing.Point(12, 9);
            this.lblInstruction.Name = "lblInstruction";
            this.lblInstruction.Size = new System.Drawing.Size(384, 24);
            this.lblInstruction.TabIndex = 0;
            this.lblInstruction.Text = "Gelieve onderstaande gegevens in te vullen:";
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 66);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 1;
            this.lblNaam.Text = "Naam:";
            // 
            // lblGeslacht
            // 
            this.lblGeslacht.AutoSize = true;
            this.lblGeslacht.Location = new System.Drawing.Point(12, 104);
            this.lblGeslacht.Name = "lblGeslacht";
            this.lblGeslacht.Size = new System.Drawing.Size(49, 13);
            this.lblGeslacht.TabIndex = 2;
            this.lblGeslacht.Text = "Geslacht";
            // 
            // lblDatum
            // 
            this.lblDatum.AutoSize = true;
            this.lblDatum.Location = new System.Drawing.Point(12, 143);
            this.lblDatum.Name = "lblDatum";
            this.lblDatum.Size = new System.Drawing.Size(80, 13);
            this.lblDatum.TabIndex = 3;
            this.lblDatum.Text = "Geboortedatum";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(461, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(327, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 286);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(772, 54);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(140, 63);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(302, 20);
            this.txtNaam.TabIndex = 6;
            this.txtNaam.TextChanged += new System.EventHandler(this.txtNaam_TextChanged);
            // 
            // radioButtonMan
            // 
            this.radioButtonMan.AutoSize = true;
            this.radioButtonMan.Location = new System.Drawing.Point(140, 104);
            this.radioButtonMan.Name = "radioButtonMan";
            this.radioButtonMan.Size = new System.Drawing.Size(46, 17);
            this.radioButtonMan.TabIndex = 7;
            this.radioButtonMan.TabStop = true;
            this.radioButtonMan.Text = "Man";
            this.radioButtonMan.UseVisualStyleBackColor = true;
            this.radioButtonMan.CheckedChanged += new System.EventHandler(this.radioButtonMan_CheckedChanged);
            // 
            // radioButtonVrouw
            // 
            this.radioButtonVrouw.AutoSize = true;
            this.radioButtonVrouw.Location = new System.Drawing.Point(231, 104);
            this.radioButtonVrouw.Name = "radioButtonVrouw";
            this.radioButtonVrouw.Size = new System.Drawing.Size(55, 17);
            this.radioButtonVrouw.TabIndex = 8;
            this.radioButtonVrouw.TabStop = true;
            this.radioButtonVrouw.Text = "Vrouw";
            this.radioButtonVrouw.UseVisualStyleBackColor = true;
            this.radioButtonVrouw.CheckedChanged += new System.EventHandler(this.radioButtonVrouw_CheckedChanged);
            // 
            // radioButtonOverige
            // 
            this.radioButtonOverige.AutoSize = true;
            this.radioButtonOverige.Location = new System.Drawing.Point(322, 104);
            this.radioButtonOverige.Name = "radioButtonOverige";
            this.radioButtonOverige.Size = new System.Drawing.Size(62, 17);
            this.radioButtonOverige.TabIndex = 9;
            this.radioButtonOverige.TabStop = true;
            this.radioButtonOverige.Text = "Overige";
            this.radioButtonOverige.UseVisualStyleBackColor = true;
            this.radioButtonOverige.CheckedChanged += new System.EventHandler(this.radioButtonOverige_CheckedChanged);
            // 
            // dateTimePickerGeboorteDatum
            // 
            this.dateTimePickerGeboorteDatum.Location = new System.Drawing.Point(140, 137);
            this.dateTimePickerGeboorteDatum.Name = "dateTimePickerGeboorteDatum";
            this.dateTimePickerGeboorteDatum.Size = new System.Drawing.Size(302, 20);
            this.dateTimePickerGeboorteDatum.TabIndex = 10;
            this.dateTimePickerGeboorteDatum.ValueChanged += new System.EventHandler(this.dateTimePickerGeboorteDatum_ValueChanged);
            // 
            // Oefening2_HowOld
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dateTimePickerGeboorteDatum);
            this.Controls.Add(this.radioButtonOverige);
            this.Controls.Add(this.radioButtonVrouw);
            this.Controls.Add(this.radioButtonMan);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblDatum);
            this.Controls.Add(this.lblGeslacht);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.lblInstruction);
            this.Name = "Oefening2_HowOld";
            this.Text = "Oefening2_HowOld";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInstruction;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblGeslacht;
        private System.Windows.Forms.Label lblDatum;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.RadioButton radioButtonMan;
        private System.Windows.Forms.RadioButton radioButtonVrouw;
        private System.Windows.Forms.RadioButton radioButtonOverige;
        private System.Windows.Forms.DateTimePicker dateTimePickerGeboorteDatum;
    }
}