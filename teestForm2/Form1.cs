using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace teestForm2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtId.Enabled = false;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtAge.Enabled = false;
            txtIds.Enabled = false;
            age.Enabled = false;
            id.Enabled = false;
            nom.Enabled = false;
            prenom.Enabled = false;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = false;
            btAnnuler.Enabled = false;
            btAjouter.Enabled = true;
            btVider.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPrenom.Enabled = true;
            txtNom.Enabled = true;
            txtAge.Enabled = true;
            txtIds.Enabled = true;
            age.Enabled = true;
            id.Enabled = true;
            nom.Enabled = true;
            prenom.Enabled = true;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;
        }

        private void btAjouter_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPrenom.Enabled = true;
            txtNom.Enabled = true;
            txtAge.Enabled = true;
            txtIds.Enabled = false;
            age.Enabled = true;
            id.Enabled = true;
            nom.Enabled = true;
            prenom.Enabled = true;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;

            



        }

        private void btConfirmer_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPrenom.Enabled = true;
            txtNom.Enabled = true;
            txtAge.Enabled = true;
            txtIds.Enabled = true;
            age.Enabled = true;
            id.Enabled = true;
            nom.Enabled = true;
            prenom.Enabled = true;
            btModifier.Enabled = true;
            btSupprimer.Enabled = true;
            btConfirmer.Enabled = false;
            btAnnuler.Enabled = false;
            btAjouter.Enabled = true;

            string ids = txtId.Text;
            txtIds.Items.Add(ids);
            txtIds.Text = ids;

            //vider les champs
            txtId.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            txtNom.Text = String.Empty;
            txtAge.Text = String.Empty;


        }

        private void btquitter_Click(object sender, EventArgs e)
        {
            
            this.Close();
        }

        private void btAnnuler_Click(object sender, EventArgs e)
        {
            if (txtIds.Text == "")
            {
                txtId.Enabled = false;
                txtPrenom.Enabled = false;
                txtNom.Enabled = false;
                txtAge.Enabled = false;
                txtIds.Enabled = false;
                age.Enabled = false;
                id.Enabled = false;
                nom.Enabled = false;
                prenom.Enabled = false;
                btModifier.Enabled = false;
                btSupprimer.Enabled = false;
                btConfirmer.Enabled = false;
                btAnnuler.Enabled = false;
                btAjouter.Enabled = true;
            }
            else
            {
                txtId.Enabled = true;
                txtPrenom.Enabled = true;
                txtNom.Enabled = true;
                txtAge.Enabled = true;
                txtIds.Enabled = true;
                age.Enabled = true;
                id.Enabled = true;
                nom.Enabled = true;
                prenom.Enabled = true;
                btModifier.Enabled = true;
                btSupprimer.Enabled = true;
                btConfirmer.Enabled = false;
                btAnnuler.Enabled = false;
                btAjouter.Enabled = true;
            }
        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            txtId.Enabled = true;
            txtPrenom.Enabled = true;
            txtNom.Enabled = true;
            txtAge.Enabled = true;
            txtIds.Enabled = true;
            age.Enabled = true;
            id.Enabled = true;
            nom.Enabled = true;
            prenom.Enabled = true;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void prenom_Click(object sender, EventArgs e)
        {

        }

        private void btVider_Click(object sender, EventArgs e)
        {
            txtId.Text = String.Empty;
            txtNom.Text = String.Empty;
            txtAge.Text = String.Empty;
            txtPrenom.Text = String.Empty;
            

        }
    }
}
