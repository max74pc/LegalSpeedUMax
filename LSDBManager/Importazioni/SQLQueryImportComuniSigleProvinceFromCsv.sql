BULK
INSERT ComuniItaliani
FROM 'd:\ProgettiVS2017\LegalSpeedUMax\LSDBManager\Importazioni\ElencoComuniSigleProvinceMio.csv'
WITH
(
FIELDTERMINATOR = ';',
ROWTERMINATOR = '\n'
)
GO
