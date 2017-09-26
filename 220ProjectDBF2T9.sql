Create table Account
(userID int identity primary key,
firstName varchar (25),
lastName varchar (25),
address varchar (100),
city varchar (25),
zip varchar (7),
state varchar(30),
country varchar (50),
email varchar(100),
passwordHash varchar (256),
passwordSalt varchar (256),
membershipLevel varchar (15),
employee varchar (3),
membershipExpiration Date,
amountSpent float)

Create Table CreditCardInfo(
cardID int identity primary key,
userID int ,
nameOnCard varchar (100),
expirationDate Date,
billingAddress varchar(100),
city varchar(50),
state varchar(30),
country varchar(50),
zip varchar (7),
cardType varchar(30),
csvHash varchar(256),
csvSalt varchar(256),
cardNumberHash varchar(256),
cardNumberSalt varchar(256),
cardLastFourDigits varchar(4)


foreign key (userID) references Account(userID), 
)


CREATE TABLE Products
(
productID int IDENTITY PRIMARY KEY,
productName varchar (100),
productDescription varchar (255),
productCategory varchar (50),
price varchar (20),
expirationDate Date,
isHazardous varchar(3),
numberInStock int,
maxStock int,
reorderPoint int,
numsold int,
reorderAmount int,
lastSold date

)

Create Table Cart
(
userID int ,
productID int,
productName varchar (100),
productDescription varchar (255),
productCategory varchar (50),
price varchar (20),
numInCart int

foreign key (userID) references Account(userID),
foreign key (productID) references Products(productID),
 
)


CREATE TABLE ReceiptHeader
(
receiptID int identity primary key,
userID int,
orderSubTotal float ,
orderFederalTax float,
orderStateTax float,
orderGrandTotal float,

foreign key (userID) references Account(userID),
)


Create Table ReceiptDetail
(
detailID int identity primary key,
userID int,
receiptID int,
productID int,
productName varchar (100),
productDescription varchar (255),
productCategory varchar (50),
price varchar (20),


foreign key (userID) references Account(userID),
foreign key (receiptID) references ReceiptHeader(receiptID),
foreign key (productID) references Products(productID)
)

GO

Create Proc usp_AddAccount
	@firstName varchar (25),
	@lastName varchar(25),
	@address varchar (100),
	@city varchar (25),
	@zip varchar(7),
	@state varchar(30),
	@country varchar (50),
	@email varchar (100),
	@passwordHash varchar(256),
	@passwordSalt varchar (256),
	@membershipLevel varchar(15),
	@employee varchar(3),
	@expDate date,
	@amountSpent float
AS
	INSERT INTO Account (firstName,lastName,address, city ,zip ,state ,country , email, passwordHash,passwordSalt,membershipLevel, employee, membershipExpiration, amountSpent) VALUES (@firstName ,@lastName ,@address ,@city , @zip, @state , @country ,@email, @passwordHash , @passwordSalt , @membershipLevel , @employee, @expDate, @amountSpent)
GO

Create proc usp_GetUser
	@email varchar(100)
AS
	Begin
		SELECT *
		FROM Account
		WHERE email  = @email
	END 
GO

Create proc usp_AddCard
	@userID int,
	@nameOnCard varchar (100),
	@expirationDate Date,
	@billingAddress varchar(100),
	@city varchar(50),
	@state varchar(30),
	@country varchar(50),
	
	@zip varchar (7),
	@cardType varchar(30),
	@csvHash varchar(256),
	@csvSalt varchar(256),
	@cardNumberHash varchar(256),
	@cardNumberSalt varchar(256),
	@lastFour varchar(4)
AS
	INSERT INTO CreditCardInfo (userID,nameOnCard , expirationDate,billingAddress,city,state,country,zip,cardType,csvHash,csvSalt,cardNumberHash,cardNumberSalt,cardLastFourDigits) VALUES (@userID,@nameOnCard,@expirationDate,@billingAddress,@city,@state,@country,@zip,@cardType,@csvHash,@csvSalt,@cardNumberHash, @cardNumberSalt,@lastFour)
GO

Create proc usp_UpdateAccountMembershipLevelBronze
	@userID int
AS
	BEGIN
		UPDATE Account 
        SET membershipLevel = 'Bronze'
        WHERE  userID = @userID
	END
GO

Create proc usp_UpdateAccountExpirationDate
	@userID int,
	@date date
AS
	BEGIN
		UPDATE Account 
        SET membershipExpiration = @date
        WHERE  userID = @userID
	END
GO

GO
create proc usp_AddProduct
	
	@productName varchar (100),
	@productDescription varchar (255),
	@productCategory varchar (50),
	@price varchar (20),
	@expirationDate Date,
	@isHazardous varchar(3),
	@numberInStock int,
	@maxStock int,
	@reorderPoint int,
	@numSold int,
	@reorderAmount int,
	@lastSold Date
AS
	INSERT INTO Products (productName,productDescription,productCategory,price,expirationDate,isHazardous,numberInStock,maxStock,reorderPoint, numsold,reorderAmount,lastSold) VALUES (@productName, @productDescription,@productCategory,@price,@expirationDate,@isHazardous,@numberInStock,@maxStock,@reorderPoint,@numSold,@reorderAmount,@lastSold)
GO


create proc usp_GetAllProducts
AS
	BEGIN 
		select*
		from Products
	END
GO

create proc usp_GetAllAccounts
AS
	BEGIN 
		select*
		from Account
	END
GO

create proc usp_AddToCart
	@userID int,
	@productID int,
	@productName varchar (100),
	@productDescription varchar (255),
	@productCategory varchar (50),
	@price varchar (20),
	@Qty int
AS
	INSERT INTO Cart(userID, productID,productName, productDescription, productCategory, price,numInCart ) VALUES (@userID, @productID, @productName, @productDescription, @productCategory, @price,@Qty)
GO

create proc usp_GetUserCart
	@userID int
AS
	Begin
		SELECT *
		FROM Cart
		WHERE userID  = @userID
	END 
GO

create proc usp_GetUserCards
	@userID int
AS
	Begin
		SELECT *
		FROM CreditCardInfo
		WHERE userID  = @userID
	END 
GO

create proc usp_UpdateStockQty
	@productID int,
	@Qty int
AS
	BEGIN
		UPDATE Products 
        SET numberInStock = numberInStock -@Qty
        WHERE  productID = @productID
	END
GO

create proc usp_ReturnToStock
	@productID int
AS
	BEGIN
		UPDATE Products 
        SET numberInStock = numberInStock +1
        WHERE  productID = @productID
	END
GO
create proc usp_UpdateTotalSpent
	@userID int,
	@totalSpent float
AS
	BEGIN
		UPDATE Account
        SET amountSpent = amountSpent + @totalSpent
        WHERE  userID = @userID
	END
GO

create proc usp_AddReceiptHeader
	@userID int,
	@orderSubTotal varchar (25),
	@orderFederalTax varchar (25),
	@orderStateTax varchar (25),
	@orderGrandTotal varchar (25)
AS
	INSERT INTO ReceiptHeader (userID,orderSubTotal,orderFederalTax,orderStateTax,orderGrandTotal) VALUES (@userID,@orderSubTotal, @orderFederalTax,@orderStateTax,@orderGrandTotal)
GO

create proc usp_AddReceiptDetail
	@userID int,
	@receiptID int,
	@productID int,
	@productName varchar (100),
	@productDescription varchar (255),
	@productCategory varchar (50),
	@price varchar (20)
	
AS
	INSERT INTO ReceiptDetail (userID,receiptID,productID,productName,productDescription,productCategory,price) VALUES (@userID,@receiptID,@productID,@productName,@productDescription,@productCategory,@price)
GO


create proc usp_GetReceiptID
	@userID int
AS
	Begin
		SELECT receiptID
		FROM ReceiptHeader
		WHERE userID  = @userID
	END 
GO

create proc usp_RemoveCartItem
	@userID int,
	@productID int
AS
	Begin
		DELETE FROM Cart Where userID =@userID and productID = @productID
	END 
GO

create proc usp_RemoveAccount
	@userID int
AS
	Begin
		DELETE FROM Account Where userID =@userID 
	END 
GO

Create Proc usp_EditAccount
	@userID int,
	@firstName varchar (25),
	@lastName varchar(25),
	@address varchar (100),
	@city varchar (25),
	@zip varchar(7),
	@state varchar(30),
	@country varchar (50),
	@email varchar (100)


AS
	BEGIN
		UPDATE Account
        SET  firstName = @firstName , lastName = @lastName, address = @address, city = @city , zip = @zip , state = @state, country = @country, email =  @email
        WHERE  userID = @userID
	END
GO


create proc usp_RemoveProduct
	@productID int
AS
	Begin
		DELETE FROM Products Where productID = @productID
	END 
GO

create proc usp_EditProduct
	@productID int,
	@productName varchar (100),
	@productDescription varchar (255),
	@productCategory varchar (50),
	@price varchar (20),
	@expirationDate Date,
	@isHazardous varchar(3),
	@numberInStock int,
	@maxStock int,
	@reorderPoint int
	
AS
	BEGIN
		UPDATE Products
        SET  productName = @productName, productDescription = @productDescription, productCategory = @productCategory, price = @price, expirationDate = @expirationDate, isHazardous = @isHazardous, numberInStock = @numberInStock, maxStock = @maxStock, reorderPoint = @reorderPoint 
        WHERE  productID = @productID
	END
GO

create proc usp_GetPurchases
	@userID int
AS
	Begin
		SELECT *
		FROM ReceiptDetail
		WHERE userID  = @userID
	END 
GO

Create proc usp_UpdateAccountMembershipLevel
	@userID int,
	@memLvl varchar (15)
AS
	BEGIN
		UPDATE Account 
        SET membershipLevel = @memLvl
        WHERE  userID = @userID
	END
GO

create proc usp_ExpiredItemRemoval
	@productID int
AS
	Begin
		UPDATE Products
		set numberInStock = 0
		where productID = @productID
	End
GO

create proc usp_UpdateNumSold
	@productID int,
	@numSold int
AS
	Begin
		Update Products
		set numsold =@numSold
		where productID = @productID
	End
GO

create proc usp_UpdateLastSold
	@productID int,
	@lastSold date
AS
	Begin
		Update Products
		set lastSold = @lastSold
		where productID = @productID
	End
GO

create proc usp_ChangePass
	@userID int,
	@passwordHash varChar(256), 
	@passwordSalt varChar(256)
AS
	Begin
		Update Account
		set passwordHash = @passwordHash, passwordSalt = @passwordSalt
		where userID = @userID
	End
GO

EXEC usp_UpdateStockQty @productID = 1

select *
from Account

select *
from CreditCardInfo

select *
from Products

select *
from Cart

select *
from ReceiptDetail

select *
from ReceiptHeader

Drop Table CreditCardInfo
Drop TABLE Account
drop table products
drop table Cart
drop table ReceiptHeader
drop table ReceiptDetail

delete from account where userID = 2

exec usp_AddProduct 'Jack Davidson 1.75L','1.75L of hand made whisky','Alcohol','29.99','0001-01-01','Yes',5,10,3,0,1,'0001-01-01'


exec usp_AddProduct 'Jack Davidson 750ml','750ml of hand made whisky','Alcohol','19.99','0001-01-01','Yes',5,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Jack Davidson 50ml','50ml of hand made whisky','Alcohol','5.00','0001-01-01','Yes',4,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Grey Duck 1.75L','1.75L of imported vodka','Alcohol','29.99','0001-01-01','Yes',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Grey Duck 750ml','750ml of imported vodka','Alcohol','19.99','0001-01-01','Yes',5,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Grey Duck 50ml','50ml of imported vodka','Alcohol','5.00','0001-01-01','Yes',3,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Goodwiser 24pk','24 pk of craft original beer from the rockies','Alcohol','18.79','0001-01-01','Yes',10,14,3,0,1,'0001-01-01'



exec usp_AddProduct 'Carlboro Crimson pk','Pack of Carlboro cigarrettes','Tobacco','4.84','0001-01-01','No',4,10,2,0,3,'0001-01-01'
exec usp_AddProduct 'Carlboro Crimson carton','Carton of Carlboro cigarrettes','Tobacco','35.63','0001-01-01','No',4,10,2,0,1,'0001-01-01'
exec usp_AddProduct 'Carlboro Lite pk','Pack of Carlboro cigarrettes','Tobacco','4.74','0001-01-01','No',6,10,2,0,1,'0001-01-01'
exec usp_AddProduct 'Carlboro Lite carton','Carton of Carlboro cigarrettes','Tobacco','34.63','0001-01-01','No',5,10,2,0,1,'0001-01-01'
exec usp_AddProduct 'Skole Straight Can','Skole dipping tobbacco one can','Tobacco','3.32','0001-01-01','No',6,10,3,0,1,'0001-01-01'



exec usp_AddProduct 'Fauxbreze 9.7OZ','Air Freshener','Household','6.99','0001-01-01','Yes',6,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Dysol Disenfectant 9.7OZ','Antibacterial Disinfectant','Household','6.99','0001-01-01','Yes',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Flade 9.7 OZ','Air Freshener','Household','6.99','0001-01-01','Yes',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'DeGrease Men Deoderant 3OZ','Mens Deoderant One Unit','Household','4.99','0001-01-01','Yes',4,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'DeGrease Women Deoderant 3OZ','Womens Deoderant One Unit','Household','4.99','0001-01-01','Yes',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'New Spice Men Deoderant 3OZ','Mens Deoderant One Unit','Household','4.99','0001-01-01','Yes',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'New Spice Women Deoderant 3OZ','Womens Deoderant One Unit','Household','4.99','0001-01-01','Yes',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Angel Hard Toilet Paper 9pk','Very Hard Toilet Paper.','Household','9.12','0001-01-01','No',6,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Angel Hard Toilet Paper 4pk','Very Hard Toilet Paper.','Household','6.44','0001-01-01','No',4,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Crust Toothpaste and Brush Combo Pack','Toothpaste and Toothbrush Combo Pack','Household','8.95','0001-01-01','No',5,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Pissterine Mouthwash 1L','Very Nasty Knockoff Mouthwash','Household','8.95','0001-01-01','Yes',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Pride Tods Detergent Pods 32ct','Prideful Detergent for Champions Only','Household','12.99','0001-01-01','Yes',6,10,3,0,3,'0001-01-01'





exec usp_AddProduct 'Sunny PSMore','Slightly good graphics, succeptable to hacks, solid gaming system nonetheless','Electronics','399.99','0001-01-01','Yes',3,6,2,0,1,'0001-01-01'
exec usp_AddProduct 'Sunny PSMore Controller','The controllers are this expensive?!?','Electronics','59.95','0001-01-01','Yes',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Sunny PSMore Sadden 16 Football','Another Year, Another 60$ Game','Electronics','59.95','0001-01-01','No',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Sunny PSMore Lifa 16 Soccer','Another Year, Another 60$ Game','Electronics','59.95','0001-01-01','No',4,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Smallsoft YBoxFun','Will hook up to your TV. Thats about it.  Plays some games but not as good as a PC.','Electronics','399.99','0001-01-01','Yes',3,6,2,0,1,'0001-01-01'
exec usp_AddProduct 'Smallsoft YBoxFun Controller','The controllers are this expensive?!?','Electronics','59.95','0001-01-01','Yes',5,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Smallsoft YBoxFun Sadden 16 Football','Another Year, Another 60$ Game','Electronics','59.95','0001-01-01','No',3,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Smallsoft YBoxFun Lifa 16 Soccer','Another Year, Another 60$ Game','Electronics','59.95','0001-01-01','No',4,10,3,0,3,'0001-01-01'




exec usp_AddProduct 'Winston Baseball','Baseball made with authentic materials made to be used in the sport of Baseball','Sporting Goods','2.99','0001-01-01','No',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Winston Football Youth','Football made with authentic materials made to be used in the sport of Football','Sporting Goods','8.99','0001-01-01','No',4,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Winston Football Adult','Football made with authentic materials made to be used in the sport of Football','Sporting Goods','19.99','0001-01-01','No',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Winston Basketball Adult','Basketball made with authentic materials made to be used in the sport of Basketball','Sporting Goods','19.99','0001-01-01','No',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Winston Basketball Youth','Basketball made with authentic materials made to be used in the sport of Basketball','Sporting Goods','8.99','0001-01-01','No',6,10,3,0,3,'0001-01-01'
exec usp_AddProduct 'Winston Tennisballs 3pk','Tennisballs made with authentic materials made to be used in the sport of Tennis.This pack contains 3','Sporting Goods','4.45','0001-01-01','No',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Nicky Liveweak Armband 3pk','3 pack of Nicky Liveweak Armbands, great for looking like a real supporter of a not so great man','Sporting Goods','0.99','0001-01-01','No',4,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Nicky Soccer Ball Youth','Soccerball made with authentic materials made to be used in the sport of Soccer','Sporting Goods','9.95','0001-01-01','No',6,10,3,0,1,'0001-01-01'
exec usp_AddProduct 'Nicky Soccer Ball Adult','Soccerball made with authentic materials made to be used in the sport of Soccer','Sporting Goods','22.50','0001-01-01','No',6,10,3,0,1,'0001-01-01'


exec usp_AddProduct 'Expired Milk','Test. Do Not Drink','Food','4.24','2016-11-19','No',1,5,2,3,1,'0001-01-01'
exec usp_AddProduct 'Carbers Whole Milk 1Gal','1 Gallon of Whole Milk','Food','4.24','2016-12-27','No',3,6,2,0,1,'0001-01-01'
exec usp_AddProduct 'Carbers Skim Milk 1Gal','1 Gallon of Skim Milk','Food','4.24','2016-12-27','No',5,6,2,0,1,'0001-01-01'
exec usp_AddProduct 'Carbers Chocolate Milk 1Gal','1 Gallon of Chocolate Milk','Food','5.24','2016-12-27','No',4,6,2,0,3,'0001-01-01'
exec usp_AddProduct 'Carbers 2% Milk 1Gal','1 Gallon of 2% Milk','Food','4.24','2016-12-27','No',5,6,2,0,1,'0001-01-01'
exec usp_AddProduct 'Carbers Soy Milk 1Gal','1 Gallon of Soy Milk','Food','6.24','2016-12-27','No',5,6,2,0,1,'0001-01-01'
exec usp_AddProduct 'Raft Swiss Cheese','Pack of Swiss Cheese','Food','3.99','2016-12-27','No',5,12,4,0,3,'0001-01-01'
exec usp_AddProduct 'Raft American Cheese','Pack of American Cheese','Food','3.99','2016-12-27','No',6,12,4,0,1,'0001-01-01'

