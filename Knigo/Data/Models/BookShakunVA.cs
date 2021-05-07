using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Models
{
    public class BookShakunVA
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public virtual AuthorShakunVA Author { get; set; }
        public int PublisherId { get; set; }
        public virtual PublisherShakunVA Publisher { get; set; }
        public int Year { get; set; }
        public int Price { get; set; }
        public int StatusId { get; set; }
        public virtual StatusShakunVA Status { get; set; }
        public string Annotation { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public string Img { get; set; }
        public int RankId { get; set; }
        public virtual RankShakunVA Rank { get; set; }


    }
}
