--使用master数据库
use master
go
--判断数据库是否存在
if exists(select 1 from sys.databases where name='MySchool')
begin
	drop database MySchool
end
go
--创建MySchool数据库
create database MySchool
go
--使用MySchool数据库
use MySchool
go
--判断用户信息表是否存在
if exists(select 1 from sys.objects where name='UserInfo')
	drop table UserInfo
go
--创建用户信息表
create table UserInfo
(
	--用户编号
	userId int identity primary key,
	--用户名
	userName varchar(20) unique not null,
	--密码
	userPwd varchar(20) not null
)
go
--判断班级信息表是否存在
if exists (select 1 from sys.objects where name='ClassInfo')
begin
	drop table ClassInfo
end
go
--创建班级信息表
create table ClassInfo
(
	--班级编号
	classId int primary key not null identity,
	--班级名称
	className varchar(20) not null unique,
	--代课老师
	teacher varchar(20) not null,
	--备注信息
	remark varchar(50)
)
go
--判断学生信息表是否存在
if exists (select 1 from sys.objects where name='StuInfo')
begin
	drop table StuInfo
end
go
--创建学生信息表
create table StuInfo
(
	--学生编号
	stuId int primary key identity,
	--班级编号
	classId int references ClassInfo(classId) not null,
	--学生姓名
	stuName varchar(20) not null,
	--学生性别
	stuSex char(2) not null,
	--电话号码
	stuPhone varchar(20),
	--备注信息
	Remark varchar(30) 
)
go
--向班级信息表中插入数据
insert into classInfo values('1802','老代','这个班很踏实')
insert into classInfo values('1803','老向','这个班学得很好')
insert into classInfo values('1804','老许',null)
insert into classInfo values('1805','老张','这个班，一言难尽。。。。')
insert into classInfo values('1806','老张','这个班，无法形容。。。。')
insert into classInfo values('1807','老刘',null)
insert into classInfo values('1808','老刘',null)
insert into classInfo values('1809','大张','这个班非常优秀')

--向学生信息表中插入数据
insert into stuInfo values(1,'小小','女','12242134324',null)
insert into stuInfo values(1,'小花','女','5254542656',null)
insert into stuInfo values(1,'花朵','男','5635365656',null)
insert into stuInfo values(1,'朵星','男','6563765653',null)
insert into stuInfo values(2,'大大','男','53465435345',null)
insert into stuInfo values(2,'大花','女','52542545454',null)
insert into stuInfo values(2,'花草','女','4524545435',null)
insert into stuInfo values(3,'中中','男','53454353454',null)
insert into stuInfo values(3,'中天','男','5423543543',null)
insert into stuInfo values(3,'天天','女','52524543254',null)
insert into stuInfo values(3,'天飞飞','女','352532532',null)
insert into stuInfo values(3,'飞儿','男','3424324234',null)
insert into stuInfo values(4,'阿米','女','636546',null)
insert into stuInfo values(4,'米香','男','5432543543',null)
insert into stuInfo values(4,'香令','女','563635653',null)
insert into stuInfo values(5,'听雨','女','3545435435',null)
insert into stuInfo values(5,'雨下','男','54354354',null)
insert into stuInfo values(5,'下翠','女','65929326492',null)
insert into stuInfo values(5,'翠花','女','54354354354',null)
insert into stuInfo values(6,'芳玉','女','763767663',null)
insert into stuInfo values(6,'玉划','男','52455464356',null)
insert into stuInfo values(6,'划线','男','435435346536',null)
insert into stuInfo values(7,'铃铛','女','58585656',null)
insert into stuInfo values(7,'铛响','男','652656546',null)
insert into stuInfo values(7,'响响','男','53543543',null)
insert into stuInfo values(8,'果果','女','3423546',null)
insert into stuInfo values(8,'菜菜','男','654645654',null)
insert into stuInfo values(8,'匆匆','男','6546547474',null)
--想用户信息表插入数据
insert into UserInfo values('admin','123456')
insert into UserInfo values('zhangsan','123456')
insert into UserInfo values('lisi','123456')

--查看数据
select * from classInfo
select * from stuInfo
select * from UserInfo

select className 班级名称, stuName 学生姓名,stuSex 学生性别,stuPhone 学生电话,ClassInfo.Remark 备注信息
from classInfo join stuInfo on classInfo.classId= stuInfo.classid where className='1805'

select className from ClassInfo 