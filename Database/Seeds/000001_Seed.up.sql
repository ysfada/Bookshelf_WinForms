INSERT INTO [dbo].[User]
	([Username], [Email], [Password], [Phone], [Role])
	VALUES (N'admin',	   N'admin@example.com',	  '5u8jRPzAh7QNwdA1Qyu+32Z618AimnVA|1000|itOGETmGhnXHXkAyvE61pWewXWIm0UBv', '0123456789', 'Admin'),
		   (N'personel1',  N'personel1@eaxmple.com',  'uadhjiaGNnx3XnfG+XCit9R04OkC0axF|1000|K1nG5huIAUrewb/b2XGnFyFOm6KZt16b', '1234567890', 'Staff'),
		   (N'kullanıcı1', N'kullanıcı1@example.com', 'vfo5nOqh+JonoikQ0J3azcPZaBaRsC6k|1000|cEtChE4oWDfokmI/YgwWXDk9LKBMAIFO', '2345678901', 'User')

GO

INSERT INTO [dbo].[Book]
	([BookName], [Pages], [PublishedAt], [Edition], [Author], [Genre])
	VALUES (N'Hobbit',													'336',	'2019', '16',	N'John Ronald Reuel Tolkien',	'Literature'),
		   (N'Silmarillion',											'696',	'2007', '14',	N'John Ronald Reuel Tolkien',	'Literature'),
		   (N'Yüzüklerin Efendisi (Tek Cilt)',						   '1026',	'2020', '14',	N'John Ronald Reuel Tolkien',	'Literature'),
		   (N'İki Şehrin Hikayesi',										'928',	'2007', '14',	N'Charles Dickens',				'Literature'),
		   (N'Küçük Prens',												'440',	'2019',	 '3',	N'Antoine de Saint-Exupéry',	'Literature'),
		   (N'On Küçük Zenci',											'224',	'2020',	 '1',	N'Agatha Christie',				'Literature'),
		   (N'Simyacı',													'184',	'2019',	 '6',	N'Paulo Coelho',				'Literature'),
		   (N'Gülün Adı',												'732',	'2019',	 '4',	N'Umberto Eco',					'Literature'),
		   (N'Savaş ve Barış',											'576',	'2005',	 '2',	N'Leo Tolstoy',					'Literature'),
		   (N'Yüzyıllık Yalnızlık',										'464',	'2019',	 '6',	N'Gabriel García Márquez',		'Literature'),
		   (N'Bin Dokuz Yüz Seksen Dört',								'352',	'2019', '12',	N'George Orwell',				'Literature'),
		   (N'Harry Potter ve Felsefe Taşı',							'274',	'2001',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Harry Potter ve Sırlar Odası',							'314',	'2001',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Harry Potter ve Azkaban Tutsağı',							'396',	'2001',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Harry Potter ve Ateş Kadehi',								'660',	'2001',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Harry Potter ve Zümrüdüanka Yoldaşlığı',				   '1114',	'2003',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Harry Potter ve Melez Prens',								'594',	'2007',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Harry Potter ve Ölüm Yadigârları',						'690',	'2007',	 '1',	N'Joanne Kathleen Rowling',		'Literature'),
		   (N'Sofie''nin Dünyası',										'591',	'2017', '11',	N'Jostein Gaarder',				'Philosophy'),
		   (N'Böyle Buyurdu Zerdüşt',									'304',	'2019',	 '2',	N'Friedrich Nietzsche',			'Philosophy'),
		   (N'Osmanlı Tarihinde Efsaneler ve Gerçekler',				'272',	'2020',	 '2',	N'Halil İnalcık',				   'History'),
		   (N'Anadolu Mutfağında Dünden Bugüne Unutulmayan Lezzetler',	'443',	'2020',	 '1',	N'Fegan Mutlu',						 'Hobby')

GO

--INSERT INTO [dbo].[BookIssue]
--	([UserId], [BookId], [IssuerId])
--	VALUES ((SELECT TOP (1) [Id] FROM [dbo].[User] WHERE [Username] = N'admin'),	  (SELECT TOP (1) [Id] FROM [dbo].[Book] WHERE [BookName] = N'Hobbit'),							(SELECT TOP (1) [Id] FROM [dbo].[User] WHERE [Username] = N'admin')),
--		   ((SELECT TOP (1) [Id] FROM [dbo].[User] WHERE [Username] = N'personel1'),  (SELECT TOP (1) [Id] FROM [dbo].[Book] WHERE [BookName] = N'Silmarillion'),					(SELECT TOP (1) [Id] FROM [dbo].[User] WHERE [Username] = N'personel1')),
--		   ((SELECT TOP (1) [Id] FROM [dbo].[User] WHERE [Username] = N'kullanıcı1'), (SELECT TOP (1) [Id] FROM [dbo].[Book] WHERE [BookName] = N'Yüzüklerin Efendisi (Tek Cilt)'), (SELECT TOP (1) [Id] FROM [dbo].[User] WHERE [Username] = N'personel1'))

--GO

--UPDATE [dbo].[BookIssue]
--        SET [Returned] = 1,
--			[ReturnedAt] = GETDATE()
--		WHERE [Id] IN ((SELECT [Id] FROM [dbo].[BookIssue] WHERE [BookId] IN (SELECT [Id] FROM [dbo].[Book] WHERE [BookName] IN (N'Hobbit', N'Silmarillion', N'Yüzüklerin Efendisi (Tek Cilt)'))))

--GO

--SELECT book.[BookName] AS 'Book Name', usr.[Username] AS 'Taken by', issuer.[Username] AS 'Given by', bookIssue.[ReturnedAt] AS 'Returned At', bookIssue.[Returned]
--FROM [dbo].[Book] book
--JOIN [dbo].[BookIssue] bookIssue ON bookIssue.[BookId] = book.[Id]
--JOIN [dbo].[User] usr ON usr.[Id] = bookIssue.[UserId]
--JOIN [dbo].[User] issuer ON issuer.[Id] = bookIssue.[IssuerId]
--WHERE bookIssue.[Returned] = 1
