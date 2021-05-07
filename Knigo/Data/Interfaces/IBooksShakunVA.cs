using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Interfaces
{
    public interface IBooksShakunVA
    {
        public IEnumerable<BookShakunVA> Books { get; }
        public void SaveBook(int id, int rank, string status);
        public IEnumerable<BookShakunVA> GetBookByName(string search);
        public IEnumerable<BookShakunVA> GetBooksOnStatus(string status);
        public IEnumerable<BookShakunVA> GetBookOnRank(int rank);
        public IEnumerable<BookShakunVA> GetBookOnCategory(string category);
        public IEnumerable<BookShakunVA> GetBookOnPublisher(string publisher);
        public IEnumerable<BookShakunVA> GetBookOnAuthor(string author);
        public BookShakunVA GetObjectBook(int? bookId);
    }
}
