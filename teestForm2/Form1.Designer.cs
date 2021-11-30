
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
            this.id = new System.Windows.Forms.Label();
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
            this.txtIds = new System.Windows.Forms.ComboBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btquitter = new System.Windows.Forms.Button();
            this.Ids = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(170, 90);
            this.id.Name = "id";
            this.id.Size = new System.Drawing.Size(96, 56);
            this.id.TabIndex = 0;
            this.id.Text = "ID :";
            this.id.Click += new System.EventHandler(this.label1_Click);
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
            this.btSupprimer.Location = new System.Drawing.Point(590, 543);
            this.btSupprimer.Name = "btSupprimer";
            this.btSupprimer.Size = new System.Drawing.Size(176, 63);
            this.btSupprimer.TabIndex = 10;
            this.btSupprimer.Text = "Supprimer";
            this.btSupprimer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btSupprimer.UseVisualStyleBackColor = true;
            this.btSupprimer.Click += new System.EventHandler(this.button2_Click);
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
            // txtIds
            // 
            this.txtIds.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIds.FormattingEnabled = true;
            this.txtIds.Location = new System.Drawing.Point(524, 23);
            this.txtIds.Name = "txtIds";
            this.txtIds.Size = new System.Drawing.Size(469, 48);
            this.txtIds.TabIndex = 13;
            this.txtIds.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtId.Location = new System.Drawing.Point(524, 98);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(469, 48);
            this.txtId.TabIndex = 14;
            // 
            // btquitter
            // 
            this.btquitter.Location = new System.Drawing.Point(1208, 45);
            this.btquitter.Name = "btquitter";
            this.btquitter.Size = new System.Drawing.Size(160, 101);
            this.btquitter.TabIndex = 15;
            this.btquitter.Text = "QUITTER";
            this.btquitter.UseVisualStyleBackColor = true;
            this.btquitter.Click += new System.EventHandler(this.btquitter_Click);
            // 
            // Ids
            // 
            this.Ids.AutoSize = true;
            this.Ids.Font = new System.Drawing.Font("Microsoft YaHei UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ids.Location = new System.Drawing.Point(170, 15);
            this.Ids.Name = "Ids";
            this.Ids.Size = new System.Drawing.Size(121, 56);
            this.Ids.TabIndex = 16;
            this.Ids.Text = "IDS :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1441, 774);
            this.Controls.Add(this.Ids);
            this.Controls.Add(this.btquitter);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtIds);
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
            this.Controls.Add(this.id);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id;
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
        private System.Windows.Forms.ComboBox txtIds;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btquitter;
        private System.Windows.Forms.Label Ids;
    }
}

