

-- INSERT INTO [dbo].[Reviews]
--            ([id_Review]
--            ,[id_user]
--            ,[description]
--            ,[rating]
--            ,[date]
--            ,[id_Movie])
--      VALUES
--            (<id_Review, int,>
--            ,<id_user, int,>
--            ,<description, nchar(100),>
--            ,<rating, int,>
--            ,<date, datetime,>
--            ,<id_Movie, int,>)
-- GO

INSERT INTO [dbo].[Reviews]
([id_Review], [id_user], [description], [rating], [date], [id_Movie])
VALUES
(1, 1, 'Absolutely loved the depth of the characters!', 5, '2024-02-12 10:30:00', 1),
(2, 2, 'Incredible cinematography!', 5, '2024-02-12 11:15:00', 2),
(3, 3, 'Left me speechless, such a powerful storyline.', 4, '2024-02-12 12:00:00', 3),
(4, 4, 'The acting was superb!', 5, '2024-02-12 13:45:00', 4),
(5, 5, 'A masterpiece!', 5, '2024-02-12 14:30:00', 5),
(6, 6, 'Not what I expected, but still good.', 3, '2024-02-12 15:15:00', 6),
(7, 7, 'Thrilling till the very end!', 5, '2024-02-12 16:00:00', 7),
(8, 8, 'Kept me entertained throughout.', 4, '2024-02-12 16:45:00', 8),
(9, 9, 'Highly emotional and moving.', 5, '2024-02-12 17:30:00', 9),
(10, 10, 'A rollercoaster of emotions!', 5, '2024-02-12 18:15:00', 10),
(11, 11, 'The visuals were stunning!', 5, '2024-02-12 19:00:00', 11),
(12, 12, 'A bit slow-paced for my taste.', 3, '2024-02-12 19:45:00', 12),
(13, 13, 'Impressive storytelling.', 4, '2024-02-12 20:30:00', 13),
(14, 14, 'A classic!', 5, '2024-02-12 21:15:00', 14),
(15, 15, 'One of the best movies I''ve seen in a while!', 5, '2024-02-12 22:00:00', 15),
(16, 16, 'Captivating from start to finish.', 5, '2024-02-12 22:45:00', 16),
(17, 17, 'Left me wanting more.', 4, '2024-02-12 23:30:00', 17),
(18, 18, 'Great chemistry between the leads.', 4, '2024-02-13 00:15:00', 18),
(19, 19, 'Beautifully crafted.', 5, '2024-02-13 01:00:00', 19),
(20, 20, 'A thought-provoking experience.', 5, '2024-02-13 01:45:00', 20),
(21, 1, 'Highly recommend it!', 5, '2024-02-13 02:30:00', 21),
(22, 2, 'Loved every minute of it!', 5, '2024-02-13 03:15:00', 22),
(23, 3, 'Had me on the edge of my seat.', 4, '2024-02-13 04:00:00', 23),
(24, 4, 'A must-watch!', 5, '2024-02-13 04:45:00', 24),
(25, 5, 'Will definitely watch it again!', 5, '2024-02-13 05:30:00', 25),
(26, 6, 'Not my favorite genre, but enjoyed it nonetheless.', 3, '2024-02-13 06:15:00', 26),
(27, 7, 'Kept me guessing till the end.', 5, '2024-02-13 07:00:00', 27),
(28, 8, 'A fun watch!', 4, '2024-02-13 07:45:00', 28),
(29, 9, 'Breathtaking visuals!', 5, '2024-02-13 08:30:00', 29),
(30, 10, 'One of the best of the year!', 5, '2024-02-13 09:15:00', 30),
--
(1, 1, 'This movie was terrible. I couldn''t even finish it.', 1, '2024-02-12', 1),
(2, 2, 'Absolutely awful. Waste of time and money.', 2, '2024-02-11', 3),
(3, 3, 'One of the worst movies I''ve ever seen. Avoid at all costs.', 1, '2024-02-10', 5),
(4, 4, 'I can''t believe I paid to see this garbage.', 1, '2024-02-09', 7),
(5, 5, 'Horrendous acting, terrible plot. Just terrible.', 2, '2024-02-08', 9),
(6, 6, 'Do not waste your time on this movie. It''s painfully bad.', 1, '2024-02-07', 11),
(7, 7, 'I''d rather watch paint dry than sit through this movie again.', 2, '2024-02-06', 13),
(8, 8, 'What a disappointment. I expected better.', 1, '2024-02-05', 15),
(9, 9, 'This movie was a total disaster. I want my money back.', 1, '2024-02-04', 17),
(10, 10, 'Awful, just awful. I''ve never been so bored in my life.', 2, '2024-02-03', 19);
