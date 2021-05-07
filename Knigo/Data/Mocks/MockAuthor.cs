using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Mocks
{
    public class MockAuthor: IBooksAuthorShakunVA
    {
        public IEnumerable<AuthorShakunVA> GetAuthors
        {
            get
            {
                return new List<AuthorShakunVA>
                {
                    new AuthorShakunVA{AuthorName="Юлия Рублева", AmountOfWrittenBooks=2, AuthorInfo="Молодая писательница"},
                    new AuthorShakunVA{AuthorName="Михаил Лабковский", AmountOfWrittenBooks=1, AuthorInfo="Психолог, писатель"},
                    new AuthorShakunVA{AuthorName="Марк Уильямс", AmountOfWrittenBooks=1, AuthorInfo=""},
                    new AuthorShakunVA{AuthorName="Денни Пенман", AmountOfWrittenBooks=1, AuthorInfo=""},

                };

            }
        }
    }
}
