using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Repository
{
    public class AuthorRepositoryShakunVA : IBooksAuthorShakunVA
    {
        private readonly AppDBContentShakunVA appDBContent;
        public AuthorRepositoryShakunVA(AppDBContentShakunVA appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<AuthorShakunVA> GetAuthors => appDBContent.Author;
    }
}
