using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Repository
{
    public class CategoryRepositoryShakunVA: IBooksCategoryShakunVA
    {
        private readonly AppDBContentShakunVA appDBContent;
        public CategoryRepositoryShakunVA(AppDBContentShakunVA appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<Category> GetCategories => appDBContent.Category;
    }
}
