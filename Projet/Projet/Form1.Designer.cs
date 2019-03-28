namespace Projet
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtCote1 = new System.Windows.Forms.TextBox();
            this.txtCote2 = new System.Windows.Forms.TextBox();
            this.lblCote = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCote1
            // 
            this.txtCote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCote1.Location = new System.Drawing.Point(160, 128);
            this.txtCote1.Name = "txtCote1";
            this.txtCote1.Size = new System.Drawing.Size(138, 29);
            this.txtCote1.TabIndex = 0;
            // 
            // txtCote2
            // 
            this.txtCote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCote2.Location = new System.Drawing.Point(338, 128);
            this.txtCote2.Name = "txtCote2";
            this.txtCote2.Size = new System.Drawing.Size(150, 29);
            this.txtCote2.TabIndex = 1;
            // 
            // lblCote
            // 
            this.lblCote.AutoSize = true;
            this.lblCote.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCote.Location = new System.Drawing.Point(156, 101);
            this.lblCote.Name = "lblCote";
            this.lblCote.Size = new System.Drawing.Size(64, 24);
            this.lblCote.TabIndex = 2;
            this.lblCote.Text = "Côté 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Côté 2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(160, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ce programme calcule h\'hypthenise d\'un triangle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblCote);
            this.Controls.Add(this.txtCote2);
            this.Controls.Add(this.txtCote1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCote1;
        private System.Windows.Forms.TextBox txtCote2;
        private System.Windows.Forms.Label lblCote;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

