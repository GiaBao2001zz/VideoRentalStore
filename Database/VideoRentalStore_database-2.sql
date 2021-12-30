CREATE DATABASE VideoRentalStore
GO


USE VideoRentalStore
GO

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

CREATE TABLE Video
(
	id NVARCHAR(100) PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
	Price FLOAT NOT NULL DEFAULT 0,
	Quantity INT NOT NULL DEFAULT 0, -->1:Available, 0: Sold out
	Director NVARCHAR(100)  DEFAULT N'Unknow',
	Actor NVARCHAR(100) DEFAULT N'Unknow',
	Decription NVARCHAR (1000) DEFAULT N'Unknow',
	Thumbnail NVARCHAR(1000) NOT NULL,
	Provider NVARCHAR(1000) DEFAULT N'Unknow',
	Category NVARCHAR(100) DEFAULT N'Unknow',
)
GO

CREATE TABLE Request
(
	id INT IDENTITY PRIMARY KEY,
	userName NVARCHAR(100) NOT NULL DEFAULT N'Unknow',
	idVideo NVARCHAR(100) NOT NULL,
	DateRequest DATE NOT NULL DEFAULT GETDATE(),
	Price FLOAT NOT NULL DEFAULT 0,
	Quantity INT NOT NULL DEFAULT 1, 
	DateDelivered DATE,
	Type NVARCHAR(1000) NOT NULL DEFAULT N'Rent',  -- Rent / Buy / Return
	Status NVARCHAR(1000) NOT NULL  DEFAULT N'Waiting', --Waiting/Delivering/Completed

	FOREIGN KEY(idVideo) REFERENCES dbo.Video(id),
	FOREIGN KEY(userName) REFERENCES dbo.Account(Username)
)
GO


CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idVideo NVARCHAR(100) NOT NULL,
	Price INT NOT NULL,
	Status NVARCHAR(1000) NOT NULL, -- 1: đã thanh toán, 0: chưa thanh toán

	FOREIGN KEY (idVideo) REFERENCES dbo.Video(id)
)
GO


CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idVideo NVARCHAR(100) NOT NULL,
	count INT NOT NULL DEFAULT 0,
	FOREIGN KEY(idVideo) REFERENCES dbo.Video(id),
	FOREIGN KEY(idBill) REFERENCES dbo.Bill(id)

)
GO

CREATE TABLE AddToCart
(
	id INT IDENTITY PRIMARY KEY,
	Username NVARCHAR(100),
	Price FLOAT NOT NULL DEFAULT 0, --Giá 1 sản phẩm
	CurrentPrice FLOAT NOT NULL DEFAULT 0, --Giá sau khi tăng giảm số lượng
	idVideo NVARCHAR(100) NOT NULL, 
	Payment NVARCHAR(100), --Rent or Buy
	Quantity INT NOT NULL DEFAULT 1, 

	FOREIGN KEY(Username) REFERENCES dbo.Account(Username),
	FOREIGN KEY(idVideo) REFERENCES dbo.Video(id),

)
GO


SELECT * FROM Video
SELECT * FROM Account
SELECT * FROM AddToCart
SELECT * FROM Request

DELETE FROM AddToCart
DROP TABLE AddToCart
sp_help 'Request'