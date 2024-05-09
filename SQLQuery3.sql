
use shivamindustries1;

create table items(item_name varchar(20) not null primary key ,item_size varchar(20),item_type varchar(20),item_no_packets int ,item_price int);

insert into items(item_name,item_size,item_type,item_no_packets,item_price) values ('2020','2*2','rough',20,450);
select * from items ;