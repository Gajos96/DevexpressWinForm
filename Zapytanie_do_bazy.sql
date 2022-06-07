
use [C:\USERS\GARTENLAND13\SOURCE\REPOS\TESTUJE\TESTUJE\DATABASE_TRIAL.MDF]
go

BEGIN TRY 
Create Table Trial_Table
(
id int primary key identity(1000,1) ,
nazwa_eksportu nvarchar(25) not null,
data_wprowadzenia datetime2 not null default  CURRENT_TIMESTAMP,
uzytkownik nvarchar (25) not null UNIQUE,
lokal nvarchar(25) not null
)
END TRY  
BEGIN CATCH 
END CATCH 


DECLARE @intCounter as INT = 1;
Declare @Lokal as nvarchar= 'Krowa'
WHILE @intCounter <= 5
BEGIN
INSERT INTO Trial_Table (nazwa_eksportu ,uzytkownik ,lokal)
Values ('nazwa' + CONVERT( nvarchar,@intCounter), @Lokal + CONVERT( nvarchar, @intCounter) , 'Lokal ' + CONVERT( nvarchar, @intCounter))
Set @intCounter = @intCounter +1
END;
