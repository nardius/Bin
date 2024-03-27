CREATE TABLE [dbo].[MedicalRecords] (
    [PatientID]      INT NOT NULL,
    [Alive]          INT NULL,
    [Age]            INT NULL,
    [Sex]            INT NULL,
    [Steroid]        INT NULL,
    [Antivirals]     INT NULL,
    [Fatigue]        INT NULL,
    [Malaise]        INT NULL,
    [Anorexia]       INT NULL,
    [LiverBig]       INT NULL,
    [LiverFirm]      INT NULL,
    [SpleenPalpable] INT NULL,
    [Spiders]        INT NULL,
    [Ascites]        INT NULL,
    [Varices]        INT NULL,
    PRIMARY KEY CLUSTERED ([PatientID] ASC)
);

