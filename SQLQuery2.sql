--Select
--ANSII
Select ContactName ,CompanyName ,City from Customers

Select * from Customers where City='London'

--case insensitive(büyük/küçük harf duyarsız)
select * from Products where CategoryID=1 or CategoryID=3

select * from Products where CategoryID=1 and UnitPrice>=10

select * from Products order by UnitPrice asc

select count(*) Adet from Products where CategoryID=2

select categoryID, count(*) from Products where UnitPrice>20
group by CategoryID having count(*)<10

select Products.ProductID, Products.ProductName, Products.UnitPrice, Categories.CategoryName
from Products inner join Categories 
on Products.CategoryID=Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation Object

Select * from Products p left join [Order Details] od
on p.ProductID=od.ProductID

select * from Customers c left join Orders o
on c.CustomerID=o.CustomerID
where o.CustomerID is null


SELECT SUM(Price) FROM Products p INNER JOIN [Order Details] od 
ON p.ProductID=od.ProductID

SELECT Products.ProductName AS 'Ürün Adı', SUM([Order Details].UnitPrice) 
AS 'Kazanılan Toplam Miktar'
FROM Products INNER JOIN [Order Details]
ON Products.ProductID = [Order Details].ProductID INNER JOIN Orders
ON Orders.OrderID = [Order Details].OrderID
GROUP BY Products.ProductName