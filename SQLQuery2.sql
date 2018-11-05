use master
go 
CREATE database GuestBook
go
CREATE TABLE Records
(
[Id] int identity PRIMARY KEY,
[Message] nvarchar(100) not null,
[Author] nvarchar(30) NOT NULL,
[Date]DATE NOT NULL
)
GO
SELECT [Id],[Message],[Author],[Date]
FROM Records
GO 
INSERT INTO Records ([Message],[Author], [Date])
VALUES ('Hello','Sasha','11/1/2018')