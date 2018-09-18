CREATE TABLE [dbo].[Record] (
    [record_date] DATE      NOT NULL,
    [product_no]  CHAR (12) NOT NULL,
    [sell_price]  DECIMAL(18,3)       NOT NULL,
    [amount]      INT       NOT NULL,
    PRIMARY KEY CLUSTERED ([record_date] ASC, [product_no] ASC),
    CONSTRAINT [FK_Record_Health_product] FOREIGN KEY ([product_no]) REFERENCES [dbo].[Health_Product] ([product_no]),
    CONSTRAINT [FK_Record_Prescription_product] FOREIGN KEY ([product_no]) REFERENCES [dbo].[Prescription_product] ([product_no])
);

