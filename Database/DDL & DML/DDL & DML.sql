CREATE TABLE Indextation (
	id_index		INT				PRIMARY KEY IDENTITY(1,1),
	base_format		NVARCHAR(25)	NOT NULL,
	amount_data		INT				DEFAULT(0)
)

CREATE TABLE Categories (
	category_id		INT				PRIMARY KEY IDENTITY(1,1),
	category_name	NVARCHAR(100)	NOT NULL,
	category_status	INT				DEFAULT(1)
)

CREATE TABLE Products (
	product_id		NVARCHAR(25)		PRIMARY KEY,
	product_name	NVARCHAR(250)		NOT NULL,
	product_price	FLOAT				NOT NULL,
	category_id		INT					REFERENCES Categories(category_id),
	product_image	IMAGE				NOT NULL,
	product_status	INT					DEFAULT(1)
)

CREATE TABLE Users (
	user_id			NVARCHAR(25)		PRIMARY KEY,
	user_name		NVARCHAR(250)		NOT NULL,
	user_address	NVARCHAR(250)		NOT NULL,
	user_email		NVARCHAR(250)		UNIQUE NOT NULL,
	user_phone		NVARCHAR(250)		NOT NULL,
	user_role		INT					NOT NULL,
	user_username	NVARCHAR(50)		NOT NULL,
	user_password	NVARCHAR(MAX)		NOT NULL,
	user_image		IMAGE				NOT NULL,
	user_status		INT					DEFAULT(1)
)

CREATE TABLE Payments (
	payment_id		INT					PRIMARY KEY IDENTITY(1,1),
	payment_name	NVARCHAR(50)		NOT NULL,
	payment_status	INT					DEFAULT(1)
)

CREATE TABLE Orders (
	order_id		NVARCHAR(25)		PRIMARY KEY,
	user_id			NVARCHAR(25)		REFERENCES Users(user_id),
	payment_id		INT					REFERENCES Payments(payment_id),
	order_date		DATETIME			NOT NULL,
	order_status	INT					DEFAULT(1)
)

CREATE TABLE OrderDetail (
	detail_id			INT					PRIMARY KEY IDENTITY(1,1),
	order_id			NVARCHAR(25)		REFERENCES Orders(order_id),
	product_id			NVARCHAR(25)		REFERENCES Products(product_id),
	product_price		FLOAT				NOT NULL,
	order_amount		INT					NOT NULL
)

INSERT INTO Indextation(base_format)
VALUES
	('PROD'), ('USR'), ('ORD')

INSERT INTO Payments (payment_name)
VALUES
    ('Cash'), ('Debit Card'), ('Credit Card'), ('E-Wallet'), ('Bank Transfer'), ('QRIS'), ('Pay Later'), ('Others');