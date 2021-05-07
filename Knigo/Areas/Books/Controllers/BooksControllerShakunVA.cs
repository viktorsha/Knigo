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
    public class BooksControllerShakunVA: Controller
    {
        private readonly IBooksShakunVA _books;
        private readonly IBooksCategoryShakunVA _booksCategory;
        private readonly IBooksAuthorShakunVA _booksAuthor;
        private readonly IBooksPublisherShakunVA _booksPublisher;
        private readonly IBooksRankShakunVA _booksRank;
        private readonly IBooksStatusShakunVA _booksStatus;
        BooksListViewModelShakunVA obj = new BooksListViewModelShakunVA();
        StatusListViewModel stat = new StatusListViewModel();

        public BooksControllerShakunVA(IBooksShakunVA iBooks, IBooksCategoryShakunVA iBooksCategory, IBooksAuthorShakunVA iBooksAuthor, IBooksPublisherShakunVA iBooksPublisher, IBooksRankShakunVA iBooksRank, IBooksStatusShakunVA iBooksStatus)
        {
            _books = iBooks;
            _booksCategory = iBooksCategory;
            _booksAuthor = iBooksAuthor;
            _booksPublisher = iBooksPublisher;
            _booksRank = iBooksRank;
            _booksStatus = iBooksStatus;
        }

        public ViewResult List(int? id)
        {
            stat.allStatuses = _booksStatus.GetStatuses.ToList();
            if (id!=null)
            {
                obj.bookById = _books.GetObjectBook(id);
                obj.currentCategory = "Книги";
            }
            else
            {
                obj.allBooks = _books.Books;
                obj.currentCategory = "Книги";
            }

            ViewBag.Status = stat;
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
