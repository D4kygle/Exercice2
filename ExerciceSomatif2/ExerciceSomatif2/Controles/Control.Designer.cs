namespace ExerciceSomatif2.Controles
{
    partial class Control
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.lblType = new System.Windows.Forms.Label();
            this.picboxForme = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picboxForme)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ceci est :";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Location = new System.Drawing.Point(88, 53);
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(38, 20);
            this.lblType.TabIndex = 1;
            this.lblType.Text = "type";
            // 
            // picboxForme
            // 
            this.picboxForme.Location = new System.Drawing.Point(289, 53);
            this.picboxForme.Name = "picboxForme";
            this.picboxForme.Size = new System.Drawing.Size(200, 200);
            this.picboxForme.TabIndex = 2;
            this.picboxForme.TabStop = false;
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.picboxForme);
            this.Controls.Add(this.lblType);
            this.Controls.Add(this.label1);
            this.Name = "Control";
            this.Size = new System.Drawing.Size(543, 327);
            ((System.ComponentModel.ISupportInitialize)(this.picboxForme)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label lblType;
        private PictureBox picboxForme;
    }
}
