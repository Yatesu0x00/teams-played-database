CREATE DEFINER=`root`@`localhost` PROCEDURE `Delete`(IN inHMKurz CHAR(3), IN inGMKurz CHAR(3))
BEGIN
	DELETE FROM spiel WHERE HMKurz = inHMKurz AND GMKurz = inGMKurz;
END