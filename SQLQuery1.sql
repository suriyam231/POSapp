select * from ReceiptDetail



SELECT Products.ProductID, Products.ProductName ,ReceiptDetail.ReceiptPrice , ReceiptDetail.Amount ,ReceiptDetail.Amount*ReceiptDetail.ReceiptPrice AS Total FROM Products
LEFT JOIN ReceiptDetail ON Products.ProductID = ReceiptDetail.ProductID
Where ReceiptID = '758029858'

delete ReceiptDetail