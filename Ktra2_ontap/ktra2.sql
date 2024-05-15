
CREATE TABLE tblmausac (
    mamau NVARCHAR(20) PRIMARY KEY,
    tenmau NVARCHAR(50)
)
CREATE TABLE tblhanghoa (
    mahang NVARCHAR(50) PRIMARY KEY,
    tenhang NVARCHAR(50),
    mamau NVARCHAR(20),
    soluong float,
    thoigianbaohanh float,
    FOREIGN KEY (mamau) REFERENCES tblmausac(mamau)
)

insert into tblmausac (mamau, tenmau) values ('cl01', 'mau do')
insert into tblmausac (mamau, tenmau) values ('cl02', 'mau xanh')
insert into tblmausac (mamau, tenmau) values ('cl03', 'mau vang')

insert into tblhanghoa (mahang, tenhang, mamau, soluong, thoigianbaohanh) values 
('h01','giay xinh', 'cl01', 30, 3)
insert into tblhanghoa (mahang, tenhang, mamau, soluong, thoigianbaohanh) values 
('h02','giay dep', 'cl02', 30, 3)
insert into tblhanghoa (mahang, tenhang, mamau, soluong, thoigianbaohanh) values 
('h03','giay xin', 'cl03', 30, 3)

select * from tblhanghoa;
select * from tblmausac;

drop table tblhanghoa;
drop table tblmausac;
