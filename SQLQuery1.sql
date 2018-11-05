go
CREATE TABLE Records
(
[Id] int identity PRIMARY KEY,
[Message] nvarchar(100) not null,
[Author] nvarchar(30) NOT NULL,
[Date]DATE NOT NULL
)