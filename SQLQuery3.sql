
select * from ReceiptDetail  where ProductID = '6959996075490'

SELECT ProductID, ReceiptPrice, COUNT(*) as Count
FROM ReceiptDetail
GROUP BY ProductID, ReceiptPrice
HAVING COUNT(*) > 1 


SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity, SUM(ReceiptDetail.Amount) as Counts
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity
HAVING SUM(ReceiptDetail.Amount) > 10
ORDER BY Counts DESC





Select * from Products

Select *  from Receipt where ReceiptDate Between '2020-01-01' and '2020-01-16' ORDER BY ReceiptTime DESC


