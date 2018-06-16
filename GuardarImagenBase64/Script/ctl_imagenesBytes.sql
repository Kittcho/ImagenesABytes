-- drop table ctl_imagenesBytes
Create table ctl_imagenesBytes
(
	id serial,
	nom_imagen varchar(150),
	arr_bytes bytea
);



select * from ctl_imagenesBytes

select length(arr_bytes) from ctl_imagenesBytes -- 1048576


SELECT id,nom_imagen FROM ctl_imagenesBytes

SELECT arr_bytes FROM ctl_imagenesBytes WHERE id = 