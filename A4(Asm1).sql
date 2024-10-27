CREATE DATABASE A4;
USE A4;
-- Table Employee (tạo trước vì có khóa ngoại tham chiếu từ bảng Users)
CREATE TABLE Employee(
    EmployeeID INT PRIMARY KEY,
    EmployeeName NVARCHAR(255),
    Gender VARCHAR(10),
    Email VARCHAR(255),
    Phone VARCHAR(15),
    BirthOfDate DATE
);

-- Table Users (tạo sau Employee)
CREATE TABLE Users (
    UserID INT PRIMARY KEY,
    UserName VARCHAR(50),
    Password VARCHAR(50),
    Role VARCHAR(10), -- "Admin" hoặc "User"
    EmployeeID INT,
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID)
);

-- Thêm một số người dùng ví dụ
INSERT INTO Users (UserID, UserName, Password, Role) 
VALUES 
(1, 'admin', 'admin123', 'Admin'),
(2, 'user1', 'user123', 'User');

-- Table Customer
CREATE TABLE Customer(
    CustomerID INT PRIMARY KEY,
    CustomerName NVARCHAR(255),
    Gender VARCHAR(10),
    BirthofDate DATE,
    Phone VARCHAR(15),
    Gmail VARCHAR(255)
);

-- Thêm dữ liệu vào bảng Customer
INSERT INTO Customer (CustomerID, CustomerName, Gender, BirthofDate, Phone, Gmail)
VALUES
(1, N'Hoàng Đình Khải', N'MALE', '2005-12-05', '0878922005', N'haan05122005@gmail.com'),
(2, N'Phạm Thị Ánh Tuyết', N'FEMALE', '2006-12-17', '0123456789', N'khaihoangdinh05@gmail.com'),
(3, N'Phạm Thị Ánh Thư', N'MALE', '2006-12-17', '0705158986', N'khaihoangdinh05@gmail.com');

-- Table Products
CREATE TABLE Products(
    ProductID INT PRIMARY KEY,
    ProductName NVARCHAR(MAX),
    ProductImage VARBINARY (MAX),
    SizeProduct VARCHAR(255),
    InventoryPrice DECIMAL(10,2),
    SellingPrice DECIMAL(10,2)
);

-- Table Statistic
CREATE TABLE Statistic (
    StatisticID INT PRIMARY KEY,
    ProductID INT,
    EmployeeID INT,
    CustomerID INT,
    QuantitySold INT,
    SaleDate DATE,
    TotalPrice DECIMAL(10,2),
    -- Khóa ngoại 
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (EmployeeID) REFERENCES Employee(EmployeeID),
    FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID)
);