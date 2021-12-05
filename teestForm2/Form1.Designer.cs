
namespace teestForm2
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
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.prenom = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.nom = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.age = new System.Windows.Forms.Label();
            this.btAjouter = new System.Windows.Forms.Button();
            this.btModifier = new System.Windows.Forms.Button();
            this.btSupprimer = new System.Windows.Forms.Button();
            this.btConfirmer = new System.Windows.Forms.Button();
            this.btAnnuler = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.ddl_ids = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtPrenom
            // 
            this.txtPrenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrenom.Location = new System.Drawing.Point(524, 192);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(469, 48);
            this.txtPrenom.TabIndex = 3;
            // 
            // prenom
            // 
            this.prenom.AutoSize = true;
            this.prenom.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prenom.Location = new System.Drawing.Point(170, 179);
            this.prenom.Name = "prenom";
            this.prenom.Size = new System.Drawing.Size(215, 56);
            this.prenom.TabIndex = 2;
            this.prenom.Text = "Prenom :";
            this.prenom.Click += new System.EventHandler(this.prenom_Click);
            // 
            // txtNom
            // 
            this.txtNom.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNom.Location = new System.Drawing.Point(524, 290);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(469, 48);
            this.txtNom.TabIndex = 5;
            // 
            // nom
            // 
            this.nom.AutoSize = true;
            this.nom.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nom.Location = new System.Drawing.Point(170, 277);
            this.nom.Name = "nom";
            this.nom.Size = new System.Drawing.Size(154, 56);
            this.nom.TabIndex = 4;
            this.nom.Text = "Nom :";
            this.nom.Click += new System.EventHandler(this.nom_Click);
            // 
            // txtAge
            // 
            this.txtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(524, 392);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(469, 48);
            this.txtAge.TabIndex = 7;
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(170, 377);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(133, 56);
            this.age.TabIndex = 6;
            this.age.Text = "Age :";
            this.age.Click += new System.EventHandler(this.age_Click);
            // 
            // btAjouter
            // 
            this.btAjouter.Location = new System.Drawing.Point(68, 543);
            this.btAjouter.Name = "btAjouter";
            this.btAjouter.Size = new System.Drawing.Size(176, 63);
            this.btAjouter.TabIndex = 8;
            this.btAjouter.Text = "Ajouter";
            this.btAjouter.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAjouter.UseVisualStyleBackColor = true;
            this.btAjouter.Click += new System.EventHandler(this.btAjouter_Click);
            // 
            // btModifier
            // 
            this.btModifier.Location = new System.Drawing.Point(323, 543);
            this.btModifier.Name = "btModifier";
            this.btModifier.Size = new System.Drawing.Size(176, 63);
            this.btModifier.TabIndex = 9;
            this.btModifier.Text = "Modifier";
            this.btModifier.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btModifier.UseVisualStyleBackColor = true;
            this.btModifier.Click += new System.EventHandler(this.btModifier_Click);
            // 
            // btSupprimer
            // 
            this.btSupprimer.Location = new System.Drawing.Point(573, 543);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(176, 63);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.btSupprimer_Click);
            // 
            // btConfirmer
            // 
            this.btConfirmer.Location = new System.Drawing.Point(817, 543);
            this.btConfirmer.Name = "btConfirmer";
            this.btConfirmer.Size = new System.Drawing.Size(176, 63);
            this.btConfirmer.TabIndex = 11;
            this.btConfirmer.Text = "Confirmer";
            this.btConfirmer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btConfirmer.UseVisualStyleBackColor = true;
            this.btConfirmer.Click += new System.EventHandler(this.btConfirmer_Click);
            // 
            // btAnnuler
            // 
            this.btAnnuler.Location = new System.Drawing.Point(1068, 543);
            this.btAnnuler.Name = "btAnnuler";
            this.btAnnuler.Size = new System.Drawing.Size(176, 63);
            this.btAnnuler.TabIndex = 12;
            this.btAnnuler.Text = "Annuler";
            this.btAnnuler.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btAnnuler.UseVisualStyleBackColor = true;
            this.btAnnuler.Click += new System.EventHandler(this.btAnnuler_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(170, 71);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(96, 56);
            this.ID.TabIndex = 16;
            this.ID.Text = "ID :";
            this.ID.Click += new System.EventHandler(this.ID_Click);
            // 
            // ddl_ids
            // 
            this.ddl_ids.BackColor = System.Drawing.Color.White;
            this.ddl_ids.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ddl_ids.FormattingEnabled = true;
            this.ddl_ids.Location = new System.Drawing.Point(524, 90);
            this.ddl_ids.Name = "ddl_ids";
            this.ddl_ids.Size = new System.Drawing.Size(469, 48);
            this.ddl_ids.TabIndex = 17;
            this.ddl_ids.SelectedIndexChanged += new System.EventHandler(this.ddl_ids_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 774);
            this.Controls.Add(this.ddl_ids);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.btAnnuler);
            this.Controls.Add(this.btConfirmer);
            this.Controls.Add(this.btSupprimer);
            this.Controls.Add(this.btModifier);
            this.Controls.Add(this.btAjouter);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.age);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.nom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.prenom);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.Label prenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label nom;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Button btAjouter;
        private System.Windows.Forms.Button btModifier;
        private System.Windows.Forms.Button btSupprimer;
        private System.Windows.Forms.Button btConfirmer;
        private System.Windows.Forms.Button btAnnuler;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.ComboBox ddl_ids;
    }
}

