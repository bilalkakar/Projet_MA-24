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
            this.txtAdjacent = new System.Windows.Forms.TextBox();
            this.txtOppose = new System.Windows.Forms.TextBox();
            this.lblAdjacent = new System.Windows.Forms.Label();
            this.lblOppose = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmdCalcul = new System.Windows.Forms.Button();
            this.lblhypothenise = new System.Windows.Forms.Label();
            this.lblResultHypo = new System.Windows.Forms.Label();
            this.lblPerimetre = new System.Windows.Forms.Label();
            this.lblResultPerim = new System.Windows.Forms.Label();
            this.cmdButton = new System.Windows.Forms.Button();
            this.lblAir = new System.Windows.Forms.Label();
            this.lblResultAir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdjacent
            // 
            this.txtAdjacent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdjacent.Location = new System.Drawing.Point(123, 128);
            this.txtAdjacent.Name = "txtAdjacent";
            this.txtAdjacent.Size = new System.Drawing.Size(159, 29);
            this.txtAdjacent.TabIndex = 0;
            // 
            // txtOppose
            // 
            this.txtOppose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOppose.Location = new System.Drawing.Point(366, 128);
            this.txtOppose.Name = "txtOppose";
            this.txtOppose.Size = new System.Drawing.Size(159, 29);
            this.txtOppose.TabIndex = 1;
            // 
            // lblAdjacent
            // 
            this.lblAdjacent.AutoSize = true;
            this.lblAdjacent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdjacent.Location = new System.Drawing.Point(119, 101);
            this.lblAdjacent.Name = "lblAdjacent";
            this.lblAdjacent.Size = new System.Drawing.Size(84, 24);
            this.lblAdjacent.TabIndex = 2;
            this.lblAdjacent.Text = "Adjacent";
            // 
            // lblOppose
            // 
            this.lblOppose.AutoSize = true;
            this.lblOppose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOppose.Location = new System.Drawing.Point(362, 101);
            this.lblOppose.Name = "lblOppose";
            this.lblOppose.Size = new System.Drawing.Size(78, 24);
            this.lblOppose.TabIndex = 3;
            this.lblOppose.Text = "Opposé";
            this.lblOppose.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(601, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Calculer l\'hypthenus, périmètre et l\'aire d\'un triangle rectangle";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cmdCalcul
            // 
            this.cmdCalcul.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdCalcul.Location = new System.Drawing.Point(123, 210);
            this.cmdCalcul.Name = "cmdCalcul";
            this.cmdCalcul.Size = new System.Drawing.Size(159, 50);
            this.cmdCalcul.TabIndex = 5;
            this.cmdCalcul.Text = "Calculer";
            this.cmdCalcul.UseVisualStyleBackColor = true;
            this.cmdCalcul.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblhypothenise
            // 
            this.lblhypothenise.AutoSize = true;
            this.lblhypothenise.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhypothenise.Location = new System.Drawing.Point(119, 292);
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
            this.lblResultHypo.Location = new System.Drawing.Point(362, 292);
            this.lblResultHypo.Name = "lblResultHypo";
            this.lblResultHypo.Size = new System.Drawing.Size(0, 24);
            this.lblResultHypo.TabIndex = 7;
            // 
            // lblPerimetre
            // 
            this.lblPerimetre.AutoSize = true;
            this.lblPerimetre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerimetre.Location = new System.Drawing.Point(119, 339);
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
            this.lblResultPerim.Location = new System.Drawing.Point(362, 339);
            this.lblResultPerim.Name = "lblResultPerim";
            this.lblResultPerim.Size = new System.Drawing.Size(0, 24);
            this.lblResultPerim.TabIndex = 9;
            // 
            // cmdButton
            // 
            this.cmdButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdButton.Location = new System.Drawing.Point(366, 210);
            this.cmdButton.Name = "cmdButton";
            this.cmdButton.Size = new System.Drawing.Size(159, 50);
            this.cmdButton.TabIndex = 10;
            this.cmdButton.Text = "Reset";
            this.cmdButton.UseVisualStyleBackColor = true;
            this.cmdButton.Click += new System.EventHandler(this.cmdButton_Click);
            // 
            // lblAir
            // 
            this.lblAir.AutoSize = true;
            this.lblAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAir.Location = new System.Drawing.Point(119, 390);
            this.lblAir.Name = "lblAir";
            this.lblAir.Size = new System.Drawing.Size(28, 20);
            this.lblAir.TabIndex = 11;
            this.lblAir.Text = "Air";
            // 
            // lblResultAir
            // 
            this.lblResultAir.AutoSize = true;
            this.lblResultAir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblResultAir.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultAir.Location = new System.Drawing.Point(362, 390);
            this.lblResultAir.Name = "lblResultAir";
            this.lblResultAir.Size = new System.Drawing.Size(0, 24);
            this.lblResultAir.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 477);
            this.Controls.Add(this.lblResultAir);
            this.Controls.Add(this.lblAir);
            this.Controls.Add(this.cmdButton);
            this.Controls.Add(this.lblResultPerim);
            this.Controls.Add(this.lblPerimetre);
            this.Controls.Add(this.lblResultHypo);
            this.Controls.Add(this.lblhypothenise);
            this.Controls.Add(this.cmdCalcul);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblOppose);
            this.Controls.Add(this.lblAdjacent);
            this.Controls.Add(this.txtOppose);
            this.Controls.Add(this.txtAdjacent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdjacent;
        private System.Windows.Forms.TextBox txtOppose;
        private System.Windows.Forms.Label lblAdjacent;
        private System.Windows.Forms.Label lblOppose;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cmdCalcul;
        private System.Windows.Forms.Label lblhypothenise;
        private System.Windows.Forms.Label lblResultHypo;
        private System.Windows.Forms.Label lblPerimetre;
        private System.Windows.Forms.Label lblResultPerim;
        private System.Windows.Forms.Button cmdButton;
        private System.Windows.Forms.Label lblAir;
        private System.Windows.Forms.Label lblResultAir;
    }
}

