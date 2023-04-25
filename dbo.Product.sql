CREATE TABLE [dbo].[Product] (
    [Product_Id]          INT           IDENTITY (100000, 1) NOT NULL,
    [Product_Name]        NVARCHAR (50) NOT NULL,
    [Product_Description] NVARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Product_Id] ASC)
);

