CREATE TABLE [dbo].[Report] (
    [report_no]            INT       NOT NULL,
    [report_date]          DATE      NOT NULL,
    [date_start]           DATE      NOT NULL,
    [date_end]             DATE      NOT NULL,
    [product_no]           CHAR (12) NOT NULL,
    [total_sale]           DECIMAL(18, 3)       NOT NULL,
    [week_projected_sale]  DECIMAL(18, 3)       NOT NULL,
    [month_projected_sale] DECIMAL(18, 3)       NOT NULL,
    [stock_left]           INT       NOT NULL,
    PRIMARY KEY CLUSTERED ([report_no] ASC, [report_date] ASC, [date_start] ASC, [date_end] ASC, [product_no] ASC),
    CONSTRAINT [FK_Report_ToHealth_product] FOREIGN KEY ([product_no]) REFERENCES [dbo].[Health_Product] ([product_no]),
    CONSTRAINT [FK_Report_ToPrescription_product] FOREIGN KEY ([product_no]) REFERENCES [dbo].[Prescription_product] ([product_no])
);

