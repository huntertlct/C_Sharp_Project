CREATE DATABASE QuanLyQuanCafe
GO

USE QuanLyQuanCafe
GO

-- Employee
CREATE TABLE Cf_Employee(
	employee_no INT IDENTITY CONSTRAINT pk_cf_employee PRIMARY KEY,
	employee_name NVARCHAR(70) NOT NULL,
	employee_dob DATE NOT NULL,
	employee_id CHAR(12) NOT NULL UNIQUE,
	employee_address NVARCHAR(200)
)
GO

-- Account
CREATE TABLE Cf_Account(
	account_user VARCHAR(50),
	account_pwd CHAR(64) NOT NULL,
	account_type INT NOT NULL DEFAULT 0, -- 1 là admin | 0 là staff
	employee_no INT NOT NULL,
	
	CONSTRAINT pk_cf_account PRIMARY KEY (account_user),
	CONSTRAINT fk_cf_account_employee FOREIGN KEY (employee_no) REFERENCES Cf_Employee(employee_no) ON DELETE CASCADE
)
GO

-- Drink
CREATE TABLE Cf_Drink(
	drink_no INT IDENTITY,
	drink_name NVARCHAR(50) NOT NULL UNIQUE,
	drink_price INT NOT NULL DEFAULT 0,

	CONSTRAINT pk_cf_drink PRIMARY KEY (drink_no)
)
GO

-- Table
CREATE TABLE Cf_Table(
	table_no INT IDENTITY,
	table_name NVARCHAR(15) NOT NULL,
	table_stt NVARCHAR(50) NOT NULL DEFAULT N'Trống', -- "Trống" | "Có người"

	CONSTRAINT pk_cf_table PRIMARY KEY (table_no)
)
GO

-- Bill
CREATE TABLE Cf_Bill(
	bill_no INT IDENTITY,
	bill_checkintime DATETIME NOT NULL DEFAULT SYSDATETIME(),
	bill_checkouttime DATETIME,
	bill_stt INT NOT NULL DEFAULT 0, -- 1 là đã thanh toán | 0 là chưa thanh toán
	table_no INT NOT NULL,

	CONSTRAINT pk_cf_bill PRIMARY KEY (bill_no),
	CONSTRAINT fk_cf_bill_table FOREIGN KEY (table_no) REFERENCES Cf_Table(table_no) ON DELETE CASCADE,
)
GO

-- BillDetail
CREATE TABLE Cf_BillDetail(
	billdetail_no INT IDENTITY,
	bill_no INT NOT NULL,
	drink_no INT NOT NULL,
	drink_amount INT NOT NULL DEFAULT 0,

	CONSTRAINT pk_cf_billdetail PRIMARY KEY (billdetail_no),
	CONSTRAINT fk_cf_billdetail_bill FOREIGN KEY (bill_no) REFERENCES Cf_Bill(bill_no) ON DELETE CASCADE,
	CONSTRAINT fk_cf_billdetail_drink FOREIGN KEY (drink_no) REFERENCES Cf_Drink(drink_no) ON DELETE CASCADE
)
GO

-- insert values
--INSERT INTO dbo.Cf_Employee
--(
--    employee_name,
--    employee_dob,
--    employee_id,
--    employee_address
--)
--VALUES
--(   N'steve phan',       -- employee_name - nvarchar(70)
--    '2000-01-13', -- employee_dob - date
--    '362527137',        -- employee_id - char(12)
--    N'Thốt Nốt - Cần Thơ'        -- employee_address - nvarchar(200)
--    )
--GO

--INSERT INTO dbo.Cf_Account
--(
--    account_user,
--    account_pwd,
--    account_type,
--    employee_no
--)
--VALUES
--(   'steve', -- account_user - varchar(50)
--    'a665a45920422f9d417e4867efdc4fb8a04a1f3fff1fa07e998e86f7f7a27ae3', -- account_pwd - char(64) -- pwd là "123"
--    1,  -- account_type - int
--    1   -- employee_no - int
--    )
--GO

--INSERT INTO dbo.Cf_Drink
--(
--    drink_name,
--    drink_price
--)
--VALUES
--(   N'Café đá', -- drink_name - nvarchar(50)
--    15000 -- drink_price - int
--    )
--GO

--INSERT INTO dbo.Cf_Drink
--(
--    drink_name,
--    drink_price
--)
--VALUES
--(   N'Café sữa', -- drink_name - nvarchar(50)
--    20000 -- drink_price - int
--    )
--GO

--DECLARE @i INT = 1
--WHILE @i <= 20
--BEGIN
--    INSERT INTO dbo.Cf_Table(table_name) VALUES(N'Bàn ' + CAST(@i AS VARCHAR(3)))
--	SET @i = @i + 1
--END
--GO

--INSERT INTO dbo.Cf_Bill
--(
--    bill_checkintime,
--    bill_checkouttime,
--    bill_stt,
--    table_no
--)
--VALUES
--(   GETDATE(), -- bill_checkintime - datetime
--    NULL, -- bill_checkouttime - datetime
--    0,         -- bill_stt - int
--    1         -- table_no - int
--)
--GO

--INSERT INTO dbo.Cf_Bill (bill_checkintime, bill_checkouttime, bill_stt, table_no)
--VALUES( GETDATE(), GETDATE(), 1, 2)
--GO

--INSERT INTO dbo.Cf_BillDetail ( bill_no, drink_no, drink_amount )
--VALUES ( 1, 1, 2 )
--GO

--INSERT INTO dbo.Cf_BillDetail ( bill_no, drink_no, drink_amount )
--VALUES ( 1, 2, 4 )
--GO

--INSERT INTO dbo.Cf_BillDetail ( bill_no, drink_no, drink_amount )
--VALUES ( 2, 1, 2 )
--GO

--INSERT INTO dbo.Cf_BillDetail ( bill_no, drink_no, drink_amount )
--VALUES ( 2, 2, 4 )
--GO

-- Procedure
CREATE PROCEDURE getPwd
@acc_user VARCHAR(50)
AS
BEGIN
    SELECT dbo.Cf_Account.account_pwd
	FROM dbo.Cf_Account
	WHERE dbo.Cf_Account.account_user = @acc_user
END
GO

CREATE PROCEDURE getAccType
@acc_user VARCHAR(50)
AS
BEGIN
	SELECT dbo.Cf_Account.account_type
	FROM dbo.Cf_Account
	WHERE account_user = @acc_user
END
GO

CREATE PROCEDURE changePwd
@newPwd CHAR(64),
@acc_user VARCHAR(50)
AS
BEGIN
	UPDATE dbo.Cf_Account
	SET account_pwd = @newPwd
	WHERE account_user = @acc_user
END
GO

CREATE PROCEDURE getEmployee
AS
BEGIN
	  SELECT cf_Employee.employee_no AS 'Mã NV',
			employee_name AS 'Họ Tên',
			employee_dob AS 'Ngày sinh',
			employee_id AS 'CMND',
			employee_address AS 'Địa chỉ',
			account_user AS 'Tài khoản',
			account_type AS 'Loại TK'
	FROM dbo.Cf_Employee, dbo.Cf_Account
	WHERE dbo.Cf_Employee.employee_no = dbo.Cf_Account.employee_no
END
GO

CREATE PROCEDURE getEmpName
@acc_user VARCHAR(50)
AS
BEGIN
    SELECT employee_name
	FROM cf_employee, dbo.Cf_Account
	WHERE cf_employee.employee_no = cf_account.employee_no and cf_account.account_user = @acc_user
END
GO

CREATE PROCEDURE getTableList
AS
BEGIN
	SELECT *
	FROM dbo.Cf_Table
END
GO

CREATE PROCEDURE getUncheckBillByTableNo
@tableNo INT
AS
BEGIN
	  SELECT *
	  FROM dbo.Cf_Bill
	  WHERE table_no = @tableNo AND bill_stt = 0
END
GO

CREATE PROCEDURE getBillDetailListByBillNo
@billNo INT
AS
BEGIN
	SELECT  bill_no, drink_name, drink_amount, drink_price, drink_amount*drink_price AS drink_total
	FROM dbo.Cf_BillDetail, dbo.Cf_Drink
	WHERE bill_no = @billNo AND Cf_BillDetail.drink_no = Cf_Drink.drink_no
END
GO

CREATE PROCEDURE getDrinkList
AS
BEGIN
	SELECT drink_no, drink_name
	FROM dbo.Cf_Drink
END
GO

CREATE PROCEDURE createBillByTableNo
@tableNo INT
AS
BEGIN
	INSERT INTO dbo.Cf_Bill (bill_checkintime, bill_checkouttime, bill_stt, table_no )
	VALUES ( GETDATE(), null, @tableNo, 0)  
END
GO

ALTER PROCEDURE addBillDetail
@billNo INT,
@drinkNo INT,
@drinkAmount INT
AS
BEGIN
	DECLARE @isExitBillDetail INT
	DECLARE @exitDrinkAmount INT

	SELECT @isExitBillDetail = billdetail_no, @exitDrinkAmount = drink_amount
	FROM dbo.Cf_BillDetail
	WHERE bill_no = @billNo
		AND drink_no = @drinkNo

	IF(@isExitBillDetail > 0)
		BEGIN
			DECLARE @newDrinkAmount INT = @exitDrinkAmount + @drinkAmount
			IF(@newDrinkAmount > 0)
				UPDATE dbo.Cf_BillDetail
				SET drink_amount = @newDrinkAmount
				WHERE drink_no = @drinkNo
					AND bill_no = @billNo
			ELSE
				DELETE dbo.Cf_BillDetail
				WHERE bill_no = @billNo
					AND	drink_no = @drinkNo
		END
	ELSE 
		BEGIN
			IF(@drinkAmount > 0)
				INSERT INTO dbo.Cf_BillDetail (bill_no, drink_no, drink_amount)
				VALUES( @billNo, @drinkNo, @drinkAmount)
		END
END
GO

-- test script
--USE QuanLyQuanCafe
--SELECT cf_Employee.employee_no AS 'Mã NV',
--		employee_name AS 'Họ Tên',
--		employee_dob AS 'Ngày sinh',
--		employee_id AS 'CMND',
--		employee_address AS 'Địa chỉ',
--		account_user AS 'Tài khoản',
--		account_type AS 'Loại TK'
--FROM dbo.Cf_Employee, dbo.Cf_Account
--WHERE dbo.Cf_Employee.employee_no = dbo.Cf_Account.employee_no
--GO

--SELECT employee_name
--FROM cf_employee, dbo.Cf_Account
--WHERE cf_employee.employee_no = cf_account.employee_no and cf_account.account_user = 'steve'
--GO

--SELECT dbo.Cf_Account.account_pwd
--FROM dbo.Cf_Account
--WHERE dbo.Cf_Account.account_user = 'steve'
--GO
