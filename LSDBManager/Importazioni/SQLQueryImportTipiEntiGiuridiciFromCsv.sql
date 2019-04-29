BULK
INSERT TipiEntiGiuridici
FROM 'D:\ProgettiVS2017\LegalSpeedUMax\LSDBManager\Importazioni\TipologieEntiGiuridiciMio.csv'
WITH
(
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO
