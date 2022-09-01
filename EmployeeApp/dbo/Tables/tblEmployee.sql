CREATE TABLE [dbo].[tblEmployee] (
    [EmloyeeId]    UNIQUEIDENTIFIER DEFAULT (newid()) NOT NULL,
    [FullName]     VARCHAR (20)     NOT NULL,
    [Adderess]     VARCHAR (20)     NOT NULL,
    [CompanyName]  VARCHAR (20)     NOT NULL,
    [Designation]  VARCHAR (20)     NOT NULL,
    [MobailNumber] VARCHAR (20)     NOT NULL,
    [Email]        VARCHAR (20)     NOT NULL,
    [Active]       BIT              DEFAULT ((1)) NULL,
    [CreatedOn]    VARCHAR (50)     DEFAULT (getdate()) NULL,
    [CreatedBy]    UNIQUEIDENTIFIER NULL,
    [DeletedOn]    VARCHAR (50)     NULL,
    [DeletedBy]    UNIQUEIDENTIFIER NULL,
    [UpdatedOn]    VARCHAR (50)     NULL,
    [UpdatedBy]    UNIQUEIDENTIFIER NULL,
    PRIMARY KEY CLUSTERED ([EmloyeeId] ASC)
);

