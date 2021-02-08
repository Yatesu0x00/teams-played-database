CREATE DEFINER=`root`@`localhost` PROCEDURE `GetMannschaft`()
BEGIN
	SELECT * FROM Mannschaft; 
END