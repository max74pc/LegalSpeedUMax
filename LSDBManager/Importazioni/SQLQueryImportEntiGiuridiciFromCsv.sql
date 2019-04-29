BULK
INSERT EntiGiuridici
FROM 'D:\ProgettiVS2017\LegalSpeedUMax\LSDBManager\Importazioni\ElencoEntiGiuridiciMio.csv'
WITH
(
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO
