using Knigo.Data.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data
{
    public class DBObjects
    {
        public static void Initial(AppDBContentShakunVA content)
        {

            if (!content.Category.Any())
            {
                content.Category.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.Author.Any())
            {
                content.Author.AddRange(Authors.Select(c => c.Value));
            }
            if (!content.Publisher.Any())
            {
                content.Publisher.AddRange(Publishers.Select(c => c.Value));
            }
            if (!content.Rank.Any())
            {
                content.Rank.AddRange(Ranks.Select(c => c.Value));
            }
            if (!content.Status.Any())
            {
                content.Status.AddRange(Statuses.Select(c => c.Value));
            }
            if (!content.Book.Any())
            {
                content.Book.AddRange(
                    new BookShakunVA
                    {
                        Name = "Одиночество мужчин",
                        Img = "https://s1.livelib.ru/boocover/1000754113/o/ea95/Yuliya_Rubleva__Odinochestvo_muzhchin.jpeg",
                        Year = 2013,
                        Publisher = Publishers["АСТ"],
                        Category = Categories["Художественная литература"],
                        Author = Authors["Юлия Рублева"],
                        Rank = Ranks[5],
                        Status = Statuses["Прочитано"],
                        Price = 5,
                        Annotation = "Легкая, интересная для всех психологов"

                    },
                    new BookShakunVA
                    {
                        Name = "Хочу и буду",
                        Img = "https://cv3.litres.ru/pub/c/elektronnaya-kniga/cover_max1500/25280333-mihail-labkovskiy-hochu-i-budu-prinyat-sebya-polubit-zhizn-i-stat-schastlivym.jpg",
                        Year = 2020,
                        Publisher = Publishers["Альпина паблишер"],
                        Category = Categories["Художественная литература"],
                        Author = Authors["Михаил Лабковский"],
                        Rank = Ranks[3],
                        Status = Statuses["В процессе"],
                        Price = 20,
                        Annotation = "Для всех групп населения"
                    },
                    new BookShakunVA
                    {
                        Name = "Осознанность",
                        Img = "https://www.mann-ivanov-ferber.ru/assets/images/covers/11/10411/1.00x-thumb.png",
                        Year = 2020,
                        Publisher = Publishers["АСТ"],
                        Category = Categories["Художественная литература"],
                        Author = Authors["Марк Уильямс"],
                        Rank = Ranks[4],
                        Status = Statuses["В процессе"],
                        Price = 25,
                        Annotation = "Для тех, кто хочет жить и работать без стресса"
                    }); ;
            }

            content.SaveChanges();
        }
        private static Dictionary<string, Category> category;
        public static Dictionary<string, Category> Categories
            {
            get
            {
                if (category==null)
                {
                    var list = new Category[]
                    {
                        new Category{CategoryName="Художественная литература", CategoryDesc="Литература для приятного времяпровождения: от классики до современной литературы" },
                        new Category{CategoryName="Бизнес-литература", CategoryDesc="Литература для саморазвития, использования в сфере бизнеса, маркетинга, менеджмента"}
                    };
                    category = new Dictionary<string, Category>();
                    foreach (var item in list)
                    {
                        category.Add(item.CategoryName, item);
                    }
                }
                return category;
            }
        }

        private static Dictionary<string, AuthorShakunVA> author;
        public static Dictionary<string, AuthorShakunVA> Authors
        {
            get
            {
                if (author == null)
                {
                    var list1 = new AuthorShakunVA[]
                    {
                        new AuthorShakunVA{AuthorName="Юлия Рублева", AmountOfWrittenBooks=2, AuthorInfo="Молодая писательница"},
                    new AuthorShakunVA{AuthorName="Михаил Лабковский", AmountOfWrittenBooks=1, AuthorInfo="Психолог, писатель"},
                    new AuthorShakunVA{AuthorName="Марк Уильямс", AmountOfWrittenBooks=1, AuthorInfo=""},
                    new AuthorShakunVA{AuthorName="Денни Пенман", AmountOfWrittenBooks=1, AuthorInfo=""},
                    };
                    author = new Dictionary<string, AuthorShakunVA>();
                    foreach (var item in list1)
                    {
                        author.Add(item.AuthorName, item);
                    }
                }
                return author;
            }
        }

        private static Dictionary<string, PublisherShakunVA> publisher;
        public static Dictionary<string, PublisherShakunVA> Publishers
        {
            get
            {
                if (publisher == null)
                {
                    var list2 = new PublisherShakunVA[]
                    {
                       new PublisherShakunVA{PublisherName="АСТ"},
                       new PublisherShakunVA{PublisherName="Альпина паблишер"}
                    };
                    publisher = new Dictionary<string, PublisherShakunVA>();
                    foreach (var item in list2)
                    {
                        publisher.Add(item.PublisherName, item);
                    }
                }
                return publisher;
            }
        }

        private static Dictionary<int, RankShakunVA> rank;
        public static Dictionary<int, RankShakunVA> Ranks
        {
            get
            {
                if (rank == null)
                {
                    var list2 = new RankShakunVA[]
                    {
                       new RankShakunVA{StarsAmount=0},
                    new RankShakunVA{StarsAmount=1},
                    new RankShakunVA{StarsAmount=2},
                    new RankShakunVA{StarsAmount=3},
                    new RankShakunVA{StarsAmount=4},
                    new RankShakunVA{StarsAmount=5}
                    };
                    rank = new Dictionary<int, RankShakunVA>();
                    foreach (var item in list2)
                    {
                        rank.Add(item.StarsAmount, item);
                    }
                }
                return rank;
            }
        }

        private static Dictionary<string, StatusShakunVA> status;
        public static Dictionary<string, StatusShakunVA> Statuses
        {
            get
            {
                if (status == null)
                {
                    var list2 = new StatusShakunVA[]
                    {
                        new StatusShakunVA{StatusName="Не прочитано"},
                        new StatusShakunVA{StatusName="В процессе"},
                        new StatusShakunVA{StatusName="Прочитано"}
                    };
                    status = new Dictionary<string, StatusShakunVA>();
                    foreach (var item in list2)
                    {
                        status.Add(item.StatusName, item);
                    }
                }
                return status;
            }
        }
    }
}
