using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCloture
{
  public abstract class GestionDate
  {
    // renvoit le numéro du mois précédent la date d'aujourd'hui sous forme "xx"
    public static string getMoisPrecedent()
    {
      // récupération de la date d'aujourd'hui
      DateTime laDate = DateTime.Today;
      // récupère le mois
      int leMois = laDate.Month;
      // récupére et retourne le mois précédent
      return moisPrecedent(leMois);
    }


    // renvoit le numéro du mois precedent la date en paramètre sous forme "xx"
    public static string getMoisPrecedent(DateTime laDate)
    {
      // récupère le mois
      int leMois = laDate.Month;
      // récupére et retourne le mois precedent
      return moisPrecedent(leMois);
    }


    // renvoit le numéro du mois suivant la date d'aujourd'hui sous forme "xx"
    public static string getMoisSuivant()
    {
      // récupération de la date d'aujourd'hui
      DateTime laDate = DateTime.Today;
      // récupère le mois
      int leMois = laDate.Month;
      // récupére et retourne le mois suivant
      return moisSuivant(leMois);
    }


    // renvoit le numéro du mois suivant la date en paramètre sous forme "xx"
    public static string getMoisSuivant(DateTime laDate)
    {
      // récupère le mois
      int leMois = laDate.Month;
      // récupére et retourne le mois suivant
      return moisSuivant(leMois);
    }


    // vérifie si le jour d'aujourd'hui se situ entre les deux jours mis en paramètre
    public static bool entre(int jour1, int jour2)
    {
      // récupère le jour d'aujourd'hui
      DateTime laDate = DateTime.Today;
      int leJour = laDate.Day;
      // vérifie et retourne si le jour se situ entre les deux jours en paramètre
      return (leJour >= jour1 && leJour <= jour2) ;
    }


    public static bool entre(int jour1, int jour2, DateTime laDate)
    {
      // récupère le jour de la date en paramètre
      int leJour = laDate.Day;
      // vérifie et retourne si le jour se situ entre les deux jours en paramètre
      return (leJour >= jour1 && leJour <= jour2);
    }


    // méthode qui retourne le mois précédent de celui mis en paramètre sous forme "xx"
    private static String moisPrecedent(int leMois)
    {
      // vérifie si le mois est janvier dans ce cas faudra le mois précédent sera décembre donc 12
      if (leMois == 1)
      {
        return "12";
      }
      else
      {
        // vérifie si le mois est antérieur à octobre dans ce cas on rajoute un '0' devant
        if (leMois < 10)
        {
          return ("0" + (leMois-1).ToString());
        }
        else
        {
          return (leMois - 1).ToString();
        }
      }
    }


    // méthode qui retourne le mois suivant de celui mis en^paramètre sous forme "xx"
    private static String moisSuivant(int leMois)
    {
      // vérifie si le mois est décembre dans ce cas faudra le mois suivant sera janvier donc 01
      if (leMois == 1)
      {
        return "01";
      }
      else
      {
        // vérifie si le mois suivant est antérieur à octobre dans ce cas on rajoute un '0' devant
        if (leMois+1 < 10)
        {
          return ("0" + (leMois + 1).ToString());
        }
        else
        {
          return (leMois + 1).ToString();
        }
      }
    }


  }
}
