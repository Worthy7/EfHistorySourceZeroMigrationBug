using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Migrations.History;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF6Bug
{
    public class DbCommandTreeInterceptor : IDbCommandTreeInterceptor
    {
        public void TreeCreated(DbCommandTreeInterceptionContext interceptionContext)
        {
            var firstc = interceptionContext.DbContexts.First();
            if (firstc is HistoryContext)
            {

                if ((firstc as HistoryContext).CacheKey == "dbo")
                    throw new Exception($"History Context is wrong {(firstc as HistoryContext).CacheKey}");
            }

        }
    }
}
