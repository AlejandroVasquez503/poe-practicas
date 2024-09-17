CREATE TABLE Books (
    BookID INT PRIMARY KEY IDENTITY(1,1),
    Title NVARCHAR(100),
    Author NVARCHAR(100),
    YearPublished INT,
    Genre NVARCHAR(50)
);

-- Crear la tabla Members
CREATE TABLE Members (
    MemberID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100),
    JoinDate DATE,
    Email NVARCHAR(100),
    Phone NVARCHAR(15)
);

-- Crear la tabla Loans
CREATE TABLE Loans (
    LoanID INT PRIMARY KEY IDENTITY(1,1),
    BookID INT,
    MemberID INT,
    LoanDate DATE,
    ReturnDate DATE,
    FOREIGN KEY (BookID) REFERENCES Books(BookID),
    FOREIGN KEY (MemberID) REFERENCES Members(MemberID)
);

-- Insertar registros en la tabla Books
INSERT INTO Books (Title, Author, YearPublished, Genre)
VALUES 
('The Catcher in the Rye', 'J.D. Salinger', 1951, 'Fiction'),
('To Kill a Mockingbird', 'Harper Lee', 1960, 'Fiction'),
('1984', 'George Orwell', 1949, 'Dystopian'),
('The Great Gatsby', 'F. Scott Fitzgerald', 1925, 'Classic'),
('Moby Dick', 'Herman Melville', 1851, 'Adventure');

-- Insertar registros en la tabla Members
INSERT INTO Members (Name, JoinDate, Email, Phone)
VALUES
('John Doe', '2020-01-15', 'john@example.com', '555-1234'),
('Jane Smith', '2021-03-22', 'jane@example.com', '555-5678'),
('Emily Davis', '2019-11-03', 'emily@example.com', '555-9012'),
('Michael Brown', '2022-06-18', 'michael@example.com', '555-3456'),
('Sarah Johnson', '2018-07-25', 'sarah@example.com', '555-7890');

-- Insertar registros en la tabla Loans
INSERT INTO Loans (BookID, MemberID, LoanDate, ReturnDate)
VALUES
(1, 1, '2023-01-01', '2023-01-15'),
(2, 2, '2023-02-10', '2023-02-24'),
(3, 3, '2023-03-05', '2023-03-19'),
(4, 4, '2023-04-12', '2023-04-26'),
(5, 5, '2023-05-07', '2023-05-21');

SELECT * FROM Books;

SELECT * FROM Members;

SELECT * FROM Loans;

UPDATE Books
SET Genre = 'Literary Fiction'
WHERE BookID = 1;

UPDATE Members
SET Email = 'alejandro@example.com'
WHERE MemberID = 2;

UPDATE Loans
SET ReturnDate = '2025-02-28'
WHERE LoanID = 2;

DELETE FROM Books
WHERE BookID = 5;

DELETE FROM Members
WHERE MemberID = 4;

DELETE FROM Loans
WHERE LoanID = 5;
