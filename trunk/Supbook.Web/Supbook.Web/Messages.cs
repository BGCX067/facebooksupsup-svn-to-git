using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Supbook.Web
{
    
    public partial class Messages
    {
        static SupbookEntities ctx = new SupbookEntities();

        public static List<Wall> AllMessages()
        {
            var query = from a in ctx.Walls
                        select a;
            return query.ToList();
        }

        public static List<Wall> MesMessages(int id)
        {
            var query = from a in ctx.Walls
                        select a;
            List<Wall> meswallmessages = new List<Wall>();
            foreach (var item in query)
            {
                if (item.IdUser == id)
                {
                    meswallmessages.Add(item);
                }
            }
            return meswallmessages;
        }
    }
}