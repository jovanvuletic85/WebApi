create database Vehicle
go

create table Brand(
BrandId int identity(1,1) not null primary key,
BrandName nvarchar(15) not null CONSTRAINT UQ_BrandName UNIQUE,
CountryOfOrigin nvarchar(15) not null
);

create table Model(
ModelId int identity(1,1) not null primary key,
BrandId int not null foreign key references Brand(BrandId),
ModelName nvarchar(15) not null CONSTRAINT UQ_ModelName UNIQUE,
YearsOfAge int not null,
Price money not null,
Fuel nvarchar(10) null CONSTRAINT DF_Fuel DEFAULT 'gasoline'
)

insert into Brand(BrandName,CountryOfOrigin)
values('Opel','Germany');

insert into Brand(BrandName,CountryOfOrigin)
values('Ford','USA');

insert into Brand(BrandName,CountryOfOrigin)
values('Peugeot','France');

insert into Model(BrandId,ModelName,YearsOfAge,Price,Fuel)
values(1,'Corsa',10,4999.00,'gasoline')

insert into Model(BrandId,ModelName,YearsOfAge,Price,Fuel)
values(1,'Astra',9,6999.00,'diesel')

insert into Model(BrandId,ModelName,YearsOfAge,Price,Fuel)
values(2,'Mondeo',4,8699.00,'gasoline')

insert into Model(BrandId,ModelName,YearsOfAge,Price,Fuel)
values(2,'Fiesta',7,5399.00,'gasoline')

insert into Model(BrandId,ModelName,YearsOfAge,Price,Fuel)
values(3,'207',5,5099.00,'diesel')

insert into Model(BrandId,ModelName,YearsOfAge,Price)
values(3,'307',6,6399.00)

select* from Model