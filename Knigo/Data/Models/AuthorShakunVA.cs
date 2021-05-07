using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Models
{
    public class AuthorShakunVA
    {
        public int Id { get; set; }
        public string AuthorName { get; set; }
        public int AmountOfWrittenBooks { get; set; }

        public string AuthorInfo { get; set; }

    }
}
