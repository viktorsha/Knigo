using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Interfaces
{
    public interface IBooksPublisherShakunVA
    {
        IEnumerable<PublisherShakunVA> GetPublishers { get; }
    }
}
