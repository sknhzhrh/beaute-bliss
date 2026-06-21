CREATE TABLE Customer (
    CustomerID INT IDENTITY(1,1) NOT NULL,
    Names NVARCHAR(100) NOT NULL,
    PhoneNo NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    Addresses NVARCHAR(200) NOT NULL,
    CONSTRAINT PK_Customer PRIMARY KEY (CustomerID)
);


CREATE TABLE Staffs (
    StaffID INT IDENTITY(1,1) NOT NULL,
    Names NVARCHAR(100) NOT NULL,
    Positions NVARCHAR(50) NOT NULL,
    PhoneNo NVARCHAR(20) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    CONSTRAINT PK_Staffs PRIMARY KEY (StaffID)
);


CREATE TABLE ServiceList (
    ServiceID INT IDENTITY(1,1) NOT NULL,
    ServiceName NVARCHAR(100) NOT NULL,
    Category NVARCHAR(50) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Duration NVARCHAR(50) NOT NULL,
    CONSTRAINT PK_ServiceList PRIMARY KEY (ServiceID)
);


CREATE TABLE Products (
    ProductID INT IDENTITY(1,1) NOT NULL,
    ProductName NVARCHAR(100) NOT NULL,
    Brand NVARCHAR(100) NOT NULL,
    Price DECIMAL(10,2) NOT NULL,
    Quantity INT NOT NULL,
    CONSTRAINT PK_Products PRIMARY KEY (ProductID)
);


CREATE TABLE Booking (
    BookingID INT IDENTITY(1,1) NOT NULL,
    CustomerID INT NOT NULL,
    StaffID INT NOT NULL,
    ServiceID INT NOT NULL,
    BookingDate DATE NOT NULL,
    BookingTime TIME NOT NULL,
    BookStatus NVARCHAR(50) NOT NULL,

    CONSTRAINT PK_Booking PRIMARY KEY (BookingID),
    CONSTRAINT FK_Booking_Customer FOREIGN KEY (CustomerID) REFERENCES Customer(CustomerID),
    CONSTRAINT FK_Booking_Staffs FOREIGN KEY (StaffID) REFERENCES Staffs(StaffID),
    CONSTRAINT FK_Booking_ServiceList FOREIGN KEY (ServiceID) REFERENCES ServiceList(ServiceID)
);


CREATE TABLE Payment (
    PaymentID INT IDENTITY(1,1) NOT NULL,
    BookingID INT NULL,
    ProductID INT NULL,
    PaymentMethod NVARCHAR(50) NOT NULL,
    Total DECIMAL(10,2) NOT NULL,
    PaymentDate DATE NOT NULL,

    CONSTRAINT PK_Payment PRIMARY KEY (PaymentID),
    CONSTRAINT FK_Payment_Booking FOREIGN KEY (BookingID) REFERENCES Booking(BookingID),
    CONSTRAINT FK_Payment_Products FOREIGN KEY (ProductID) REFERENCES Products(ProductID)
);
