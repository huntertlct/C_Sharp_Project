USE [master]
GO
/****** Object:  Database [QuanLyQuanCafe]    Script Date: 10/16/2021 23:21:58 ******/
CREATE DATABASE [QuanLyQuanCafe]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyQuanCafe', FILENAME = N'F:\programs\SQL server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe.mdf' , SIZE = 4288KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyQuanCafe_log', FILENAME = N'F:\programs\SQL server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyQuanCafe_log.ldf' , SIZE = 1072KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyQuanCafe] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyQuanCafe].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyQuanCafe] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  ENABLE_BROKER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyQuanCafe] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyQuanCafe] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyQuanCafe] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyQuanCafe] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyQuanCafe] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyQuanCafe] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyQuanCafe]
GO
/****** Object:  Table [dbo].[Cf_Account]    Script Date: 10/16/2021 23:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cf_Account](
	[account_user] [varchar](50) NOT NULL,
	[account_pwd] [char](64) NOT NULL,
	[account_type] [int] NOT NULL,
	[employee_no] [int] NOT NULL,
 CONSTRAINT [pk_cf_account] PRIMARY KEY CLUSTERED 
(
	[account_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cf_Bill]    Script Date: 10/16/2021 23:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cf_Bill](
	[bill_no] [int] IDENTITY(1,1) NOT NULL,
	[bill_checkintime] [datetime] NOT NULL,
	[bill_checkouttime] [datetime] NULL,
	[bill_stt] [int] NOT NULL,
	[table_no] [int] NOT NULL,
	[bill_total] [int] NOT NULL,
 CONSTRAINT [pk_cf_bill] PRIMARY KEY CLUSTERED 
(
	[bill_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cf_BillDetail]    Script Date: 10/16/2021 23:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cf_BillDetail](
	[billdetail_no] [int] IDENTITY(1,1) NOT NULL,
	[bill_no] [int] NOT NULL,
	[drink_no] [int] NOT NULL,
	[drink_amount] [int] NOT NULL,
 CONSTRAINT [pk_cf_billdetail] PRIMARY KEY CLUSTERED 
(
	[billdetail_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cf_Drink]    Script Date: 10/16/2021 23:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cf_Drink](
	[drink_no] [int] IDENTITY(1,1) NOT NULL,
	[drink_name] [nvarchar](50) NOT NULL,
	[drink_price] [int] NOT NULL,
 CONSTRAINT [pk_cf_drink] PRIMARY KEY CLUSTERED 
(
	[drink_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[drink_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cf_Employee]    Script Date: 10/16/2021 23:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cf_Employee](
	[employee_no] [int] IDENTITY(1,1) NOT NULL,
	[employee_name] [nvarchar](70) NOT NULL,
	[employee_dob] [date] NOT NULL,
	[employee_id] [char](12) NOT NULL,
	[employee_address] [nvarchar](200) NULL,
 CONSTRAINT [pk_cf_employee] PRIMARY KEY CLUSTERED 
(
	[employee_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Cf_Table]    Script Date: 10/16/2021 23:21:58 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cf_Table](
	[table_no] [int] IDENTITY(1,1) NOT NULL,
	[table_name] [nvarchar](15) NOT NULL,
	[table_stt] [nvarchar](50) NOT NULL,
 CONSTRAINT [pk_cf_table] PRIMARY KEY CLUSTERED 
(
	[table_no] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Cf_Account] ADD  DEFAULT ((0)) FOR [account_type]
GO
ALTER TABLE [dbo].[Cf_Bill] ADD  DEFAULT (sysdatetime()) FOR [bill_checkintime]
GO
ALTER TABLE [dbo].[Cf_Bill] ADD  DEFAULT ((0)) FOR [bill_stt]
GO
ALTER TABLE [dbo].[Cf_Bill] ADD  DEFAULT ((0)) FOR [bill_total]
GO
ALTER TABLE [dbo].[Cf_BillDetail] ADD  DEFAULT ((0)) FOR [drink_amount]
GO
ALTER TABLE [dbo].[Cf_Drink] ADD  DEFAULT ((0)) FOR [drink_price]
GO
ALTER TABLE [dbo].[Cf_Table] ADD  DEFAULT (N'Trống') FOR [table_stt]
GO
ALTER TABLE [dbo].[Cf_Account]  WITH CHECK ADD  CONSTRAINT [fk_cf_account_employee] FOREIGN KEY([employee_no])
REFERENCES [dbo].[Cf_Employee] ([employee_no])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cf_Account] CHECK CONSTRAINT [fk_cf_account_employee]
GO
ALTER TABLE [dbo].[Cf_Bill]  WITH CHECK ADD  CONSTRAINT [fk_cf_bill_table] FOREIGN KEY([table_no])
REFERENCES [dbo].[Cf_Table] ([table_no])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cf_Bill] CHECK CONSTRAINT [fk_cf_bill_table]
GO
ALTER TABLE [dbo].[Cf_BillDetail]  WITH CHECK ADD  CONSTRAINT [fk_cf_billdetail_bill] FOREIGN KEY([bill_no])
REFERENCES [dbo].[Cf_Bill] ([bill_no])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cf_BillDetail] CHECK CONSTRAINT [fk_cf_billdetail_bill]
GO
ALTER TABLE [dbo].[Cf_BillDetail]  WITH CHECK ADD  CONSTRAINT [fk_cf_billdetail_drink] FOREIGN KEY([drink_no])
REFERENCES [dbo].[Cf_Drink] ([drink_no])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Cf_BillDetail] CHECK CONSTRAINT [fk_cf_billdetail_drink]
GO
/****** Object:  StoredProcedure [dbo].[addBillDetail]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[addBillDetail]
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
/****** Object:  StoredProcedure [dbo].[changePwd]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[changePwd]
@newPwd CHAR(64),
@acc_user VARCHAR(50)
AS
BEGIN
	UPDATE dbo.Cf_Account
	SET account_pwd = @newPwd
	WHERE account_user = @acc_user
END
GO
/****** Object:  StoredProcedure [dbo].[createBillByTableNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createBillByTableNo]
@tableNo INT
AS
BEGIN
	INSERT INTO dbo.Cf_Bill (bill_checkintime, bill_checkouttime, bill_stt, table_no )
	VALUES ( GETDATE(), null, 0, @tableNo)  
END
GO
/****** Object:  StoredProcedure [dbo].[createDrink]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createDrink]
@name NVARCHAR(50),
@price INT
AS
BEGIN
    INSERT INTO dbo.Cf_Drink (drink_name, drink_price)
    VALUES (@name, @price)
END
GO
/****** Object:  StoredProcedure [dbo].[createEmployee]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[createEmployee]
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
/****** Object:  StoredProcedure [dbo].[deleteDrinkByNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteDrinkByNo]
@drinkNo INT
AS
BEGIN
    DELETE FROM dbo.Cf_Drink
	WHERE drink_no = @drinkNo
END
GO
/****** Object:  StoredProcedure [dbo].[deleteEmployeeByNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[deleteEmployeeByNo]
@empNo INT
AS
BEGIN
	IF (@empNo <> 1)
    DELETE FROM dbo.Cf_Employee
	WHERE employee_no = @empNo
END
GO
/****** Object:  StoredProcedure [dbo].[getAccType]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getAccType]
@acc_user VARCHAR(50)
AS
BEGIN
	SELECT dbo.Cf_Account.account_type
	FROM dbo.Cf_Account
	WHERE account_user = @acc_user
END
GO
/****** Object:  StoredProcedure [dbo].[getBillDetailListByBillNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getBillDetailListByBillNo]
@billNo INT
AS
BEGIN
	SELECT  bill_no, drink_name, drink_amount, drink_price, drink_amount*drink_price AS drink_total
	FROM dbo.Cf_BillDetail, dbo.Cf_Drink
	WHERE bill_no = @billNo AND Cf_BillDetail.drink_no = Cf_Drink.drink_no
END
GO
/****** Object:  StoredProcedure [dbo].[getDrinkInfoByNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDrinkInfoByNo]
@drinkNo INT
AS
BEGIN
    SELECT *
	FROM dbo.Cf_Drink
	WHERE drink_no = @drinkNo;
END
GO
/****** Object:  StoredProcedure [dbo].[getDrinkList]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getDrinkList]
AS
BEGIN
	SELECT drink_no, drink_name, drink_price
	FROM dbo.Cf_Drink
END
GO
/****** Object:  StoredProcedure [dbo].[getEmployee]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getEmployee]
AS
BEGIN
	SELECT cf_Employee.employee_no AS 'Mã NV',
			employee_name AS 'Họ tên',
			employee_dob AS 'Ngày sinh',
			employee_id AS 'CMND',
			employee_address AS 'Địa chỉ',
			account_user AS 'Tài khoản',
			account_type AS 'Loại TK'
	FROM dbo.Cf_Employee LEFT OUTER JOIN dbo.Cf_Account ON dbo.Cf_Employee.employee_no = dbo.Cf_Account.employee_no
END
GO
/****** Object:  StoredProcedure [dbo].[getEmployeeInfoByNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getEmployeeInfoByNo]
@empNo INT
AS
BEGIN
	SELECT Cf_Employee.employee_no, employee_name, employee_dob, employee_id, employee_address, account_user, account_type
	FROM dbo.Cf_Employee LEFT OUTER JOIN dbo.Cf_Account ON Cf_Employee.employee_no = Cf_Account.employee_no
	WHERE Cf_Employee.employee_no = @empNo
END
GO
/****** Object:  StoredProcedure [dbo].[getEmpName]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getEmpName]
@acc_user VARCHAR(50)
AS
BEGIN
    SELECT employee_name
	FROM cf_employee, dbo.Cf_Account
	WHERE cf_employee.employee_no = cf_account.employee_no and cf_account.account_user = @acc_user
END
GO
/****** Object:  StoredProcedure [dbo].[getPwd]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- Procedure
CREATE PROCEDURE [dbo].[getPwd]
@acc_user VARCHAR(50)
AS
BEGIN
    SELECT dbo.Cf_Account.account_pwd
	FROM dbo.Cf_Account
	WHERE dbo.Cf_Account.account_user = @acc_user
END
GO
/****** Object:  StoredProcedure [dbo].[getStatistic]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[getStatistic]
@type NVARCHAR(20),
@fromDate NVARCHAR(8),
@toDate NVARCHAR(8)
AS
BEGIN
	IF (@type = 'all')
		BEGIN
			SELECT bill_no AS 'Mã hóa đơn', bill_checkintime AS 'Thời gian vào', bill_checkouttime AS 'Thời gian ra', table_no AS 'Số bàn', bill_total AS 'Tổng hóa đơn'
			FROM dbo.Cf_Bill
			WHERE bill_stt = 1
		END;
	ELSE
		BEGIN
		    SELECT bill_no AS 'Mã hóa đơn', bill_checkintime AS 'Thời gian vào', bill_checkouttime AS 'Thời gian ra', table_no AS 'Số bàn', bill_total AS 'Tổng hóa đơn'
			FROM dbo.Cf_Bill
			WHERE bill_checkintime >= '20211002' AND bill_checkouttime <= DATEADD(DAY,1,@toDate) AND bill_stt = 1
		END;
END;
GO
/****** Object:  StoredProcedure [dbo].[getTableList]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getTableList]
AS
BEGIN
	SELECT *
	FROM dbo.Cf_Table
END
GO
/****** Object:  StoredProcedure [dbo].[getUncheckBillByTableNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[getUncheckBillByTableNo]
@tableNo INT
AS
BEGIN
	  SELECT *
	  FROM dbo.Cf_Bill
	  WHERE table_no = @tableNo AND bill_stt = 0
END
GO
/****** Object:  StoredProcedure [dbo].[payBill]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[payBill]
@billNo INT,
@total INT
AS
BEGIN
    UPDATE dbo.Cf_Bill
	SET bill_stt = 1,
		bill_checkouttime = GETDATE(),
		bill_total = @total
	WHERE bill_no = @billNo
END
GO
/****** Object:  StoredProcedure [dbo].[resetPwdByEmpNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[resetPwdByEmpNo]
@empNo INT,
@newPwd CHAR(64)
AS
BEGIN
	UPDATE dbo.Cf_Account
	SET account_pwd = @newPwd
	WHERE employee_no = @empNo
END
GO
/****** Object:  StoredProcedure [dbo].[switchTable]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[switchTable]
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
/****** Object:  StoredProcedure [dbo].[updateDrinkInfoByNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateDrinkInfoByNo]
@no INT,
@name NVARCHAR(50),
@price INT
AS
BEGIN
    UPDATE dbo.Cf_Drink
	SET drink_name = @name,
		drink_price = @price
	WHERE drink_no = @no
END
GO
/****** Object:  StoredProcedure [dbo].[updateEmpInfoByNo]    Script Date: 10/16/2021 23:21:59 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[updateEmpInfoByNo]
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
USE [master]
GO
ALTER DATABASE [QuanLyQuanCafe] SET  READ_WRITE 
GO
