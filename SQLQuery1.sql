
drop table [dbo].[Users];
CREATE TABLE [dbo].[Users]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [name] VARCHAR(50) NULL, 
    [sirname] VARCHAR(50) NULL, 
    [email] VARCHAR(50) NULL, 
    [password] VARCHAR(50) NULL, 
    [adress] VARCHAR(50) NULL
)
