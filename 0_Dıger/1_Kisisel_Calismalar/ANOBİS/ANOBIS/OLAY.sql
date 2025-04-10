CREATE TABLE [dbo].[OLAY] (
    [Id]             INT           NOT NULL PRIMARY KEY CLUSTERED ([Id] ASC),
    [ORGUT_ID]       VARCHAR (50)  NOT NULL,
    [IL_ID]          VARCHAR (50)  NOT NULL,
    [ILCE_ID]        VARCHAR (50)  NOT NULL,
    [YER_ID]         VARCHAR (MAX) NOT NULL,
    [TARIH]          DATE          NOT NULL,
    [SAAT]           TIME (7)      NOT NULL,
    [KATILIM_SAYISI] INT           NULL,
    [PROTESTO_ID]    INT           NULL,
    [BILGI_NOTU]     INT           NOT NULL
);
