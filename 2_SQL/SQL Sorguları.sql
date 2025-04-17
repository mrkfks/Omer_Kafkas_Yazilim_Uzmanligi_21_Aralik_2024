--INSERT INTO users ([name], [surname], [email], [Phone], [password], [savedate], [status]) VALUES ('Muhittin', '!Kelaynak', 'kelaynakmuhittin@mail.com', '5553330011', '12345', '2025-04-02 00:00:00', 1);
--INSERT INTO users VALUES ('Haydar', 'Zerdali', 'zerdalihaydar@mail.com', 5489651232, '12345', '2025-04-02 00:00:00', 1);
--INSERT INTO users ([surname], [name], [email], [password], [Phone]) VALUES ('Yavaş', 'Mansur', 'yavasgardasımyavas@mail.com', '12345', 5758529137);
--SELECT * from users;
--SELECT TOP (100)* FROM users;
--SELECT TOP (100) [uid], [name], [surname] FROM users;
--SELECT TOP(100) [uid], [name] as username, [surname] AS usersurname from users;
--SELECT * FROM users WHERE [uid] = 100;
--SELECT * FROM users WHERE [status] != 1;
--SELECT TOP (50) [uid], [name], [surname], [email] FROM users WHERE [uid] > 100;
--SELECT TOP (50) [uid], [name], [surname], [email] FROM users WHERE [uid] < 100;
--SELECT * FROM users WHERE [uid] BETWEEN 100 AND 200;
--SELECT * FROM users WHERE [savedate] BETWEEN '2024-07-15' AND GETDATE();
--SELECT * FROM users WHERE [name] LIKE 'MANSUR';
--SELECT * FROM users WHERE [name] LIKE 'M%';
--SELECT * FROM users WHERE [name] LIKE '%AL' OR [surname] LIKE '%AL';
--SELECT * FROM users WHERE [email] LIKE 'jdaal10@1688.com' AND [password] LIKE 'qD8!8r';
--SELECT * FROM users WHERE [uid] IN (5 , 10, 15, 20, 25, 30, 35, 40, 45, 50);
--SELECT * FROM users WHERE [email] IN ('ali@mail.com', 'aholmea@google.pl', 'mrepp29@salon.com')
--SELECT * FROM users WHERE [uid] IN (SELECT [uid] FROM users WHERE [name] LIKE 'M%');
--SELECT * FROM users ORDER BY [uid] DESC;
--SELECT * FROM users ORDER BY [uid] ASC;
--SELECT * FROM users ORDER BY savedate DESC;
--SELECT * FROM users WHERE [name] LIKE '%el%' or [surname] LIKE '%el%' ORDER BY [uid] DESC;
--SELECT TOP 5 * FROM users
--SELECT  * FROM users ORDER BY [uid] ASC OFFSET 20 ROWS FETCH NEXT 10 ROWS ONLY;
--SELECT COUNT(*) AS usercount FROM users
--SELECT * FROM users WHERE MONTH ([savedate]) = 2 and DAY([savedate]) = 3;

-- DECLARE @i INT = 0;
-- WHILE @i < 3015
-- BEGIN
--     SET @i = @i + 1;
--     UPDATE users SET [age] = FLOOR(RAND() * 42) + 18
--     WHERE [uid] = @i;
-- END

--SELECT MAX(age) AS maxage FROM users
--SELECT MIN(age) AS minage FROM users
--SELECT AVG(age) AS avgage FROM users
--SELECT uid, [name], [surname], LEN ([surname]) as surnamelenght FROM users

--SELECT AVG(age) AS avgAge, COUNT(*) count, [status]  FROM users GROUP BY [status]

--SELECT * FROM users WHERE savedate BETWEEN DATEADD(MONTH, -1, GETDATE()) AND GETDATE();

--SELECT * FROM product
--INNER JOIN category ON product.cid = category.cId

--SELECT * FROM product
--INNER JOIN category ct ON product.cid = ct.cId

--SELECT pr.pId, pr.cid, pr.title,pr.detail, pr.price, ct.cId FROM product pr INNER JOIN category ct ON pr.cid = ct.cId
--WHERE CT.cId = 1

--SELECT pr.pId, pr.cid, pr.title, pr.detail, pr.price, ct.name FROM product pr INNER JOIN category ct ON pr.cid = ct.cId
--WHERE ct.cId = 1
--ORDER BY pr.pId ASC
--OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY;

-- SELECT 
-- pro.pId, pro.title, pro.detail, pro.price,
-- ca.cId, ca.name
-- FROM product as pro
-- INNER JOIN product_category as procat
-- ON pro.pId = procat.pid
-- INNER JOIN category as ca
-- ON ca.cId = procat.cid

--SELECT TOP (100) * FROM product as pro RIGHT JOIN category as cat ON pro.cid = cat.cId
--SELECT TOP (100) * FROM product as pro LEFT JOIN category as cat ON pro.cid = cat.cId

--DELETE FROM users WHERE [uid] = 100;
--DELETE FROM users WHERE savedate BETWEEN '2024-07-15' AND GETDATE();

-- CREATE VIEW pro_cat_join
-- AS
-- SELECT 
-- pro.pId, pro.cid, pro.title, pro.detail, pro.price, cat.name, cat.[status]
-- FROM product as pro
-- INNER JOIN category as cat
-- ON pro.cid = cat.cId

-- CREATE FUNCTION dbo.Fnc_Sum (@num1 INT, @num2 INT)
-- RETURNS INT
-- AS
-- BEGIN
--     DECLARE @sum INT;
--     SET @sum = @num1 + @num2;
--     RETURN @sum;
-- END

-- CREATE FUNCTION dbo.Fnc_NameConcat(@uid INT)
-- RETURNS VARCHAR(150)
-- AS
-- BEGIN
--     DECLARE @NameConcat VARCHAR(150);
--     SET @NameConcat = (SELECT CONCAT([name], ' ', [surname]) FROM users WHERE [uid] = @uid);
--     RETURN @NameConcat;
-- END

-- CREATE FUNCTION dbo.Fnc_NameConcat2(@uid int)
-- RETURNS Varchar(150)
-- AS 
-- BEGIN
-- 	Declare @NameConcat Varchar(150);

-- 	SET @NameConcat = (select concat('Sn. ',name, ' ' ,surname) from users where uid = @uid);
-- 	return @NameConcat;
-- END

-- CREATE PROCEDURE dbo.Pro_ProCat(@page INT)
-- AS
-- SELECT * FROM product as p
-- INNER JOIN product_category as pc
-- ON p.pId = pc.pid
-- INNER JOIN category as c
-- ON c.cId = pc.cid
-- ORDER BY p.pId ASC
-- OFFSET @page ROWS FETCH NEXT 10 ROWS ONLY;

-- EXEC dbo.Pro_ProCat 0;

-- CREATE PROCEDURE dbo.Pro_ProCat2(@page INT)
-- AS
-- DECLARE @COUNT INT;
-- SET @COUNT = 10;
-- SET @page = @page * @COUNT;
-- SELECT * FROM product as p
-- INNER JOIN product_category as pc
-- ON p.pId = pc.pid
-- INNER JOIN category as c
-- ON c.cId = pc.cid
-- ORDER BY p.pId ASC
-- OFFSET @page ROWS FETCH NEXT @COUNT ROWS ONLY;


-- CREATE OR ALTER TRIGGER AddStock ON project.dbo.product
-- AFTER INSERT
-- AS
-- BEGIN
	
-- declare @pid int
-- SET @pid = (select top 1 pid from product order by pid desc)
-- INSERT INTO stock values(@pid, 10)

-- END

-- CREATE TRIGGER UpdateStock ON project.dbo.product
-- AFTER UPDATE
-- AS
-- BEGIN
--     DECLARE @pid INT;

--     SELECT @pid = pId FROM inserted;
--     UPDATE stock SET count = 10 WHERE pId = @pid;
-- END;
