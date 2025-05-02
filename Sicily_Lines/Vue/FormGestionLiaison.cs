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
using Sicily_Lines.Vue;

namespace Sicily_Lines
{
    public partial class FormGestionLiaison : Form
    {
        Mgr monManager;

        List<Secteur> listSecteur = new List<Secteur>(); 
        List<Port> listPort = new List<Port>();
        List<Liaison> listLiaison = new List<Liaison>();
        public FormGestionLiaison()
        {
            InitializeComponent();
            monManager = new Mgr();
        }

        private void FormGestionLiaison_Load(object sender, EventArgs e)
        {
            listPort = monManager.chargementPortBD();
            listSecteur = monManager.chargementSectBD();
            cbPort.DataSource = null;
            cbPort.DataSource = listPort;
            cbPort.DisplayMember = "Description";
            afficheSect();
        }
        public void afficheSect()
        {
            try
            {
                lbSecteur.DataSource = null;
                lbSecteur.DataSource = listSecteur;
                lbSecteur.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void afficheLiai()
        {
            try
            {
                tbDuree.Clear();
                tbDureeAdd.Clear();
                tbId.Clear();
                lbLiaison.DataSource = null;
                lbLiaison.DataSource = listLiaison;
                lbLiaison.DisplayMember = "Description";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void lbSecteur_SelectedIndexChanged(object sender, EventArgs e)
        {
            listLiaison = monManager.chargementLiaiBD((Secteur)lbSecteur.SelectedItem);
            afficheLiai();
        }

        private void buttonMAJ_Click(object sender, EventArgs e)
        {
            try
            {
                Liaison liai = (Liaison)lbLiaison.SelectedItem;

                liai.Duree = tbDuree.Text+"mn";

                monManager.updateLiaison(liai);

                listLiaison = monManager.chargementLiaiBD(liai.Id_secteur);


                afficheLiai();

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void buttonSupp_Click(object sender, EventArgs e)
        {
            try
            {
                Liaison liai = (Liaison)lbLiaison.SelectedItem;
                monManager.suppLiaison(liai);
                listLiaison = monManager.chargementLiaiBD(liai.Id_secteur);
                afficheLiai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                Port port_dep = new Port();
                Port port_arr = (Port)cbPort.SelectedItem;
                Secteur secteur = (Secteur)lbSecteur.SelectedItem;
                foreach (var port in listPort)
                {
                    if (port.Nom == secteur.Libelle)
                    {
                        port_dep = port;
                    }
                }
                Liaison liai = new Liaison(Convert.ToInt16(tbId.Text),port_dep,secteur,port_arr,tbDureeAdd.Text+"mn");
                monManager.addLiaison(liai);
                listLiaison = monManager.chargementLiaiBD(liai.Id_secteur);
                afficheLiai();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void BoutonTraversee_Click(object sender, EventArgs e)
        {
            Liaison liaison =(Liaison)lbLiaison.SelectedItem;
            FormTraversee modif_trav = new FormTraversee();
            modif_trav.getLiaison(liaison);
            modif_trav.ShowDialog();

        }

        private void btQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbLiaison_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
