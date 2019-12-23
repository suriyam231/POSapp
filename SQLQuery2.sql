Select *  from Receipt where ReceiptDate Between '2019-12-22' and '2019-12-23'

SELECT Products.ProductID,Products.ProductName,Products.ProductPrice, ReceiptDetail.Amount FROM Products LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID 
Where ReceiptID = '362611431'