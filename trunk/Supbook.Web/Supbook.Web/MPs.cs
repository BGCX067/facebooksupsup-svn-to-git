using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supbook.Web
{
    public partial class MPs
    {
        static SupbookEntities ctx = new SupbookEntities();

        public static List<Utilisateur> GetListMPsUser(int idUser)
        {
            var query = from a in ctx.MPs
                        where a.IdUser == idUser
                        || a.IdContact == idUser
                        select a.Utilisateur;

            return query.Distinct().ToList();
        }

        public static List<MP> GetAllMPsByIdUser(int idUser)
        {
            var query = from a in ctx.MPs
                        where a.IdUser == idUser
                        || a.IdContact == idUser
                        select a;

            return query.ToList();
        }
    }
}