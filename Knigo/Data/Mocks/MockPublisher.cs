using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Mocks
{
    public class MockPublisher: IBooksPublisherShakunVA
    {
        public IEnumerable<PublisherShakunVA> GetPublishers
        {
            get
            {
                return new List<PublisherShakunVA>
                {
                    new PublisherShakunVA{PublisherName="АСТ"},
                    new PublisherShakunVA{PublisherName="Альпина паблишер"}

                };

            }
        }

    }
}
