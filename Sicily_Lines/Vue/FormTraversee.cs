using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using MySql.Data.MySqlClient;
using Sicily_Lines.Controleur;
using Sicily_Lines.Modele;

namespace Sicily_Lines.Vue
{
    public partial class FormTraversee : Form
    {
        Mgr monManager;
        Liaison liaison;
        List<Traversee> listTraversee;
        List<Bateau> listBateau;
        public FormTraversee()
        {
            InitializeComponent();
            monManager = new Mgr();
        }
        private void FormTraversee_Load(object sender, EventArgs e)
        {
            listTraversee = monManager.chargementTravBD(liaison);
            listBateau = monManager.chargementBateauBD();
            cbBateau.DataSource = null;
            cbBateau.DataSource = listBateau;
            cbBateau.DisplayMember = "Description";
            affichage();
        }
        internal void getLiaison(Liaison uneliaison)
        {
            this.liaison = uneliaison;
        }
        public void affichage()
        {
            try
            {
                lbTraversee.DataSource = null;
                lbTraversee.DataSource = listTraversee;
                lbTraversee.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void BoutonUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Traversee trav = (Traversee)lbTraversee.SelectedItem;
                trav.DateTraverse = tbDateMAJ.Text;
                trav.Heure= tbHeureMAJ.Text;
                monManager.updateTraversee(trav);
                listTraversee = monManager.chargementTravBD(liaison);
                affichage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoutonSupp_Click(object sender, EventArgs e)
        {
            try
            {
                Traversee trav = (Traversee)lbTraversee.SelectedItem;
                monManager.suppTraversee(trav);
                listTraversee = monManager.chargementTravBD(liaison);
                affichage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoutonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Traversee trav = new Traversee(Convert.ToInt16(tbIdTrav.Text), (Bateau)cbBateau.SelectedItem, liaison, tbDate.Text, tbHeure.Text);
                monManager.addTraversee(trav);
                listTraversee = monManager.chargementTravBD(liaison);
                affichage();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
