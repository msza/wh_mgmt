USE [wh_mgmt_db]
GO
/****** Object:  Table [dbo].[trh_mstr]    Script Date: 13.05.2021 15:33:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[trh_mstr](
	[trh_id] [int] IDENTITY(1,1) NOT NULL,
	[trh_whdm_id] [int] NOT NULL,
	[trh_eff_date] [datetime2](7) NOT NULL,
	[trh_tr_type] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_trh_mstr] PRIMARY KEY CLUSTERED 
(
	[trh_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[whd_det]    Script Date: 13.05.2021 15:33:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[whd_det](
	[whdd_id] [int] IDENTITY(1,1) NOT NULL,
	[whdd_whdm_id] [int] NOT NULL,
	[whdd_sku] [nvarchar](50) NOT NULL,
	[whdd_qty] [decimal](18, 0) NOT NULL,
	[whdd_netto] [decimal](16, 2) NOT NULL,
	[whdd_brutto] [decimal](16, 2) NOT NULL,
 CONSTRAINT [PK_whd_det] PRIMARY KEY CLUSTERED 
(
	[whdd_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[whd_mstr]    Script Date: 13.05.2021 15:33:46 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[whd_mstr](
	[whdm_id] [int] IDENTITY(1,1) NOT NULL,
	[whdm_date] [datetime2](7) NOT NULL,
	[whdm_nbr] [nvarchar](50) NOT NULL,
	[whdm_cust] [nvarchar](50) NOT NULL,
	[whdm_name] [nvarchar](50) NOT NULL,
	[whdm_netto] [decimal](16, 2) NOT NULL,
	[whdm_brutto] [decimal](16, 2) NOT NULL,
 CONSTRAINT [PK_whd_mstr] PRIMARY KEY CLUSTERED 
(
	[whdm_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[whd_det]  WITH CHECK ADD  CONSTRAINT [FK_whd_det_whdm_id] FOREIGN KEY([whdd_whdm_id])
REFERENCES [dbo].[whd_mstr] ([whdm_id])
GO
ALTER TABLE [dbo].[whd_det] CHECK CONSTRAINT [FK_whd_det_whdm_id]
GO
