using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using Knigo.Data;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Knigo.Data.Repository
{
    public class BookRepositoryShakunVA : IBooksShakunVA
    {
        private readonly AppDBContentShakunVA appDBContent;
        public BookRepositoryShakunVA (AppDBContentShakunVA appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<BookShakunVA> Books => appDBContent.Book.Include(b => b.Category).Include(c=>c.Author).Include(c=>c.Publisher).Include(c=>c.Rank).Include(c=>c.Status);


        public BookShakunVA GetObjectBook(int? bookId)
        {
            return appDBContent.Book.Include(b => b.Category).Include(c => c.Author).Include(c => c.Publisher).Include(c => c.Rank).Include(c => c.Status).FirstOrDefault(b => b.Id == bookId);
        }
        public void SaveBook(int id, int rank, string status)
        {
            BookShakunVA book = appDBContent.Book.Include(b => b.Category).Include(c => c.Author).Include(c => c.Publisher).Include(c => c.Rank).Include(c => c.Status).FirstOrDefault(b => b.Id == id);
            book.Rank.StarsAmount = rank;
            book.Status.StatusName = status;
            appDBContent.SaveChanges();
        }
        public IEnumerable<BookShakunVA> GetBookOnRank(int rank) => appDBContent.Book.Where(b => b.Rank.StarsAmount == rank);

        public IEnumerable<BookShakunVA> GetBookOnCategory(string category) => appDBContent.Book.Where(b => b.Category.CategoryName == category);
        public IEnumerable<BookShakunVA> GetBookOnPublisher(string publisher) => appDBContent.Book.Where(b => b.Publisher.PublisherName == publisher);

        public IEnumerable<BookShakunVA> GetBookOnAuthor(string author) => appDBContent.Book.Where(b => b.Author.AuthorName == author);

        public IEnumerable<BookShakunVA> GetBooksOnStatus(string status) => appDBContent.Book.Where(b => b.Status.StatusName == status);

        public IEnumerable<BookShakunVA> GetBookByName(string search)=>appDBContent.Book.Where(b => b.Name.Contains(search) || b.Author.AuthorName.Contains(search)).Include(b => b.Category).Include(c => c.Author).Include(c => c.Publisher).Include(c => c.Rank).Include(c => c.Status);

        public IEnumerable<BookShakunVA> GetFilteredBook(string[] filterString)
        {
            if (!String.IsNullOrEmpty(filterString[0])&&!String.IsNullOrEmpty(filterString[1]))
                return appDBContent.Book.Where(b => b.Price>=Convert.ToInt32(filterString[0])&&b.Price<=Convert.ToInt32(filterString[1])||b.Author.AuthorName.Contains(filterString[2]) || b.Status.StatusName.Contains(filterString[3]) || b.Category.CategoryName.Contains(filterString[4])
                || b.Rank.StarsAmount == Convert.ToInt32(filterString[5]) || b.Publisher.PublisherName.Contains(filterString[6])).Include(b => b.Category).Include(c => c.Author).Include(c => c.Publisher).Include(c => c.Rank).Include(c => c.Status);
            else
                return appDBContent.Book.Where(b => b.Author.AuthorName.Contains(filterString[2]) || b.Status.StatusName.Contains(filterString[3])|| b.Category.CategoryName.Contains(filterString[4]) 
                || b.Rank.StarsAmount==Convert.ToInt32(filterString[5]) || b.Publisher.PublisherName.Contains(filterString[6])).Include(b => b.Category).Include(c => c.Author).Include(c => c.Publisher).Include(c => c.Rank).Include(c => c.Status);

        }
    }
}
