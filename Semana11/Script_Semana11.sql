Use Negocios2018

go

Create table tb_caracteristica(
	idCar char(4) primary key,
	desCar varchar(100))

go

Create table tb_herramienta(
	idHer 	char(7), 
	desHer 	varchar(100),
	idCar   char(4) references tb_caracteristica,
	preUni	decimal(10,2),
	stock	int)
	
go

insert into tb_caracteristica values ('C001','Caracteristica 1');
insert into tb_caracteristica values ('C002','Caracteristica 2');
insert into tb_caracteristica values ('C003','Caracteristica 3');
insert into tb_caracteristica values ('C004','Caracteristica 4');
insert into tb_caracteristica values ('C005','Caracteristica 5');

go

insert into tb_herramienta values ('H000001','Pinza','C001',59.4,106);
insert into tb_herramienta values ('H000002','Cinta de enhebrar','C002',31.94,199);
insert into tb_herramienta values ('H000003','Cinta de enhebrar','C003',63.8,21);
insert into tb_herramienta values ('H000004','Cinto de seguridad','C004',66.02,118);
insert into tb_herramienta values ('H000005','Barrenas','C005',75.7,171);
insert into tb_herramienta values ('H000006','Barrenas','C001',91.67,150);
insert into tb_herramienta values ('H000007','Portamacho','C002',75.92,147);
insert into tb_herramienta values ('H000008','Pistola p/silicona ','C003',23.38,42);
insert into tb_herramienta values ('H000009','Pinza para terminales','C004',60.64,58);
insert into tb_herramienta values ('H000010','Disco para sierra','C005',47.41,184);
insert into tb_herramienta values ('H000011','Disco para sierra','C001',30.92,178);
insert into tb_herramienta values ('H000012','Disco para sierra','C002',36.11,136);
insert into tb_herramienta values ('H000013','Atornillador','C003',70.67,52);
insert into tb_herramienta values ('H000014','Mechas SDS p/hormigón','C004',94.26,191);
insert into tb_herramienta values ('H000015','Mechas SDS p/hormigón','C005',0.96,177);
insert into tb_herramienta values ('H000016','Mechas SDS p/hormigón','C001',59.02,182);
insert into tb_herramienta values ('H000017','Linterna minera','C002',42.36,109);
insert into tb_herramienta values ('H000018','Plomada','C003',42.52,145);
insert into tb_herramienta values ('H000019','Chaura','C004',85.92,65);
insert into tb_herramienta values ('H000020','Manguera','C005',92.39,94);
insert into tb_herramienta values ('H000021','Cabos','C001',28.66,198);
insert into tb_herramienta values ('H000022','Cabos','C002',88,83);
insert into tb_herramienta values ('H000023','Piqueta de albañil','C003',36.47,149);
insert into tb_herramienta values ('H000024','Martillo/chuela','C004',78.57,92);
insert into tb_herramienta values ('H000025','Guantes de goma','C005',23.52,141);
insert into tb_herramienta values ('H000026','Juego de mechas p/hierro','C001',31,193);
insert into tb_herramienta values ('H000027','Cinta eléctrica','C002',36.06,153);
insert into tb_herramienta values ('H000028','Cinta destapa caños','C003',65.84,62);
insert into tb_herramienta values ('H000029','Cinta destapa caños','C004',25.23,107);
insert into tb_herramienta values ('H000030','Terrajas','C005',44.62,133);
insert into tb_herramienta values ('H000031','Raw Plug','C001',2.14,43);
insert into tb_herramienta values ('H000032','Llave articulada','C002',50.9,89);
insert into tb_herramienta values ('H000033','Herramientas p/grifería','C003',62.28,58);
insert into tb_herramienta values ('H000034','Desobstructores','C004',97.12,196);
insert into tb_herramienta values ('H000035','Cajoneras P.V.C. p/transporte de herramientas','C005',26.02,189);
insert into tb_herramienta values ('H000036','Correas de torax fluorescentes','C001',20.77,99);
insert into tb_herramienta values ('H000037','Correas p/asegurar bultos','C002',56.36,196);
insert into tb_herramienta values ('H000038','Disco de corte','C003',48.73,199);
insert into tb_herramienta values ('H000039','Taladro eléctrico','C004',88.98,166);
insert into tb_herramienta values ('H000040','Megohmetro','C005',38.66,190);
insert into tb_herramienta values ('H000041','Respirador anti/gases','C001',41.4,112);
insert into tb_herramienta values ('H000042','Pulidora eléctrica manual','C002',29.58,95);
insert into tb_herramienta values ('H000043','Tester','C003',44.61,48);
insert into tb_herramienta values ('H000044','Piloto','C004',95.92,117);
insert into tb_herramienta values ('H000045','Compresor','C005',36.87,122);
insert into tb_herramienta values ('H000046','Metros digitales','C001',79.42,166);
insert into tb_herramienta values ('H000047','Trozador','C002',38.43,136);
insert into tb_herramienta values ('H000048','Zizalla corta hierro','C003',4.21,126);
insert into tb_herramienta values ('H000049','Escalera coliza','C004',37.34,123);
insert into tb_herramienta values ('H000050','Escalera coliza','C005',9.4,53);
insert into tb_herramienta values ('H000051','Escalera coliza','C001',76.25,75);
insert into tb_herramienta values ('H000052','Escalera coliza','C002',87.99,145);
insert into tb_herramienta values ('H000053','Pala p/pilotes','C003',41.96,133);
insert into tb_herramienta values ('H000054','Máscaras respiratorias','C004',2.44,151);
insert into tb_herramienta values ('H000055','Garrafa','C005',33.06,69);
