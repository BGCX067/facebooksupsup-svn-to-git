using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supbook.Web
{
    public partial class Utilisateur
    {
        static SupbookEntities ctx = new SupbookEntities();

        public static Utilisateur GetByLogin(string login)
        {
            var query = from a in ctx.Utilisateurs
                        where a.Login == login
                        select a;
            return query.FirstOrDefault();
        }

        public static List<Utilisateur> GetAll()
        {
            /* Cette méthode récupère tous les users mais il faudrait en créer une pour récupèrer tous les amis */
            var query = from a in ctx.Utilisateurs
                        select a;
            return query.ToList();
        }

        public static Utilisateur GetByID(int id)
        {
            var query = from a in ctx.Utilisateurs
                        where a.IdUser == id
                        select a;
            return query.FirstOrDefault();
        }

        public static List<Utilisateur> GetFriendsById(int id)
        {
            return (from a in ctx.Utilisateurs
                    from f in ctx.Friends
                    where (f.IdUser == a.IdUser &&
                           f.IdUserLinked == id) ||
                          (f.IdUser == id &&
                           f.IdUserLinked == a.IdUser)
                    select a).ToList();
        }
    }
}