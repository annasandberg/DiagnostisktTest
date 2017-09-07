using DiagnostisktTest.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiagnostisktTest.Services
{
    public class ProductCategoryService
    {
        private readonly ApplicationDbContext _context;

        public ProductCategoryService(ApplicationDbContext context)
        {
            _context = context;
        }

        public SelectList GetSelectList()
        {
            var categories = _context.ProductCategories.OrderBy(x => x.Name).ToList();
            var categoriesSelectList = new SelectList(categories, "ProductCategoryId", "Name");
            return categoriesSelectList;
        }
    }
}