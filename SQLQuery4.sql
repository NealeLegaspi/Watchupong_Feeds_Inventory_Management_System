CREATE TABLE [dbo].[Account] (
    [User_Id]  INT           IDENTITY (1, 1) NOT NULL,
    [Username] VARCHAR (100) NULL,
    [Password] VARCHAR (100) NULL,
    [Role]     VARCHAR (100) NULL,
    [Status]   VARCHAR (100) NULL,
    PRIMARY KEY CLUSTERED ([User_Id] ASC)
);