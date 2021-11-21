/****** Script for SelectTopNRows command from SSMS  ******/
SELECT distinct [Unit of Measure Code]
      ,[Minimum Quantity]
  FROM [dbo].[Induma$Sales Price$437dbf0e-84ff-417a-965d-ed2bb9650972]
  where [Item No_] like 'T%'
  and [Sales Code] like 'PE%'
  order by 1