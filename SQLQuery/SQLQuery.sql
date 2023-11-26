SELECT 
    ProductName AS Product,
    Categories.CategoryName AS Category  
FROM Products
LEFT JOIN ProductCategories ON Products.ProductID = ProductCategories.ProductID
LEFT JOIN Categories ON ProductCategories.CategoryID = Categories.CategoryID 