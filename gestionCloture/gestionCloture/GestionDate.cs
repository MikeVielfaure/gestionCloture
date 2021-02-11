using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gestionCloture
{
  public abstract class GestionDate
  {
    // renvoit le numéro du mois précédent à la date d'aujourd'hui sous forme "xx"
    public static string getMoisPrecedent()
    {
      // récupération de la date d'aujourd'hui
      DateTime laDate = DateTime.Today;
      // récupère le mois
      int leMois = laDate.Month;
      // récupére et retourne le mois précédent
      return moisPrecedent(leMois);
    }


    // renvoit le numéro du mois précédent à la date en paramètre sous forme "xx"
    public static string getMoisPrecedent(DateTime laDate)
    {
      // récupère le mois
      int leMois = laDate.Month;
      // récupére et retourne le mois précédent
      return moisPrecedent(leMois);
    }


    // méthode qui récupère le mois précédent sous forme "xx"
    private static String moisPrecedent(int leMois)
    {
      // vérifie si le mois actuel est janvier dans ce cas faudra le mois précédent sera décembre donc 12
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


  }
}
