using System;
using System.Collections.Generic;

namespace BeautyHall.Api.SDK.Responses;

public class DailySummary
{
    public DateTime SummaryDate { get; set; }

    public decimal TotalGross { get; set; }

    public decimal? TotalCash { get; set; }

    public decimal? TotalPos { get; set; }

    public decimal? TotalNet { get; set; }

    public decimal? TotalCashNet { get; set; }

    public decimal? DailyCosts { get; set; }
}
