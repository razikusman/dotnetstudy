IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Publishers] (
    [PublisherId] int NOT NULL IDENTITY,
    [PublsherName] nvarchar(max) NULL,
    CONSTRAINT [PK_Publishers] PRIMARY KEY ([PublisherId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200928150922_initialCreate', N'3.1.8');

GO

CREATE TABLE [Books] (
    [BookId] int NOT NULL IDENTITY,
    [MainTitle] nvarchar(max) NULL,
    [SubTitle] nvarchar(max) NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY ([BookId])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200929094932_cratetable_bookks', N'3.1.8');

GO

ALTER TABLE [Books] ADD [Title] nvarchar(max) NULL;

GO

update Books set Title = MainTitle + ' : ' + SubTitle

GO

DECLARE @var0 sysname;
SELECT @var0 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'MainTitle');
IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var0 + '];');
ALTER TABLE [Books] DROP COLUMN [MainTitle];

GO

DECLARE @var1 sysname;
SELECT @var1 = [d].[name]
FROM [sys].[default_constraints] [d]
INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Books]') AND [c].[name] = N'SubTitle');
IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Books] DROP CONSTRAINT [' + @var1 + '];');
ALTER TABLE [Books] DROP COLUMN [SubTitle];

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20200929113217_drop_subtitle_and_maintitile_and_add_title_colomn', N'3.1.8');

GO

