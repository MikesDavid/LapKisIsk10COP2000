﻿--CREATE DATABASE osztalypenztar2000
--USE osztalypenztar2000;

--CREATE TABLE NAPLO(
--	sorszam INT PRIMARY KEY	IDENTITY(0,1),
--	nev VARCHAR(25) NOT NULL,
--	tavozott DATE NULL
--);

--CREATE TABLE BANK(
--	tetelszam INT PRIMARY KEY IDENTITY,
--	leiras VARCHAR(120) NOT NULL,
--	mikor DATE NOT NULL,
--	ki INT FOREIGN KEY REFERENCES NAPLO(sorszam),
--	osszeg INT NOT NULL
--);


--INSERT INTO NAPLO VALUES
--('Osztály Főnök', null),
--('Alap Tibi', null),
--('Brutkó Dezső', '2000-12-05'),
--('Cserepes Virág', null),
--('Dzsesszika Alba', null),
--('Fá Zoltán', null),
--('Felex Elek', null),
--('Füty Imre', null),
--('Keresztes Lyézus', null),
--('Koton Botond', '2000-11-03'),
--('Lapos Elemér', null),
--('Mérő Edény', null),
--('Végh Béla', '2000-10-10'),
--('Zajos Ricsárdka', null);

--INSERT INTO BANK VALUES
--('elozo eves zaroegyenleg atvezetese', '2000-09-02', 0, 42654),
--('szamlavezetesi dij minusz kamat', '2000-09-03', 0, -175),
--('havi osztalypenz', '2000-09-25', 1, 1000),
--('osztalypenz egesz evre', '2000-09-25', 2, 8000),
--('havi osztalypenz', '2000-09-26', 5, 1000),
--('fenymasolas', '2000-09-26', 0, -645),
--('havi osztalypenz', '2000-09-26', 7, 1000),
--('osztalypenz egesz evre', '2000-09-26', 8, 8000),
--('havi osztalypenz', '2000-09-27', 9, 1000),
--('osztalypenz egesz evre', '2000-09-28', 10, 8000),
--('havi osztalypenz', '2000-09-29', 11, 1000),
--('havi osztalypenz', '2000-09-30', 13, 1000),
--('szamlavezetesi dij minusz kamat', '2000-10-03', 0, -175),
--('havi osztalypenz', '2000-10-06', 1, 1000),
--('fenymasolas', '2000-10-10', 0, -530),
--('ket havi osztalypenz', '2000-10-20', 4, 2000),
--('havi osztalypenz', '2000-10-21', 5, 1000),
--('malaj tancoslanyok', '2000-10-21', 0, -23000),
--('havi osztalypenz', '2000-10-21', 7, 1000),
--('osszetort pad kifizetese', '2000-10-22', 0, -12000),
--('fenymasolas', '2000-10-25', 0, -420),
--('havi osztalypenz', '2000-10-28', 9, 1000),
--('harom havi osztalypenz', '2000-10-30', 11, 3000),
--('osszetort pad megteritese', '2000-10-30', 2, -15000),
--('havi osztalypenz', '2000-10-30', 13, 1000),
--('szamlavezetesi dij minusz kamat', '2000-11-03', 0, -175),
--('havi osztalypenz', '2000-11-06', 1, 1000),
--('fenymasolas', '2000-11-10', 0, -830),
--('ket havi osztalypenz', '2000-11-16', 4, 2000),
--('havi osztalypenz', '2000-11-18', 5, 1000),
--('random sikkasztas csak ugy', '2000-11-20', 0, -9700),
--('maradek osztalypenz', '2000-11-21', 7, 6000),
--('virag Botond temetesere', '2000-11-21', 0, -7600),
--('havi osztalypenz', '2000-11-30', 13, 1000),
--('szamlavezetesi dij minusz kamat', '2000-12-03', 0, -175),
--('havi osztalypenz', '2000-12-06', 1, 1000),
--('havi osztalypenz', '2000-12-10', 5, 1000),
--('kabitoszer', '2000-12-11', 0, -8700),
--('maradek osztalypenz', '2000-12-11', 7, 6000),
--('fenymasolas', '2000-12-11', 0, -1140),
--('havi osztalypenz', '2000-12-11', 13, 1000),
--('habzsi-dozsi osztalykaracsonyra', '2000-12-18', 0, -4500);


