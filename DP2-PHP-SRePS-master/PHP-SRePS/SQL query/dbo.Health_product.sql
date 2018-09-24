CREATE TABLE [dbo].[Health_Product] (
    [product_no]    CHAR (12)     NOT NULL,
    [product_name]  VARCHAR (100) NOT NULL,
    [product_type]  VARCHAR (30)  NOT NULL,
    [retail_price]  DECIMAL (18,3) NOT NULL,
    [our_price]     DECIMAL (18,3) NOT NULL,
    [on_sale_price] DECIMAL (18,3) NOT NULL,
    PRIMARY KEY CLUSTERED ([product_no] ASC)
);

