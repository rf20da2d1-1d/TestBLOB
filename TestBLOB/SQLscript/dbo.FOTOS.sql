CREATE TABLE [dbo].[FOTOS] (
    [ID]          INT             IDENTITY (100, 10) NOT NULL,
    [Beskrivelse] NVARCHAR (40)   NULL,
    [FileType]    NVARCHAR (10)   NULL,
    [Foto]        VARBINARY (MAX) NULL,
    PRIMARY KEY CLUSTERED ([ID] ASC)
);

