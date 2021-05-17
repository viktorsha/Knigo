using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Mocks
{
    public class MockBooks : IBooksShakunVA
    {
        private readonly IBooksCategoryShakunVA _bookCategory = new MockCategory();
        private readonly IBooksAuthorShakunVA _bookAuthor = new MockAuthor();
        private readonly IBooksRankShakunVA _bookRank = new MockRank();
        private readonly IBooksPublisherShakunVA _bookPublisher = new MockPublisher();
        private readonly IBooksStatusShakunVA _bookStatus = new MockStatus();

        public IEnumerable<BookShakunVA> Books {
            get
            {
                return new List<BookShakunVA>
                {
                    new BookShakunVA
                    {
                        Name="Одиночество мужчин", 
                        Img="https://s1.livelib.ru/boocover/1000754113/o/ea95/Yuliya_Rubleva__Odinochestvo_muzhchin.jpeg", 
                        Year=2013, 
                        Publisher = _bookPublisher.GetPublishers.First(),
                        Category=_bookCategory.GetCategories.First(), 
                        Author=_bookAuthor.GetAuthors.ElementAt(0), 
                        Rank=_bookRank.GetRanks.ElementAt(5), 
                        Status=_bookStatus.GetStatuses.ElementAt(1),
                        Price=5,
                        Annotation = "Легкая, интересная для всех психологов"
                        
                    },
                    new BookShakunVA
                    {
                        Name="Хочу и буду",
                        Img="https://cv3.litres.ru/pub/c/elektronnaya-kniga/cover_max1500/25280333-mihail-labkovskiy-hochu-i-budu-prinyat-sebya-polubit-zhizn-i-stat-schastlivym.jpg",
                        Year=2020,
                        Publisher = _bookPublisher.GetPublishers.First(),
                        Category=_bookCategory.GetCategories.Last(),
                        Author=_bookAuthor.GetAuthors.ElementAt(1),
                        Rank=_bookRank.GetRanks.ElementAt(4),
                        Status=_bookStatus.GetStatuses.ElementAt(1),
                        Price=20,
                        Annotation = "Для всех групп населения"
                    }, 
                    new BookShakunVA
                    {
                        Name="Осознанность",
                        Img="https://www.mann-ivanov-ferber.ru/assets/images/covers/11/10411/1.00x-thumb.png",
                        Year=2020,
                        Publisher = _bookPublisher.GetPublishers.First(),
                        Category=_bookCategory.GetCategories.Last(),
                        Author=_bookAuthor.GetAuthors.ElementAt(2),
                        Rank=_bookRank.GetRanks.ElementAt(4),
                        Status=_bookStatus.GetStatuses.ElementAt(1),
                        Price=25,
                        Annotation = "Для тех, кто хочет жить и работать без стресса"
                    }
                };
            }
        }
        
        public BookShakunVA GetObjectBook(int? bookId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookShakunVA> GetBookOnRank(int rank)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookShakunVA> GetBookOnCategory(string category)
        {
            throw new NotImplementedException();
        }

        public IEnumerable <BookShakunVA> GetBookOnPublisher(string publisher)
        {
            throw new NotImplementedException();
        }

        public IEnumerable <BookShakunVA> GetBookOnAuthor(string author)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookShakunVA> GetBooksOnStatus(string status)
        {
            throw new NotImplementedException();
        }

        public void SaveBook(int id, int rank, string status)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookShakunVA> GetBookByName(string search)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<BookShakunVA> GetFilteredBook(string[] filterString)
        {
            throw new NotImplementedException();
        }
    }
}
