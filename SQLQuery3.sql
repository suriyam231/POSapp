
select * from ReceiptDetail  where Date = '2020-01-19'

update ReceiptDetail set Date = '2020-02-19' where ReceiptID = '651775180'

select * from Receipt
Select * from Products
SELECT ProductID, ReceiptPrice, COUNT(*) as Count
FROM ReceiptDetail
GROUP BY ProductID, ReceiptPrice
HAVING COUNT(*) > 1 

/*สินค้าขายดี*/
SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity, SUM(ReceiptDetail.Amount) as Counts  
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity
HAVING SUM(ReceiptDetail.Amount) > 0
ORDER BY Counts DESC

/*รายงานการขาย*/
SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue 
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
where ReceiptDetail.Date between DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+0, 0) and DATEADD(MONTH, DATEDIFF(MONTH, 01, GETDATE())+12, 0) 
GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity
HAVING SUM(ReceiptDetail.Amount) > 0
ORDER BY Products.TypeName DESC



SELECT   Products.ProductName,SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost , ReceiptDetail.Date
FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID 
where  ReceiptDetail.Date  between DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+0, 0) and DATEADD(MONTH, DATEDIFF(MONTH, 01, GETDATE())+1, 0) 
Group by Products.ProductPrice, ReceiptDetail.Date, Products.ProductName,Products.ProductID
HAVING SUM(ReceiptDetail.Amount) > 0
ORDER BY TotalRevenue DESC

SELECT   SUM(Products.ProductPrice * ReceiptDetail.Amount) as TotalRevenue ,SUM(Products.CostPrice*ReceiptDetail.Amount) as TotalCost 
FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID 
where  ReceiptDetail.Date  between DATEADD(MONTH, DATEDIFF(MONTH, 0, GETDATE())+0, 0) and DATEADD(MONTH, DATEDIFF(MONTH, 01, GETDATE())+1, 0) 
Group by Products.ProductPrice,  Products.ProductName,Products.ProductID
HAVING SUM(ReceiptDetail.Amount) > 0
ORDER BY TotalRevenue DESC


/*รายเดือน*/
SELECT  
ReceiptDetail.Date, SUM(ReceiptDetail.Amount) as Counts , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
where  ReceiptDetail.Date between '2020-01-1' and '2020-01-31' 
GROUP BY  ReceiptDetail.Date
HAVING SUM(ReceiptDetail.Amount) > 0
ORDER BY TotalRevenue DESC





SELECT  *  
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
Where  ReceiptDetail.Date between DateAdd(DD,-2,GETDATE() ) and GETDATE() 







Select TypeName from TypeProduct

Select *  from ReceiptDetail where ReceiptDetail.Date between DateAdd(DD,-100,GETDATE() ) and GETDATE() 


Select * from Users

