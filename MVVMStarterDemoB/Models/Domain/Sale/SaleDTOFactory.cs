using System;
using DTO.Implementation;
using DTO.Interfaces;

namespace MVVMStarterDemoB.Models.Domain.Sale
{
    public class SaleDTOFactory : DTOFactoryBase<Sale, SaleDTO>
    {
        public override Sale CreateT(IDTO obj)
        {
            SaleDTO dtoObj = (obj as SaleDTO);
            if (dtoObj == null)
            {
                throw new ArgumentException(nameof(SaleDTOFactory));
            }

            return new Sale(
                dtoObj.Key,
                dtoObj.CarKey,
                dtoObj.CustomerKey,
                dtoObj.EmployeeKey,
                dtoObj.SalesDate,
                dtoObj.FinalPrice);
        }
    }
}