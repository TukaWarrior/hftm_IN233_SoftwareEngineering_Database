CREATE TABLE Person (
    PersonID INT AUTO_INCREMENT PRIMARY KEY,
    Name VARCHAR(255),
    Vorname VARCHAR(255),
    Geburtsdatum INT,
    Heimatort VARCHAR(255)
);

CREATE TABLE Ortschaft (
    PLZ INT PRIMARY KEY,
    Ort VARCHAR(255)
);

CREATE TABLE Adresse (
    AdresseID INT AUTO_INCREMENT PRIMARY KEY,
    PersonID INT,
    Strasse VARCHAR(255),
    Nummer VARCHAR(50),
    GueltigAb DATE,
    GueltigBis DATE,
    PLZ INT,
    FOREIGN KEY (PersonID) REFERENCES Person(PersonID),
    FOREIGN KEY (PLZ) REFERENCES Ortschaft(PLZ)
);
