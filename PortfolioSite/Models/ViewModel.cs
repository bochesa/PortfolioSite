using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PortfolioSite.Models
{
    public class ViewModel
    {
       
        public ContactMe ContactMe { get; set; }
        public MyInfo MyInfo { get; set; }
        public IEnumerable<Portfolio> Portfolios { get; set; }

    }
}
