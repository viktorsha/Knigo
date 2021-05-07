using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Mocks
{
    public class MockRank: IBooksRankShakunVA
    {
        public IEnumerable<RankShakunVA> GetRanks
        {
            get
            {
                return new List<RankShakunVA>
                {
                    new RankShakunVA{StarsAmount=0},
                    new RankShakunVA{StarsAmount=1},
                    new RankShakunVA{StarsAmount=2},
                    new RankShakunVA{StarsAmount=3},
                    new RankShakunVA{StarsAmount=4},
                    new RankShakunVA{StarsAmount=5}

                };

            }
        }
    }
}
