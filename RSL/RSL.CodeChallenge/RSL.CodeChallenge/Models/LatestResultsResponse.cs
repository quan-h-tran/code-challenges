using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RSL.CodeChallenge.Models
{
    public class LatestResultsResponse
    {
        public List<DrawResult> DrawResults { get; set; }

        public ErrorInfo ErrorInfo { get; set; }
    }

    public class ErrorInfo
    {
        public int SystemId { get; set; }

        public int ErrorNo { get; set; }

        public string DisplayMessage { get; set; }

        public bool ContactSupport { get; set; }

        public string SupportErrorReference { get; set; }
    }

    public class DrawResult
    {
        public string ProductId { get; set; }

        public int DrawNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}")]
        public DateTime DrawDate { get; set; }

        public string DrawDisplayName { get; set; }

        public string DrawLogoUrl { get; set; }

        public List<int> PrimaryNumbers { get; set; }

        public List<int> SecondaryNumbers { get; set; }

        public List<int> TicketNumbers { get; set; }

        public List<Dividend> Dividends { get; set; }
    }

    public class Dividend
    {
        public int Division { get; set; }

        public int BlocNumberOfWinners { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal BlocDividend { get; set; }

        public string CompanyId { get; set; }

        public int CompanyNumberOfWinners { get; set; }

        [DisplayFormat(DataFormatString = "{0:C}")]
        public decimal CompanyDividend { get; set; }

        public string PoolTransferType { get; set; }

        public int PoolTransferredTo { get; set; }
    }
}
