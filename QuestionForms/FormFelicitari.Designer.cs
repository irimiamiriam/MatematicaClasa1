namespace MatematicaClasa1.QuestionForms
{
    partial class FormFelicitari
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFelicitari));
            this.panel1 = new System.Windows.Forms.Panel();
            this.labeltimp = new System.Windows.Forms.Label();
            this.labelscor = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BlueViolet;
            this.panel1.Controls.Add(this.labeltimp);
            this.panel1.Controls.Add(this.labelscor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(161, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(942, 295);
            this.panel1.TabIndex = 4;
            // 
            // labeltimp
            // 
            this.labeltimp.AutoSize = true;
            this.labeltimp.BackColor = System.Drawing.Color.Transparent;
            this.labeltimp.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labeltimp.ForeColor = System.Drawing.Color.Gold;
            this.labeltimp.Location = new System.Drawing.Point(372, 210);
            this.labeltimp.Name = "labeltimp";
            this.labeltimp.Size = new System.Drawing.Size(106, 32);
            this.labeltimp.TabIndex = 2;
            this.labeltimp.Text = "timp: ";
            // 
            // labelscor
            // 
            this.labelscor.AutoSize = true;
            this.labelscor.BackColor = System.Drawing.Color.Transparent;
            this.labelscor.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelscor.ForeColor = System.Drawing.Color.Gold;
            this.labelscor.Location = new System.Drawing.Point(372, 153);
            this.labelscor.Name = "labelscor";
            this.labelscor.Size = new System.Drawing.Size(108, 32);
            this.labelscor.TabIndex = 1;
            this.labelscor.Text = "scor: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Minecraft", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gold;
            this.label1.Location = new System.Drawing.Point(169, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(639, 96);
            this.label1.TabIndex = 0;
            this.label1.Text = "FELICITARI!";
            // 
            // FormFelicitari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1229, 675);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1255, 746);
            this.MinimumSize = new System.Drawing.Size(1255, 746);
            this.Name = "FormFelicitari";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matematica clasa I";
            this.Load += new System.EventHandler(this.FormFelicitari_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labeltimp;
        private System.Windows.Forms.Label labelscor;
        private System.Windows.Forms.Label label1;
    }
}