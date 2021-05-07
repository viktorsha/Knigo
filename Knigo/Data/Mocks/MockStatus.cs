using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Mocks
{
    public class MockStatus: IBooksStatusShakunVA
    {
        public IEnumerable<StatusShakunVA> GetStatuses
        {
            get
            {
                return new List<StatusShakunVA>
                {
                    new StatusShakunVA{StatusName="Не прочитано"},
                    new StatusShakunVA{StatusName="В процессе"},
                    new StatusShakunVA{StatusName="Прочитано"}
                };

            }
        }
    }
}
