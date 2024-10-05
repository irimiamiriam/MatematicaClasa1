namespace MatematicaClasa1.QuestionForms
{
    partial class FormIntrebare
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormIntrebare));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelIntrebari = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.labelceas = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Indigo;
            this.panel1.Controls.Add(this.panelIntrebari);
            this.panel1.Controls.Add(this.label);
            this.panel1.Location = new System.Drawing.Point(307, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(628, 718);
            this.panel1.TabIndex = 0;
            // 
            // panelIntrebari
            // 
            this.panelIntrebari.Location = new System.Drawing.Point(27, 213);
            this.panelIntrebari.Name = "panelIntrebari";
            this.panelIntrebari.Size = new System.Drawing.Size(576, 477);
            this.panelIntrebari.TabIndex = 3;
            // 
            // label
            // 
            this.label.BackColor = System.Drawing.Color.Transparent;
            this.label.Font = new System.Drawing.Font("Minecraft", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.Gold;
            this.label.Location = new System.Drawing.Point(44, 38);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(559, 146);
            this.label.TabIndex = 2;
            this.label.Text = "Intrebare";
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // labelceas
            // 
            this.labelceas.AutoSize = true;
            this.labelceas.BackColor = System.Drawing.Color.Transparent;
            this.labelceas.Font = new System.Drawing.Font("Minecraft", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelceas.ForeColor = System.Drawing.Color.Indigo;
            this.labelceas.Location = new System.Drawing.Point(1091, 32);
            this.labelceas.Name = "labelceas";
            this.labelceas.Size = new System.Drawing.Size(131, 43);
            this.labelceas.TabIndex = 2;
            this.labelceas.Text = "00:00";
            // 
            // FormIntrebare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1234, 754);
            this.Controls.Add(this.labelceas);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(1260, 825);
            this.MinimumSize = new System.Drawing.Size(1260, 825);
            this.Name = "FormIntrebare";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matematica clasa I";
            this.Load += new System.EventHandler(this.FormIntrebare_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelIntrebari;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label labelceas;
    }
}