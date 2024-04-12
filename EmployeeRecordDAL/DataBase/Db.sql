USE [master]
GO

CREATE DATABASE [EmployeeRecord]
GO

USE [EmployeeRecord]
GO



CREATE FUNCTION [dbo].[ufnGetPhoneFormat] (
    @Phone NVARCHAR(20)
)
RETURNS NVARCHAR(20)
AS
BEGIN
    DECLARE @Result NVARCHAR(20);
    SET @Result = CONCAT('(', SUBSTRING(@Phone,0,4), ') ', SUBSTRING(@Phone,4,3),'-',SUBSTRING(@Phone,7,4))
    RETURN @Result;
END;
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 4/12/2024 7:33:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employee](
	[EmployeeId] [int] IDENTITY(1,1) NOT NULL,
	[EmployeeLastName] [varchar](150) NOT NULL,
	[EmployeeFirstName] [varchar](150) NOT NULL,
	[EmployeePhone] [varchar](14) NOT NULL,
	[EmployeeZip] [int] NOT NULL,
	[HireDate] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Employee] ON 

INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (21, N'Johnson', N'Emily', N'5551234567', 90210, CAST(N'2022-07-15' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (22, N'Smith', N'Michael', N'5559876543', 10001, CAST(N'2023-04-25' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (23, N'Brown', N'Jessica', N'5552345678', 30303, CAST(N'2024-01-10' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (24, N'Davis', N'Christopher', N'5558765432', 60606, CAST(N'2022-11-18' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (25, N'Miller', N'Matthew', N'5553456789', 85001, CAST(N'2023-09-02' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (26, N'Wilson', N'Samantha', N'5557654321', 90210, CAST(N'2024-03-15' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (27, N'Anderson', N'David', N'5554325678', 30303, CAST(N'2022-12-20' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (28, N'Martinez', N'Ashley', N'5556547890', 10001, CAST(N'2023-07-05' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (29, N'Taylor', N'Kevin', N'5558765432', 60606, CAST(N'2024-02-18' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (30, N'Hernandez', N'Amanda', N'5559876543', 85001, CAST(N'2022-08-22' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (31, N'Moore', N'Andrew', N'5553456789', 90210, CAST(N'2023-05-01' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (32, N'Jackson', N'Sarah', N'5552345678', 30303, CAST(N'2024-01-14' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (33, N'White', N'Justin', N'5556547890', 10001, CAST(N'2022-10-01' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (34, N'Thomas', N'Elizabeth', N'5558765432', 60606, CAST(N'2023-06-07' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (35, N'Garcia', N'Joshua', N'5559876543', 85001, CAST(N'2024-04-20' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (36, N'Lopez', N'Nicole', N'5551234567', 90210, CAST(N'2022-09-08' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (37, N'Rodriguez', N'Ryan', N'5552345678', 30303, CAST(N'2023-03-12' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (38, N'Williams', N'Kimberly', N'5556547890', 10001, CAST(N'2024-08-17' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (39, N'Gonzalez', N'Daniel', N'5558765432', 60606, CAST(N'2022-06-21' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (40, N'Harris', N'Lauren', N'5553456789', 85001, CAST(N'2023-11-29' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (41, N'Jorsh', N'Emily', N'5551234567', 90210, CAST(N'2024-04-11' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (42, N'Johnson', N'Emily', N'5551234567', 90210, CAST(N'2024-04-14' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (43, N'Mario', N'Emily', N'5551234567', 90210, CAST(N'2023-09-09' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (44, N'Johnson', N'Emily', N'5551234567', 90210, CAST(N'2024-05-12' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (45, N'Emily', N'Ortiz', N'50589611536', 876, CAST(N'2023-10-05' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (46, N'Jonh', N'Ortiz', N'50589611536', 876, CAST(N'2024-05-12' AS Date))
INSERT [dbo].[Employee] ([EmployeeId], [EmployeeLastName], [EmployeeFirstName], [EmployeePhone], [EmployeeZip], [HireDate]) VALUES (47, N'Yenny', N'Chavez', N'1238991223', 133, CAST(N'2023-10-13' AS Date))
SET IDENTITY_INSERT [dbo].[Employee] OFF
GO
/****** Object:  StoredProcedure [dbo].[uspCreateEmployee]    Script Date: 4/12/2024 7:33:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROC [dbo].[uspCreateEmployee]
 (
	@EmployeeLastName VARCHAR(150),
	@EmployeeFirstName VARCHAR(150),
	@EmployeePhone VARCHAR(8),
	@EmployeePhoneCode VARCHAR(3),
	@EmployeeZip INT,
	@HireDate varchar(10)	
 )AS 
 
BEGIN TRY
	-- Inserting data
	 INSERT INTO Employee(EmployeeLastName, EmployeeFirstName, EmployeePhone, EmployeeZip, HireDate) 
	 VALUES(@EmployeeLastName, @EmployeeFirstName, concat(@EmployeePhoneCode, @EmployeePhone), @EmployeeZip, CAST(@HireDate as date))
	-- Hadling method statu
    Select '' MethodMessage,
	CAST(1 AS BIT) MethodStatu
END TRY

BEGIN CATCH
    -- Error handling code goes here
    Select 'An error occurred: ' + ERROR_MESSAGE() MethodMessage,
	CAST(0 AS BIT) MethodStatu
END CATCH;
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployee]    Script Date: 4/12/2024 7:33:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROC [dbo].[uspGetEmployee] 
 (
	@EmployeeId INT
 )AS 

SELECT 
EmployeeId,
EmployeeLastName,
EmployeeFirstName, 
SUBSTRING(EmployeePhone,4,8) EmployeePhone,
SUBSTRING(EmployeePhone,0,4) EmployeePhoneCode,
EmployeeZip, 
FORMAT(HireDate, 'yyyy-MM-dd')HireDate
FROM Employee

WHERE EmployeeId = @EmployeeId
 
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployeeCustomSearch]    Script Date: 4/12/2024 7:33:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROC [dbo].[uspGetEmployeeCustomSearch]
 (
	@EmployeeLastName VARCHAR(150),
	@EmployeePhone VARCHAR(150),
	@Option BIT
 )AS 

	SELECT 
	EmployeeId,
	EmployeeLastName,
	EmployeeFirstName, 
	dbo.ufnGetPhoneFormat(EmployeePhone) EmployeePhone, 
	EmployeeZip, 
	FORMAT(HireDate, 'dd/MM/yyyy')HireDate 

	FROM Employee

	WHERE EmployeeLastName = CASE WHEN @Option = 1 THEN @EmployeeLastName ELSE EmployeeLastName END 
	AND EmployeePhone = CASE WHEN @Option = 0 THEN @EmployeePhone ELSE EmployeePhone END 
GO
/****** Object:  StoredProcedure [dbo].[uspGetEmployeeList]    Script Date: 4/12/2024 7:33:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


 CREATE PROC [dbo].[uspGetEmployeeList]
 AS 

SELECT 
EmployeeId,
EmployeeLastName,
EmployeeFirstName, 
dbo.ufnGetPhoneFormat(EmployeePhone) EmployeePhone, 
EmployeeZip, 
FORMAT(HireDate, 'dd/MM/yyyy')HireDate 

FROM Employee

GO
/****** Object:  StoredProcedure [dbo].[uspUpdateEmployee]    Script Date: 4/12/2024 7:33:24 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

 CREATE PROC [dbo].[uspUpdateEmployee]
 (
	@EmployeeId INT,
	@EmployeeLastName VARCHAR(150),
	@EmployeeFirstName VARCHAR(150),
	@EmployeePhone VARCHAR(8),
	@EmployeePhoneCode VARCHAR(3),
	@EmployeeZip INT,
	@HireDate varchar(10)		
 )AS 

 BEGIN TRY
	-- Updating data
	UPDATE Employee

	 SET EmployeeLastName = @EmployeeLastName,
		 EmployeeFirstName = @EmployeeFirstName, 
		 EmployeePhone = @EmployeePhoneCode + @EmployeePhone, 
		 EmployeeZip = @EmployeeZip, 
		 HireDate = CAST(@HireDate AS DATE) 

	 WHERE EmployeeId = @EmployeeId
	-- Hadling method statu
	Select '' MethodMessage,
	CAST(1 AS BIT) MethodStatu
END TRY

BEGIN CATCH
    -- Error handling code goes here
    Select 'An error occurred: ' + ERROR_MESSAGE() MethodMessage,
	CAST(0 AS BIT) MethodStatu
END CATCH;


 
GO
USE [master]
GO
ALTER DATABASE [EmployeeRecord] SET  READ_WRITE 
GO
