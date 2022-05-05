create database QLSV
go

use QLSV
go

create table SV(
	maSV nchar(20) not null,
	tenSV nvarchar(30),
	ngaySinh nvarchar(20),
	gioiTinh nvarchar(20),
	diaChi nvarchar(20),
	constraint pk_SV primary key(maSV)
)

create table Lop(
	maLop nchar(20) primary key  not null,
	tenLop nvarchar(100),
	maSV nchar(20),
	
)
create table GV(
	maGV nchar(20) primary key not null,
	tenGV nvarchar(30),
	maLop nchar (20),
	ngaySinh nvarchar(20),
	gioiTinh nvarchar(20),
	email nvarchar(90),
	sdt nvarchar(20),


)
create table TaiKhoan(
	maSV nchar(20),
	maGV nchar(20),
	tenTk nchar(100) primary key not null,
	mK nchar(30) not null,
	quyenTruyCap nvarchar(15) not null,
	
)
create table Khoa(
	maKhoa nchar(20) primary key not null,
	tenKhoa nvarchar(100),
	maLop nchar(20),
	
)
create table MonHoc(
	maMon nchar(20) primary key not null,
	maSV nchar(20),
	tenMon nvarchar(100),
	hocKy nvarchar(50)
	
)
create table RangBuoc(
 id int primary key not null,
 tenSV nvarchar(30),
 tenKhoa nvarchar(100),
  tenLop nvarchar(100),
 tenMon nvarchar(100),
)

create table KetQua(
	maSV nchar(20) not null,
	tenSV nvarchar(30),
	tenLop nvarchar(100),
	tenMon nvarchar(110),
	diemTX float,
	diemThi float,
	diemTK float,
	diem4 float,
	diemChu nvarchar(10),
	hocky nvarchar(30),
	constraint pk_Kq primary key(maSV),
	
)
go
insert into SV values('sv01','Nguyen Huu An','22/03/2001','nam','Ha Noi')
insert into SV values('sv02','Tran Van Soai','12/06/2001','nam','Lao Cai')
insert into SV values('sv03','Bui Thi Tho','03/10/2001','nu','Hai Phong')
insert into SV values('sv04','Nguyen Van Chinh','16/03/2001','nam','Lang Son')
insert into SV values('sv05','Nguyen Ngoc Thuy','06/03/2000','nu','Nam Dinh')
insert into SV values('sv06','Nguyen Nam Son','11/06/2001','nam','Hai Duong')
insert into SV values('sv07','Nguyen Thi Thuy','20/01/2001','nu','Nam Dinh')
insert into SV values('sv08','Pham Manh Hung','17/07/2001','nam','Thai Binh')
insert into SV values('sv09','Vu Van Chuong','21/4/2001','nam','Bac Giang')
insert into SV values('sv10','Trinh Duy Thai','08/08/2001','nam','Ninh Binh')
insert into SV values('sv11','Nguyen Thuy Nga','31/08/2001','nu','Ha Nam')
insert into SV values('sv12','Nguyen Huy Nam','29/05/2001','nam','Bac Ninh')
insert into SV values('sv13','Pham Phi Vu','20/07/2001','nu','nam Dinh')
insert into SV values('sv14','Truong Viet Thang','09/09/2001','nam','Quang Ninh')
insert into SV values('sv15','Hoang Gia Bao','13/03/2001','nam','Phu Tho')
insert into SV values('sv16','Nguyen Thi Ngoc Nhi','12/02/2001','nu','Ha Noi')
insert into SV values('sv17','Vu Van Hieu','01/01/2001','nam','Ha Giang')
insert into SV values('sv18','Nguyen Thuy Tien','15/10/2001','nu','Nghe An')
insert into SV values('sv19','Lang Van Son','28/4/2002','nam','Yen Bai')
insert into SV values('sv20','Trinh Thai Bao','09/08/2001','nam','Soc Son')
insert into SV values('sv21','Nguyen Hang Nga','01/09/2001','nu','Ha Nam')
insert into SV values('sv22','Nguyen Huy Hoang','21/05/2001','nam','Dak Lak')
insert into SV values('sv23','Pham Phi Hung','24/07/2001','nu','Yen Bai')
insert into SV values('sv24','Truong Van Cao','09/01/2001','nam','Quang Ninh')
insert into SV values('sv25','Hoang Thai Luong','11/03/2001','nam','Binh Thuan')
insert into SV values('sv26','Nguyen Thi Ngoc ','11/07/2001','nu','Ha Noi')
insert into SV values('sv27','Vu Van Minh','09/01/2001','nam','Ha Giang')
insert into SV values('sv28','Nguyen Ngoc Hoa','15/10/2001','nu','Nghe An')

go
insert into Lop values('l01','He thong thong tin','sv1')
insert into Lop values('l02','My thuat','sv2')
insert into Lop values('l03','Ngon ngu Anh','sv3')
insert into Lop values('l04','Quan tri kinh doanh','sv4')
insert into Lop values('l05','Quan tri khach san','sv5')
insert into Lop values('l06','Quan tri lu hanh','sv6')
insert into Lop values('l07','Cong nghe thong tin','sv7')
insert into Lop values('l08','May','sv8')
insert into Lop values('l09','Thiet ke thoi trang','sv9')
insert into Lop values('l10','Cong nghe hoa','sv10')
insert into Lop values('l11','Khoa hoc may tinh','sv11')
insert into Lop values('l12','Ky thuat phan mem','sv12')
insert into Lop values('l13','Ke toan','sv13')
insert into Lop values('l14','Ngon ngu Han','sv14')
insert into Lop values('l15','Co khi','sv15')
insert into Lop values('l16','Co dien tu','sv16')
insert into Lop values('l17','Tu dong hoa','sv17')
insert into Lop values('l18','Cong nghe thuc pham','sv18')

go

insert into GV values('gv01','Tran Van Tu','l1','22/03/1980','nam','trantu@gmail.com',1234)
insert into GV values('gv02','Hoang Thi Toi','l2','12/03/1992','nu','hoangtoi@gmail.com',3456)
insert into GV values('gv03','Luu Kien Quoc','l3','22/06/1987','nam','luuquoc@gmail.com',4567)
insert into GV values('gv04','Nguyen Thi Ngoc','l4','06/12/1989','nu','nguyenngoc@gmail.com',7896)
insert into GV values('gv05','Nguyen Quoc Cuong','l5','09/11/1985','nam','cuong1985@gmail.com',3413)
insert into GV values('gv06','Dao Van Manh','l6','07/05/1986','nam','vanmanh86@gmail.com',6436)
insert into GV values('gv07','Do Ngoc Nhung','l7','01/12/1981','nu','donhung@gmail.com',5343)
insert into GV values('gv08','Nguyen Bich Thuy','l8','30/2/1978','nu','nguyenthuy@gmail.com',6546)
insert into GV values('gv09','Ngo Manh Hung','l9','21/12/1991','nam','hung@gmail.com',7854)
insert into GV values('gv10','Pham Phi Vu','l10','20/1/1984','nam','vupham84@gmail.com',6547)
insert into GV values('gv11','Khuat Manh Tien','l11','12/2/1983','nam','tien@gmail.com',9675)
insert into GV values('gv12','Nguyen Thuy Trang','l12','09/09/1981','nu','trang99@gmail.com',9899)
insert into GV values('gv13','Nguyen Hong Ngoc','l13','15/10/1982','nu','ngoc@gmail.com',5435)
insert into GV values('gv14','Nguyen Thi Hong Nhung','l14','06/12/1983','nu','nguyennhung@gmail.com',7654)
insert into GV values('gv15','Truong Van Hung','l15','06/12/1988','nam','truonghung@gmail.com',4356)
insert into GV values('gv16','Nguyen Kim Ngan','l16','02/03/1993','nu','kimngan93@gmail.com',4236)
insert into GV values('gv17','Pham Minh Chien','l17','16/08/1987','nam','phamchien@gmail.com',2343)
insert into GV values('gv18','Nguyen Thanh Cong','l18','30/08/1988','nu','cong88@gmail.com',8843)
insert into GV values('gv19','Nguyen Thi Thuy','l12','19/09/1981','nu','thuy@gmail.com',3242)
insert into GV values('gv20','Nguyen Hong Hoa','l13','30/10/1982','nu','hoa@gmail.com',8865)
insert into GV values('gv21','Nguyen Thi Hong ','l14','03/11/1983','nu','hong@gmail.com',7654)
insert into GV values('gv22','Truong Van Tuan','l15','10/06/1988','nam','tuan@gmail.com',1111)
insert into GV values('gv23','Nguyen Kim Thoa','l16','02/09/1991','nu','thoa@gmail.com',7348)
insert into GV values('gv24','Pham Minh Hien','l17','16/10/1987','nam','hien@gmail.com',0942)
insert into GV values('gv25','Nguyen Thanh Thai','l18','10/05/1988','nu','thai@gmail.com',7435)

go
insert into TaiKhoan values('sv01','gv01','nguyenhuuan','123456','sinhvien')
insert into TaiKhoan values('sv02','gv02','hoangtoi@gmail.com','123456','admin')
insert into TaiKhoan values('sv03','gv03','buithitho','123456','sinhvien')
insert into TaiKhoan values('sv04','gv04','nguyenngoc@gmail.com','123456','admin')
insert into TaiKhoan values('sv05','gv05','ngocthuy','123456','sinhvien')
insert into TaiKhoan values('sv06','gv06','vanmanh86@gmail.com','123456','admin')
insert into TaiKhoan values('sv07','gv07','nguyenthuy','123456','sinhvien')
insert into TaiKhoan values('sv08','gv08','nguyenthuy@gmail.com','123456','admin')
insert into TaiKhoan values('sv09','gv09','vanchuong','123456','sinhvien')
insert into TaiKhoan values('sv10','gv10','vupham84@gmail.com','123456','admin')
insert into TaiKhoan values('sv11','gv11','thuynga','123456','sinhvien')
insert into TaiKhoan values('sv12','gv12','trang99@gmail.com','123456','admin')
insert into TaiKhoan values('sv13','gv13','vupham','123456','sinhvien')
insert into TaiKhoan values('sv14','gv14','nguyennhung@gmail.com','123456','admin')
insert into TaiKhoan values('sv15','gv15','giabao','123456','sinhvien')
insert into TaiKhoan values('sv16','gv16','kimngan93@gmail.com','123456','admin')
insert into TaiKhoan values('sv17','gv17','vuhieu','123456','sinhvien')
insert into TaiKhoan values('sv18','gv18','cong88@gmail.com','123456','admin')
insert into TaiKhoan values('sv19','gv19','thuy@gmail.com','123456','admin')
insert into TaiKhoan values('sv20','gv20','hoa@gmail.com','123456','admin')
insert into TaiKhoan values('sv21','gv21','hangnga','123456','sinhvien')
insert into TaiKhoan values('sv22','gv22','huyhoang','123456','sinhvien')
insert into TaiKhoan values('sv23','gv23','thoa@gmail.com','123456','admin')
insert into TaiKhoan values('sv24','gv24','hien@gmail.com','123456','admin')
insert into TaiKhoan values('sv25','gv25','thailuong','123456','sinhvien')



go
insert into Khoa values('k01','Cong nghe thong tin','l01')
insert into Khoa values('k02','Nang khieu','l02')
insert into Khoa values('k03','Ngon ngu','l03')
insert into Khoa values('k04','Quan tri','l04')
insert into Khoa values('k05','Du lich','l05')
insert into Khoa values('k06','Co khi','l06')
insert into Khoa values('k07','Dien','l07')
insert into Khoa values('k08','Dien tu','l08')
insert into Khoa values('k09','Cong nghe o to','l09')
insert into Khoa values('k10','Ke toan kiem toan','l10')
insert into Khoa values('k11','Cong nghe hoa','l11')
insert into Khoa values('k12','Cong nghe may va thiet ke thoi trang','l12')
insert into Khoa values('k13','Khoa hoc co ban','l13')
insert into Khoa values('k14','Ly lua chinh tri Phap luat','l14')

go
insert into MonHoc values('m01','sv01','Lap trinh net','Hoc ky I')
insert into MonHoc values('m02','sv02','Ve chan dung','Hoc ky II')
insert into MonHoc values('m03','sv03','Tieng anh 2','Hoc ky II')
insert into MonHoc values('m04','sv04','Triet hoc','Hoc ky III')
insert into MonHoc values('m05','sv05','Lich su Dang cong sang Viet Nam','Hoc ky III')
insert into MonHoc values('m06','sv06','Tu tuong HCM','Hoc ky IV')
insert into MonHoc values('m07','sv07','Phap luat dai cuong','Hoc ky IV')
insert into MonHoc values('m08','sv08','Ky thuat lap trinh','Hoc ky II')
insert into MonHoc values('m09','sv09','Triet hoc','Hoc ky III')
insert into MonHoc values('m10','sv10','Co so du lieu','Hoc ky II')
insert into MonHoc values('m11','sv11','He quan tri co so du lieu SQL','Hoc ky III')
insert into MonHoc values('m12','sv12','Phat trien ung dung thuong mai dien tu','Hoc ky IV')
insert into MonHoc values('m13','sv13','Nguyen ly he dieu hanh','Hoc ky V')
insert into MonHoc values('m14','sv14','Toan cao cap','Hoc ky I')
insert into MonHoc values('m15','sv15','Lap trinh huong doi tuong','Hoc ky V')
insert into MonHoc values('m16','sv16','Tai chinh tien te','Hoc ky II')
insert into MonHoc values('m17','sv17','Ly thuyet thong ke','Hoc ky I')
insert into MonHoc values('m18','sv18','Thiet ke Web','Hoc ky III')
insert into MonHoc values('m19','sv19','Xac suat thong ke','Hoc ky III')
insert into MonHoc values('m20','sv20','Lap trinh java','Hoc ky IV')
insert into MonHoc values('m21','sv21','Sua chua o to','Hoc ky V')
insert into MonHoc values('m22','sv22','Toan cao cap','Hoc ky I')
insert into MonHoc values('m23','sv23','Phan tich luong giac','Hoc ky V')
insert into MonHoc values('m24','sv24','Bong ban','Hoc ky II')
insert into MonHoc values('m25','sv25','Bong chuyen','Hoc ky I')
insert into MonHoc values('m26','sv26','Bong ro','Hoc ky III')


go
insert into KetQua values('sv01','Nguyen Huu An','He thong thong tin','Lap trinh net',8.7,8.5,8.5,4,'A','Hoc ky I')
insert into KetQua values('sv02','Tran Van Soai','My thuat','Ve chan dung',6.5,8.8,8.1,3.5,'B+','Hoc ky II')
insert into KetQua values('sv03','Bui Thi Tho','Ngon ngu Anh','Tieng anh 2',9.5,7.9,8.4,3.5,'B+','Hoc ky II')
insert into KetQua values('sv04','Nguyen Van Chinh','Quan tri kinh doanh','Triet hoc',5.5,6.5,6.2,2.5,'C+','Hoc ky III')
insert into KetQua values('sv05','Nguyen Ngoc Thuy','Quan tri khach san','Lich su Dang cong san Viet Nam',5,6.5,6,3,'C','Hoc ky III')
insert into KetQua values('sv06','Nguyen Nam Son','Quan tri lu hanh','Tu tuong HCM',7,6,8.2,6,'B','Hoc ky IV')
insert into KetQua values('sv07','Nguyen Thi Thuy','Cong nghe thong tin','Phap lua dai cuong',7,8,5.6,7,'B','Hoc ky IV')
insert into KetQua values('sv08','Pham Manh Hung','May','Ky thuat lap trinh',5,6.5,6,4,'C','Hoc ky II')
insert into KetQua values('sv09','Vu Van Chuong','Thiet ke thoi trang','Triet hoc',4,8,8,7.5,'B','Hoc ky III')
insert into KetQua values('sv10','Tran Duy Thai','Cong nghe may','Co so du lieu',6,6.5,7,6,'C','Hoc ky II')
insert into KetQua values('sv11','Nguyen Thuy Nga','Khoa hoc may tinh','He quan tri so so du lieu SQL',8,9,10,8.5,'A','Hoc ky III')
insert into KetQua values('sv12','Nguyen Huy Nam','Ky thuat phan mem','Phat trien ung dung thuong mai dien tu',5.5,6.5,6.2,2.5,'C+','Hoc ky III')
insert into KetQua values('sv13','Pham Phi Vu','Ke toan','Nguyen ly he dieu hanh',7,6.5,7,8,'B+','Hoc ky IV')
insert into KetQua values('sv14','Truong Viet Thang','Ngon ngu Han','Toan cao cap',5,6.5,6.5,4.5,'C','Hoc ky I')
insert into KetQua values('sv15','Hoang Gia Bao','Co khi','lap trinh huong doi tuong',5.5,6,6,7.5,'C','Hoc ky V')
insert into KetQua values('sv16','Nguyen Thi Ngoc Nhi','Co dien tu','Tai chinh tien te',8,9,9,8.5,'A','Hoc ky II')
insert into KetQua values('sv17','Vu Van Hieu','Tu dong hoa','Ly thuyet thong ke',8,9,8,8,'A','Hoc ky I')
insert into KetQua values('sv18','Nguyen Thuy Tien','Cong nghe thuc pham','Thiet ke Web',8,9,10,8.5,'A','Hoc ky III')
insert into KetQua values('sv19','Lang Van Son','He thong thong tin','Xac suat thong ke',6,6.5,7,6,'C','Hoc ky III')
insert into KetQua values('sv20','Trinh Thai Bao','Co khi','Lap trinh java',8,9,10,8.5,'A','Hoc ky IV')
insert into KetQua values('sv21','Nguyen Hang Nga','Co dien tu','Sua chua o to',5.5,6.5,6.2,2.5,'C+','Hoc ky V')
insert into KetQua values('sv22','Nguyen Huy Hoang','Tu dong hoa','Toan cao cap',7,6.5,7,8,'B+','Hoc ky II')
insert into KetQua values('sv23','Pham Phi Hung','Cong nghe thuc pham','Phan tich luong giac',5,6.5,6.5,4.5,'C','Hoc ky I')
insert into KetQua values('sv24','Truong Van Cao','My thuat','Bong ban',5.5,6,6,7.5,'C','Hoc ky V')
insert into KetQua values('sv25','Hoang Thai Luong','Ngon ngu Anh','Bong chuyen',8,9,9,8.5,'A','Hoc ky I')
insert into KetQua values('sv26','Nguyen Thi Ngoc','Cong nghe thong tin','Bong ro',8,9,8,8,'A','Hoc ky III')
insert into KetQua values('sv27','Vu Van Minh','He thong thong tin','Cong nghe thuc pham',8,9,10,8.5,'A','Hoc ky III')



go 
insert into RangBuoc values(01,'Nguyen Huu An','Cong nghe thong tin','He thong thong tin','Lap trinh net')
insert into RangBuoc values(02,'Tran Van Soai','Nang khieu','My thuat','Ve chan dung')
insert into RangBuoc values(03,'Bui Thi Tho','Ngon ngu','Ngon ngu Anh','Tieng anh 2')
insert into RangBuoc values(04,'Nguyen Van Chinh','Quan tri','Quan tri kinh doanh','Triet hoc')
insert into RangBuoc values(05,'Nguyen Ngoc Thuy','Du lich','Quan tri khach san','Lich su Dang cong san Viet Nam')
insert into RangBuoc values(06,'Nguyen Nam Son','Co khi','Quan tri lu hanh','Tu tuong HCM')
insert into RangBuoc values(07,'Nguyen Thi Thuy','Cong nghe thong tin ','Cong nghe thong tin','Phap luat dai cuong')
insert into RangBuoc values(08,'Pham Manh Hung','Cong nghe may va thiet ke thoi tran','May','Ky thuat lap trinh')
insert into RangBuoc values(09,'Vu Van Chuong','Cong nghe may va thiet ke thoi tran','Thiet ke thoi trang','Triet hoc')
insert into RangBuoc values(10,'Tran Duy Thai','Cong nghe may va thiet ke thoi tran','Cong nghe may','Co so du lieu')
insert into RangBuoc values(11,'Nguyen Thuy Nga','Cong nghe thong tin','Khoa hoc may tinh','He quan tri co so lieu SQL')
insert into RangBuoc values(12,'Nguyen Huy Nam','Cong nghe cong tin','Ky thuat phan mem','Phat trien ung dung thuong mai dien tu')
insert into RangBuoc values(13,'Pham Phi Vu','Ke toan kiem toan','Ke toan','Nguyen ly he dieu hanh')
insert into RangBuoc values(14,'Truong Viet Thang','Ngon ngu','Ngon ngu Han','Toan cao cap')
insert into RangBuoc values(15,'Hoang Gia Bao','Co khi','Co khi','lap trinh huong doi tuong')
insert into RangBuoc values(16,'Nguyen Thi Ngoc Nhi','Dien tu','Co dien tu','Tai chinh tien te')
insert into RangBuoc values(17,'Vu Van Hieu','Dien tu','Tu dong hoa','Ly thuyet thong ke')
insert into RangBuoc values(18,'Nguyen Thuy Tien','Nang khieu','Cong nghe thuc phan','Thiet ke Web')
go

select *from SV
select *from Lop
select *from GV
select *from TaiKhoan
select *from Khoa
select *from MonHoc
select *from KetQua
select *from RangBuoc
