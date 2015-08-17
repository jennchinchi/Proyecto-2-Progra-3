------------------------------------------------------------
---------------- HISTORIAL DE MODIFICACION -----------------
------------------------------------------------------------
----Fecha creación: 14-06-2015
----Descripción: Creación de base de datos y tabla cliente
---- con sus respectivos store procedures
----Encargado: Roberto Mora Castro

----Fecha creación: 20-06-2015
----Descripción: Creación de tablas tiquete,vuelo,avion y
---- sus respectivos store procedures
----Encargado: Jenniffer Chinchilla Porras

----Fecha creación: 09-08-2015 // 16-08-2015
----Descripción: Cambio en la tabla Flight, columna price de money a float y agregar el GO en el SP // Modificacion de SP
----Encargado: Ronald Moreira Artavia
----Llave= cambPriceFloat // mod_SP

--------------------------------------------------------------
---------------FIN HISTORIAL DE MODIFICACION ---------------
------------------------------------------------------------
---- Creacion de base de datos
USE master;
GO

CREATE DATABASE Flights
GO
---- Creacion de tablas
USE Flights;

CREATE TABLE Client
(
        id varchar(50) NOT NULL ,
        name varchar(50) NOT NULL,
        lastname varchar(50) NOT NULL,
        email varchar(50),
        phone varchar(50),
		clientState varchar(50) NOT NULL,
        clientType varchar(50) NOT NULL,
		miles int 
);
 GO
	 ALTER TABLE Client
	 ADD CONSTRAINT pk_ClientID PRIMARY KEY (id)
	 
GO
 CREATE TABLE Ticket
(
		idTicket int IDENTITY(1,1) PRIMARY KEY,
        currency int NOT NULL,
		ticketState varchar(50) NOT NULL,
        idClient varchar(50) NOT NULL,
		idFlight int NOT NULL,
		numSeat int
);
GO
CREATE TABLE Plane
(
		idPlane int IDENTITY(1,1) PRIMARY KEY,
		marca varchar(50),
		qtyAsiento int
);
GO
CREATE TABLE Flight
(
		idFlight int IDENTITY(1,1) PRIMARY KEY,
		idPlane  int NOT NULL FOREIGN KEY REFERENCES dbo.Plane(idPlane),
		origen varchar (50),
		destino  varchar (50),
		horaPartida  varchar (50),
		horaLlegada  varchar (50),
		price float NOT NULL --cambPriceFloat
);

CREATE TABLE Place
(		idPlace int IDENTITY(1,1) PRIMARY KEY,
		name varchar (50),
		latitude varchar (50),
		longitude varchar (50)
);

GO
---- Registro de aviones 

INSERT INTO Plane (marca,qtyAsiento) values ('Taca','40');
INSERT INTO Plane (marca,qtyAsiento) values ('Avianca','35');
INSERT INTO Plane (marca,qtyAsiento) values ('jetBlue','50');
INSERT INTO Plane (marca,qtyAsiento) values ('American Airlines','45');
GO
---- Registro de lugares
INSERT INTO Place (name, latitude,longitude) values ('San Francisco California, EEUU','37.774120','-122.415627');
INSERT INTO Place (name, latitude,longitude) values ('New York,EEUU','40.649675','73.669317');
INSERT INTO Place (name, latitude,longitude) values ('New Jersey,EEUU','40.714243','-74.019506');
INSERT INTO Place (name, latitude,longitude) values ('Washington, EEUU','38.956503','-77.456623');
INSERT INTO Place (name, latitude,longitude) values ('Tocula, Mexico','19.338256','-99.565193');
INSERT INTO Place (name, latitude,longitude) values ('Bolivia','-17.817155','-61.308186');
INSERT INTO Place (name, latitude,longitude) values ('Cuba','23.100373','-82.409167');
INSERT INTO Place (name, latitude,longitude) values ('Puerto Rico','18.439301',' -66.001605');
INSERT INTO Place (name, latitude,longitude) values ('Panama','9.080852','-79.389208');
INSERT INTO Place (name, latitude,longitude) values ('Buenos Aires,Argentina','-34.559315','-58.415277');
INSERT INTO Place (name, latitude,longitude) values ('San Jose, Costa Rica','9.999593','-84.204078');
INSERT INTO Place (name, latitude,longitude) values ('Sao Paulo, Brasil','-23.440505','-46.481327');
INSERT INTO Place (name, latitude,longitude) values ('Guatelama','14.583075','-90.527605');
INSERT INTO Place (name, latitude,longitude) values ('Lima,Peru','-12.088517', '-77.024145');
INSERT INTO Place (name, latitude,longitude) values ('Bogotá,Colombia','4.698971', '-74.141528 ');
INSERT INTO Place (name, latitude,longitude) values ('San Andrés, Colombia','12.583920','-81.711463');
INSERT INTO Place (name, latitude,longitude) values ('Toronto, Canada','43.677741','-79.624817');
INSERT INTO Place (name, latitude,longitude) values ('Tegucigalpa, Honduras','14.044847','-87.217222');
INSERT INTO Place (name, latitude,longitude) values ('San Luis, El Salvador','13.441035','-89.054291');
INSERT INTO Place (name, latitude,longitude) values ('Orlando, Florida','28.431969','-81.307639');
INSERT INTO Place (name, latitude,longitude) values ('Chile','-33.395330','-70.968690');

-- Store Procedures inserts

GO
CREATE PROCEDURE sp_Register
	@pId varchar(50),
    @pName varchar(50),
    @pLastname varchar(50),
    @pEmail varchar(50),
    @pPhone varchar(50),
    @pClientState varchar(50),
    @pClientType varchar(10),
	@pmillas int
AS 
BEGIN
	INSERT INTO Client (id,name,lastname,email,phone,clientState,clientType, miles)
	VALUES (@pId, @pName,@pLastname,@pEmail,@pPhone,@pClientState,@pClientType, @pmillas)
END

GO 
CREATE PROCEDURE sp_RegisterTicket
	@pCurrency int,
	@pTicketState varchar(50),
    @pIdClient varchar(50),
	@pIdFlight int,
	@pNumSeat int

AS 
BEGIN
	INSERT INTO Ticket (currency,ticketState,idClient,idFlight,numSeat)
	VALUES (@pCurrency,@pTicketState,@pIdClient,@pIdFlight,@pNumSeat)
END

GO 
CREATE PROCEDURE sp_RegisterFlight
	@idPlane int,
    @origen varchar(50),
	@destino varchar(50),
	@horaPartida varchar(50),
	@horaLlegada varchar(50),
    @price float --cambPriceFloat
AS 
BEGIN
	INSERT INTO Flight (idPlane,origen,destino,horaPartida,horaLlegada, price)
	VALUES (@idPlane,@origen,@destino,@horaPartida,@horaLlegada, @price)
END


-- Store Procedures updates

GO
CREATE PROCEDURE sp_UpdateClient
	@pId varchar(50),
    @pName varchar(50),
    @pLastname varchar(50),
    @pEmail varchar(50),
    @pPhone varchar(50),
    @pClientState varchar(50),
    @pClientType varchar(50), 
	@pmiles int
AS 
	BEGIN
	UPDATE Client
	SET
	    id=@pId,
        name=@pName,
        lastname=@pLastname,
        email=@pEmail,
        phone=@pPhone,
        clientState=@pClientState,
        clientType=@pClientType,
		miles = @pmiles
		WHERE id=@pId
END

GO
CREATE PROCEDURE sp_UpdateTicket
	@pId varchar(50),
	@pCurrency int,
	@pTicketState varchar(50),
    @pIdClient varchar(50),
	@pIdFlight int,
	@pNumSeat int
AS 
	BEGIN
	UPDATE Ticket
	SET
        currency=@pCurrency,
        ticketState=@pTicketState,
        idClient=@pIdClient,
        idFlight=@pIdFlight,
        numSeat=@pNumSeat
		WHERE idTicket=@pId
END

GO 
CREATE PROCEDURE sp_UpdateFlight
	@pId int,
	@idPlane int,
    @origen varchar(50),
	@destino varchar(50),
	@horaPartida varchar(50),
	@horaLlegada varchar(50),
    @price float --cambPriceFloat
AS 
	BEGIN
	UPDATE Flight
	SET
        idPlane=@idPlane,
        origen=@origen,
        destino=@destino,
        horaPartida=@horaPartida,
        horaLlegada=@horaLlegada,
		price=@price
		WHERE idFlight = @pId
END

---- Store Procedures list

GO
CREATE PROCEDURE sp_listClients
	AS
	BEGIN
	SELECT id AS identificacion, name AS nombre, lastname AS apellido,
		   email AS email, phone AS telefono, clientState AS estado, clientType AS tipoCliente, miles AS millas
	FROM Client
	WHERE clientState != 'Inactivo'
END

GO
CREATE PROCEDURE sp_listTickets
	AS
	BEGIN
	SELECT idTicket AS idTiquete, currency AS moneda,
		   ticketState AS estado, idClient AS cliente, idFlight AS vuelo, numSeat AS asiento	
	FROM Ticket;
END

GO
CREATE PROCEDURE sp_listFlights
	AS
	BEGIN
	SELECT idFlight AS vuelo,idPlane AS avion,origen AS origen,destino AS destino,
		   horaPartida AS horaSalida,horaLlegada AS horaLlegada, price AS precio
	FROM Flight;
END

GO
CREATE PROCEDURE sp_listFlights2 --mod_SP
	AS
	 BEGIN
	SELECT idFlight AS vuelo,idPlane AS avion, origen, (SELECT name FROM Place WHERE idPlace = origen) as origenDisplay,destino,(SELECT name FROM Place WHERE 	idPlace = destino) as destinoDisplay, horaPartida AS horaSalida,horaLlegada AS horaLlegada, price AS precio  
	FROM Flight;
END

GO
CREATE PROCEDURE sp_listPlane
AS
BEGIN
	SELECT idPlane AS idAvion, marca AS marca, qtyAsiento AS cantidadAsientos
	FROM Plane;
END
GO
CREATE PROCEDURE sp_listPlace
AS
BEGIN
	SELECT idPlace AS idLugar, name AS nombre, latitude AS latitud, longitude AS longitud
	FROM Place;
END


-- Store Procedures search

GO
CREATE PROCEDURE sp_searchById
		@pId varchar (50)
AS
	BEGIN
	SELECT id AS identificacion, name AS nombre, lastname AS apellido,
	 email AS email, phone AS telefono, clientState AS estado, clientType AS tipoCliente, miles AS millas
	FROM Client
	WHERE id =@pId
END
GO

CREATE PROCEDURE sp_searchByIdPlane
	@pId varchar (50)
AS
BEGIN
	SELECT idPlane AS idAvion, marca AS marca, qtyAsiento AS cantidadAsientos
	FROM Plane WHERE idPlane = @pId;
END

GO
CREATE PROCEDURE sp_searchByIdTicket
	@pId INT
AS
	BEGIN
	SELECT idTicket AS idTiquete, currency AS moneda,
		   ticketState AS estado, idClient AS cliente, idFlight AS vuelo, numSeat AS asiento	
	FROM Ticket	WHERE idTicket = @pId
END

GO
CREATE PROCEDURE sp_searchByIdPlace
	@pId varchar (50)
AS
BEGIN
	SELECT idPlace AS idLugar, name AS nombre, latitude AS latitud, longitude AS longitud
	FROM Place WHERE idPlace = @pId;
END

GO
CREATE PROCEDURE sp_searchByClienteByVuelo
	@pIdCliente varchar (50),
	@pIdFlight int
AS
	BEGIN
	SELECT idTicket AS idTiquete, currency AS moneda,
		   ticketState AS estado, idClient AS cliente, idFlight AS vuelo, numSeat AS asiento	
	FROM Ticket	WHERE idClient = @pIdCliente OR idFlight = @pIdFlight  
END

GO
CREATE PROCEDURE sp_searchByIdFlightORDestino
	@pId INT,
	@pDestino varchar (50)
AS
	BEGIN
	SELECT idFlight AS vuelo,idPlane AS avion,origen AS origen,
		   destino AS Destino,horaPartida AS horaSalida,horaLlegada AS horaLlegada, price AS precio
	FROM Flight WHERE idFlight = @pId OR destino LIKE '%'+@pDestino+'%'
END

GO
CREATE PROCEDURE sp_searchClienteByIdORNombre
	@pId varchar (50),
	@pNombre varchar (50)
AS
	BEGIN
	SELECT id AS identificacion, name AS nombre, lastname AS apellido,
		   email AS email, phone AS telefono, clientState AS estado, clientType AS tipoCliente, miles AS millas
	FROM Client WHERE id = @pId OR name LIKE '%'+@pNombre+'%'
END

GO
CREATE PROCEDURE sp_listaAsientosReservados
	@pIdFlight int
AS
BEGIN
	SELECT numSeat AS asiento	
	FROM Ticket	WHERE idFlight = @pIdFlight
END

