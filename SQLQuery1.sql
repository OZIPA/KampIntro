--Select
Select ContactName Adi,CompanyName SirketAdi,City Sehir from Customers

Select * from Customers where City= 'London'

sElEct * from Products where CategoryID=1 or CategoryID=3

sElEct * from Products where CategoryID=1 and UnitPrice>=10

select * from products order by UnitPrice asc --ascending artan zaten default

select * from products where CategoryID=1 order by UnitPrice desc --descending dusen

select * from products order by CategoryID, ProductName

select count(*) from Products where CategoryID=2

select categoryID, count(*) from products group by CategoryID
select categoryID, count(*) from products group by CategoryID having count(*)<10
select categoryID, count(*) from products where unitprice>20 group by CategoryID having count(*)<10

select Products.ProductId, Products.ProductName, Products.UnitPrice, categories.categoryname
 from products inner join Categories on Products.CategoryID=Categories.CategoryID where products.UnitPrice>10

 select * from products p left join [Order Details] od on p.ProductID =od.ProductID
 select * from customers c left join orders o on c.CustomerID=o.CustomerID where o.CustomerID is null

  select * from products p inner join [Order Details] od on p.ProductID =od.ProductID inner join orders o on o.orderid=od.orderid



