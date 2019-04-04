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
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.lblhypothenise = new System.Windows.Forms.Label();
            this.lblResultHypo = new System.Windows.Forms.Label();
            this.lblPerimetre = new System.Windows.Forms.Label();
            this.lblResultPerim = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCote1
            // 
            this.txtCote1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCote1.Location = new System.Drawing.Point(123, 128);
            this.txtCote1.Name = "txtCote1";
            this.txtCote1.Size = new System.Drawing.Size(138, 29);
            this.txtCote1.TabIndex = 0;
            // 
            // txtCote2
            // 
            this.txtCote2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCote2.Location = new System.Drawing.Point(375, 128);
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
            this.label1.Location = new System.Drawing.Point(426, 101);
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
            this.label2.Location = new System.Drawing.Point(88, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(477, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ce programme calcule h\'hypthenise d\'un triangle";
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcul.Location = new System.Drawing.Point(218, 226);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(196, 50);
            this.cmdCalcul.TabIndex = 5;
            this.cmdCalcul.Text = "Calculer";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhypothenise
            // 
            this.lblhypothenise.AutoSize = true;
            this.lblhypothenise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhypothenise.Location = new System.Drawing.Point(122, 312);
            this.lblhypothenise.Name = "lblhypothenise";
            this.lblhypothenise.Size = new System.Drawing.Size(98, 20);
            this.lblhypothenise.TabIndex = 6;
            this.lblhypothenise.Text = "Hypothenise";
            // 
            // lblResultHypo
            // 
            this.lblResultHypo.AutoSize = true;
            this.lblResultHypo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResultHypo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultHypo.Location = new System.Drawing.Point(126, 361);
            this.lblResultHypo.Name = "lblResultHypo";
            this.lblResultHypo.Size = new System.Drawing.Size(0, 24);
            this.lblResultHypo.TabIndex = 7;
            // 
            // lblPerimetre
            // 
            this.lblPerimetre.AutoSize = true;
            this.lblPerimetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetre.Location = new System.Drawing.Point(438, 312);
            this.lblPerimetre.Name = "lblPerimetre";
            this.lblPerimetre.Size = new System.Drawing.Size(77, 20);
            this.lblPerimetre.TabIndex = 8;
            this.lblPerimetre.Text = "Périmètre";
            this.lblPerimetre.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResultPerim
            // 
            this.lblResultPerim.AutoSize = true;
            this.lblResultPerim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResultPerim.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultPerim.Location = new System.Drawing.Point(453, 361);
            this.lblResultPerim.Name = "lblResultPerim";
            this.lblResultPerim.Size = new System.Drawing.Size(0, 24);
            this.lblResultPerim.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 450);
            this.Controls.Add(this.lblResultPerim);
            this.Controls.Add(this.lblPerimetre);
            this.Controls.Add(this.lblResultHypo);
            this.Controls.Add(this.lblhypothenise);
            this.Controls.Add(this.cmdCalcul);
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
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label lblhypothenise;
        private System.Windows.Forms.Label lblResultHypo;
        private System.Windows.Forms.Label lblPerimetre;
        private System.Windows.Forms.Label lblResultPerim;
    }
}

