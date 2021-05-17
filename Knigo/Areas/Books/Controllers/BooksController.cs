using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using Knigo.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Controllers
{
    [Area("Books")]
    //[Route("Books/List")]
    public class BooksController: Controller
    {
        private readonly IBooksShakunVA _books;
        private readonly IBooksCategoryShakunVA _booksCategory;
        private readonly IBooksAuthorShakunVA _booksAuthor;
        private readonly IBooksPublisherShakunVA _booksPublisher;
        private readonly IBooksRankShakunVA _booksRank;
        private readonly IBooksStatusShakunVA _booksStatus;
        BooksListViewModelShakunVA obj = new BooksListViewModelShakunVA();
        StatusListViewModel stat = new StatusListViewModel();
        AuthorListViewModel author = new AuthorListViewModel();
        CategoryListViewModel category = new CategoryListViewModel();
        RankListViewModel rank = new RankListViewModel();
        PublisherListViewModel publisher = new PublisherListViewModel();

        public BooksController(IBooksShakunVA iBooks, IBooksCategoryShakunVA iBooksCategory, IBooksAuthorShakunVA iBooksAuthor, IBooksPublisherShakunVA iBooksPublisher, IBooksRankShakunVA iBooksRank, IBooksStatusShakunVA iBooksStatus)
        {
            _books = iBooks;
            _booksCategory = iBooksCategory;
            _booksAuthor = iBooksAuthor;
            _booksPublisher = iBooksPublisher;
            _booksRank = iBooksRank;
            _booksStatus = iBooksStatus;
        }
        [HttpGet]
        public ViewResult List(int? id, string[] filterString)
        {

            stat.allStatuses = _booksStatus.GetStatuses.ToList();
            author.allAuthors = _booksAuthor.GetAuthors.ToList();
            category.allCategories = _booksCategory.GetCategories.ToList();
            rank.allRanks = _booksRank.GetRanks.ToList();
            publisher.allPublishers = _booksPublisher.GetPublishers.ToList();
            if (id!=null)
            {
                obj.bookById = _books.GetObjectBook(id);
                if (obj.bookById!=null)
                {
                    ViewBag.Mode = "byId";
                    obj.currentCategory = "Книги";
                }
                else
                {
                    return View("NotFound");
                }
                
            }
            else
            {
                if (filterString.Count()!=0)
                {
                    obj.allBooks = _books.GetFilteredBook(filterString);
                    ViewBag.Mode = "byFilter";
                }
                else
                {
                    obj.allBooks = _books.Books;
                    ViewBag.Mode = "all";

                }
                obj.currentCategory = "Книги";
            }


            ViewBag.Status = stat;
            ViewBag.Author = author;
            ViewBag.Category = category;
            ViewBag.Rank = rank;
            ViewBag.Publisher = publisher;
            return View(obj);
        }
        [HttpPost]
        public ActionResult Save(int id, int rank, string status)
        {
            _books.SaveBook(id, rank, status);
            return Redirect("~/Books/Books/List/"+id);
        }
        [HttpPost]
        
        public ViewResult SearchResult(string search)
        {
            obj.allBooks = _books.GetBookByName(search);
            return View(obj);
        }
        
    }
}
