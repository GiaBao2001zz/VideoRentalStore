CREATE DATABASE VideoRentalStore
GO


USE VideoRentalStore
GO

--Video
--VideoCategory
--DiscEntryVoucher
--Account
--Bill
--BillInfo
--Rental voucher
--Provider

CREATE TABLE Account
(
	Username NVARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	PhoneNumber NVARCHAR(100),
	Email NVARCHAR(100),
	DateCreate DATE,
	CMND NVARCHAR(100) NOT NULL DEFAULT 0,
	Address NVARCHAR(100),
	Type INT NOT NULL DEFAULT 0 -- 1:Admin/staff , 0: User

)
GO

CREATE TABLE VideoCategory
(
	id NVARCHAR(100) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
)
GO

CREATE TABLE Video
(
	id INT  PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
	IDCategory NVARCHAR(100) NOT NULL,
	Price FLOAT NOT NULL DEFAULT 0,
	Quantity INT NOT NULL DEFAULT 0, -->1:Available, 0: Sold out
	Director NVARCHAR(100)  DEFAULT N'Unknow',
	Actor NVARCHAR(100),
	Decription NVARCHAR (1000),
	Thumbnail NVARCHAR(100),
	Provider NVARCHAR(1000),
	Category NVARCHAR(100),
)
GO


CREATE TABLE Provider
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
)


/*
CREATE TABLE DiscEntryVoucher
(
	id INT IDENTITY PRIMARY KEY,
	idProvider INT NOT NULL,
	idVideo INT NOT NULL,
	idCategory INT NOT NULL,

	FOREIGN KEY(idProvider) REFERENCES dbo.Provider(id)
)
GO
*/
Go

CREATE TABLE Request
(
	id INT IDENTITY PRIMARY KEY,
	nameCustomer NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
	addressCustomer NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
	idVideo INT NOT NULL,
	DateRequest DATE NOT NULL DEFAULT GETDATE(),
	DateDelivered DATE,
	Type NVARCHAR(1000) NOT NULL DEFAULT N'Rent',  -- Rent / Buy / Return
	Status NVARCHAR(1000) NOT NULL  DEFAULT N'Waiting', --Waiting/Delivering/Completed
	FOREIGN KEY(idVideo) REFERENCES dbo.Video(id)
)

GO


CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idVideo INT NOT NULL,
	Price INT NOT NULL,
	Status NVARCHAR(1000) NOT NULL, -- 1: đã thanh toán, 0: chưa thanh toán

	FOREIGN KEY (idVideo) REFERENCES dbo.Video(id)
)
GO


CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idVideo INT NOT NULL,
	count INT NOT NULL DEFAULT 0,
	FOREIGN KEY(idVideo) REFERENCES dbo.Video(id),
	FOREIGN KEY(idBill) REFERENCES dbo.Bill(id)

)
GO

INSERT INTO Account
VALUES (N'admin',N'Gia Bảo',N'admin','0948769460',N'tranhoanggiabao2001@gmail.com','20211120','272839489',N'Đồng Nai',1)

select * from Account
	
DELETE FROM Account WHERE Username='';
SELECT Username FROM Account WHERE Username = 'Chiki '
Select * from Request



INSERT INTO Request(nameCustomer, addressCustomer,idVideo,DateRequest,DateDelivered,RequestType,Status)
VALUES (N'Nguyễn Văn Toán', N'45/2 Lê Lợi, TP Thủ Dầu Một', 01 , '20011127' , '20211129' ,'Rent' ,N'Waiting')
VALUES (N'Nguyễn Trọng Tính', N'15/4 Huỳnh Văn Lũy, TP Thủ Dầu Một', 01 , '20011123' , '20211125' ,'Rent' ,N'Waiting').

VALUES (N'Nguyễn Trọng Tính', N'15/4 Huỳnh Văn Lũy, TP Thủ Dầu Một', 01 , '20011123' , '20211125' ,'Rent' ,N'Waiting')
VALUES (N'Nguyễn Trọng Tính', N'15/4 Huỳnh Văn Lũy, TP Thủ Dầu Một', 01 , '20011123' , '20211125' ,'Rent' ,N'Waiting')
Select * from Video

INSERT INTO Video( id,Name,IDCategory,Price,Quantity,Director,Actor,Decription,Thumbnail)
VALUES ('01', N'Promise Land' , '01' , 100000, 12 , N'Kaiu Shirai, Posuka Demizu' , N'Emma ,Ray, Don, Gilda, Anna' ,'IDK' ,'404')

Insert into VideoCategory
Values ('01', N'Kinh Dị')
Select * from VideoCategory

SELECT id, nameCustomer, addressCustomer, DateRequest,Type  FROM Request WHERE Status = 'Waiting'

UPDATE Request SET Status = 'Compeleted' Where id = 3


UPDATE Request SET Status = 'Waiting' Where id = 3
select * from Request

SELECT * FROM Video

INSERT INTO Video (Name, id, Price, Quantity, Provider, Category) VALUES (N'Joker', 1, 100000, 1, 123, 123 )

ALTER TABLE Video ADD  Category NVARCHAR(100)
ALTER TABLE Video DROP COLUMN IDCategory
ALTER TABLE Video
DROP CONSTRAINT FK__Video__IDCategor__30F848ED;

ALTER TABLE Video
ADD Thumbnail nvarchar(100)

ALTER TABLE Video DROP COLUMN Thumbnail

Alter table Video Alter Column Thumbnail nvarchar(100)

Delete FROM Video WHERE Thumbnail IS NULL

sp_help 'Video'   