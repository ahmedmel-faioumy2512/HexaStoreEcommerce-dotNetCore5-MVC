using HexaStoreECom.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HexaStoreECom.Entities.Repositories
{
    public interface IOrderDetailRepository:IGenericRepository<OrderDetail>
    {
        void Update(OrderDetail orderDetail);
    }
}
