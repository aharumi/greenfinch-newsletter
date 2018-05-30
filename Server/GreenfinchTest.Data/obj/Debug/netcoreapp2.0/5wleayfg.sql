IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Newsletters] (
    [Id] int NOT NULL IDENTITY,
    [Email] nvarchar(max) NULL,
    [Heard] nvarchar(max) NULL,
    [Reason] nvarchar(max) NULL,
    CONSTRAINT [PK_Newsletters] PRIMARY KEY ([Id])
);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20180530104524_initial', N'2.1.0-rtm-30799');

GO

