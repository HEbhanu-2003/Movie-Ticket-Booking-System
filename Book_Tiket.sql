CREATE DATABASE BookTicket;
USE BookTicket;

CREATE TABLE MoviesTiketsBookingDetails
(
	BookingId int Primary key,
	Name VARCHAR(20),
	Date Date,
	Tickets Int,
	Price VARCHAR(20),

);

CREATE TABLE PaymentsDetails
(
	PaymentId int Primary Key,
	Full_Total VARCHAR (25),
	Email VARCHAR (50),
	MobileNumber Char(10),
	CardNumber Char (20),
	CountryOfOrigin VARCHAR(50),
	ExpireDate Char(10),
	CVC int,
	BranchName VARCHAR (50),
);

CREATE TABLE Select_Food_AND_Drinks_Price_Details
(
	Selected_Items_ID int PRIMARY KEY,
	Items_Price VARCHAR (25),
);

DROP TABLE MoviesTiketsBookingDetails;
SELECT * FROM MoviesTiketsBookingDetails;
DROP TABLE PaymentsDetails;
SELECT * FROM PaymentsDetails;
DROP TABLE Select_Food_AND_Drinks_Price_Details;
SELECT * FROM Select_Food_AND_Drinks_Price_Details;