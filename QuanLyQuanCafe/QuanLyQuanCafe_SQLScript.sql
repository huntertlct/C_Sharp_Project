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
	FROM dbo.Cf_Employee LEFT OUTER JOIN dbo.Cf_Account ON dbo.Cf_Employee.employee_no = dbo.Cf_Account.employee_no
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
	VALUES ( GETDATE(), null, 0, @tableNo)  
END
GO

CREATE PROCEDURE addBillDetail
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

CREATE PROCEDURE payBill
@billNo INT
AS
BEGIN
    UPDATE dbo.Cf_Bill
	SET bill_stt = 1,
		bill_checkouttime = GETDATE()
	WHERE bill_no = @billNo
END
GO

CREATE PROCEDURE switchTable
@table1 INT,
@table2 INT
AS
BEGIN
	DECLARE @firstBillNo INT
	DECLARE @secondBillNo INT

	SELECT @firstBillNo = bill_no FROM dbo.Cf_Bill WHERE table_no = @table1 AND bill_stt = 0
	SELECT @secondBillNo = bill_no FROM dbo.Cf_Bill WHERE table_no = @table2 AND bill_stt = 0

	DECLARE @isTable1Empty INT = 0
	DECLARE @isTable2Empty INT = 0


	IF (@firstBillNo IS NULL)
	BEGIN
	    INSERT INTO dbo.Cf_Bill (bill_checkintime, bill_checkouttime, bill_stt, table_no)
	    VALUES (GETDATE(), NULL, 0, @table1)
		SELECT @firstBillNo = MAX(bill_no) FROM dbo.Cf_Bill WHERE table_no = @table1 AND bill_stt = 0
	END
	IF (@secondBillNo IS NULL)
	BEGIN
	    INSERT INTO dbo.Cf_Bill (bill_checkintime, bill_checkouttime, bill_stt, table_no)
	    VALUES (GETDATE(), NULL, 0, @table2)
		SELECT @secondBillNo = MAX(bill_no) FROM dbo.Cf_Bill WHERE table_no = @table2 AND bill_stt = 0
	END

	SELECT billdetail_no INTO BillDetailNoTable FROM dbo.Cf_BillDetail WHERE bill_no = @secondBillNo

	UPDATE dbo.Cf_BillDetail SET bill_no = @secondBillNo WHERE bill_no = @firstBillNo

	UPDATE dbo.Cf_BillDetail SET bill_no = @firstBillNo WHERE billdetail_no IN (SELECT * FROM dbo.BillDetailNoTable)

	SELECT @isTable1Empty = COUNT(*) FROM dbo.Cf_BillDetail WHERE bill_no = @firstBillNo
	SELECT @isTable2Empty = COUNT(*) FROM dbo.Cf_BillDetail WHERE bill_no = @secondBillNo

	IF(@isTable1Empty = 0)
	BEGIN
	    UPDATE dbo.Cf_Table SET table_stt = N'Trống' WHERE table_no = @table1
		DELETE FROM dbo.Cf_Bill WHERE bill_no = @firstBillNo
	END

	IF(@isTable2Empty = 0)
	BEGIN
	    UPDATE dbo.Cf_Table SET table_stt = N'Trống' WHERE table_no = @table2
		DELETE FROM dbo.Cf_Bill WHERE bill_no = @secondBillNo
	END

	DROP TABLE dbo.BillDetailNoTable
END
GO

CREATE PROCEDURE createEmployee
@name NVARCHAR(70),
@dob DATE,
@id CHAR(12),
@address NVARCHAR(200),
@account VARCHAR(50),
@pwd CHAR(64),
@accType INT
AS
BEGIN
	INSERT INTO dbo.Cf_Employee ( employee_name, employee_dob, employee_id, employee_address)
	VALUES ( @name, @dob, @id, @address)

	DECLARE @empNo INT
	SELECT @empNo = MAX(dbo.Cf_Employee.employee_no) FROM dbo.Cf_Employee
	INSERT INTO dbo.Cf_Account ( account_user, account_pwd, account_type, employee_no)
	VALUES (@account, @pwd, @accType, @empNo)
END
GO

CREATE PROCEDURE getEmployeeInfoByNo
@empNo INT
AS
BEGIN
	SELECT Cf_Employee.employee_no, employee_name, employee_dob, employee_id, employee_address, account_user, account_type
	FROM dbo.Cf_Employee LEFT OUTER JOIN dbo.Cf_Account ON Cf_Employee.employee_no = Cf_Account.employee_no
	WHERE Cf_Employee.employee_no = @empNo
END
GO

CREATE PROCEDURE resetPwdByEmpNo
@empNo INT,
@newPwd CHAR(64)
AS
BEGIN
	UPDATE dbo.Cf_Account
	SET account_pwd = @newPwd
	WHERE employee_no = @empNo
END
GO

CREATE PROCEDURE deleteEmployeeByNo
@empNo INT
AS
BEGIN
	IF (@empNo <> 1)
    DELETE FROM dbo.Cf_Employee
	WHERE employee_no = @empNo
END
GO

CREATE PROCEDURE UpdateEmpInfoByNo
@empNo INT,
@empName NVARCHAR(70),
@empDob DATE,
@empID CHAR(12),
@empAddress NVARCHAR(200),
@accType INT
AS
BEGIN
    UPDATE dbo.Cf_Employee
	SET employee_name = @empName,
		employee_dob = @empDob,
		employee_id = @empID,
		employee_address = @empAddress
	WHERE employee_no = @empNo
	IF( @empNo <> 1 )
		UPDATE dbo.Cf_Account
		SET account_type = @accType
		WHERE employee_no = @empNo
END
GO

------------------------------------------ TRIGGER
CREATE TRIGGER TRIGGER_UpdateBillDetail
ON dbo.Cf_BillDetail FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @billNo INT
	DECLARE @tableNo INT

	SELECT @billNo = bill_no
	FROM Inserted

	SELECT @tableNo = table_no
	FROM dbo.Cf_Bill
	WHERE bill_no = @billNo
		AND bill_stt = 0

	UPDATE dbo.Cf_Table 
	SET table_stt = N'Có người'
	WHERE table_no = @tableNo
END
GO

CREATE TRIGGER TRIGGER_UpdateBill
ON dbo.Cf_Bill FOR INSERT, UPDATE
AS
BEGIN
    DECLARE @billNo INT

	SELECT @billNo = bill_no
	FROM Inserted

	DECLARE @table_no INT

	SELECT @table_no = table_no
	FROM dbo.Cf_Bill
	WHERE bill_no = @billNo

	DECLARE @count INT = 0
	SELECT @count = COUNT(*)
	FROM dbo.Cf_Bill
	WHERE table_no = @table_no
		AND bill_stt = 0

	IF (@count = 0)
		UPDATE dbo.Cf_Table
		SET table_stt = N'Trống'
		WHERE table_no = @table_no
END
GO
