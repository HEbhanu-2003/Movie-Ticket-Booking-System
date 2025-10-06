CREATE DATABASE Registration1;
USE  Registration1;

CREATE TABLE Registration_Details
(
	RegisterId INT PRIMARY KEY,
	UserName VARCHAR (20),
	Password VARCHAR(20),
);
SELECT * FROM Registration_Details;
DROP TABLE Registration_Details;