CREATE TABLE [dbo].[Daily_Summary] (
    [SummaryDate]  DATETIME        NOT NULL,
    [TotalGross]   DECIMAL (18, 2) NOT NULL,
    [TotalCash]    DECIMAL (18, 2) NULL,
    [TotalPos]     DECIMAL (18, 2) NULL,
    [TotalNet]     DECIMAL (18, 2) NULL,
    [TotalCashNet] DECIMAL (18, 2) NULL,
    [DailyCosts]   DECIMAL (18, 2) NULL,
    PRIMARY KEY CLUSTERED ([SummaryDate] ASC)
);

