using Knigo.Data.Interfaces;
using Knigo.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Knigo.Data.Repository
{
    public class StatusRepositoryShakunVA: IBooksStatusShakunVA
    {
        private readonly AppDBContentShakunVA appDBContent;
        public StatusRepositoryShakunVA(AppDBContentShakunVA appDBContent)
        {
            this.appDBContent = appDBContent;
        }
        public IEnumerable<StatusShakunVA> GetStatuses => appDBContent.Status;
    }
}
