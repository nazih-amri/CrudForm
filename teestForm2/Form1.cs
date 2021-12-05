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
        int where;
        List<Person> listPer = new List<Person>();

        private void inisial()
        {
            ddl_ids.Enabled = true;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtAge.Enabled = false;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = false;
            btAnnuler.Enabled = false;
            btAjouter.Enabled = true;
            ddl_ids.SelectedItem = null;
            txtPrenom.Clear();
            txtNom.Clear();
            txtAge.Clear();

        }

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            inisial();
        }


        private void btAjouter_Click(object sender, EventArgs e)
        {
            where = 1;
            ddl_ids.Enabled = false;
            ddl_ids.SelectedItem = null;
            txtPrenom.Enabled = true;
            txtNom.Enabled = true;
            txtAge.Enabled = true;
            /*age.Enabled = true;
            nom.Enabled = true;
            prenom.Enabled = true;*/
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;
            txtPrenom.Clear();
            txtNom.Clear();
            txtAge.Clear();
            ddl_ids.Enabled = false;

        }

        private void btModifier_Click(object sender, EventArgs e)
        {
            where = 2;
            ddl_ids.Enabled = false;
            txtPrenom.Enabled = true;
            txtNom.Enabled = true;
            txtAge.Enabled = true;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;

        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            where = 3;
            ddl_ids.Enabled = false;
            txtPrenom.Enabled = false;
            txtNom.Enabled = false;
            txtAge.Enabled = false;
            btModifier.Enabled = false;
            btSupprimer.Enabled = false;
            btConfirmer.Enabled = true;
            btAnnuler.Enabled = true;
            btAjouter.Enabled = false;
        }

        private void btConfirmer_Click(object sender, EventArgs e)
        {
            if (where == 1)
            {
                if (txtPrenom.Text.Trim().Length > 0 && txtNom.Text.Trim().Length > 0 && txtAge.Text.Trim().Length > 0)
                {
                    Person p = new Person(txtPrenom.Text, txtNom.Text, int.Parse(txtAge.Text));
                    listPer.Add(p);
                    ddl_ids.Items.Add(p.id.ToString());
                    ddl_ids.Text = p.id.ToString();
                    txtPrenom.Text = p.prenom;
                    txtNom.Text = p.nom;
                    txtAge.Text = p.age.ToString();
                    txtAge.Text = string.Empty;
                    txtNom.Text = string.Empty;
                    txtPrenom.Text = string.Empty;
                    ddl_ids.Text = string.Empty;


                }
            }
            else if (where == 2)
            {
                for (int i = 0; i < listPer.Count; i++)
                {
                    if (listPer[i].id == int.Parse(ddl_ids.Text))
                    {
                        listPer[i].prenom = txtPrenom.Text;
                        listPer[i].nom = txtNom.Text;
                        listPer[i].age = int.Parse(txtAge.Text);
                        btAjouter.Enabled = true;
                        btModifier.Enabled = true;
                        btSupprimer.Enabled = true;
                        btAnnuler.Enabled = false;
                        btConfirmer.Enabled = false;
                    }
                }
            }
            else
            {
                for (int i = 0; i < listPer.Count; i++)
                {
                    if (listPer[i].id == int.Parse(ddl_ids.Text))
                    {
                        listPer.Remove(listPer[i]);
                        ddl_ids.Items.Remove(ddl_ids.SelectedItem);
                        inisial();
                    }

                }

            }

        }

            private void btAnnuler_Click(object sender, EventArgs e)
            {
                inisial();
            }


            private void ddl_ids_SelectedIndexChanged(object sender, EventArgs e)
            {
                ddl_ids.Enabled = true;
                txtAge.Enabled = false;
                txtNom.Enabled = false;
                txtPrenom.Enabled = false;
                btAjouter.Enabled = true;
                btModifier.Enabled = true;
                btSupprimer.Enabled = true;
                btConfirmer.Enabled = false;
                btAnnuler.Enabled = false;
                foreach (Person p in listPer)
                {
                    if (p.id.ToString() == ddl_ids.Text)
                    {
                        txtAge.Text = p.age.ToString();
                        txtPrenom.Text = p.prenom;
                        txtNom.Text = p.nom;
                    }
                }
            }

        private void prenom_Click(object sender, EventArgs e)
        {

        }



        private void age_Click(object sender, EventArgs e)
        {

        }

        private void nom_Click(object sender, EventArgs e)
        {

        }

        private void ID_Click(object sender, EventArgs e)
        {

        }





    }
    }

