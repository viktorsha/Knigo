using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Mocks
{
    public class MockCategory : IBooksCategoryShakunVA
    {
        public IEnumerable<Category> GetCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category{CategoryName="Художественная литература", CategoryDesc="Литература для приятного времяпровождения: от классики до современной литературы" },
                    new Category{CategoryName="Бизнес-литература", CategoryDesc="Литература для саморазвития, использования в сфере бизнеса, маркетинга, менеджмента"}
                };
                    
            }
        }
    }
}
