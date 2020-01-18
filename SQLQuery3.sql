
select * from ReceiptDetail  where Date = '2020-01-18'
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

SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice, SUM(ReceiptDetail.Amount) as Counts  , Products.ProductPrice * SUM(ReceiptDetail.Amount) as TotalRevenue
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
where ReceiptDetail.Date = '2020-01-18'
GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity
HAVING SUM(ReceiptDetail.Amount) > 0
ORDER BY TotalRevenue DESC

SELECT  *  
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
Where  ReceiptDetail.Date between DateAdd(DD,-1,GETDATE() ) and GETDATE() 







Select TypeName from TypeProduct

Select *  from ReceiptDetail where ReceiptDetail.Date between DateAdd(DD,-100,GETDATE() ) and GETDATE() 


Select * from Users

