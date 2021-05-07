using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Knigo.Data.Models;

namespace Knigo.Data.Interfaces
{
    public interface IBooksCategoryShakunVA
    {
        IEnumerable<Category> GetCategories { get; }
    }
}
