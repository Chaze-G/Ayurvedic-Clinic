# Database Setup

Before running the application, ensure that Microsoft SQL Server LocalDB is installed on your computer.

Please use the below server name when connecting to the Microsoft SQL Server Application

```
(localdb)\MSSQLLocalDB

```

## Database Installation

1. Open SQL Server Management Studio (SSMS).
2. Connect to the following server name:
   ```
   (localdb)\MSSQLLocalDB
  
   ```
3. Click "New Query".
4. Copy and paste the SQL script below into the query window.
5. Click **Execute** (or press F5) to create the database and all required tables.



Please find the sql query below.

-- 1. Create Database
CREATE DATABASE SuwasewanaDB;
GO

-- 2. Use Database
USE SuwasewanaDB;
GO

-- 3. Doctor Table
CREATE TABLE Doctor (
    AMCNo VARCHAR(50) NOT NULL PRIMARY KEY,
    DoctorName VARCHAR(100) NOT NULL,
    SpecializedFor VARCHAR(100),
    ContactNumber VARCHAR(12),
    Gender VARCHAR(10)
);
GO

-- 4. Patient Table
CREATE TABLE Patient (
    NIC VARCHAR(20) NOT NULL PRIMARY KEY,
    PatientName VARCHAR(100) NOT NULL,
    ContactNumber VARCHAR(15),
    Address VARCHAR(200),
    Gender VARCHAR(10),
    Age INT,
    Allergies VARCHAR(200),
    GuardianNIC VARCHAR(20)
);
GO

-- 5. Pharmacist Table
CREATE TABLE Pharmacist (
    LicenseNo VARCHAR(50) NOT NULL PRIMARY KEY,
    PharmacistName VARCHAR(100) NOT NULL,
    ContactNumber VARCHAR(12),
    Gender VARCHAR(10)
);
GO

-- 6. Users Table
CREATE TABLE Users (
    Username VARCHAR(50) NOT NULL PRIMARY KEY,
    Password VARCHAR(100) NOT NULL,
    Role VARCHAR(20) NOT NULL
);
GO

-- 7. Patient History Table
CREATE TABLE PatientHistory (
    HistoryID INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
    NIC VARCHAR(20) NOT NULL,
    VisitDate DATE NOT NULL,
    AMCNumber VARCHAR(30) NOT NULL,
    Prescription VARCHAR(MAX),

    CONSTRAINT FK_PatientHistory_Patient
    FOREIGN KEY (NIC) REFERENCES Patient(NIC)
);
GO
```

After executing the script successfully, the `SuwasewanaDB` database and all required tables will be created and the application will be ready to connect.
Thank you.
