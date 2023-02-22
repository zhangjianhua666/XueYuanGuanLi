--ʹ��master���ݿ�
use master
go
--�ж����ݿ��Ƿ����
if exists(select 1 from sys.databases where name='MySchool')
begin
	drop database MySchool
end
go
--����MySchool���ݿ�
create database MySchool
go
--ʹ��MySchool���ݿ�
use MySchool
go
--�ж��û���Ϣ���Ƿ����
if exists(select 1 from sys.objects where name='UserInfo')
	drop table UserInfo
go
--�����û���Ϣ��
create table UserInfo
(
	--�û����
	userId int identity primary key,
	--�û���
	userName varchar(20) unique not null,
	--����
	userPwd varchar(20) not null
)
go
--�жϰ༶��Ϣ���Ƿ����
if exists (select 1 from sys.objects where name='ClassInfo')
begin
	drop table ClassInfo
end
go
--�����༶��Ϣ��
create table ClassInfo
(
	--�༶���
	classId int primary key not null identity,
	--�༶����
	className varchar(20) not null unique,
	--������ʦ
	teacher varchar(20) not null,
	--��ע��Ϣ
	remark varchar(50)
)
go
--�ж�ѧ����Ϣ���Ƿ����
if exists (select 1 from sys.objects where name='StuInfo')
begin
	drop table StuInfo
end
go
--����ѧ����Ϣ��
create table StuInfo
(
	--ѧ�����
	stuId int primary key identity,
	--�༶���
	classId int references ClassInfo(classId) not null,
	--ѧ������
	stuName varchar(20) not null,
	--ѧ���Ա�
	stuSex char(2) not null,
	--�绰����
	stuPhone varchar(20),
	--��ע��Ϣ
	Remark varchar(30) 
)
go
--��༶��Ϣ���в�������
insert into classInfo values('1802','�ϴ�','������̤ʵ')
insert into classInfo values('1803','����','�����ѧ�úܺ�')
insert into classInfo values('1804','����',null)
insert into classInfo values('1805','����','����࣬һ���Ѿ���������')
insert into classInfo values('1806','����','����࣬�޷����ݡ�������')
insert into classInfo values('1807','����',null)
insert into classInfo values('1808','����',null)
insert into classInfo values('1809','����','�����ǳ�����')

--��ѧ����Ϣ���в�������
insert into stuInfo values(1,'СС','Ů','12242134324',null)
insert into stuInfo values(1,'С��','Ů','5254542656',null)
insert into stuInfo values(1,'����','��','5635365656',null)
insert into stuInfo values(1,'����','��','6563765653',null)
insert into stuInfo values(2,'���','��','53465435345',null)
insert into stuInfo values(2,'��','Ů','52542545454',null)
insert into stuInfo values(2,'����','Ů','4524545435',null)
insert into stuInfo values(3,'����','��','53454353454',null)
insert into stuInfo values(3,'����','��','5423543543',null)
insert into stuInfo values(3,'����','Ů','52524543254',null)
insert into stuInfo values(3,'��ɷ�','Ů','352532532',null)
insert into stuInfo values(3,'�ɶ�','��','3424324234',null)
insert into stuInfo values(4,'����','Ů','636546',null)
insert into stuInfo values(4,'����','��','5432543543',null)
insert into stuInfo values(4,'����','Ů','563635653',null)
insert into stuInfo values(5,'����','Ů','3545435435',null)
insert into stuInfo values(5,'����','��','54354354',null)
insert into stuInfo values(5,'�´�','Ů','65929326492',null)
insert into stuInfo values(5,'�仨','Ů','54354354354',null)
insert into stuInfo values(6,'����','Ů','763767663',null)
insert into stuInfo values(6,'��','��','52455464356',null)
insert into stuInfo values(6,'����','��','435435346536',null)
insert into stuInfo values(7,'����','Ů','58585656',null)
insert into stuInfo values(7,'����','��','652656546',null)
insert into stuInfo values(7,'����','��','53543543',null)
insert into stuInfo values(8,'����','Ů','3423546',null)
insert into stuInfo values(8,'�˲�','��','654645654',null)
insert into stuInfo values(8,'�Ҵ�','��','6546547474',null)
--���û���Ϣ���������
insert into UserInfo values('admin','123456')
insert into UserInfo values('zhangsan','123456')
insert into UserInfo values('lisi','123456')

--�鿴����
select * from classInfo
select * from stuInfo
select * from UserInfo

select className �༶����, stuName ѧ������,stuSex ѧ���Ա�,stuPhone ѧ���绰,ClassInfo.Remark ��ע��Ϣ
from classInfo join stuInfo on classInfo.classId= stuInfo.classid where className='1805'

select className from ClassInfo 