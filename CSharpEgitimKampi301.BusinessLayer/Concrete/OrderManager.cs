using CSharpEgitimKampi301.BusinessLayer.Abstract;
using CSharpEgitimKampi301.DataAccessLayer.Abstract;
using CSharpEgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.BusinessLayer.Concrete
{
    public class OrderManager : IOrderService
    {
        private readonly IOrderDal _orderDal;

        public OrderManager(IOrderDal orderDal)
        {
            _orderDal = orderDal;
        }

        public void TDelete(Order entity)
        {
            _orderDal.Delete(entity);
            //throw new NotImplementedException();
        }
        public List<Order> TGetAll()
        {
            return _orderDal.GetAll();
            //throw new NotImplementedException();
        }
        public Order TGetById(int id)
        {
            return _orderDal.GetById(id);
            //throw new NotImplementedException();
        }
        public void TInsert(Order entity)
        {
            _orderDal.Insert(entity);
            //throw new NotImplementedException();
        }
        public void TUpdate(Order entity)
        {
            _orderDal.Update(entity);
            //throw new NotImplementedException();
        }
    }
}
