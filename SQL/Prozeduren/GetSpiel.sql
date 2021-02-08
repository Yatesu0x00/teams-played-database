CREATE DEFINER=`root`@`localhost` PROCEDURE `GetSpiel`()
BEGIN
	SELECT HMKurz, GMKurz, Spieltag, Datum, ToreH, ToreG, PunkteH, PunkteG FROM spiel ORDER BY Spieltag, Datum ASC;
END