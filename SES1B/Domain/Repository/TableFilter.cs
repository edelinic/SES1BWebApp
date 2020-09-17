using SES1BBackendAPI.Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Domain.Repository
{
    public static partial class TableRepositoryExtension
    {
        public static Table WithTableId(this IQueryable<Table> tables, int TableId)
        {
            return tables.SingleOrDefault(p => p.TableId == TableId);
        }
    }
}
