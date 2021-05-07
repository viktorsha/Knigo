using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Repository
{
    public class RankRepositoryShakunVA: IBooksRankShakunVA
    {
        private readonly AppDBContentShakunVA appDBContent;
        public RankRepositoryShakunVA(AppDBContentShakunVA appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<RankShakunVA> GetRanks => appDBContent.Rank;

    }
}
