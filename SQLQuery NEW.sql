USE [lochana ]
GO
/****** Object:  Schema [att]    Script Date: 08/05/2023 2:40:02 am ******/
CREATE SCHEMA [att]
GO
/****** Object:  Schema [sam]    Script Date: 08/05/2023 2:40:02 am ******/
CREATE SCHEMA [sam]
GO
/****** Object:  Schema [syst]    Script Date: 08/05/2023 2:40:02 am ******/
CREATE SCHEMA [syst]
GO
/****** Object:  UserDefinedFunction [dbo].[Varcharsplit]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create function [dbo].[Varcharsplit]
(
@param nvarchar(max), 
@delimiter char(1)
)
returns @t table (val nvarchar(max), seq int)
as
begin
set @param += @delimiter

;with a as
(
select cast(1 as bigint) f, charindex(@delimiter, @param) t, 1 seq
union all
select t + 1, charindex(@delimiter, @param, t + 1), seq + 1
from a
where charindex(@delimiter, @param, t + 1) > 0
)
insert @t
select substring(@param, f, t - f), seq from a
option (maxrecursion 0)
return
end
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Cus_id] [varchar](50) NOT NULL,
	[Cus_name] [varchar](50) NULL,
	[Cus_addresss] [varchar](50) NULL,
	[Cus_email] [varchar](50) NULL,
	[Cus_password] [varchar](50) NULL,
	[Cus_phonenumber] [varchar](50) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [sam].[Category]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [sam].[Category](
	[CategoryID] [varchar](50) NOT NULL,
	[CategoryName] [varchar](50) NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [sam].[Data]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [sam].[Data](
	[DataID] [varchar](50) NOT NULL,
	[CategoryID] [varchar](50) NULL,
	[DataName] [varchar](50) NOT NULL,
	[JoinedDate] [datetime] NULL,
	[DataCost] [money] NULL,
	[DataDescription] [varchar](max) NULL,
	[ActiveStatus] [varchar](50) NULL,
 CONSTRAINT [PK_Data] PRIMARY KEY CLUSTERED 
(
	[DataID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [sam].[V_Number_Temp]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [sam].[V_Number_Temp](
	[Id] [varchar](50) NOT NULL,
	[V_Number] [varchar](50) NULL,
	[In_Time] [datetime] NULL,
	[Out_Time] [datetime] NULL,
	[Status] [varchar](50) NULL,
	[Customer_ID] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [syst].[APIKey]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [syst].[APIKey](
	[KeyID] [varchar](50) NOT NULL,
	[KeyValue] [varchar](100) NULL,
	[KeyDetails] [varchar](100) NULL,
	[CreatedDate] [datetime] NULL,
	[ActiveStatus] [varchar](50) NULL,
 CONSTRAINT [PK__APIKey] PRIMARY KEY CLUSTERED 
(
	[KeyID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [syst].[NumberFormat]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [syst].[NumberFormat](
	[TableName] [varchar](50) NOT NULL,
	[Prefix] [varchar](50) NULL,
	[NumberPart] [bigint] NULL,
	[NumberLength] [int] NOT NULL,
 CONSTRAINT [PK_NumberConfiguration] PRIMARY KEY CLUSTERED 
(
	[TableName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [syst].[SystemUser]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [syst].[SystemUser](
	[UserID] [varchar](50) NOT NULL,
	[Username] [varchar](100) NULL,
	[Password] [varchar](100) NULL,
	[DisplayName] [varchar](100) NULL,
	[Emails] [varchar](100) NULL,
	[RoleMode] [varchar](50) NULL,
	[ActiveStatus] [varchar](50) NULL,
 CONSTRAINT [PK__User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([Cus_id], [Cus_name], [Cus_addresss], [Cus_email], [Cus_password], [Cus_phonenumber]) VALUES (N'CUS00004', N'Lochana rajapaksha', N'Watakeyawa
Gonawila', N'lochanarajapaksha25@gmail.com', N'123', N'0769104122')
GO
INSERT [dbo].[Customer] ([Cus_id], [Cus_name], [Cus_addresss], [Cus_email], [Cus_password], [Cus_phonenumber]) VALUES (N'CUS00005', N'Harshana Rajapaksha', N'Watakeyawa
Gonawila', N'harshanarajapaksha@gmail.com', N'1234', N'0701563245')
GO
INSERT [dbo].[Customer] ([Cus_id], [Cus_name], [Cus_addresss], [Cus_email], [Cus_password], [Cus_phonenumber]) VALUES (N'CUS00006', N'Hasiru Lankshan', N'Colombo Road, Negombo', N'hasirulakshan@gmail.com', N'12345', N'0716845215')
GO
INSERT [dbo].[Customer] ([Cus_id], [Cus_name], [Cus_addresss], [Cus_email], [Cus_password], [Cus_phonenumber]) VALUES (N'CUS00007', N'Hasitha Herath', N'Madawalaulpatha, Matale', N'hasithaherath@gmail.com', N'Hasi1234', N'0768256413')
GO
INSERT [dbo].[Customer] ([Cus_id], [Cus_name], [Cus_addresss], [Cus_email], [Cus_password], [Cus_phonenumber]) VALUES (N'CUS00008', N'Danushka Madusanka', N'Watakeyawa
Gonawila', N'danushkamadusanka@gmail.com', N'danu123', N'0778423654')
GO
INSERT [dbo].[Customer] ([Cus_id], [Cus_name], [Cus_addresss], [Cus_email], [Cus_password], [Cus_phonenumber]) VALUES (N'CUS00009', N'Kasun Vidanage', N'Colombo Road, Negombo', N'kasunvidanage@gmail.com', N'kasun12', N'0784652136')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00001', N'Sample 1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00002', N'Samplere 1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00003', N'Sample rer1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00004', N'Sample refds1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00006', N'Sample 1ew')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00007', N'Sample ewsd1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00008', N'Manuals')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00009', N'Sample fd1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00010', N'Supervisor')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00012', N'Sample sa')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00013', N'Sample sad')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00014', N'Jewellery')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00015', N'Sample 43 3 ')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00016', N'Sample32 ')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00017', N'Samplere3 3 1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00018', N'Sample 32rer1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00019', N'Samplerewe 1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00020', N'Solutions')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00021', N'Sample fewd1')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00022', N'pavilion')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00023', N'Sample safd')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00024', N'Suspensions')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00025', N'Sample 4vb3 3 ')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00026', N'Sample32bv ')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00027', N'Lotions')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00028', N'Tablets')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00029', N'234234')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00030', N'Solid Items')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00031', N'World-wide')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00032', N'wdf')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00033', N'sfsfsfsf')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00034', N'sdfs')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00035', N'lochana')
GO
INSERT [sam].[Category] ([CategoryID], [CategoryName]) VALUES (N'SCAT00036', N'xddxxc')
GO
INSERT [sam].[Data] ([DataID], [CategoryID], [DataName], [JoinedDate], [DataCost], [DataDescription], [ActiveStatus]) VALUES (N'SDAT00001', N'SCAT00029', N'sdfsd', CAST(N'2023-04-01T00:00:00.000' AS DateTime), 12.0000, N'xdfsdf', N'A')
GO
INSERT [sam].[Data] ([DataID], [CategoryID], [DataName], [JoinedDate], [DataCost], [DataDescription], [ActiveStatus]) VALUES (N'SDAT00002', N'SCAT00027', N'Decimal Tuneup', CAST(N'2021-05-19T00:00:00.000' AS DateTime), 456.0000, N'Docmented Data', N'A')
GO
INSERT [sam].[Data] ([DataID], [CategoryID], [DataName], [JoinedDate], [DataCost], [DataDescription], [ActiveStatus]) VALUES (N'SDAT00005', N'SCAT00029', N'Data Section 007', CAST(N'2021-06-03T00:00:00.000' AS DateTime), 235.0000, N'', N'A')
GO
INSERT [sam].[Data] ([DataID], [CategoryID], [DataName], [JoinedDate], [DataCost], [DataDescription], [ActiveStatus]) VALUES (N'SDAT00006', N'SCAT00029', N'sdsd', CAST(N'2021-12-02T00:00:00.000' AS DateTime), 113.0000, N'', N'A')
GO
INSERT [sam].[Data] ([DataID], [CategoryID], [DataName], [JoinedDate], [DataCost], [DataDescription], [ActiveStatus]) VALUES (N'SDAT00007', N'SCAT00029', N'sdfsfsf', CAST(N'2022-02-03T00:00:00.000' AS DateTime), 2342.0000, N'', N'A')
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00001', N'34324', CAST(N'2023-04-04T00:00:00.000' AS DateTime), CAST(N'2023-04-10T00:00:00.000' AS DateTime), N'P', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00002', N'AB-2342', CAST(N'2023-03-30T00:38:00.000' AS DateTime), CAST(N'2023-04-03T01:39:00.000' AS DateTime), N'C', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00003', N'UY-4736', CAST(N'2023-05-01T15:00:00.000' AS DateTime), CAST(N'2023-01-05T20:00:00.000' AS DateTime), N'SA', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00004', N'ME-8804', CAST(N'2023-05-10T00:00:00.000' AS DateTime), CAST(N'2023-05-12T00:00:00.000' AS DateTime), N'C', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00005', N'BB-2345', CAST(N'2023-06-07T01:00:00.000' AS DateTime), CAST(N'2023-06-15T00:00:00.000' AS DateTime), N'SA', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00006', N'123', CAST(N'2023-05-07T00:00:00.000' AS DateTime), CAST(N'2023-05-07T00:00:00.000' AS DateTime), N'P', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00007', N'1111', CAST(N'2023-05-13T00:00:00.000' AS DateTime), CAST(N'2023-01-01T09:00:00.000' AS DateTime), N'P', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT00008', N'234323423', CAST(N'2023-05-10T00:00:00.000' AS DateTime), CAST(N'2023-01-01T09:00:00.000' AS DateTime), N'P', NULL)
GO
INSERT [sam].[V_Number_Temp] ([Id], [V_Number], [In_Time], [Out_Time], [Status], [Customer_ID]) VALUES (N'VNT0002', N'AB-23123', CAST(N'2023-03-30T00:38:00.000' AS DateTime), CAST(N'2023-04-03T01:39:00.000' AS DateTime), N'SNA', NULL)
GO
INSERT [syst].[APIKey] ([KeyID], [KeyValue], [KeyDetails], [CreatedDate], [ActiveStatus]) VALUES (N'0000', N'1032', N'Default App', CAST(N'1900-01-01T00:00:00.000' AS DateTime), N'A')
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'dbo.Customer', N'CUS', 9, 5)
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'sam.Category', N'SCAT', 36, 5)
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'sam.Data', N'SDAT', 1, 5)
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'sam.V_Number_Temp', N'VNT', 8, 5)
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'syst.APIKey', N'APIK', 0, 5)
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'syst.SystemUser', N'USR', 0, 5)
GO
INSERT [syst].[NumberFormat] ([TableName], [Prefix], [NumberPart], [NumberLength]) VALUES (N'syst.TaxTable', N'TAX', 0, 3)
GO
INSERT [syst].[SystemUser] ([UserID], [Username], [Password], [DisplayName], [Emails], [RoleMode], [ActiveStatus]) VALUES (N'0000', N'Admin', N'TBai1sKZ/7lujXMRFF58Cw==', N'Administrator User', N'mail@exesmart.com', N'R', N'A')
GO
ALTER TABLE [syst].[NumberFormat] ADD  CONSTRAINT [DF_NumberConfiguration_Length]  DEFAULT ((0)) FOR [NumberLength]
GO
/****** Object:  StoredProcedure [dbo].[Customer_AddEdit]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    Procedure [dbo].[Customer_AddEdit]
(
	@APIKey	varchar(100),
				   
	@Cus_id	   VARCHAR(50),
	@Cus_name  varchar(50),
	@Cus_addresss varchar(50), 
	@Cus_email  varchar(50),
	@Cus_password   varchar(50),
	@Cus_phonenumber   varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		IF @Cus_id = ''
		BEGIN
			IF EXISTS(select Cus_id from dbo.Customer where Cus_name = @Cus_name)
			BEGIN
				;THROW 50000, 'Customer name already exists', 1;
			END

			-- Get next primary key
			DECLARE @PrimaryKey Varchar(50)
			exec syst.NumberFormat_Get 'dbo.Customer','Cus_id', @PrimaryKey OUT 

			INSERT INTO dbo.Customer (Cus_id, Cus_name,Cus_addresss, Cus_email,Cus_password,Cus_phonenumber)
				values (@PrimaryKey, @Cus_name, @Cus_addresss,@Cus_email, @Cus_password, @Cus_phonenumber)

			exec syst.NumberFormat_Set 'dbo.Customer'

			SET @RetValue = @PrimaryKey

		END
		ELSE
		BEGIN
			IF EXISTS(select Cus_id from dbo.Customer where Cus_name = @Cus_name AND Cus_id <> @Cus_id)
			BEGIN
				;THROW 50000, 'Customer name already exists', 1;
			END

			SET @RetValue = @Cus_id

			update dbo.Customer SET 
					Cus_name =@Cus_name,
					Cus_addresss = @Cus_addresss, 
					Cus_email = @Cus_email,
					Cus_password = @Cus_password,
					Cus_phonenumber = @Cus_phonenumber
			WHERE Cus_id = @Cus_id

		END
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "Customer_AddEdit"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [dbo].[Customer_Count]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [dbo].[Customer_Count]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = ''
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END


		select 	COUNT(*) as RecordCount
		
		from dbo.Customer 

		where Cus_name LIKE '%' + @KeyW + '%'
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Customer_Count"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [dbo].[Customer_Delete]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    Procedure [dbo].[Customer_Delete]
(
	@APIKey	varchar(100),
	@ID varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Check for record
		IF NOT EXISTS (select Cus_id from dbo.Customer WHERE Cus_id = @ID)
		BEGIN
			;THROW 50000, 'Record not found', 1;
		END


		
		SET @RetValue = @ID
		delete from dbo.Customer WHERE Cus_id = @ID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "Customer_Delete"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [dbo].[Customer_Get]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [dbo].[Customer_Get]
(
	@APIKey	varchar(100),
	@ID varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		select Cus_id, Cus_name,

			(select COUNT(*) from sam.Data WHERE Cus_id = dbo.Customer.Cus_id) as 'DataCount'
		
		from dbo.Customer 

		where Cus_id = @ID
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Customer_Get"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [dbo].[Customer_List]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    Procedure [dbo].[Customer_List]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = '',

	@Page int = 0,
	@PageSize int = 99999
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Set default value page and page size
		IF @Page = 0 
		BEGIN
			SET @PageSize = 99999
			SET @Page = 1
		END


		select Cus_id, Cus_name, 
       [Cus_addresss]
      ,[Cus_email]
      ,[Cus_password]
      ,[Cus_phonenumber]
		from dbo.Customer 

		where Cus_name LIKE '%' + @KeyW + '%'

		ORDER BY Cus_name

		OFFSET (@PageSize*(@Page-1)) ROWS FETCH NEXT @PageSize ROWS ONLY;
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Customer_List"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [dbo].[Customer_Login]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [dbo].[Customer_Login]
(
	@APIKey	varchar(100),
	@Cus_email varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

			select Cus_id, Cus_name, 
       [Cus_addresss]
      ,[Cus_email]
      ,[Cus_password]
      ,[Cus_phonenumber]
		from dbo.Customer 


		where [Cus_email] = @Cus_email
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "User_Login"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Category_AddEdit]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Category_AddEdit]
(
	@APIKey	varchar(100),
				   
	@CategoryID	   varchar(50),
	@CategoryName  varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		IF @CategoryID = ''
		BEGIN
			IF EXISTS(select CategoryID from sam.Category where CategoryName = @CategoryName)
			BEGIN
				;THROW 50000, 'Category name already exists', 1;
			END

			-- Get next primary key
			DECLARE @PrimaryKey Varchar(50)
			exec syst.NumberFormat_Get 'sam.Category','CategoryID', @PrimaryKey OUT 

			INSERT INTO sam.Category (CategoryID, CategoryName)
				values (@PrimaryKey, @CategoryName)

			exec syst.NumberFormat_Set 'sam.Category'

			SET @RetValue = @PrimaryKey

		END
		ELSE
		BEGIN
			IF EXISTS(select CategoryID from sam.Category where CategoryName = @CategoryName AND CategoryID <> @CategoryID)
			BEGIN
				;THROW 50000, 'Category name already exists', 1;
			END

			SET @RetValue = @CategoryID

			update sam.Category SET 
				CategoryName = @CategoryName
			WHERE CategoryID = @CategoryID

		END
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "Category_AddEdit"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Category_Count]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Category_Count]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = ''
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END


		select 	COUNT(*) as RecordCount
		
		from sam.Category 

		where CategoryName LIKE '%' + @KeyW + '%'
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Category_Count"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Category_Delete]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Category_Delete]
(
	@APIKey	varchar(100),
	@ID varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Check for record
		IF NOT EXISTS (select CategoryID from sam.Category WHERE CategoryID = @ID)
		BEGIN
			;THROW 50000, 'Record not found', 1;
		END

		IF EXISTS(select DataID from sam.Data where CategoryID = @ID)
		BEGIN
			;THROW 50000, 'Data exist under this record', 1;
		END
		
		SET @RetValue = @ID
		delete from sam.Category WHERE CategoryID = @ID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "Category_Delete"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Category_Get]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Category_Get]
(
	@APIKey	varchar(100),
	@ID varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		select CategoryID, CategoryName,

			(select COUNT(*) from sam.Data WHERE CategoryID = sam.Category.CategoryID) as 'DataCount'
		
		from sam.Category 

		where CategoryID = @ID
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Category_Get"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Category_List]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Category_List]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = '',

	@Page int = 0,
	@PageSize int = 99999
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Set default value page and page size
		IF @Page = 0 
		BEGIN
			SET @PageSize = 99999
			SET @Page = 1
		END


		select CategoryID, CategoryName,

			(select COUNT(*) from sam.Data WHERE CategoryID = sam.Category.CategoryID) as 'DataCount'
		
		from sam.Category 

		where CategoryName LIKE '%' + @KeyW + '%'

		ORDER BY CategoryName

		OFFSET (@PageSize*(@Page-1)) ROWS FETCH NEXT @PageSize ROWS ONLY;
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Category_List"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Data_AddEdit]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Data_AddEdit]
(
	@APIKey	varchar(100),
				   
	@DataID			 varchar(50),
	@CategoryID		 varchar(50),
	@DataName		 varchar(50),
	@JoinedDate		 Datetime,
	@DataCost		 money,
	@DataDescription varchar(MAX) = '',
	@ActiveStatus	 varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		IF @DataID = ''
		BEGIN
			IF EXISTS(select CategoryID from sam.Data where DataName = @DataName)
			BEGIN
				;THROW 50000, 'Data name already exists', 1;
			END

			-- Get next primary key
			DECLARE @PrimaryKey Varchar(50)
			exec syst.NumberFormat_Get 'sam.Data','DataID', @PrimaryKey OUT 

			INSERT INTO sam.Data(DataID, CategoryID, DataName, JoinedDate, DataCost, DataDescription, ActiveStatus)
				values (@PrimaryKey, @CategoryID, @DataName, @JoinedDate, @DataCost, @DataDescription, @ActiveStatus)

			exec syst.NumberFormat_Set 'sam.Data'

			SET @RetValue = @PrimaryKey

		END
		ELSE
		BEGIN
			IF EXISTS(select CategoryID from sam.Data where DataName = @DataName AND DataID <> @DataID)
			BEGIN
				;THROW 50000, 'Data name already exists', 1;
			END

			SET @RetValue = @CategoryID

			update sam.Data SET 
				DataName = @DataName, 
				JoinedDate = @JoinedDate, 
				DataCost = @DataCost, 
				DataDescription = @DataDescription, 
				ActiveStatus = @ActiveStatus
			WHERE DataID = @DataID

		END
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "Data_AddEdit"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Data_Count]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Data_Count]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = '',
	@CategoryID	varchar(50) = '',
	@ActiveStatus varchar(50) = ''
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END


		select 	COUNT(*) as RecordCount
		
		from sam.Data
		INNER JOIN sam.Category ON sam.Category.CategoryID = sam.Data.CategoryID

		where DataName + ' ' + DataDescription LIKE '%' + @KeyW + '%'

		AND 
		CASE WHEN @CategoryID = '' THEN 1
			 WHEN @CategoryID <> '' AND sam.Data.CategoryID = @CategoryID THEN 1
		END = 1

		AND 
		CASE WHEN @ActiveStatus = '' THEN 1
			 WHEN @ActiveStatus <> '' AND sam.Data.ActiveStatus = @ActiveStatus THEN 1
		END = 1
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Data_Count"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Data_Delete]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Data_Delete]
(
	@APIKey	varchar(100),
	@ID varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Check for record
		IF NOT EXISTS (select DataID from sam.Data WHERE DataID = @ID)
		BEGIN
			;THROW 50000, 'Record not found', 1;
		END

		
		SET @RetValue = @ID
		delete from sam.Data WHERE DataID = @ID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "Data_Delete"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Data_Get]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Data_Get]
(
	@APIKey	varchar(100),
	@ID varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		select DataID, sam.Data.CategoryID, DataName, JoinedDate, DataCost, DataDescription, ActiveStatus,

			sam.Category.CategoryName as 'CategoryName'
		
		from sam.Data
		INNER JOIN sam.Category ON sam.Category.CategoryID = sam.Data.CategoryID

		where DataID = @ID
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Data_Get"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[Data_List]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[Data_List]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = '',
	@CategoryID	varchar(50) = '',
	@ActiveStatus varchar(50) = '',

	@Page int = 0,
	@PageSize int = 99999
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Set default value page and page size
		IF @Page = 0 
		BEGIN
			SET @PageSize = 99999
			SET @Page = 1
		END


		select DataID, sam.Data.CategoryID, DataName, JoinedDate, DataCost, DataDescription, ActiveStatus,

			sam.Category.CategoryName as 'CategoryName'
		
		from sam.Data
		INNER JOIN sam.Category ON sam.Category.CategoryID = sam.Data.CategoryID

		where DataName + ' ' + DataDescription LIKE '%' + @KeyW + '%'

		AND 
		CASE WHEN @CategoryID = '' THEN 1
			 WHEN @CategoryID <> '' AND sam.Data.CategoryID = @CategoryID THEN 1
		END = 1

		AND 
		CASE WHEN @ActiveStatus = '' THEN 1
			 WHEN @ActiveStatus <> '' AND sam.Data.ActiveStatus = @ActiveStatus THEN 1
		END = 1

		ORDER BY DataName

		OFFSET (@PageSize*(@Page-1)) ROWS FETCH NEXT @PageSize ROWS ONLY;
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Data_List"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[V_Number_Temp_AddEdit]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[V_Number_Temp_AddEdit]
(
	@APIKey	varchar(100),
				   
	@Id	   varchar(50),
	@V_Number  varchar(50),
	@In_Time datetime,
	@Out_Time datetime,
	@Status varchar(50),
	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		IF @Id = ''
		BEGIN
			IF EXISTS(select Id from sam.V_Number_Temp where V_Number = @V_Number)
			BEGIN
				;THROW 50000, 'Vehicle Number already exists', 1;
			END

			-- Get next primary key
			DECLARE @PrimaryKey Varchar(50)
			exec syst.NumberFormat_Get 'sam.V_Number_Temp','Id', @PrimaryKey OUT 

			INSERT INTO sam.V_Number_Temp (Id, V_Number,In_Time,Out_Time,Status)
				values (@PrimaryKey, @V_Number,@In_Time,@Out_Time,@Status)

			exec syst.NumberFormat_Set 'sam.V_Number_Temp'

			SET @RetValue = @PrimaryKey

		END
		ELSE
		BEGIN
			IF EXISTS(select Id from sam.V_Number_Temp where V_Number = @V_Number AND Id <> @Id)
			BEGIN
				;THROW 50000, 'Vehicle Numbe already exists', 1;
			END

			SET @RetValue = @Id

			update sam.V_Number_Temp SET 
				V_Number = @V_Number ,
				In_Time = @In_Time
				,Out_Time = @Out_Time,
				Status = @Status
			WHERE	Id = @Id

		END
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "V_Number_Temp_AddEdit"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[V_Number_Temp_Count]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [sam].[V_Number_Temp_Count]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = ''
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END


		select 	COUNT(*) as RecordCount
		
		from sam.V_Number_Temp 

		where V_Number LIKE '%' + @KeyW + '%'
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "Category_Count"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[V_Number_Temp_Delete]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    Procedure [sam].[V_Number_Temp_Delete]
(
	@APIKey	varchar(100),
	@Id varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		
		SET @RetValue = @ID
		delete from sam.V_Number_Temp WHERE Id = @Id

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "V_Number_Temp_Delete"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[V_Number_Temp_Get]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE    Procedure [sam].[V_Number_Temp_Get]
(
	@APIKey	varchar(100),
	@Id varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		select Id, V_Number, In_Time, Out_Time, Status
		
		from sam.V_Number_Temp 

		where Id = @Id
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "V_Number_Temp_Get"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [sam].[V_Number_Temp_List]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
cREATE    Procedure [sam].[V_Number_Temp_List]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = '',

	@Page int = 0,
	@PageSize int = 99999
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Set default value page and page size
		IF @Page = 0 
		BEGIN
			SET @PageSize = 99999
			SET @Page = 1
		END


		select Id, V_Number, In_Time, Out_Time, Status
		
		from sam.V_Number_Temp

		where V_Number LIKE '%' + @KeyW + '%'

		ORDER BY V_Number

		OFFSET (@PageSize*(@Page-1)) ROWS FETCH NEXT @PageSize ROWS ONLY;
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "V_Number_Temp_List"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[NumberFormat_Get]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[NumberFormat_Get]
(
	@TableName varchar(50),
	@KeyColumn varchar(50),

	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		DECLARE @PrimaryKey varchar(50), @Prefix varchar(50), @NumberPart BIGINT, @NumberLength int
		DECLARE @DynamicSQL nvarchar(4000), @RecordCount int 

		SELECT @Prefix = Prefix, @NumberPart = NumberPart, @NumberLength = NumberLength from syst.NumberFormat
			WHERE TableName = @TableName

		IF @Prefix IS NULL
			BEGIN
				;THROW 50000, 'Invalid table name provided', 1;
			END
		
		CalculateKey:
		SET @NumberPart += 1
		SET @PrimaryKey = @Prefix + FORMAT(@NumberPart, REPLICATE('0',@NumberLength))

		SET @DynamicSQL = 'Select @Result = COUNT(*) from ' + @TableName + ' WHERE ' + @KeyColumn + ' = ''' + @PrimaryKey + ''''
		Exec sp_executesql @DynamicSQL, N'@Result int out', @RecordCount out

		IF @RecordCount > 0
		BEGIN
			UPDATE syst.NumberFormat SET NumberPart = @NumberPart WHERE TableName = @TableName
			GOTO CalculateKey
		END
		
		SET @RetValue = @PrimaryKey
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        ROLLBACK TRANSACTION
		RAISERROR ('%s (NumberFormat_Get)', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[NumberFormat_Set]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[NumberFormat_Set]
(
	@TableName varchar(50)
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		UPDATE syst.NumberFormat SET NumberPart = NumberPart + 1 WHERE TableName = @TableName
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        ROLLBACK TRANSACTION
		RAISERROR ('%s (NumberFormat_Set)', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_AddEdit]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create    Procedure [syst].[User_AddEdit]
(
	@APIKey	varchar(100),

	@UserID	varchar(50),		   
	@Username	varchar(50),
	@Password  varchar(50),

	@DisplayName	varchar(50),		   
	@Emails	varchar(50),
	@RoleMode	varchar(50),
	@ActiveStatus varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		IF @UserID = ''
		BEGIN
			IF EXISTS(select UserID from syst.SystemUser where Username = @Username)
			BEGIN
				;THROW 50000, 'Username already exists', 1;
			END

			-- Get next primary key
			DECLARE @PrimaryKey Varchar(50)
			exec syst.NumberFormat_Get 'syst.SystemUser','UserID', @PrimaryKey OUT 

			INSERT INTO syst.SystemUser (UserID, Username,Password,DisplayName,Emails,RoleMode,ActiveStatus)
				values (@PrimaryKey, @Username,@Password,@DisplayName,@Emails,@RoleMode,@ActiveStatus)

			exec syst.NumberFormat_Set 'syst.SystemUser'

			SET @RetValue = @PrimaryKey

		END
		ELSE
		BEGIN
			IF EXISTS(select UserID from syst.SystemUser where Username = @Username AND UserID <> @UserID)
			BEGIN
				;THROW 50000, 'Username already exists', 1;
			END

			SET @RetValue = @UserID

			update syst.SystemUser SET 
				Username = @Username,
			
				DisplayName = @DisplayName,
				Emails=@Emails,
				RoleMode = @RoleMode,
				ActiveStatus = @ActiveStatus
			WHERE UserID = @UserID

			IF @Password <> ''
			BEGIN

				update syst.SystemUser SET 
					Password = @Password
				WHERE UserID = @UserID

			END

		END
		
		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "SystemUser_AddEdit"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_Count]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[User_Count]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = ''
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END


		select 	COUNT(*) as RecordCount
		
		from syst.SystemUser 

		where Username LIKE '%' + @KeyW + '%'
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "User_Count"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_Delete]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[User_Delete]
(
	@APIKey	varchar(100),
	@ID varchar(50),

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		Declare @UserID varchar(50) ;
		SET @UserID = @ID
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Check for record
		IF NOT EXISTS (select UserID from syst.SystemUser WHERE UserID = @ID)
		BEGIN
			;THROW 50000, 'Record not found', 1;
		END

		IF (@UserID = '0000')
		BEGIN
			;THROW 50000, 'You cannot delete main administrator', 1;
		END
		
		
		SET @RetValue = @ID
		delete from syst.SystemUser WHERE UserID = @ID

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "User_Delete"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_EditPassword]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create    Procedure [syst].[User_EditPassword]
(
	@APIKey	varchar(100),

	@UserID	varchar(50),		   
	@Password  varchar(50),

	

	@LogUserID varchar(50) = '',
	@RetValue varchar(50) = '' OUT
)	
As
Begin
	SET NOCOUNT ON

	BEGIN TRY
		BEGIN TRANSACTION

		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

			
		IF @UserID <> ''
			BEGIN
			SET @RetValue = @UserID
				update syst.SystemUser SET 
					Password = @Password

				WHERE UserID = @UserID
			END
		

		COMMIT TRANSACTION
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
        IF @@TRANCOUNT > 0 ROLLBACK TRANSACTION;
        RAISERROR ('%s in "User_EditPassword"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_Get]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[User_Get]
(
	@APIKey	varchar(100),
	@ID varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		select UserID, Username, Password, DisplayName,Emails, RoleMode, ActiveStatus
		
		from syst.SystemUser

		where UserID = @ID
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "User_Get"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_List]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[User_List]
(
	@APIKey	varchar(100),
				   
	@KeyW varchar(50) = '',

	@Page int = 0,
	@PageSize int = 99999
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		-- Set default value page and page size
		IF @Page = 0 
		BEGIN
			SET @PageSize = 99999
			SET @Page = 1
		END


		select  UserID, Username, Password, DisplayName,Emails, RoleMode, ActiveStatus
		from syst.SystemUser 

		where Username LIKE '%' + @KeyW + '%'

		ORDER BY Username

		OFFSET (@PageSize*(@Page-1)) ROWS FETCH NEXT @PageSize ROWS ONLY;
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "User_List"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
/****** Object:  StoredProcedure [syst].[User_Login]    Script Date: 08/05/2023 2:40:02 am ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
Create    Procedure [syst].[User_Login]
(
	@APIKey	varchar(100),
	@Username varchar(50)
)	
As
Begin
	SET NOCOUNT ON
	BEGIN TRY
		
		-- Check for API Key
		IF NOT EXISTS (select KeyID from syst.APIKey WHERE KeyValue = @APIKey AND ActiveStatus = 'A')
		BEGIN
			;THROW 50000, 'Invalid API Key', 1;
		END

		select UserID, Username, Password, DisplayName,Emails, RoleMode, ActiveStatus
		
		from syst.SystemUser

		where Username = @Username
		
	END TRY
	BEGIN CATCH
        DECLARE @ERROR_MESSAGE varchar(4000)= ERROR_MESSAGE();
		RAISERROR ('%s in "User_Login"', 16, 1, @ERROR_MESSAGE);
	END CATCH

End
GO
