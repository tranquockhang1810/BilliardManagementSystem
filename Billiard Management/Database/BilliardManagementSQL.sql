create database  BilliardManagement;

use BilliardManagement;

alter database BilliardManagement character set utf8mb4;

-- Tạo bảng

create table StoreInfo
(
		storeName char(100) not null default 'Chưa đặt tên',
        address char(100) not null default 'Chưa có địa chỉ',
        phone char(100) not null default '0123456789',
        email char(100),
        mailPassword char(100),
        pricePerHour double not null default 60000
);


create table BilliardTable
(
	tableID int auto_increment primary key,
    tableName char(100) not null default 'Chưa đặt tên bàn',
    tableStatus char(100) not null default 'Trống', -- (Trống | Có người)
    tableType char(100) not null, -- ( phăng |  lỗ)
    deleteStatus int not null default 1
) auto_increment = 1;


create table StaffRole
(
	roleID int auto_increment primary key,
    roleName char(100) not null default 'Chưa có tên',
    status int not null default 1
)auto_increment = 1;


create table Staff
(
	staffID char(100) primary key,
    staffName char(100) not null default 'Nhân viên mới',
    staffPhone char(100),
    staffEmail char(100),
    roleID int not null,
    status int not null default 1,
    
    foreign key (roleID) references staffrole(roleID)
);


create table LoginAccount
(
	staffID char(100) primary key,
    passWord char(255) not null default 'c4ca4238a0b923820dcc509a6f75849b',
    roleID int not null default 2,
    status int not null default 1,
    loginTime int not null default 0,
    
    foreign key (staffID) references staff(staffID),
    foreign key (roleID) references staffrole(roleID)
);


create table FoodCategory
(
	categoryID int auto_increment primary key,
    categoryName char(100) not null default 'Chưa đặt tên',
    status int not null default 1
)auto_increment = 1;


create table Food
(
	foodID int auto_increment primary key,
    foodName char(100) not null default 'Chưa đặt tên món',
    categoryID int not null,
    foodPrice double not null default 0,
    foodImage char(255) default 'Chưa có ảnh',
    status int not null default 1,
    
    foreign key(categoryID) references FoodCategory(categoryID)
)auto_increment = 1;


create table Bill
(
	billID int auto_increment primary key,
    tableID int not null,
    checkIn datetime not null default now(),
    checkOut datetime default null,
    discount int not null default 0,
    tablePrice double not null default 0,
    billTotalPrice double not null default 0,
    billStatus int not null default 0, -- 1: đã thanh toán || 0: chưa thanh toán
    staffID char(100) not null,
    
    foreign key(tableID) references BilliardTable(tableID),
    foreign key(staffID) references staff(staffID)
)auto_increment = 1;


create table BillInfo
(
	billInfoID int auto_increment primary key,
    billID int not null,
    foodID int not null,
    amount int not null default 0,
    
    foreign key (billID) references Bill(billID),
    foreign key (foodID) references Food(foodID)
)auto_increment = 1;

-- Thêm dữ liệu


insert into storeinfo (`storeName`, `address`, `email`, `mailPassword`) 
values ('Billiard For Life', '101 Nguyễn Văn A - P10 - Q10 - TP.HCM', 'billiardforlifeapps@gmail.com', 'yuwhjogdlyitsuhy');


DELIMITER //
CREATE PROCEDURE insert_billiardtableLo()
BEGIN
    DECLARE i INT DEFAULT 1;
    WHILE (i <= 10) DO
        INSERT INTO billiardtable(`tableName`, `tableType`) VALUES (CONCAT('Bàn ',i), 'Pool');
        SET i = i + 1;
    END WHILE;
END //
DELIMITER ;
call insert_billiardtableLo();
DROP PROCEDURE IF EXISTS insert_billiardtableLo;

DELIMITER //
CREATE PROCEDURE insert_billiardtablePhang()
BEGIN
    DECLARE i INT DEFAULT 11;
    WHILE (i <= 20) DO
        INSERT INTO billiardtable(`tableName`, `tableType`) VALUES (CONCAT('Bàn ',i), 'France');
        SET i = i + 1;
    END WHILE;
END //
DELIMITER ;
call insert_billiardtablePhang();
DROP PROCEDURE IF EXISTS insert_billiardtablePhang;


insert into StaffRole (`roleName`)
values ('Quản lý');
insert into StaffRole (`roleName`)
values ('Thu ngân');


insert into staff(`staffID`, `staffName`, `roleID`, `staffEmail`, `staffPhone`)
values ('NV001', 'Trần Quốc Khang', 1, 'fantacymaster1@gmail.com', '0829137177');


insert into LoginAccount(`staffID`,`passWord`, `roleID`)
values ('NV001','a3cbf05578a7d038970afe4ea0a7f296',1);


insert into foodcategory (`categoryName`)
values ('Ăn vặt');
insert into foodcategory (`categoryName`)
values ('Giải khát');
insert into foodcategory (`categoryName`)
values ('Mì');
insert into foodcategory (`categoryName`)
values ('Cà phê');
insert into foodcategory (`categoryName`)
values ('Cơm');
insert into foodcategory (`categoryName`)
values ('Trà');
insert into foodcategory (`categoryName`)
values ('Kem');
insert into foodcategory (`categoryName`)
values ('Bia');


insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Snack khoai tây', 1, 10000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Bò khô', 1, 35000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Cơm cháy', 5, 25000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Gà khô', 1, 30000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Khoai tây chiên', 1, 20000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cá viên chiên', 1, 20000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Kem ốc quế', 7, 10000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Kem Vani', 7, 10000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Kem Cá', 7, 15000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Bánh tráng trộn', 1, 12000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Xoài lắc', 1, 12000);


insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Sting', 2, 10000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Coca', 2, 10000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('7 Up', 2, 10000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Pepsi', 2, 10000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Bia SG', 8, 20000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Bia Tiger', 8, 22000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Strongbow', 2, 15000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Nước suối', 2, 10000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Bò húc', 2, 15000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Trà Ô Long', 6, 15000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Trà Đào', 6, 15000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cafe sữa đá', 4, 20000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cafe Campuchino', 4, 30000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cafe Americano', 4, 30000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Bia Heniken', 8, 20000);


insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Cơm chiên dương châu', 5, 40000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Cơm chiên hải sản', 5, 45000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Mì xào hải sản', 3, 30000);
insert into food (`foodName`, `categoryID`, `foodPrice`)
values ('Mì thịt bò trứng', 3, 25000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cơm Gà xối mỡ', 5, 40000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cơm tấm', 5, 40000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Cơm Trộn Hàn Quốc', 5, 35000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Mì trộn xá xíu', 3, 30000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Mì ramen', 3, 35000);
insert  into food(`foodName`, `categoryID`, `foodPrice`)
values ('Mì xào thị bò', 3, 40000);


delimiter //
create procedure USP_Login(prStaffID char(100), prPassWord char(100))
begin
	select * from loginaccount where staffID = prStaffID and passWord = prPassWord and status = 1;
    update loginaccount set loginTime = loginTime + 1 where staffID = prStaffID;
end //
delimiter ;


delimiter //
create procedure USP_InsertBill(prTableID int, prStaffID char(100))
begin
	insert into bill(`tableID`,`staffID`)
    values (prTableID, prStaffID);
end//
delimiter ;


delimiter //
CREATE PROCEDURE USP_InsertBillInfo(prBillID int, prFoodID int, prAmount int)
begin
	declare prExistedBillID int;
    declare prExistedAmount int ;
    declare prNewAmount int;
    set prExistedAmount = 1;
    
    select billID into prExistedBillID from billinfo
    where billinfo.billID = prBillID and billinfo.foodID = prFoodID;
    
    select amount into prExistedAmount from billinfo
    where billinfo.billID = prBillID and billinfo.foodID = prFoodID;
    
    if prExistedBillID is not null then
        set prNewAmount = prAmount;
        if prNewAmount > 0 then
			update billinfo set billinfo.amount = prAmount where billinfo.foodID = prFoodID;
		else
			delete from billinfo where billinfo.billID = prBillID and billinfo.foodID = prFoodID;
		end if ;
    else
		if prAmount > 0 then
			insert into billinfo(`billID`, `foodID`, `amount`)
			values (prBillID, prFoodID, prAmount);
		end if;
	end if ;
end //
delimiter ;


DELIMITER //
CREATE TRIGGER UTG_UpdateBillInfo_Insert
BEFORE INSERT ON billinfo
FOR EACH ROW
BEGIN
    DECLARE prTableID INT;
    
    SELECT tableID INTO prTableID FROM bill WHERE billID = NEW.billID AND billStatus = 0;
    
    UPDATE billiardtable SET tableStatus = 'Có người' WHERE tableID = prTableID;
END //
DELIMITER ;


DELIMITER //
CREATE TRIGGER UTG_UpdateBillInfo_Update
BEFORE UPDATE ON billinfo
FOR EACH ROW
BEGIN
    DECLARE prTableID INT;
    
    SELECT tableID INTO prTableID FROM bill WHERE billID = NEW.billID AND billStatus = 0;
    
    UPDATE billiardtable SET tableStatus = 'Có người' WHERE tableID = prTableID;
END //
DELIMITER ;


DELIMITER //
CREATE TRIGGER UTG_UpdateBill
AFTER UPDATE ON bill
FOR EACH ROW
BEGIN
    DECLARE prBillID INT;
    DECLARE prTableID INT;
    DECLARE prCount INT;
    
    SELECT billID INTO prBillID FROM bill WHERE billID = NEW.billID;
    SELECT tableID INTO prTableID FROM bill WHERE billID = prBillID;
    
    SET prCount = 0;
    SELECT COUNT(*) INTO prCount FROM bill WHERE tableID = prTableID AND billStatus = 0;
    
    IF (prCount = 0) THEN
        UPDATE billiardtable SET tableStatus = 'Trống' WHERE tableID = prTableID;
    END IF;
END //
DELIMITER ;


delimiter //
create procedure USP_ChangeTable(prTableID1 int, prTableID2 int)  
begin
    update bill set tableID = prTableID2 where billStatus = 0 and tableID = prTableID1;
end //
delimiter ;


delimiter //
create procedure USP_GetBillAmountByDate( prFromDate datetime, prToDate datetime)
begin
	select count(*) from bill where checkIn between prFromDate and prToDate and billStatus = 1;
end //
delimiter ;

delimiter //
CREATE PROCEDURE USP_GetBillList(prFromDate DATETIME,prToDate DATETIME,prPage INT, prRowPerPage int)
BEGIN
    DECLARE selectedRows INT;
    DECLARE exceptedRows INT;
    
    SET selectedRows = prRowPerPage;
    SET exceptedRows = (prPage - 1) * selectedRows;
    
    CREATE TEMPORARY TABLE BillShow AS
    SELECT b.billID, bt.tableName AS `Tên bàn`, st.staffName as `Tên thu ngân`, concat(DATE_FORMAT(b.checkIn, '%d-%m-%Y'), ' (', time_format(b.checkIn, '%H:%i'), ' - ', time_format(b.checkOut, '%H:%i'), ')') as `Ngày`,
    time_format(timediff(b.checkOut,b.checkIn),'%H:%i') as `Giờ chơi`, b.discount AS `Giảm giá (%)`, b.tablePrice as `Tiền bàn`, b.billTotalPrice AS `Tổng tiền`
    FROM bill AS b
    JOIN billiardtable AS bt ON b.tableID = bt.tableID
    JOIN staff as st on b.staffID = st.staffID
    WHERE b.checkIn BETWEEN prFromDate AND prToDate AND b.billStatus = 1;
    
    CREATE TEMPORARY TABLE ExcludedBills AS
    SELECT billID
    FROM BillShow
    ORDER BY billID
    LIMIT exceptedRows;
    SELECT b.*
    FROM BillShow AS b
    LEFT JOIN ExcludedBills AS eb ON b.billID = eb.billID
    WHERE eb.billID IS NULL
    LIMIT selectedRows;
    
    DROP TEMPORARY TABLE IF EXISTS BillShow;
    DROP TEMPORARY TABLE IF EXISTS ExcludedBills;
END //
delimiter ;

delimiter //
create procedure USP_GetFoodByCategory(prCategoryID int)
begin
	select foodID as `ID món`, foodName as `Tên món`, categoryName as `Tên danh mục`, foodPrice as `Đơn giá`, foodImage as `Hình ảnh`
    from food, foodcategory
    where food.categoryID = foodcategory.categoryID and food.categoryID = prCategoryID and food.status = 1;
end //
delimiter ;


delimiter //
create procedure USP_ChangePassword(prStaffID char(100) , prNewPassword char(100))
begin
	update loginaccount set passWord = prNewPassword where staffID = prStaffID;
end //
delimiter ;


delimiter //
create procedure USP_CheckEmail(prStaffID char(100) , prStaffEmail char(100))
begin
	select * from staff where staffID = prStaffID and staffEmail = prStaffEmail;
end //
delimiter ;


SET GLOBAL log_bin_trust_function_creators = 1;


delimiter //
CREATE FUNCTION `ClosestSearch`(inputText CHAR(100)) 
RETURNS CHAR(100)
BEGIN
    DECLARE outputText CHAR(100) DEFAULT '';
    DECLARE normalizedText CHAR(100) DEFAULT '';

    SET normalizedText = inputText;

    SET normalizedText = REPLACE(normalizedText, 'á', 'a');
    SET normalizedText = REPLACE(normalizedText, 'à', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ả', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ã', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ạ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ă', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ắ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ằ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ẳ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ẵ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ặ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'â', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ấ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ầ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ẩ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ẫ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'ậ', 'a');
    SET normalizedText = REPLACE(normalizedText, 'é', 'e');
    SET normalizedText = REPLACE(normalizedText, 'è', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ẻ', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ẽ', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ẹ', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ê', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ế', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ề', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ể', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ễ', 'e');
    SET normalizedText = REPLACE(normalizedText, 'ệ', 'e');
    SET normalizedText = REPLACE(normalizedText, 'í', 'i');
    SET normalizedText = REPLACE(normalizedText, 'ì', 'i');
    SET normalizedText = REPLACE(normalizedText, 'ỉ', 'i');
    SET normalizedText = REPLACE(normalizedText, 'ĩ', 'i');
    SET normalizedText = REPLACE(normalizedText, 'ị', 'i');
    SET normalizedText = REPLACE(normalizedText, 'ó', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ò', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ỏ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'õ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ọ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ô', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ố', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ồ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ổ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ỗ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ộ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ơ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ớ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ờ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ở', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ỡ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ợ', 'o');
    SET normalizedText = REPLACE(normalizedText, 'ú', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ù', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ủ', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ũ', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ụ', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ư', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ứ', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ừ', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ử', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ữ', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ự', 'u');
    SET normalizedText = REPLACE(normalizedText, 'ý', 'y');
    SET normalizedText = REPLACE(normalizedText, 'ỳ', 'y');
    SET normalizedText = REPLACE(normalizedText, 'ỷ', 'y');
    SET normalizedText = REPLACE(normalizedText, 'ỹ', 'y');
    SET normalizedText = REPLACE(normalizedText, 'ỵ', 'y');
    SET normalizedText = REPLACE(normalizedText, 'đ', 'd');
    
    SET outputText = LOWER(normalizedText);

    RETURN outputText;
END //
delimiter ;


SET GLOBAL log_bin_trust_function_creators = 0;


delimiter //
create procedure USP_ReportByDate(prDate datetime)
begin
	select sum(tablePrice) as `Tổng tiền bàn`, sum(billTotalPrice) - sum(tablePrice) as `Tổng tiền đồ ăn`,sum(billTotalPrice) as `Tổng doanh thu`
	from bill where date_format(checkIn, '%d-%m-%Y') = date_format(prDate, '%d-%m-%Y');
end //
delimiter ;

delimiter //
create procedure USP_ReportByMonth(prFromDate datetime, prToDate datetime)
begin
	select sum(tablePrice) as `Tổng tiền bàn`, sum(billTotalPrice) - sum(tablePrice) as `Tổng tiền đồ ăn`,sum(billTotalPrice) as `Tổng doanh thu`
	from bill where checkIn between prFromDate and prToDate ;
end //
delimiter ;


delimiter //
create procedure USP_GetPrintBill(prBillID int)
Begin
	SELECT
		b.billID as `Mã hóa đơn`, 
		concat(bt.tableName, ' - ', bt.tableType) AS `Tên bàn`, 
		st.staffName as `Tên thu ngân`, 
		concat(DATE_FORMAT(b.checkIn, '%d-%m-%Y'), ' (', time_format(b.checkIn, '%H:%i'), ' - ', time_format(b.checkOut, '%H:%i'), ')') as `Ngày`,
		time_format(timediff(b.checkOut,b.checkIn),'%H:%i') as `Giờ chơi`,
		b.discount AS `Giảm giá (%)`, b.tablePrice as `Tiền bàn`,
		b.billTotalPrice AS `Tổng tiền`
	FROM 
		bill AS b,
		billiardtable AS bt,
		staff as st
	where 
		b.tableID = bt.tableID and 
		b.staffID = st.staffID and 
		b.billStatus = 1 and
        b.billID = prBillID
	order by b.billID desc
	limit 1;
end //
delimiter ;
