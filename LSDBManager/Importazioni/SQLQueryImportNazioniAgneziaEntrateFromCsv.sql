BULK
INSERT Nazioni
FROM 'D:\ProgettiVS2017\LegalSpeedUMax\LSDBManager\Importazioni\ElencoNazioniAgenziaEntrateMio.csv'
WITH
(
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO
