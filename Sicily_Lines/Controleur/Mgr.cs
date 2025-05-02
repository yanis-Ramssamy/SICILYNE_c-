using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sicily_Lines.DAL;
using Sicily_Lines.Modele;

namespace Sicily_Lines.Controleur
{
    internal class Mgr
    {
        LiaisonDAO liaisDAO = new LiaisonDAO();

        List<Liaison> liaisList;
        List<Secteur> secteurList;
        List<Port> portList;
        List<Traversee> travList;
        List<Bateau> bateauList;

        public Mgr ()
        {
            liaisList = new List<Liaison>();
        }

        public List<Liaison> chargementLiaiBD(Secteur secteur)
        {
            liaisList = LiaisonDAO.getLiaisons(secteur);

            return (liaisList);
        }

        public List<Secteur> chargementSectBD()
        {
            secteurList = SecteurDAO.getSecteurs();

            return (secteurList);
        }
        public List<Port> chargementPortBD()
        {
            portList = PortDAO.getPorts();

            return (portList);
        }
        public List<Traversee> chargementTravBD(Liaison liaison)
        {
            travList = TraverseeDAO.getTraversee(liaison);
            return (travList);
        }
        public List<Bateau> chargementBateauBD()
        {
            bateauList = BateauDAO.getBateau();

            return (bateauList);
        }

        public void updateLiaison(Liaison e)
        {
            LiaisonDAO.updateLiaison(e);
        }
        public void suppLiaison(Liaison e)
        {
            LiaisonDAO.suppLiaison(e);
        }
        public void addLiaison(Liaison e)
        {
            LiaisonDAO.addLiaison(e);
        }
        public void updateTraversee(Traversee e)
        {
            TraverseeDAO.updateTraversee(e);
        }
        public void suppTraversee(Traversee e)
        {
            TraverseeDAO.suppTraversee(e);
        }
        public void addTraversee(Traversee e)
        {
            TraverseeDAO.addTraversee(e);
        }
    }
}
