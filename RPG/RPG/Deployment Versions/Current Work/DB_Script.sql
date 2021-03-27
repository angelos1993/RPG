use RPG
go

create table Suppliers
(
	Id int not null primary key identity(1, 1),
	Name nvarchar(500) not null,
	Phone nvarchar(50) null,
	Address nvarchar(500) null,
	Email nvarchar(max) null,
	Facebook nvarchar(max) null,
	Viber nvarchar(max) null,
	WhatsApp nvarchar(max) null,
	Other nvarchar(max) null,
)
go

create table PurchaseInvoices
(
	Id int not null primary key identity(1, 1),
	Date datetime not null,
	SupplierId int not null foreign key references Suppliers(Id),
	Total decimal(18, 2) not null,
	Paid decimal(18, 2) not null,
	Discount decimal(18, 2) not null
)
go

create table PurchaseInvoicePayments
(
	Id int not null primary key identity(1, 1),
	InvoiceId int not null foreign key references PurchaseInvoices(Id),
	Date datetime not null,
	Paid decimal(18, 2) not null
)
go

create table PurchaseInvoiceItems
(
	Id int not null primary key identity(1, 1),
	InvoiceId int not null foreign key references PurchaseInvoices(Id),
	MaterialId int not null foreign key references Materials(Id),
	UnitPrice decimal(18, 2) not null,
	Quantity decimal(18, 2) not null,
	Notes nvarchar(max) null
)
go