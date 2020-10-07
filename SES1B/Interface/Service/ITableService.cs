using SES1B.Shared.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1B.Interface.Service
{
    public interface ITableService
    {
        TableDTO CreateTable(TableDTO tableDTO);
        TableDTO EditTable(TableDTO tableDTO);
        TableDTO ViewTable(TableDTO tableDTO);
        TableDTO DeleteTable(TableDTO tableDTO);             
    }
}