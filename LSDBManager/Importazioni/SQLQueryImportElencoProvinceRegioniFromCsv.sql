BULK
INSERT Province
FROM 'd:\ProgettiVS2017\LegalSpeedUMax\LSDBManager\Importazioni\ElencoProvinceRegioniMio.csv'
WITH
(
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO
