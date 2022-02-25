using BussinessLayer.Abstrack;
using DataAccessLayer.Repositories;
using EntityLayer.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinessLayer.Concrete
{
    public class CategoryManager : ICategoryService
    {
        /* Business Katmanında Abstract klasörünün içinde yer alan interfaceler : Service olarak Adlandırılır.
         * Business katmanında Concrete klasörünün içinde yer alan Sınıflar : Manager olarak Adlandırılır.
         * 
        */
    //    CategoryRepository categoryRepository = new CategoryRepository();
    GenericRepository<Category> _repository = new GenericRepository<Category>();
        public void CategoryAdd(Category category)
        {
            /*if(category.CategoryName != "" && category.CategoryDescription != ""
                && category.CategoryName.Length>=5 && category.CategoryStatus == true)
            {
                categoryRepository.AddCategory(category);
            }
            else
            {
                // hata Mesajı 
            }
            */
        }

        public void CategoryDelete(Category category)
        {
            throw new NotImplementedException();
        }

        public void CategoryUpdate(Category category)
        {
            throw new NotImplementedException();
        }

        public Category GetCategory(int id)
        {
            throw new NotImplementedException();
        }

        public List<Category> GetList(int id)
        {
            throw new NotImplementedException();
        }
    }
}
/* Entity Layer 
 * Data Access Layer -> Crud
 * Business  -> Validasyon(Validaiton) Geçerlilik Kuralları
 * 
 */