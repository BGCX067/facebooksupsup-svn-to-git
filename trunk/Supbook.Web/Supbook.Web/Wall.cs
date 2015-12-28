using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supbook.Web
{
    public partial class Wall
    {
        private static SupbookEntities ctx = new SupbookEntities();

        public static List<Wall> GetAll()
        {
            var query = from a in ctx.Walls
                        orderby a.DateWall descending
                        select a;
            return query.ToList();
        }

        [Obsolete("Totaly boggus.")]
        public static List<Wall> GetAll(List<Utilisateur> Users)
        {
            List<int> listID = new List<int>();
            foreach (var item in Users)
	        {
                listID.Add(item.IdUser);
	        }

            using (SupbookEntities ctx = new SupbookEntities())
            {
                var query = from a in ctx.Walls
                            where listID.Contains(a.IdUser.Value)
                            select a;
                return query.ToList();
            }
        }

        public static List<Wall> GetAllByUserId(int userId)
        {
            return (from a in ctx.Walls
                    from f in ctx.Friends
                    orderby a.DateWall descending
                    // Ami
                    where (f.IdUser == userId &&
                           f.IdUserLinked == a.IdUser) ||
                        // Ami lié
                          (f.IdUserLinked == userId &&
                          f.IdUser == a.IdUser) ||
                        // Moi-même
                          a.IdUser == userId
                    select a).ToList();
        }
    }
}       