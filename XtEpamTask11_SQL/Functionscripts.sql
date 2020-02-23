/****** Object:  StoredProcedure [dbo].[AddAward]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddAward]
	@Title NVARCHAR(50),
	@Id INT OUTPUT,
	
AS
BEGIN
	INSERT INTO awards (Title)
	Values(@Title)
	set @Id = SCOPE_IDENTITY();
END

/****** Object:  StoredProcedure [dbo].[AddUserAwarded]     ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddUserAwarded] 
	@Id INT OUTPUT,
	@Name NVARCHAR(50),
	@Birthday DATETIME
AS
BEGIN
	INSERT INTO UserAwarded (Name, Birthday)
	Values(@Name, @Birthday)
	set @Id = SCOPE_IDENTITY();
END
GO
/****** Object:  StoredProcedure [dbo].[EditAward]    ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[EditAward] 
	@Id INT,
	@Title NVARCHAR(50)
AS
BEGIN
	UPDATE awards SET Title = @Title WHERE Id = @Id
END
