using Microsoft.AspNetCore.Identity;
using SES1B.Interface.Service;
using SES1B.Shared.DTO;
using SES1BBackendAPI.Domain.Entity;
using SES1BBackendAPI.Domain.Repository;
using SES1BBackendAPI.Interface.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SES1BBackendAPI.Service
{
    public class TableService : ITableService
    {
        // Every Service will have this Irepository
        // Automatically injected during runtime and the config of this will be in the startup.cs
        
        IRepository _repository;
        public TableService(IRepository repository)
        {
            _repository = repository;
        }

        protected bool ValidateTable(TableDTO tableDTO)
        {
            if (tableDTO.Seating == 0)
            {
                return false;
            }
            return true;
        }

        public TableDTO CreateTable(TableDTO tableDTO)
        {
            if (ValidateTable(tableDTO))
            {
                var table = new Table() {
                    Seating = tableDTO.Seating
                };
        
                _repository.PostTable(table);
                tableDTO.TableId = table.TableId;
                tableDTO.IsReserved = true;
                tableDTO.BookingId = table.BookingId;
            }

            return tableDTO;
        }

        public TableDTO EditTable(TableDTO tableDTO)
        {
            var Table = _repository.GetTables().WithTableId(tableDTO.TableId);

            Table.TableId = tableDTO.TableId;
            Table.BookingId = tableDTO.BookingId;
            _repository.PostTable(Table);
            
            return tableDTO;
        }

        public TableDTO ViewTable(TableDTO tableDTO)
        {
            var Table = _repository.GetTables().WithTableId(tableDTO.TableId);
            tableDTO.TableId = Table.TableId;
            tableDTO.Seating = Table.Seating;
            tableDTO.IsReserved = Table.IsReserved;
            tableDTO.BookingId  = Table.BookingId;

            return tableDTO;
        }

        public TableDTO DeleteTable(TableDTO tableDTO)
        {
            var Table = _repository.GetTables().WithTableId(tableDTO.TableId);
            _repository.RemoveTable(Table);

            return tableDTO;
        }
    }
}
