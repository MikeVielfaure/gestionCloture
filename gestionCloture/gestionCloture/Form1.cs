using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gestionCloture
{
  /// <summary>
  /// Cette classe modifie l'état des fiche de frais de la base de données
  /// </summary>
  public partial class Form1 : Form
  {
    /// <summary>
    /// initialise le composant
    /// </summary>
    public Form1()
    {
      InitializeComponent();
    }

    // proprietes
    private string chaineConnexion = "server=localhost;user id=root;database=gsb_frais;SslMode=none";
    private const String ETAT_CL = "CL";
    private const String ETAT_RB = "RB";

    /// <summary>
    /// méthode lue au démarrage de l'application
    /// </summary>
    private void Form1_Load(object sender, EventArgs e)
    {
      // active le timer
      myTimer.Start();
      //met a jours l'état des fiches de frais du précédent la date actuelle
      nouveauStatut();
    }

   
    ///<summary>
    /// change le statut des fiches de frais selon la date actuel
    ///</summary>
    private void nouveauStatut()
    {
      // on vérifie si le jour actuel est entre le premier et le 10
      if (GestionDate.entre(1, 15))
      {
        // on change l'état des fiches de frais du mois précédent avec l'état CL
        changeStatutFicheFrais(ETAT_CL, GestionDate.getMoisPrecedent());
      }
      else
      {
        // on vérifie si le jour actuel est entre le 20 et le dernier jours du mois
        if (GestionDate.entre(20, 31))
        {
          // on change l'état des fiches de frais du mois précédent avec l'état RB
          changeStatutFicheFrais(ETAT_RB, GestionDate.getMoisPrecedent());
        }
      }
    }

    ///<summary>
    /// change le statut des fiches de frais avec l'état et au mois mis en paramètre
    ///</summary>
    ///<param name="etat">etat qu'on veut affecter aux fiche de frais</param>
    ///<param name="leMois">le mois qui correspond au fiche de frais a modifier</param>
    private void changeStatutFicheFrais(String etat, String leMois)
    {
      ConnexionSQL crs = new ConnexionSQL(this.chaineConnexion);
      crs.req("UPDATE fichefrais SET idetat='" + etat + "' WHERE mois ='" + leMois + "'");
      crs.close();
    }

    ///<summary>
    ///A Chaque minute met a jour l'état des fiches de frais
    ///</summary>
    private void myTimer_Tick(object sender, EventArgs e)
    {
      //met a jours l'état des fiches de frais du précédent la date actuelle
      nouveauStatut();
    }
  }
}
