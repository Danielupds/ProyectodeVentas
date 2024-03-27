create database ProyectoTienda


create table Producto2(
IDPRODUCTO INT IDENTITY (1,1) NOT NULL,
IDMARCA INT NOT NULL,
NOMBRE NVARCHAR (100) NOT NULL,
CODIGOBARRA NVARCHAR (20) NOT NULL,
UNIDAD INT NOT NULL,
DESCRIPCION NVARCHAR (100) NOT NULL,
ESTADO NVARCHAR (20) NOT NULL,
PRIMARY KEY (IDPRODUCTO),
FOREIGN KEY (IDMARCA) REFERENCES MARCA (IDMARCA),
);



insert into producto2 values (1, 1, 'Leche Pil', '21473658', 10, 'Leche', 'Activo');
insert into producto2 values (1, 2, 'Karpil', '46929107', 20, 'Karpil', 'Activo');
insert into Producto2 values (1, 1, 'PilFrut', '98166510', 15, 'Jugo', 'Activo');
insert into producto2 values (1, 2, 'Leche Pasteorizada', '85119692', 10, 'Leche', 'Activo');
insert into producto2 values (1, 1, 'Pura Vida', '56251184', 30, 'Zumo', 'Activo');
insert into producto2 values (1, 2, 'Yogurt Boy', '38398949', 20, 'Yogurt', 'Activo');
insert into producto2 values (2, 3, 'Coca Cola', '48076473', 30, 'Gaseosa', 'Activo');
insert into producto2 values (2, 3, 'Sprit', '48076473', 30, 'Gaseosa', 'Activo');
insert into producto2 values (2, 3, 'Fanta', '50932492', 30, 'Gaseosa', 'Activo');
insert into producto2 values (2, 3, 'Pepsi', '62482802', 30, 'Gaseosa', 'Activo');
insert into producto2 values (2, 3, 'Cascada', '23895762', 30, 'Gaseosa', 'Activo');
insert into producto2 values (3, 4, 'Pavo', '47485907', 20, 'Embutido de Pavo', 'Activo');
insert into producto2 values (3, 4, 'Pollo', '64743925', 40, 'Embutido de Pavo', 'Activo');
insert into producto2 values (3, 4, 'Cerdo', '58020589', 25, 'Embutido de Pavo', 'Activo');

select * from Producto2