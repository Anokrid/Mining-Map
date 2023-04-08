USE TransportDB
GO

CREATE TABLE MachineryTypes(
	MachineryTypeId	INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_MachineryTypeId PRIMARY KEY,
	MachineryName	VARCHAR(100) NOT NULL
);
GO

CREATE TABLE Machinary(
	MachinaryiD		INT IDENTITY(1,1) NOT NULL CONSTRAINT PK_MachinaryiD PRIMARY KEY,
	MachineryType	INT NOT NULL DEFAULT (1),
	PositionLat		DECIMAL(8, 6) NULL,
	PositionLng		DECIMAL(9, 6) NULL,
	MarkerColor		INT NOT NULL DEFAULT 7
);
GO

ALTER TABLE Machinary ADD CONSTRAINT FK_MachineryTypes
FOREIGN KEY (MachineryType)
	REFERENCES MachineryTypes (MachineryTypeId)
	ON DELETE SET DEFAULT
	ON UPDATE NO ACTION;
GO

INSERT INTO MachineryTypes(MachineryName)
	VALUES	('Трактор'),
			('Бульдозер'),
			('Грузовик'),
			('Буровая установка');
GO

INSERT INTO Machinary(MachineryType, PositionLat, PositionLng, MarkerColor)
	VALUES	(1, 66.42, 94.25, 7),
            (2, 67.42, 99.26, 7),
            (3, 65.43, 92.27, 7),
            (1, 63.41, 91.25, 7),
            (1, 66.73, 93.25, 7),
            (4, 66.00, 92.12, 7),
            (2, 62.23, 93.28, 7),
            (3, 63.32, 92.27, 7);
GO