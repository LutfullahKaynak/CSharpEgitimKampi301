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
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public void TDelete(Category entity)
        {
            _categoryDal.Delete(entity);
            //throw new NotImplementedException();
        }
        public List<Category> TGetAll()
        {
            return _categoryDal.GetAll();
            //throw new NotImplementedException();
        }
        public Category TGetById(int id)
        {
            return _categoryDal.GetById(id);
            // throw new NotImplementedException();
        }
        public void TInsert(Category entity)
        {
            _categoryDal.Insert(entity);
            //throw new NotImplementedException();
        }
        public void TUpdate(Category entity)
        {
            _categoryDal.Update(entity);
            //throw new NotImplementedException();
        }
    }
}
