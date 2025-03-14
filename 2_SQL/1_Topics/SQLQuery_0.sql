-- --INSERT INTO users 
-- --([name], [surname], [email], [phone], [password], [savedate], [status]) 
-- --VALUES (
--     --'Erkan',
--     'Bilmem',
--     'erkan@mail.com',
--     5436667788,
--     '12345',
--     '2025-03-08 09:27:12',
--     1
-- )

--INSERT INTO users 
--VALUES (
    --'Ali',
    --'Bil',
    --'ali@mail.com',
    --5436667755,
    --'12345',
    --'2025-03-08 09:34:12',
    --1
--)

--alter TABLE users ADD age TINYINT

--UPDATE users SET [age] = 25

-- UPDATE users SET [age] = FLOOR( RAND() * 42) + 18 
-- WHERE [uıd] = 1


-- DECLARE @i int = 0;

-- WHILE @i<1004
-- BEGIN
--     SET @i = @i + 1;
--     UPDATE users SET [age] = FLOOR( RAND() * 42) + 18 
--     WHERE [uıd] = @i;
-- END
