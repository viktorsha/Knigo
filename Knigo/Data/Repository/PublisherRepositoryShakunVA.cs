using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace Knigo.Data.Repository
{
    public class PublisherRepositoryShakunVA: IBooksPublisherShakunVA
    {
        private readonly AppDBContentShakunVA appDBContent;
        public PublisherRepositoryShakunVA(AppDBContentShakunVA appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<PublisherShakunVA> GetPublishers => appDBContent.Publisher;
    }
}
