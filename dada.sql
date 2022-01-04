drop database if exists hotel_db;
CREATE DATABASE hotel_db;
USE hotel_db;
/*create a table named hotel*/

create table hotel(
hotel_code varchar(256) Not NULL primary key,
hotel_name varchar(256) Not NULL,
hotel_city varchar(256) Not NULL,
hotel_st varchar(256) Not NULL,
star_Rating varchar(256) Not NULL
);


-- insert some sample data
insert into hotel values('Hotel', '3AOM', 'Assuit','The university street','5');


create table Employee(
em_ID double Not NULL,
hotel_code varchar(256) Not NULL,
first_name varchar(256) Not NULL,
last_name varchar(256) Not NULL,
salary double Not NULL,
city varchar(256) Not NULL,
Gender varchar(256) Not NULL,
birthday Date Not NULL,
phone double Not NULL,
primary key (em_ID),
foreign key (hotel_code) REFERENCES hotel(hotel_code)
);


create table Room(
Room_NO double Not NULL,
Room_Type varchar(256) Not NULL,
price_room double Not NULL,
Descripition varchar(256) Not NULL,
state varchar(256) Not NULL,
hotel_code   varchar(256) Not NULL,
primary key (Room_NO),
foreign key (hotel_code) REFERENCES hotel(hotel_code)
);


create table deleted_Room(
Room_NO double Not NULL,
Room_Type varchar(256) Not NULL,
price_room double Not NULL,
Descripition varchar(256) Not NULL
);

create table GUST(
Gust_ID double Not NULL,
first_name varchar(256) Not NULL,
last_name varchar(256) Not NULL,
Gender varchar(256) Not NULL,
passport double,
city varchar(256) Not NULL,
Phone_Number double Not NULL,
birthday Date Not NULL,
reserved varchar(256) Not NULL,
primary key (Gust_ID)
);


-- insert some sample data
insert into GUST values(1,'Omar','Gamal','Male',1234567891,'Assuit',01062626546,'2000/1/1','no');
insert into GUST values(2,'Mostafa','Hussien','Male',1234567892,'Assuit',203201316516,'1999/1/1','no');
insert into GUST values(3,'Ahmed','Abd Elrahem','Male',1234567893,'Assuit',13216161,'2000/1/1','no');
insert into GUST values(4,'Ahmed','Nabil','Male',1234567894,'Assuit',156516515,'1999/2/1','no');
insert into GUST values(5,'Mohamed','Gamal','Male',1234567895,'Assuit',12651615,'2000/1/1','no');

create table Booking(
Booking_ID double Not NULL,
Gust_ID double Not NULL,
Room_NO double Not NULL,
Booking_date Date Not NULL,
check_in_date Date Not NULL,
check_out_date Date Not NULL,
primary key (Booking_ID),
foreign key (Gust_ID) REFERENCES GUST(Gust_ID),
foreign key (Room_NO) REFERENCES Room(Room_NO)
);

create table Hotel_tel(
Hotel_code varchar(256) Not NULL,
phone varchar(256) Not NULL,
primary key (Hotel_code,phone),
foreign key (hotel_code) REFERENCES hotel(hotel_code)
);

-- insert some sample data
insert into Hotel_tel values('Hotel','01000000000');

create table Deleted_GUST(
Gust_ID double ,
first_name varchar(256) ,
last_name varchar(256) ,
Gender varchar(256) ,
passport double,
city varchar(256) ,
Phone_Number double ,
birthday Date 
);


create table Deleted_employee(
em_ID double Not NULL,
first_name varchar(256) Not NULL,
last_name varchar(256) Not NULL,
salary double Not NULL,
city varchar(256) Not NULL,
Gender varchar(256) Not NULL,
birthday Date Not NULL,
phone double Not NULL
);
create table admin(
user_name  varchar(256) Not NULL,
pass varchar(256) Not NULL,
primary key(user_name));


insert into admin values('admin','admin');


create table Room_img(
Room_NO double,
img varchar(256),
primary key (Room_NO,img),
foreign key (Room_NO) REFERENCES Room(Room_NO)
);
create table Room_img_deleted(
Room_NO double,
img varchar(256));
-- insert in hotel by procedure1
delimiter *
create procedure insert_into_hotel (hotel_code varchar(50),hotel_name varchar(50),hotel_city varchar(50),hotel_st varchar(50),Num_Room int,star_Rating varchar(50))
begin 
insert into hotel values(hotel_code,hotel_name,hotel_city,hotel_st,Num_Room,star_Rating);
end *
delimiter ;

-- insert in Employee by procedure2
delimiter *
create procedure insert_into_Employee (em_ID double,first_name varchar(50),last_name varchar(50),Gender varchar(50),salary double,city varchar(50),birthday Date,phone double)
begin 
insert into Employee values(em_ID,'Hotel',first_name,last_name,salary,city,Gender,birthday,phone);
end *
delimiter ;
-- call insert_into_Employee('e06','h06','fn','ln','male',1000,'qena','nagy hammadi','1999/07/24');

-- insert in Room by procedure3
delimiter *
create procedure insert_into_Room (Room_NO int,Room_Type varchar(256),price_room double,Description varchar(256))
begin 
insert into Room values(Room_NO,Room_Type,price_room,Description,'empty','Hotel');
end *
delimiter ;

-- insert in GUST by procedure4
delimiter *
create procedure insert_into_GUST (Gust_ID double,first_name varchar(256),last_name varchar(256),Gender varchar(256),passport double,city varchar(256),Phone_Number double,birthday Date )
begin 
insert into GUST values(Gust_ID,first_name,last_name,Gender,passport,city,Phone_Number,birthday,'no');
end *
delimiter ;

-- insert in Booking by procedure5
delimiter *
create procedure insert_into_Booking (Booking_ID varchar(256),Gust_ID double,Room_NO int,Booking_date Date,check_in_date Date,check_out_date Date)
begin 
insert into Booking values(Booking_ID,Gust_ID,Room_NO,Booking_date,check_in_date ,check_out_date );
end *
delimiter ;
 
-- insert in Hotel_tel by procedure6
delimiter *
create procedure insert_into_Hotel_tel (Hotel_code varchar(256),phone varchar(256))
begin 
insert into Hotel_tel values(Hotel_code,phone);
end *
delimiter ;


-- insert in Room_img by procedure7
delimiter *
create procedure insert_into_Room_img (Room_NO int,img varchar(256))
begin 
insert into Room_img values(Room_NO,img);
end *
delimiter ;


delimiter *
create procedure update_gust (GustID double,firstname varchar(256),lastname varchar(256),Gend varchar(256),pass_port double,cit varchar(256),PhoneNumber double,birth_day Date)
begin 
replace into gust(Gust_ID,first_name,last_name,Gender,passport,city,Phone_Number,birthday,reserved) values (GustID, firstname, lastname, Gend, pass_port, cit,PhoneNumber, birth_day,'no');
end *
delimiter ;
    
    
-- delete in GUST 
delimiter *
create procedure delete_into_GUST (GustID double)
begin 
delete from gust where Gust_ID =GustID;
end *
delimiter ;


delimiter *
create procedure delete_into_employee (employee_ID double)
begin 
delete from employee where em_ID =employee_ID;
end *
delimiter ;

delimiter //   
	create trigger room_before_delete   
    before delete on  room 
    for each row   
    begin   
		insert into deleted_Room values(old.Room_No,old.Room_Type,old.price_room,old.Descripition);
    end//  
delimiter ; 
 
delimiter //   
	create trigger roomimg_before_delete   
    before delete on  room_img 
    for each row   
    begin   
		insert into Room_img_deleted values(old.Room_No,old.img);
    end//  
delimiter ;  


delimiter //   
create trigger employee_before_delete   
after delete on employee   
for each row   
begin   
insert into deleted_employee values(old.em_ID,old.first_name,old.last_name,old.salary,old.city,old.Gender,old.birthday,old.phone);   
end//  
delimiter *

delimiter //   
create trigger gust_before_delete   
after delete on GUST   
for each row   
begin   
insert into Deleted_GUST values(old.Gust_ID,old.first_name,old.last_name,old.Gender,old.passport,old.city,old.Phone_Number,old.birthday);   
end//  
delimiter ;


delimiter * 
create procedure update_employee (em_ID double,first_name varchar(50),last_name varchar(50),Gender varchar(50),salary double,city varchar(50),birthday Date,phone double)
begin 
replace into employee(em_ID,hotel_code,first_name,last_name,salary,city,Gender,birthday,phone) values (em_ID,'Hotel',first_name,last_name,salary,city,Gender,birthday,phone);
end *
delimiter ;

delimiter * 
create procedure update_room (Room_NO int,Room_Type varchar(256),price_room double,Description varchar(256) )
begin 
replace into Room(Room_NO,Room_Type,price_room,Descripition,state,hotel_code) values (Room_NO,Room_Type,price_room,Description,'empty','Hotel');
end *
delimiter ;
delimiter * 
create procedure update_room_img (Room_NO int,img varchar(256))
begin 
replace into Room_img(Room_NO,img) values (Room_NO,img);
end *
delimiter ;

-- select * from Room where price_room = 1000;   
-- update Room set price_room = 10 where Room_NO = 6;  
-- select * from Room where Room_NO = 6; 