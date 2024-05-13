CREATE DATABASE [QLKhachSan]

GO
USE  QLKhachSan
GO
-- TẠO TÀI KHOẢN
CREATE TABLE TaiKhoan
(
	UserName NVARCHAR(100) PRIMARY KEY not null,
	DisplayName NVARCHAR(100) not null,
	PassWord NVARCHAR(1000) not null ,
	idQuyen INT not null,
	FOREIGN KEY (idQuyen) REFERENCES dbo.Quyen(Type)

)
GO

--TẠO QUYỀN TÀI KHOẢN
CREATE TABLE Quyen
(
	Type INT not null PRIMARY KEY ,
	TenQuyen NVARCHAR(20) 
)
GO
SELECT * FROM  TaiKhoan
SELECT a.UserName , a.DisplayName, b.TenQuyen FROM TaiKhoan a, Quyen b WHERE a.idQuyen = b.Type
--TẠO BẢNG KHÁCH HÀNG
CREATE TABLE KhachHang 
(
	id INT IDENTITY PRIMARY KEY,	
	name NVARCHAR(100) NOT NULL,
	sinhnam DATE NOT NULL,
	sdt INT NOT NULL,
	cccd INT NOT NULL,
	gioitinh NVARCHAR(20) NOT NULL,
	diachi NVARCHAR(200) NOT NULL DEFAULT N'Trống'
)
GO
SELECT * FROM TaiKhoan 

GO
--TẠO DANH SÁCH PHÒNG
CREATE TABLE Phong
(
	id INT IDENTITY PRIMARY KEY,	
	name NVARCHAR(100) NOT NULL,
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO
--TẠO ĐẶT PHÒNG
CREATE TABLE DatPhong
(
	id INT IDENTITY PRIMARY KEY, 
	TenKhachHang NVARCHAR(100) NOT NULL,
	PhongDat NVARCHAR(100) NOT NULL,
	NgayNhan DATE NOT NULL DEFAULT GETDATE(),
	NgayTra DATE,
	TamTinh DECIMAL (20, 3),
	DichVu NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO
--TẠO BẢNG VẬT TƯ
CREATE TABLE VatTu
(
	MaVatTu INT IDENTITY PRIMARY KEY,
	TenVatTu NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	SoLuong INT DEFAULT 1,
	DonGia DECIMAL(20,3) NOT NULL DEFAULT 0,
	GhiChu NVARCHAR(200)
)
SELECT * FROM VatTu
--TẠO DỊCH VỤ
CREATE TABLE DanhMuc
(
	id INT IDENTITY PRIMARY KEY,	
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO
CREATE TABLE DichVu
(
	id INT IDENTITY PRIMARY KEY,	
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idDichvu INT NOT NULL,
	price FLOAT NOT NULL
	FOREIGN KEY (idDichvu) REFERENCES dbo.DanhMuc(id)
)
GO
--TẠO BILL
CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,	
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idPhong INT NOT NULL,
	status int NOT NULL DEFAULT 0, 
	discount int DEFAULT 0,
	totalprice DECIMAL (20, 3)

	FOREIGN KEY (idPhong) REFERENCES dbo.Phong(id)
)
GO
SELECT b.DateCheckIn, b.DateCheckOut, b.id, p.name, b.status, b.discount,b.totalprice FROM Bill b, Phong p WHERE b.idPhong = p.id
ALTER TABLE Bill
ADD discount INT DEFAULT 0;


CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,	
	idBill INT NOT NULL,
	idDichVu INT NOT NULL,
	count INT NOT NULL DEFAULT 0

	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idDichVu) REFERENCES dbo.DichVu(id)
)
GO
--Thêm danh mục
INSERT dbo.DanhMuc
(name)
VALUES(N'Giá phòng')
INSERT dbo.DanhMuc
(name)
VALUES(N'Thức ăn')
--Thêm quyền
INSERT dbo.Quyen(Type , TenQuyen) VALUES (0, N'Người dùng')
INSERT dbo.Quyen(Type , TenQuyen) VALUES (1, N'Quản trị')
--Thêm tài khoản
INSERT dbo.TaiKhoan(UserName, DisplayName, PassWord, idQuyen) VALUES (N'admin',N'Người Quản Trị', 123, 1)
INSERT dbo.TaiKhoan(UserName, DisplayName, PassWord, idQuyen) VALUES (N'user',N'Người dùng', 123, 0)
-- Thêm dịch vụ
INSERT dbo.DichVu(name ,idDichvu, price)
VALUES (N'Tôm Alasca',
		2,
		1500000
)
INSERT dbo.DichVu(name ,idDichvu, price)
VALUES (N'4 ngày',
		1,
		250000
)
INSERT dbo.DichVu(name ,idDichvu, price)
VALUES (N'5 ngày',
		1,
		500000
)
--Thêm Phòng
DECLARE @i INT = 301

WHILE @i <=305
BEGIN
	INSERT dbo.Phong(name) VALUES (N'Phòng' + CAST(@i AS nvarchar(100)))
	SET @i = @i +1
END
GO

select * from Dichvu
select * from Bill
select * from BillInfo
DELETE from Bill WHERE id = 2
DELETE from BillInfo WHERE id = 4
--Thêm bill
INSERT dbo.Bill(DateCheckIn,DateCheckOut,idPhong,status)
VALUES (GETDATE(),
		null,
		1,
		0
)
--Thêm bill info
INSERT dbo.BillInfo(idBill, idDichVu ,count)
VALUES (2,1,3)

GO
--Thêm khách hàng
INSERT INTO KhachHang (name, sinhnam, sdt, cccd, gioitinh, diachi)
VALUES ('Nguyen Van A', '1990-01-01', 123456789, 987654321, 'Nam', N'123 Đường ABC, Quận XYZ')
INSERT INTO KhachHang (name, sinhnam, sdt, cccd, gioitinh, diachi)
VALUES ('Nguyen Van Lộc', '2000-03-03', 129922, 1256698, 'Nữ', N'12 Đường ABC, Quận YZ')
INSERT INTO KhachHang (name, sinhnam, sdt, cccd, gioitinh, diachi)
VALUES ('Nguyen Van Bác', '2003-01-05', 0369668, 98769321, 'Nam', N'456 Đường ABC, Quận Z')

GO
--Tạo PROC
ALTER PROC USP_GETLISTROOM
AS SELECT * FROM Phong WHERE name LIKE N'Phòng10%'
GO
CREATE PROC USP_GETLISTROOMTANG2
AS SELECT * FROM Phong WHERE name LIKE N'Phòng20%'
GO
CREATE PROC USP_GETLISTROOMTANG3
AS SELECT * FROM Phong WHERE name LIKE N'Phòng30%'
GO
CREATE PROC USP_GETLISTALLROOM
AS SELECT * FROM Phong 
GO

CREATE PROC USP_UpdateTaiKhoan
@userName NVARCHAR(100), @passWord NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT (*) FROM TaiKhoan WHERE UserName = @userName AND PassWord = @passWord
	IF(@isRightPass =1)
	BEGIN
		IF(@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE TaiKhoan SET PassWord = @newPassword WHERE UserName =@userName
		END
		
	END
		
END
GO
CREATE PROC USP_InsertBill
@idPhong INT
AS
BEGIN

	INSERT dbo.Bill
	(DateCheckIn,
	DateCheckOut,
	idPhong,
	status,
	discount)
VALUES (GETDATE(),
		null,
		@idPhong,
		0,
		0
)
END
GO
CREATE PROC USP_InsertBillInfo
@idBill INT, @idDichvu INT, @count INT
AS
BEGIN
	
	DECLARE @ExitBillInfo INT
	DECLARE @foodCount INT = 1
	SELECT @ExitBillInfo = id, @foodCount = COUNT FROM BillInfo WHERE idBill =@idBill AND idDichVu =@idDichvu
	IF(@ExitBillInfo > 0)
	BEGIN
		DECLARE @newCount INT = @foodCount + @count
		IF(@newCount > 0)
			UPDATE BillInfo SET count = @foodCount + @count WHERE idDichVu =@idDichvu
		ElSE
			DELETE BillInfo WHERE idBill =@idBill AND idDichVu =@idDichvu
	END
	ELSE
	BEGIN
		INSERT dbo.BillInfo(idBill, idDichVu,count)
		VALUES (@idBill, @idDichvu, @count)
	END
	

END
SELECT * FROM DichVu
GO


CREATE PROC USP_GetListBillDate	
@CheckIn date, @CheckOut date
as
BEGIN
	SELECT t.name as [Số Phòng],CAST(b.totalPrice AS DECIMAL(10,3)) as [Thành tiền], DateCheckIn as [Ngày vào], DateCheckOut as [Ngày ra], Discount as [Giảm giá]
	FROM dbo.Bill as b, dbo.Phong as t 
	WHERE DateCheckIn >=@CheckIn and DateCheckOut <= @CheckIn AND b.status =1 AND t.id = b.idPhong
END 
GO
select * from Phong
CREATE PROC USP_GetListDichVuThucAn
as 
BEGIN 
	SELECT id, name, price FROM DichVu WHERE idDichvu = 2
end
GO
CREATE PROC USP_GetListDichVuGiaPhong
as 
BEGIN 
	SELECT id, name, price FROM DichVu WHERE idDichvu = 1
end
GO

CREATE TRIGGER UTG_BillInfo
ON dbo.BillInfo FOR INSERT, UPDATE
AS
BEGIN
	DECLARE @idBill INT 
	SELECT @idBill = idBill FROM Inserted
	DECLARE @idPhong INT 
	SELECT @idPhong = idPhong FROM dbo.Bill WHERE id = @idBill AND status = 0
	DECLARE @count INT
	SELECT @count =COUNT(*) FROM dbo.BillInfo WHERE idBill =@idBill
	IF(@count > 0)
		UPDATE Phong SET status = N'Đang sử dụng' WHERE id = @idPhong
	ELSE
		UPDATE Phong SET status = N'Trống' WHERE id = @idPhong
END
GO

ALTER TRIGGER UTG_UpdateRoom
ON Phong for update
AS
BEGIN
	DECLARE @idPhong INT
	DECLARE @status NVARCHAR(100)

	SELECT @idPhong = id, @status = Inserted.status FROM Inserted

	DECLARE @idBill INT
	SELECT @idBill = id FROM dbo.Bill WHERE idPhong =@idPhong AND status = 0

	DECLARE @countBillInfo INT
	SELECT @countBillInfo = COUNT(*) FROM BillInfo WHERE idBill = @idBill

	IF(@countBillInfo > 0 AND @status <> N'Đang sử dụng')
		UPDATE Phong SET status = N'Đang sử dụng' WHERE id = @idPhong
	ELSE IF(@countBillInfo <= 0 AND @status <> N'Trống')
		UPDATE dbo.TableFood SET status = N'Trống' WHERE id = @idPhong
END 
UPDATE Phong SET status = N'Trống' WHERE id =1
GO
ALTER TRIGGER UTG_UpdateBill
ON dbo.Bill FOR UPDATE 
AS
BEGIN
	DECLARE @idBill INT
	SELECT @idBill = id FROM inserted
	DECLARE @idPhong INT
	SELECT @idPhong = idPhong FROM dbo.Bill WHERE id = @idBill
	DECLARE @count INT = 0
	SELECT @count =COUNT(*) FROM dbo.Bill WHERE idPhong =@idPhong AND status = 0
	IF (@count = 0)
		UPDATE Phong SET status = N'Trống' WHERE id = @idPhong
END
GO
CREATE TRIGGER UTG_DeleteBillInfo
ON dbo.BillInfo FOR DELETE
AS
BEGIN
	DECLARE @idBillInfo Int 
	DECLARE @idBill INT
	SELECT @idBillInfo = id, @idBill  = deleted.idBill FROM deleted
	DECLARE @idPhong INT
	SELECT @idPhong = idPhong FROM Bill WHERE id =@idBill
	DECLARE @count INT =0
	SELECT @count = COUNT(*) FROM BillInfo as bi, Bill as b WHERE b.id = bi.idBill and b.id =@idBill and b.status = 0
	IF(@count = 0)
		UPDATE Phong SET status  = N'Trống' WHERE id =@idPhong
END
GO
ALTER PROC USP_UpdateTaiKhoan 
@userName NVARCHAR(100), @displayName NVARCHAR(100), @passWord NVARCHAR(100), @newPassword NVARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT (*) FROM dbo.TaiKhoan WHERE UserName =@userName AND PassWord = @passWord
	IF(@isRightPass =1)
	BEGIN
		IF(@newPassword = NULL OR @newPassword = '')
		BEGIN
			UPDATE TaiKhoan SET DisplayName =@displayName WHERE UserName =@userName
		END
		ELSE
			UPDATE TaiKhoan SET DisplayName =@displayName, PassWord = @newPassword WHERE UserName =@userName
	END
		
END
GO

