
select * from ReceiptDetail  where ProductID = '6959996075490'
select * from Receipt
Select * from Products
SELECT ProductID, ReceiptPrice, COUNT(*) as Count
FROM ReceiptDetail
GROUP BY ProductID, ReceiptPrice
HAVING COUNT(*) > 1 


SELECT  Products.ProductID,Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductPrice,Products.ProductQuantity, SUM(ReceiptDetail.Amount) as Counts
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
WHERE ReceiptDetail.Date between DateAdd(DD,-7,GETDATE() ) and GETDATE() and Products.TypeName = 'สินค้าอุปโภคและของใช้ภายในบ้าน'
GROUP BY Products.ProductName,Products.TypeName,Products.CostPrice,Products.ProductID,Products.ProductPrice,Products.ProductQuantity
HAVING SUM(ReceiptDetail.Amount) > 1
ORDER BY Counts DESC


SELECT  SUM(ReceiptDetail.Amount) as Counts  
FROM Products 
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
Where  ReceiptDetail.Date between DateAdd(DD,-7,GETDATE() ) and GETDATE() 







Select TypeName from TypeProduct

Select *  from ReceiptDetail where ReceiptDetail.Date between DateAdd(DD,-100,GETDATE() ) and GETDATE() 

UPDATE Store SET StoreName = 'x' ,Location = 'x', Owner ='x' where StoreID = '0000000001'



Select * from Users

