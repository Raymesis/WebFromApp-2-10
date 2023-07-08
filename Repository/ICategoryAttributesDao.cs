using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApplication2.Model;

namespace WebApplication2.Repository
{
    interface ICategoryAttributesDao
    {
        List<CategoryAttributes> GetCategoryAttrs();
        CategoryAttributes GetCategoryAttrsById(int CategoryAttrId);
        List<CategoryAttributes> GetCategoryAttrsByCategoryId(int catId);
        int EditCategoryAttr(CategoryAttributes CategoryAttr);
        int DeleteCategoryAttr(int postAttrId);
        int InsertCategoryAttr(CategoryAttributes CategoryAttr);
    }
}
