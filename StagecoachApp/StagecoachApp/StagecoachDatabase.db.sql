BEGIN TRANSACTION;
DROP TABLE IF EXISTS "Stagecoach";
CREATE TABLE IF NOT EXISTS "Stagecoach" (
	"stagecoachID"	INTEGER,
	"hitPoints"		INTEGER NOT NULL,
	"hitPointsMax"	INTEGER NOT NULL,
	"horses"		INTEGER NOT NULL,
	"rations"		INTEGER NOT NULL,
	"water"			INTEGER NOT NULL,
	"crewCount"		INTEGER NOT NULL,
	"name"			VARCHAR(50) NOT NULL,
	PRIMARY KEY("stagecoachID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Item";
CREATE TABLE IF NOT EXISTS "Item" (
	"itemID"		INTEGER,
	"name"			VARCHAR(50) NOT NULL,
	"value"			INTEGER NOT NULL,
	"description"	TEXT NOT NULL,
	"isUpgrade"		BOOLEAN NOT NULL,
	"equippedSlot"	INTEGER,
	"typeID"		INTEGER,
	PRIMARY KEY("itemID" AUTOINCREMENT)
);
DROP TABLE IF EXISTS "Inventory";
CREATE TABLE IF NOT EXISTS "Inventory" (
	"stagecoachID"	INTEGER,
	"itemID"		INTEGER,
	"amount"		INTEGER NOT NULL,
	FOREIGN KEY("itemID") REFERENCES "Item"("itemID"),
	FOREIGN KEY("stagecoachID") REFERENCES "Stagecoach"("stagecoachID"),
	PRIMARY KEY("stagecoachID","itemID")
);
DROP TABLE IF EXISTS "Type";
CREATE TABLE IF NOT EXISTS "Type" (
	"typeID"	INTEGER,
	"name"		VARCHAR(30) NOT NULL,
	PRIMARY KEY("typeID")
);
DROP TABLE IF EXISTS "Action";
CREATE TABLE IF NOT EXISTS "Action" (
	"actionID"		INTEGER,
	"name"			VARCHAR(30) NOT NULL,
	"upgradeID"		INTEGER NOT NULL,
	"duration"		INTEGER,
	"description"	TEXT NOT NULL,
	"typeID"		INTEGER,
	"usesAmmo"		BOOLEAN NOT NULL,
	"ammoID"		INTEGER,
	"ammoUsed"		INTEGER,
	FOREIGN KEY("typeID") REFERENCES "Type"("typeID"),
	FOREIGN KEY("ammoID") REFERENCES "Item"("itemID"),
	FOREIGN KEY("upgradeID") REFERENCES "Item"("itemID"),
	PRIMARY KEY("actionID" AUTOINCREMENT)
);
COMMIT;
