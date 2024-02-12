-- INSERT INTO [dbo].[Users]
--            ([id_User]
--            ,[Name]
--            ,[country]
--            ,[ReviewCount]
--            ,[password])
--      VALUES
--            (<id_User, int,>
--            ,<Name, nchar(30),>
--            ,<country, nchar(20),>
--            ,<ReviewCount, nchar(10),>
--            ,<password, nchar(30),>)
-- GO

INSERT INTO [dbo].[Users]
([id_User], [Name], [country], [ReviewCount], [password])
VALUES
(1, 'Alice Johnson', 'United States', 25, 'password123'),
(2, 'John Smith', 'Canada', 15, 'securepass456'),
(3, 'Emily Davis', 'United Kingdom', 10, 'qwerty789'),
(4, 'Michael Brown', 'Australia', 30, 'mypassword123'),
(5, 'Jessica Taylor', 'Germany', 20, 'pass1234'),
(6, 'David Wilson', 'France', 12, 'securepassword'),
(7, 'Sarah Martinez', 'Spain', 18, 'password456'),
(8, 'Daniel Anderson', 'Italy', 22, 'abc123'),
(9, 'Jennifer Thomas', 'Japan', 28, 'p@ssw0rd'),
(10, 'James Jackson', 'Brazil', 8, 'password789'),
(11, 'Linda Harris', 'Mexico', 16, 'secure789'),
(12, 'Robert Lee', 'South Korea', 13, 'mypassword456'),
(13, 'Karen Clark', 'China', 24, 'test123'),
(14, 'William Rodriguez', 'Russia', 19, 'passwordtest'),
(15, 'Megan Walker', 'India', 26, 'passwordabc'),
(16, 'Christopher Hill', 'Argentina', 17, 'securetest'),
(17, 'Amanda Green', 'Netherlands', 21, 'mypasswordtest'),
(18, 'Matthew Hall', 'Sweden', 14, 'password123test'),
(19, 'Lauren Turner', 'Switzerland', 23, 'securepass123'),
(20, 'Kevin King', 'Norway', 9, 'passwordsecure'),
(21, 'Ashley White', 'Denmark', 27, '123456'),
(22, 'Ryan Scott', 'Finland', 11, 'passwordpass'),
(23, 'Rebecca Young', 'Ireland', 29, 'testpass'),
(24, 'Jonathan Martinez', 'Portugal', 7, 'abc123test'),
(25, 'Nicole Garcia', 'Greece', 18, 'password123abc'),
(26, 'Steven Hernandez', 'Poland', 25, 'securepassword123'),
(27, 'Hannah Gonzalez', 'Turkey', 14, 'mypassword123abc'),
(28, 'Joseph Perez', 'Egypt', 22, 'testpassword'),
(29, 'Samantha Sanchez', 'South Africa', 12, 'passwordsecure123'),
(30, 'Tyler Ramirez', 'New Zealand', 20, 'abcpassword123');
