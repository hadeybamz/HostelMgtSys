create database CrystalBeam
go
USE [CrystalBeam]
GO

/****** Object: Table [dbo].[staff_details] Script Date: 6/20/2017 8:42:14 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[staff_details] (
    [staff_id]        INT           IDENTITY (1, 1) NOT NULL,
    [first_name]      NVARCHAR (50) NULL,
    [last_name]       NVARCHAR (50) NULL,
    [other_name]      NVARCHAR (50) NULL,
    [phone_no]        NVARCHAR (50) NULL,
    [username]        NVARCHAR (50) NULL,
    [password]        NVARCHAR (50) NULL,
    [user_previledge] NVARCHAR (15) NULL,
    [date_time]       DATETIME      NULL
);
go
CREATE TABLE [dbo].[room_details] (
    [room_id]  INT           IDENTITY (100, 1) NOT NULL,
    [room_no]  NVARCHAR (3)  NULL,
    [category] NVARCHAR (50) NULL,
    [price]    NVARCHAR (10) NULL,
    [status]   BIT           NULL
);
go
CREATE TABLE [dbo].[student_details] (
    [student_id] INT           IDENTITY (1000, 1) NOT NULL,
    [first_name] NVARCHAR (50) NULL,
    [last_name]  NVARCHAR (50) NULL,
    [other_name] NVARCHAR (50) NULL,
    [nationalty] NVARCHAR (20) NULL,
    [phone_no]   NVARCHAR (20) NULL,
    [room_id]    INT           NULL,
    [room_no]    NVARCHAR (3)  NULL,
    [time_in]    DATE          NULL,
    [time_out]   DATE          NULL
);
go
CREATE TABLE [dbo].[visitor_details] (
    [visitor_id] INT            IDENTITY (1, 1) NOT NULL,
    [first_name] NVARCHAR (50)  NULL,
    [last_name]  NVARCHAR (50)  NULL,
    [other_name] NVARCHAR (50)  NULL,
    [address]    NVARCHAR (100) NULL,
    [phone_no]   NVARCHAR (15)  NULL,
    [student_id] INT            NULL,
    [room_id]    INT            NULL,
    [room_no]    NVARCHAR (3)   NULL,
    [time_in]    DATETIME       NULL,
    [time_out]   DATETIME       NULL
);


