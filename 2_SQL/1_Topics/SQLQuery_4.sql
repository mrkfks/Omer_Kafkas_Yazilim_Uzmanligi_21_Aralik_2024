--SELECT * FROM users
--SELECT * FROM product
--DELETE FROM users WHERE uıd = 1002
--SELECT TOP(10) * FROM users
--SELECT TOP(10) [uıd], [name], [surname] FROM users
--SELECT TOP(10) [name] as Kullanıcı_Adi, [surname] as Kullanıcı_Soyadı FROM users
--SELECT * FROM users WHERE [uıd] = 50
--SELECT * FROM users WHERE [status] != 1
--SELECT TOP (50) uıd , [name], [surname] from users WHERE uıd > 100
--SELECT * from users WHERE savedate BETWEEN '2024-01-01' AND GETDATE()
--SELECT * FROM users WHERE [name] LIKE 'al%'
--SELECT * FROM users WHERE [name] LIKE '%al%' OR surname LIKE '%al%'
--SELECT * FROM users WHERE [name] LIKE '%al%' AND surname LIKE '%al%'
--SELECT * FROM users WHERE [uıd] IN (5,8,10,12)
--SELECT * FROM users WHERE [email] = 'espiaggia0@g.co' and [password] = '12345'
--SELECT * FROM users WHERE [email] IN ('ali@mail.com', 'aholmea@google.pl', 'mrepp29@salon.com')
--SELECT * FROM users WHERE uıd IN (SELECT uıd FROM users WHERE name LIKE '%eb%' or surname LIKE '%eb%')
--SELECT * FROM users ORDER BY uıd DESC
--SELECT * FROM users ORDER BY uıd ASC
--SELECT * FROM users WHERE [name] LIKE '%el%' or [surname] LIKE '%el%' ORDER by savedate DESC
--SELECT top 5 * from users
--select * from users order by uıd ASC OFFSET 0 ROWS FETCH NEXT 10 ROWS ONLY
--select COUNT(*) as usercount from users
--SELECT * FROM users WHERE MONTH(savedate) = 2 and DAY(savedate) = 3
--SELECT MAX(age) as maxage FROM users
--SELECT MIN(age) as maxage FROM users
--SELECT AVG(age) as avgAge FROM users
--SELECT uıd, [name], [surname], LEN([surname]) FROM users
--SELECT AVG(age) avgAge,  COUNT(*) count, [status] FROM users GROUP BY [status] 

SELECT * FROM product INNER JOIN category ON product.[cıd] = category.[cıd]



