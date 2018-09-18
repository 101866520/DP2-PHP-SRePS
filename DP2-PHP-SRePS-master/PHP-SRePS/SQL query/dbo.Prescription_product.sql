CREATE TABLE [dbo].[Prescription_product] (
    [product_no]       CHAR (12)     NOT NULL,
    [product_name]     VARCHAR (100) NOT NULL,
    [product_type]     VARCHAR (30)  NOT NULL,
    [brand_name]       VARCHAR (50)  NOT NULL,
    [private_price]    DECIMAL(18,3)           NOT NULL,
    [concession_price] DECIMAL(18,3)           NOT NULL,
    [normal_price]     DECIMAL(18,3)           NOT NULL,
    PRIMARY KEY CLUSTERED ([product_no] ASC),
    CONSTRAINT [FK_Prescription_product_ToTable] FOREIGN KEY ([brand_name]) REFERENCES [dbo].[Brand] ([brand_name])
);

