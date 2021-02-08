CREATE DEFINER=`root`@`localhost` PROCEDURE `AddSpiel`(IN inHMKurz CHAR(3), IN inGMKurz CHAR(3), IN inSpieltag int, IN inDatum DATE)
BEGIN
	#Variablen Deklarieren
	DECLARE  anzahl INT DEFAULT 0;
	DECLARE  msg varchar(128);
    
    IF (inSpieltag < 18) THEN
		set anzahl = (select count(*) from spiel where HMKurz = inGMkurz AND GMkurz = inHMKurz);
		IF (anzahl  = 0) THEN
			INSERT INTO spiel (HMKurz, GMKurz, Spieltag, Datum) VALUES (inHMKurz, inGMKurz, inSpieltag, inDatum);
		ELSE
		#Fehlerbehandlung
        set msg = 'Ein Rückspiel kann nicht in der Hinrunde stattfinden! ';
        signal sqlstate '45000' set message_text = msg;
		END IF;
	ELSE
		INSERT INTO spiel (HMKurz, GMKurz, Spieltag, Datum) VALUES (inHMKurz, inGMKurz, inSpieltag, inDatum);
    END IF;
END