CREATE DATABASE UsersAwards

ALTER DATABASE UsersAwards
COLLATE Cyrillic_General_100_CI_AI
GO

USE UsersAwards

CREATE TABLE Users
(
    IdUser int NOT NULL IDENTITY(1,1) CONSTRAINT PK_Users PRIMARY KEY,
    FirstName nvarchar(20) NOT NULL,
	LastName nvarchar(20) NOT NULL,
	DateOfBirth Date NOT NULL,
	Age int NOT NULL
)
GO 

CREATE TABLE Awards
(
    IdAward int NOT NULL IDENTITY(1,1) CONSTRAINT PK_Awards PRIMARY KEY,
    Title nvarchar(50) NOT NULL
)
GO 

CREATE TABLE Users_Awards
(
    Id_users int NOT NULL,
	Id_awards int NOT NULL
)
GO 

ALTER TABLE Users_Awards
ADD
CONSTRAINT FK_Awards_Users
FOREIGN KEY (Id_users) REFERENCES Users (IdUser)

ALTER TABLE Users_Awards
ADD
CONSTRAINT FK_Users_Awards
FOREIGN KEY (Id_awards) REFERENCES Awards (IdAward)



INSERT INTO Users
VALUES
('������', '���������', '1799-06-06', 221),
('��������', '������', '1891-01-15', 129),
('��������', '������', '1941-09-03', 79),
('���������', '������', '1814-10-15', 206);
GO

INSERT Awards
(Title)
VALUES
('��� ��������, ����� ��. �. ���������'),
('������ �������'),
('������ �������� ������ �������'),
('������ ������������� ���-�����'),
('����� ������� ���������� 3-� ������� (1884)'),
('����� ���� � ������ 2-� �������');
GO

INSERT INTO Users_Awards 
VALUES
(1, 2),
(2, 1),
(3, 4),
(4, 5),
(4, 6),
(1, 3),
(2, 3),
(3, 3),
(4, 3);
GO






