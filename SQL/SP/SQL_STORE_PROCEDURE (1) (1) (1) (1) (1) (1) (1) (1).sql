
CREATE OR ALTER PROC [dbo].[spCategoria]
(
	@Accion			INT,
	@P_IdCategoria	INT = NULL,
	@P_Descripcion	NVARCHAR(15) = NULL
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN
		
		SET @Validacion=0;

			IF NOT EXISTS ( SELECT 1 FROM CATEGORIA WHERE Descripcion= @P_Descripcion) 
			BEGIN 
				SET @Validacion=@Validacion+1;
				
				INSERT INTO CATEGORIA (Descripcion) VALUES (UPPER(@P_Descripcion));
			END
			ELSE
			BEGIN
				SELECT 1 AS '1' ;
				RETURN 1;
				SET @Validacion=0;
			END

		
	END

	IF @Accion = 2 -- Leer
	BEGIN
		
		SELECT * FROM CATEGORIA;

		
	END

	IF @Accion = 3 --ACCION PARA EDITAR LOS REGSITROS EXISTENTES
			BEGIN


				UPDATE CATEGORIA
					SET 
					
						Descripcion=@P_Descripcion
				WHERE
					Id_Categoria = @P_IdCategoria
		END

	IF @Accion = 4 -- Delete especial verificando que no existan productos con el id de categoria a eliminar
	BEGIN
		
		SET @Validacion=0;

			IF NOT EXISTS ( SELECT 1 FROM PRODUCTO WHERE Id_Categoria= @P_IdCategoria) 
			BEGIN 
				SET @Validacion=@Validacion+1;
				DELETE  FROM CATEGORIA  WHERE Id_Categoria = @P_IdCategoria;
			END
			ELSE
			BEGIN
				SELECT 1 AS '1' ;
				RETURN 1;
				SET @Validacion=0;
			END

		
	END


	IF @Accion = 5 -- Leer Descripcion
	BEGIN
		
		SELECT Id_Categoria,Descripcion FROM CATEGORIA;

		
	END

	IF @Accion = 6 -- Leer Descripcion
	BEGIN
		
		SELECT Id_Categoria FROM CATEGORIA WHERE Descripcion=@P_Descripcion;

		
	END


	

	IF @Accion = 7 -- Leer Descripcion cuando el ID_Categoria sea el que busques
	BEGIN
		
		SELECT Descripcion FROM CATEGORIA WHERE Id_Categoria=@P_IdCategoria;

		
	END

END
GO

CREATE OR ALTER PROC [dbo].[spMedida]
(
	@Accion			INT,
	@P_IdMedida	INT = NULL,
	@P_Descripcion	NVARCHAR(15) = NULL
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN
		
		SET @Validacion=0;

			IF NOT EXISTS ( SELECT 1 FROM MEDIDA WHERE Descripcion= @P_Descripcion) 
			BEGIN 
				SET @Validacion=@Validacion+1;
				
				INSERT INTO MEDIDA (Descripcion) VALUES (UPPER(@P_Descripcion));
			END
			ELSE
			BEGIN
				SELECT 1 AS '1' ;
				RETURN 1;
				SET @Validacion=0;
			END

		
	END

	IF @Accion = 2 -- Leer
	BEGIN
		
		SELECT * FROM MEDIDA;

		
	END

	IF @Accion = 3 --ACCION PARA EDITAR LOS REGSITROS EXISTENTES
			BEGIN


				UPDATE MEDIDA
					SET 
					
						Descripcion=@P_Descripcion
				WHERE
					Id_Medida = @P_IdMedida


					


		END

	IF @Accion = 4 -- Delete especial verificando que no existan productos con el id de categoria a eliminar
	BEGIN
		
		SET @Validacion=0;

			IF NOT EXISTS ( SELECT 1 FROM PRODUCTO WHERE Id_Medida= @P_IdMedida) 
			BEGIN 
				SET @Validacion=@Validacion+1;
				DELETE  FROM MEDIDA  WHERE Id_Medida = @P_IdMedida;
			END
			ELSE
			BEGIN
				SELECT 1 AS '1' ;
				RETURN 1;
				SET @Validacion=0;
			END

		
	END


	IF @Accion = 5 -- Leer Descripcion
	BEGIN
		
		SELECT Id_Medida,Descripcion FROM MEDIDA;

		
	END

	IF @Accion = 6 -- Leer Descripcion
	BEGIN
		
		SELECT Id_Medida FROM MEDIDA WHERE Descripcion=@P_Descripcion;

		
	END



	IF @Accion = 7 -- Leer Descripcion cuando el ID_Medida sea el que busques
	BEGIN
		
		SELECT Descripcion FROM MEDIDA WHERE Id_Medida=@P_IdMedida;

		
	END

END
GO



CREATE OR ALTER PROC [dbo].[spUsuario]
(
	@Accion			INT,
	@P_IdUsuario	INT = NULL,
	@P_Usuario	NVARCHAR(15) = NULL,
	@P_Contrasenia	NVARCHAR(15) = NULL,
	@P_IdPerfil	INT = NULL
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN
		
		SET @Validacion=0;

			IF NOT EXISTS ( SELECT 1 FROM USUARIO WHERE Usuario= @P_Usuario) 
			BEGIN 
				SET @Validacion=@Validacion+1;
				
				INSERT INTO USUARIO (Usuario,Contrasenia,Id_Perfil) VALUES (@P_Usuario,@P_Contrasenia,@P_IdPerfil);
			END
			ELSE
			BEGIN
				SELECT 1 AS '1' ;
				RETURN 1;
				SET @Validacion=0;
			END

		
	END

	IF @Accion = 2 -- Leer
	BEGIN
		
		SELECT * FROM USUARIO;

		
	END

	IF @Accion = 3 --ACCION PARA EDITAR LOS REGSITROS EXISTENTES
			BEGIN


				UPDATE USUARIO
					SET 
					
						Usuario=@P_Usuario,
						Contrasenia=@P_Contrasenia
				WHERE
					Id_Usuario = @P_IdUsuario


					


		END

	IF @Accion = 4 -- Delete especial verificando que no existan productos con el id de categoria a eliminar
	BEGIN
	
		SET @Validacion=0;

		IF NOT EXISTS( SELECT 1 FROM VENTA WHERE Id_Usuario= @P_IdUsuario) 
		BEGIN
			SET @Validacion=@Validacion+1;
		END
		ELSE
		BEGIN
		SELECT 1 AS '1' ;
		RETURN 1;

		END

		IF @Validacion=1
		BEGIN
			DELETE  FROM USUARIO  WHERE Id_Usuario = @P_IdUsuario;
		END
			

		
	END


	IF @Accion = 5 -- LOGIN
	BEGIN
	
		
				
		SELECT Id_Usuario FROM USUARIO WHERE Usuario= @P_Usuario AND Contrasenia = @P_Contrasenia;
		
	
			

		
	END


	IF @Accion = 6 -- LOGIN  // funcion para retornar el usuario cuando le demos el id 
	BEGIN
	
		
				
		select Usuario,contrasenia from USUARIO where Id_Usuario=@P_IdUsuario
		
	
			

		
	END

	IF @Accion = 7 -- LOGIN // funcion para reotrnar la categoria textual cuando le demos el id del usuario
	BEGIN
	
		DECLARE @idperfil AS INT;

		SET @idperfil = (select Id_Perfil from USUARIO where Id_Usuario=@P_IdUsuario)
		
		select Descripcion from PERFIL where Id_Perfil=@idperfil;
		
	
			

		
	END

	IF @Accion = 8 -- SELECT  Usuario FROM USUARIO WHERE id_Usuario sea difernete al loegeado
	BEGIN
	
		
		
		select Id_Usuario,Usuario from USUARIO WHERE Id_Usuario != @P_IdUsuario;
		
	
			

		
	END

	
	IF @Accion = 9 -- SELECT Usuario FROM USUARIO WHERE Usuario = @PUsuario
	BEGIN
	
		
		
		select Id_Usuario from USUARIO WHERE Usuario = @P_Usuario;
		
	
			

		
	END



	 

	



END
GO



CREATE OR ALTER PROC [dbo].[spPerfil]
(
	@Accion			INT,
	@P_IdPerfil	INT = NULL,
	@P_Descripcion	NVARCHAR(15) = NULL
	
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- Select todos los perfiles
	BEGIN
		
		SELECT Id_Perfil,Descripcion FROM PERFIL;

		
	END

	IF @Accion = 2 -- Leer
	BEGIN
		
		SELECT * FROM USUARIO;

		
	END

	 

	



END
GO


CREATE OR ALTER PROC [dbo].[spProducto]
(
	@Accion			INT,
	@P_IdProducto	VARCHAR(40) = NULL,
	@P_IdCategoria	INT = NULL,
	@P_IdMedida	INT = NULL,
	@P_IdEstatus	INT = NULL,
	@P_IdProveedor	INT = NULL,
	@P_Nombre	NVARCHAR(20) = NULL,
	@P_Descripcion	NVARCHAR(50) = NULL,
	@P_PrecioCompra	Float(3) = NULL,
	@P_PrecioVenta		Float(3) = NULL,
	@P_IdVenta INT = NULL,
	@P_validacion2 INT = NULL
	
	
)
AS
BEGIN
	DECLARE @Validacion INT;

	IF @Accion = 1 -- INSERT
	BEGIN
		
		SET @Validacion=0;

		IF NOT EXISTS( SELECT 1 FROM PRODUCTO WHERE Id_Producto= @P_IdProducto) 
		BEGIN
		SET @Validacion=@Validacion+1;
		END
		ELSE
		BEGIN
		SELECT 1 AS '1' ;
		RETURN 1;

		END

		IF NOT EXISTS ( SELECT 2 FROM PRODUCTO WHERE Nombre= @P_Nombre) 
			BEGIN
			SET @Validacion=@Validacion+1;

			END
			ELSE
			BEGIN
			SELECT 2 AS '2' ;
			RETURN 2;


		END

	

		IF @Validacion=2
			BEGIN
				INSERT INTO PRODUCTO (Id_Producto,Id_Categoria,Id_Medida,Id_Proveedor,Id_Estatus,Nombre,Descripcion,PrecioCompra,PrecioVenta,Stock) 
				VALUES (@P_IdProducto,@P_IdCategoria,@P_IdMedida,@P_IdProveedor,@P_IdEstatus,@P_Nombre,@P_Descripcion,@P_PrecioCompra,@P_PrecioVenta,0);
			

		END

		

		
	END
	

	IF @Accion = 2 -- Leer todos cuando le pase el IDproducto
	BEGIN
		
		SELECT Id_Categoria,Id_Medida,Id_Proveedor,Nombre,Descripcion,PrecioCompra,PrecioVenta,Stock,Id_Estatus FROM PRODUCTO 
		WHERE Id_Producto=@P_IdProducto ;

		
	END

	

	

	
	IF @Accion = 3 --ACCION PARA EDITAR LOS REGSITROS EXISTENTES
			BEGIN
			

				
				UPDATE PRODUCTO
					SET 
							
						Id_Categoria=@P_IdCategoria	,
						Id_Medida=@P_IdMedida	,
						Id_Proveedor=@P_IdProveedor	,
						Nombre=@P_Nombre	,
						Descripcion=@P_Descripcion,	
						PrecioCompra=@P_PrecioCompra	,
						PrecioVenta=@P_PrecioVenta		
						
		
				WHERE
					Id_Producto = @P_IdProducto
				
		END

	IF @Accion = 4 --ACCION PARA Eliminar LOS REGSITROS EXISTENTES
			BEGIN
				UPDATE PRODUCTO
					SET 
							
						Id_Estatus=@P_IdEstatus	
						
		
				WHERE
					Id_Producto = @P_IdProducto
				
		END



	IF @Accion = 7 --Accion para el datagridview de productos
			BEGIN
				SELECT Id_Producto,Nombre,Id_Categoria,Id_Medida,Id_Estatus,Stock FROM PRODUCTO WHERE Id_Estatus=1;
		END

	IF @Accion = 77 --Accion para el datagridview de productos
			BEGIN
				SELECT Id_Producto,Nombre,Id_Categoria,Id_Medida,Id_Estatus,Stock FROM PRODUCTO WHERE Id_Estatus=2;
		END


	IF @Accion = 8 --Accion hacer filtrado del datagridview ACTIVOS
		BEGIN

		
			SELECT Id_Producto,Nombre,Id_Categoria,Id_Medida,Stock FROM PRODUCTO 
			WHERE ( ((Id_Categoria=@P_IdCategoria OR @P_IdCategoria=0 ) AND  
			(Nombre LIKE '%'+ @P_Nombre+'%' OR @P_Nombre='0' ) AND

			(Id_Producto LIKE '%'+ @P_IdProducto+'%' OR @P_IdProducto='0' ) AND
			(Id_Medida=@P_IdMedida OR @P_IdMedida=0 ) AND  
			(Id_Proveedor=@P_IdProveedor OR @P_IdProveedor=0 )) AND Id_Estatus=1 ) ;
		END

	IF @Accion = 9 --Accion para el datagridview de productos en venta 
			BEGIN

			
				If @P_validacion2=0
				BEGIN
					SELECT 
					P.Id_Producto AS Id_Producto,
					P.Nombre AS Nombre,
					P.Descripcion AS Descripcion ,
					P.PrecioVenta AS PrecioVenta ,
					P.Id_Categoria AS Id_Categoria ,
					P.Id_Medida AS Id_Medida ,
					P.Stock AS Stock
						FROM PRODUCTO P
							WHERE    P.Stock>0 AND P.Id_Estatus=1  AND P.Id_Producto NOT IN 
									(SELECT VENTA_DETALLE.Id_Producto FROM VENTA_DETALLE WHERE  VENTA_DETALLE.Id_Venta=@P_IdVenta )
					
				END

				If @P_validacion2=1
				BEGIN
					SELECT 
					PRODUCTO.Id_Producto AS Id_Producto,
					PRODUCTO.Nombre AS Nombre,
					PRODUCTO.Descripcion AS Descripcion ,
					PRODUCTO.PrecioVenta AS PrecioVenta ,
					PRODUCTO.Id_Categoria AS Id_Categoria ,
					PRODUCTO.Id_Medida AS Id_Medida ,
					PRODUCTO.Stock AS Stock
					FROM
					PRODUCTO INNER JOIN VENTA_DETALLE
					ON PRODUCTO.Id_Producto = VENTA_DETALLE.Id_Producto 
					WHERE PRODUCTO.Stock>0    AND VENTA_DETALLE.Id_Venta=@P_IdVenta
				
				END
				
				
				
		END

	IF @Accion = 10 --Accion hacer filtrado del datagridview de venta //  
		BEGIN

			SELECT 
					P.Id_Producto AS Id_Producto,
					P.Descripcion AS Descripcion,
					P.PrecioVenta AS PrecioVenta,
					P.Nombre AS Nombre,
					P.Id_Categoria AS Id_Categoria ,
					P.Id_Medida AS Id_Medida ,
					P.Stock AS Stock 
					
						FROM PRODUCTO P
							WHERE  P.Stock>0 AND P.Id_Estatus=1 AND
									((P.Id_Categoria=@P_IdCategoria OR @P_IdCategoria=0 ) AND  
									(P.Id_Producto LIKE '%'+ @P_IdProducto+'%' OR @P_IdProducto='0' ) and
									(P.Id_Medida=@P_IdMedida OR @P_IdMedida=0 ) AND  
									(Nombre LIKE '%'+ @P_Nombre+'%' OR @P_Nombre='0' ) ) AND 

							P.Id_Producto  NOT IN 
									(SELECT VENTA_DETALLE.Id_Producto FROM VENTA_DETALLE 
									WHERE  VENTA_DETALLE.Id_Venta=@P_IdVenta  );
			

		
		END

	IF @Accion = 11 --Accion hacer filtrado del datagridview INACTIVOS
		BEGIN


			SELECT Id_Producto,Nombre,Id_Categoria,Id_Medida,Stock FROM PRODUCTO 
			WHERE ( (Id_Categoria=@P_IdCategoria OR @P_IdCategoria=0 ) AND  
			(Nombre LIKE '%'+ @P_Nombre+'%' OR @P_Nombre='0' ) AND
			(Id_Medida=@P_IdMedida OR @P_IdMedida=0 ) AND  
			(Id_Proveedor=@P_IdProveedor OR @P_IdProveedor=0 ) AND Id_Estatus=2 ) ;
		END


	IF @Accion = 12 --select count cantidad de productos
		BEGIN

			SELECT COUNT(*) AS CantidadProductos
					
						FROM PRODUCTO P
							WHERE    P.Stock>0 AND P.Id_Estatus=1  AND P.Id_Producto NOT IN 
									(SELECT VENTA_DETALLE.Id_Producto FROM VENTA_DETALLE WHERE  VENTA_DETALLE.Id_Venta=@P_IdVenta )
					
			

		
		END

END
GO




CREATE OR ALTER PROC [dbo].[spProveedor]
(
	@Accion INT,
	@P_IdProveedor INT = NULL,
	@P_Nombre NVARCHAR(50) = NULL,
	@P_Telefono NVARCHAR(12) = NULL,
	@P_Correo NVARCHAR(30) = NULL,
	@P_FechaEntrada DATE = NULL,
	@P_FechaModificacion DATE = NULL
)
AS
	BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN

		SET @Validacion=0;

		IF NOT EXISTS ( SELECT 1 FROM PROVEEDOR WHERE Nombre= @P_Nombre)
		BEGIN
		SET @Validacion=@Validacion+1;
		END
		ELSE
		BEGIN
		SELECT 1 AS '1' ;
		RETURN 1;

		END

	IF NOT EXISTS ( SELECT 2 FROM PROVEEDOR WHERE Telefono= @P_Telefono)
		BEGIN
		SET @Validacion=@Validacion+1;

		END
		ELSE
		BEGIN
		SELECT 2 AS '2' ;
		RETURN 2;


	END

	IF NOT EXISTS ( SELECT 3 FROM PROVEEDOR WHERE Correo= @P_Correo)
		BEGIN
		SET @Validacion=@Validacion+1;

		END
		ELSE
		BEGIN
		SELECT 3 AS '3' ;
		RETURN 3;


	END

	IF @Validacion=3
		BEGIN
			INSERT INTO PROVEEDOR (Nombre,Telefono,Correo,FechaEntrada) values(@P_Nombre,@P_Telefono,@P_Correo,@P_FechaEntrada);
		END

	END

	

	IF @Accion = 3 -- editar
		BEGIN

			
			
			UPDATE PROVEEDOR
					SET 
					
						Nombre=@P_Nombre,
						Correo=@P_Correo,
						Telefono=@P_Telefono,
						FechaModificacion=@P_FechaModificacion
				WHERE
					Id_Proveedor = @P_IdProveedor
		


	END

	IF @Accion = 4 -- Delete especial verificando que no existan productos con el id de categoria a eliminar
		BEGIN


		IF NOT EXISTS ( SELECT 1 FROM PRODUCTO WHERE Id_Proveedor= @P_IdProveedor)
		BEGIN
			DELETE  FROM PROVEEDOR  WHERE Id_Proveedor = @P_IdProveedor;
		END

		ELSE
		BEGIN
			SELECT 1 AS '1' ;
			RETURN 1;

	END



	END

	
	IF @Accion = 6 -- 
	BEGIN
		
		SELECT Id_Proveedor,Nombre FROM PROVEEDOR;

		
	END

	IF @Accion = 7 -- Leer Descripcion cuando el ID_Categoria sea el que busques
	BEGIN
		
		SELECT Nombre FROM PROVEEDOR WHERE Id_Proveedor=@P_IdProveedor;

		
	END






	IF @Accion = 10 -- Leer Nombre cuando la el id proveedor sea igual a idproveedor
	BEGIN

		SELECT Nombre,Correo,Telefono FROM PROVEEDOR WHERE Id_Proveedor=@P_IdProveedor;


	END


END
GO


CREATE OR ALTER PROC [dbo].[spEntrada]
(
	@Accion			INT,
	@P_IdEntrada	INT = NULL,
	@P_IdProducto	INT = NULL,
	@P_IdUsuario	INT = NULL,
	@P_Stock	INT = NULL,
	@P_FechaEntrada	date = NULL
	
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN
		
		
		INSERT INTO ENTRADA (Id_Producto,Id_Usuario,Stock,FechaEntrada) VALUES (@P_IdProducto,@P_IdUsuario,@P_Stock,@P_FechaEntrada);
		
		DECLARE @V_stock_actual int;

		set @V_stock_actual = (SELECT Stock FROM PRODUCTO WHERE Id_Producto=@P_IdProducto);

		UPDATE PRODUCTO
					SET 
							
						Stock=@V_stock_actual+@P_Stock	
						
		
				WHERE
					Id_Producto = @P_IdProducto
		
	END

	IF @Accion = 2 -- Leer
	BEGIN
		
		SELECT Id_Producto,Id_Usuario,Stock,FechaEntrada FROM ENTRADA;

		
	END

	

END
GO

CREATE OR ALTER PROC [dbo].[spVentaDetalle]
(
	@Accion			INT,
	@P_IdVenta	INT = NULL,
	@P_IdProducto	INT = NULL,
	@P_CantidadAComprar	INT = NULL,
	@P_PrecioVenta	float (3)= NULL,
	@P_IdUsuario INT = NULL,
	@P_Validacion INT = NULL
	
)
AS
BEGIN
	


	IF @Accion = 1 -- INSERT
	BEGIN
		
		IF @P_Validacion=0
		BEGIN
			INSERT INTO VENTA (Id_Venta) VALUES (@P_IdVenta);
			INSERT INTO VENTA_DETALLE(Id_Venta,Id_Producto,Precio,Cantidad) VALUES (@P_IdVenta,@P_IdProducto,@P_PrecioVenta,@P_CantidadAComprar);
		END

		IF @P_Validacion>=1
		BEGIN
			INSERT INTO VENTA_DETALLE(Id_Venta,Id_Producto,Precio,Cantidad) VALUES (@P_IdVenta,@P_IdProducto,@P_PrecioVenta,@P_CantidadAComprar);
		END

		

		
		
	END

	IF @Accion = 2 -- SABER EN QUE IDVENTA VOY 
	BEGIN
		
		SELECT max(Id_Venta)+1 as Id_Venta_Proxima FROM VENTA_DETALLE;

		
	END

	IF @Accion = 3 -- SELECT ORDEN COMPRA
	BEGIN
		

		SELECT
			VENTA_DETALLE.Id_Venta AS Id_Venta,
			VENTA_DETALLE.Id_Producto AS Id_Producto,
			VENTA_DETALLE.Cantidad AS Cantidad,
			VENTA_DETALLE.Precio AS Precio,
			PRODUCTO.Nombre AS Nombre
		FROM
			VENTA_DETALLE INNER JOIN PRODUCTO
				ON VENTA_DETALLE.Id_Producto = PRODUCTO.Id_Producto
				WHERE Id_Venta=@P_IdVenta;
		

	

	END

	IF @Accion = 4 -- ELIMINAR TODOS LOS ARTICULOS DE VENTADETALLE
	BEGIN
		
		DELETE FROM VENTA_DETALLE WHERE Id_Venta=@P_IdVenta;
		DELETE FROM VENTA WHERE Id_Venta=@P_IdVenta;
 

		
	END

	IF @Accion = 5 --ACCION PARA Eliminar LOS REGSITROS EXISTENTES
			BEGIN
			DELETE FROM VENTA_DETALLE WHERE Id_Venta=@P_IdVenta and Id_Producto=@P_IdProducto;
	
		END

	

	



END
GO


CREATE OR ALTER PROC [dbo].[spTipoVenta]
(
	@Accion			INT,
	@P_Id_TipoVenta	INT = NULL,
	@P_Descripcion	NVARCHAR(15) = NULL
)
AS
BEGIN



	IF @Accion = 1 -- INSERT
	BEGIN
		
		
		SELECT Descripcion FROM TIPOVENTA;
		

		
	END

	IF @Accion = 2 -- Leer
	BEGIN
		
		SELECT Id_TipoVenta FROM TIPOVENTA WHERE Descripcion=@P_Descripcion;

		
	END

	

END
GO

CREATE OR ALTER PROC [dbo].[spCliente]
(
	@Accion INT,
	@P_IdCliente INT = NULL,
	@P_Nombre NVARCHAR(50) = NULL,
	@P_Apellido_Paterno NVARCHAR(50) = NULL,
	@P_Apellido_Materno NVARCHAR(50) = NULL,
	@P_Telefono NVARCHAR(12) = NULL,
	@P_Correo NVARCHAR (30) = NULL,
	@P_Direccion NVARCHAR(100) = NULL
)
AS
	BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN

		SET @Validacion=0;



		IF NOT EXISTS ( SELECT 2 FROM CLIENTE WHERE Telefono= @P_Telefono)
		BEGIN
		SET @Validacion=@Validacion+1;

		END
		ELSE
		BEGIN
		SELECT 2 AS '2' ;
		RETURN 2;


	END

	IF NOT EXISTS ( SELECT 3 FROM CLIENTE WHERE Correo= @P_Correo)
	BEGIN
		SET @Validacion=@Validacion+1;

		END
		ELSE
		BEGIN
		SELECT 3 AS '3' ;
		RETURN 3;


	END

	IF @Validacion=2
	BEGIN
		INSERT INTO CLIENTE(Nombre,Apellido_Paterno,Apellido_Materno,Telefono,Correo,Direccion)
		values(@P_Nombre,@P_Apellido_Paterno,@P_Apellido_Materno,@P_Telefono,@P_Correo,@P_Direccion);
	END


	END

	IF @Accion = 2 -- select nombre form cliente
	BEGIN

		SELECT Nombre FROM CLIENTE;


	END

	IF @Accion = 3 -- Leer
	BEGIN

		SELECT Id_Cliente FROM CLIENTE WHERE Nombre = @P_Nombre ;


	END

	IF @Accion = 4 -- Leer
	BEGIN

		IF NOT EXISTS ( SELECT 1 FROM CREDITO WHERE Id_Cliente= @P_IdCliente)
			BEGIN
			DELETE  FROM CLIENTE  WHERE Id_Cliente = @P_IdCliente;
			END

		ELSE
			BEGIN
				SELECT 1 AS '1' ;
			RETURN 1;


		END

		END



END
GO

CREATE OR ALTER PROC [dbo].[spVenta]
(
	@Accion			INT,
	@P_IdVenta	INT = NULL,
	@P_IdUsuario	INT = NULL,
	@P_IdCliente	INT = NULL,
	@P_Total	FLOAT = NULL,
	@P_Cambio	FLOAT = NULL,
	@P_FechaVenta	DATE = NULL,
	@P_NombreTransferencia NVARCHAR (20) = NULL,
	@P_IdProducto INT = NULL,
	@P_Stock INT = NULL
	
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT en la venta efectivo
	BEGIN
		
		UPDATE VENTA
					SET 
						Id_Usuario=@P_IdUsuario	,
						Id_TipoVenta=1,
						Total=@P_Total	,
						NombreTransferencia='',
						Cambio=@P_Cambio,
						FechaVenta=@P_FechaVenta
				WHERE
					Id_Venta = @P_IdVenta




			

		
	END

	IF @Accion = 2 --Traer los productos que agrego al carro para poder descontar el stock
	BEGIN
	
		SELECT Id_Producto,Cantidad FROM VENTA_DETALLE WHERE Id_Venta=@P_IdVenta;
		
		



			

		
	END

	IF @Accion = 3 --Traer los productos que agrego al carro para poder descontar el stock
	BEGIN
	
		DECLARE @stockdisponible INT;
		DECLARE @total INT;

		SET @stockdisponible=(SELECT Stock FROM PRODUCTO WHERE Id_Producto = @P_IdProducto)

		SET @total= @stockdisponible-@P_Stock


		UPDATE PRODUCTO
					SET 
						Stock=@total
				WHERE
					Id_Producto = @P_IdProducto

	END

	IF @Accion = 4 -- INSERT en la venta transferencia
	BEGIN
		
		UPDATE VENTA
					SET 
						Id_Usuario=@P_IdUsuario	,
						Id_TipoVenta=2,
						Total=@P_Total	,
						NombreTransferencia=@P_NombreTransferencia,
						Cambio=@P_Cambio,
						FechaVenta=@P_FechaVenta
				WHERE
					Id_Venta = @P_IdVenta

	END

	IF @Accion = 5 -- INSERT en la venta credito
	BEGIN
		
		UPDATE VENTA
					SET 
						Id_Usuario=@P_IdUsuario	,
						Id_Cliente=@P_IdCliente,
						Id_TipoVenta=3,
						Total=@P_Total	,
						NombreTransferencia='',
						Cambio=@P_Cambio,
						FechaVenta=@P_FechaVenta
				WHERE
					Id_Venta = @P_IdVenta

	END

	

END
GO

CREATE OR ALTER PROC [dbo].[spCredito]
(
	@Accion			INT,
	@P_IdCredito	INT = NULL,
	@P_IdVenta	INT = NULL,
	@P_CantidadPagada	float = NULL,
	@P_IdCliente	INT = NULL,
	@P_IdEstatus	INT = NULL,
	@P_FechaRegistro	DATE = NULL,
	@P_FechaPago	DATE = NULL,
	@P_Validacion INT = NULL,
	@P_Cambio float = NULL


	
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT en la venta CREDITO
	BEGIN
		
		INSERT INTO CREDITO(Id_Venta,Id_Cliente,Id_Estatus,FechaRegistro,FechaPago,CantidadPagada)
		values(@P_IdVenta,@P_IdCliente,@P_IdEstatus,@P_FechaRegistro,@P_FechaPago,@P_CantidadPagada);

		
	END

	
	IF @Accion = 2 -- SELECT TODOS LOS DATOS DEL CLIENTE QUE TENGAN CREDITO SIN PAGAR
	BEGIN
		
		SELECT  DISTINCT
					CLIENTE.Id_Cliente AS Id_Cliente,
					CLIENTE.Nombre AS Nombre,
					CLIENTE.Apellido_Paterno AS Apellido_Paterno ,
					CLIENTE.Apellido_Materno AS Apellido_Materno ,
					CLIENTE.Direccion AS Direccion ,
					CLIENTE.Correo AS Correo ,
					CLIENTE.Telefono AS Telefono
					FROM
					CLIENTE INNER JOIN CREDITO
					ON CLIENTE.Id_Cliente = CREDITO.Id_Cliente 
				
					WHERE CREDITO.Id_Estatus=2 

				
		
	END

	
	IF @Accion = 33 -- SELECT TODOS LOS DATOS DEL CLIENTE QUE TENGAN CREDITO SIN PAGAR CUANDO LE PASE EL ID CLIENTE CON FILTRADO
	BEGIN
		
		
			SELECT DISTINCT
					CLIENTE.Id_Cliente AS Id_Cliente,
					CLIENTE.Nombre AS Nombre,
					CLIENTE.Apellido_Paterno AS Apellido_Paterno ,
					CLIENTE.Apellido_Materno AS Apellido_Materno ,
					CLIENTE.Direccion AS Direccion ,
					CLIENTE.Correo AS Correo ,
					CLIENTE.Telefono AS Telefono
					FROM
					CLIENTE INNER JOIN CREDITO
					ON CLIENTE.Id_Cliente = CREDITO.Id_Cliente 
				
					WHERE CREDITO.Id_Estatus=2  AND CLIENTE.Id_Cliente=@P_IdCliente
				
		
	END

	IF @Accion = 3 -- SELECT TODOS LOS DATOS DEL CLIENTE QUE TENGAN CREDITO SIN PAGAR CUANDO LE PASE EL ID CLIENTE CON FILTRADO
	BEGIN
		
		
			SELECT		 	DISTINCT	
					CLIENTE.Id_Cliente AS  IdCliente,
					
					VENTA.Id_Venta AS IdVenta,
					CREDITO.CantidadPagada AS CantidadPagada,
					VENTA.Total AS Total
			
					FROM VENTA 
					INNER JOIN CREDITO ON VENTA.Id_Venta = CREDITO.Id_Venta 
					INNER JOIN VENTA_DETALLE ON VENTA_DETALLE.Id_Venta = CREDITO.Id_Venta
					INNER JOIN CLIENTE ON CLIENTE.Id_Cliente = VENTA.Id_Cliente
					
				
					WHERE CREDITO.Id_Estatus=2  AND CLIENTE.Id_Cliente=@P_IdCliente 
				
		
	END


	IF @Accion = 333 -- SELECT TODOS LOS DATOS DEL CLIENTE QUE TENGAN CREDITO SIN PAGAR CUANDO LE PASE EL ID CLIENTE CON FILTRADO
	BEGIN
		
		
			SELECT		 	DISTINCT	
					CLIENTE.Id_Cliente AS  IdCliente,
					CLIENTE.Nombre AS Nombre,
					CLIENTE.Apellido_Paterno AS Apellido_Paterno,
					CLIENTE.Apellido_Materno AS Apellido_Materno,
					CLIENTE.Direccion AS Direccion,
					CLIENTE.Telefono AS Telefono,
					CLIENTE.Correo AS Correo,

					VENTA.Id_Venta AS IdVenta,
					CREDITO.CantidadPagada AS CantidadPagada,
					VENTA.Total AS Total
			
					FROM VENTA 
					INNER JOIN CREDITO ON VENTA.Id_Venta = CREDITO.Id_Venta 
					INNER JOIN VENTA_DETALLE ON VENTA_DETALLE.Id_Venta = CREDITO.Id_Venta
					INNER JOIN CLIENTE ON CLIENTE.Id_Cliente = VENTA.Id_Cliente
					
				
					WHERE    CLIENTE.Id_Cliente=@P_IdCliente  AND VENTA.Id_Venta=@P_IdVenta
				
		
	END

	IF @Accion = 4 -- INSERT DEL CLIENTE SELECIONADO PAR SABER QUE CLIENTE SELECCIONO 
	BEGIN
		

		DELETE FROM CLIENTECREDITOSELECCIONADO;
		INSERT INTO CLIENTECREDITOSELECCIONADO (Id_Cliente) VALUES (@P_IdCliente);

		
	END


	IF @Accion = 5 -- SELECT  DEL CLIENTE SELECIONADO PAR SABER QUE CLIENTE SELECCIONO 
	BEGIN
		

		SELECT Id_Cliente FROM CLIENTECREDITOSELECCIONADO ;

		
	END

	IF @Accion = 6 -- SELECT TODOS LOS CREDITOS DEL CLIENTE EN ESPECIFICO
	BEGIN
		
		SELECT DISTINCT
					CLIENTE.Id_Cliente AS Id_Cliente,
					CLIENTE.Nombre AS Nombre,
					CLIENTE.Apellido_Paterno AS Apellido_Paterno ,
					CLIENTE.Apellido_Materno AS Apellido_Materno ,
					CLIENTE.Direccion AS Direccion ,
					CLIENTE.Correo AS Correo ,
					CLIENTE.Telefono AS Telefono
					FROM
					CLIENTE INNER JOIN CREDITO
					ON CLIENTE.Id_Cliente = CREDITO.Id_Cliente 


					
					WHERE CREDITO.Id_Estatus=2  AND CLIENTE.Id_Cliente=@P_IdCliente
				
		
	END

	IF @Accion = 7 --select count cantidad de creditos
		BEGIN

			SELECT COUNT(*) AS CantidadCreditos
					
						FROM CREDITO WHERE Id_Cliente=@P_IdCliente AND Id_Estatus=2
					
			

		
		END


	IF @Accion = 8 --select count cantidad de clientes que tengan credito vigente
		BEGIN

			SELECT  DISTINCT
					  COUNT(*) AS CantidadClientes
					FROM
					CLIENTE INNER JOIN CREDITO
					ON CLIENTE.Id_Cliente = CREDITO.Id_Cliente 
				
					WHERE CREDITO.Id_Estatus=2 
			

		
		END

	IF @Accion = 9 --UPDATE CREDITO PAGADO
		BEGIN

			
		DECLARE @V_cantidad_pagada_actual int;

		set @V_cantidad_pagada_actual = (SELECT CantidadPagada FROM CREDITO WHERE Id_Venta=@P_IdVenta);
		
		IF @P_Validacion = 0 --´PAGADO PARCIAL EFECTIVO
		BEGIN
			
			UPDATE CREDITO
						SET 
							
							CantidadPagada=@V_cantidad_pagada_actual+@P_CantidadPagada,
							FechaUltimoPago=@P_FechaPago
						
		
					WHERE
						 Id_Venta=@P_IdVenta  AND CREDITO.Id_Estatus=2 

		END
		

		IF @P_Validacion =1 --PAGADO COMPLETO EFECTIVO
		BEGIN
			
		UPDATE CREDITO
					SET 
							
						CantidadPagada=@V_cantidad_pagada_actual+@P_CantidadPagada	,
						Id_Estatus=1,
						FechaUltimoPago=@P_FechaPago,
						FechaPago=@P_FechaPago
						
						
		
				WHERE
					 Id_Venta=@P_IdVenta  AND CREDITO.Id_Estatus=2 


			UPDATE VENTA
					SET 
							
						Cambio=@P_Cambio
						
		
				WHERE
					 Id_Venta=@P_IdVenta  

		END

		IF @P_Validacion =2 --´PAGADO COMPLETO TRANSFERENCIA
		BEGIN
			
		UPDATE CREDITO
					SET 
							
						CantidadPagada=@V_cantidad_pagada_actual+@P_CantidadPagada	,
						Id_Estatus=1,
						FechaUltimoPago=@P_FechaPago,
						FechaPago=@P_FechaPago
		
				WHERE
					 Id_Venta=@P_IdVenta  AND CREDITO.Id_Estatus=2 

		END
	

		END
	

	

END
GO

CREATE OR ALTER PROC [dbo].[spCliente]
(
	@Accion INT,
	@P_IdCliente INT = NULL,
	@P_Nombre NVARCHAR(50) = NULL,
	@P_Apellido_Paterno NVARCHAR(50) = NULL,
	@P_Apellido_Materno NVARCHAR(50) = NULL,
	@P_Telefono NVARCHAR(12) = NULL,
	@P_Correo NVARCHAR (30) = NULL,
	@P_Direccion NVARCHAR(100) = NULL
)
AS
BEGIN
	DECLARE @Validacion INT;


	IF @Accion = 1 -- INSERT
	BEGIN

		SET @Validacion=0;



		IF NOT EXISTS ( SELECT 2 FROM CLIENTE WHERE Telefono= @P_Telefono)
			BEGIN
			SET @Validacion=@Validacion+1;

			END
			ELSE
			BEGIN
			SELECT 2 AS '2' ;
			RETURN 2;


		END

		IF NOT EXISTS ( SELECT 3 FROM CLIENTE WHERE Correo= @P_Correo)
		BEGIN
			SET @Validacion=@Validacion+1;

			END
			ELSE
			BEGIN
			SELECT 3 AS '3' ;
			RETURN 3;


		END

		IF @Validacion=2
		BEGIN
			INSERT INTO CLIENTE(Nombre,Apellido_Paterno,Apellido_Materno,Telefono,Correo,Direccion)
			values(@P_Nombre,@P_Apellido_Paterno,@P_Apellido_Materno,@P_Telefono,@P_Correo,@P_Direccion);
		END


	END

	IF @Accion = 2 -- select nombre form cliente
	BEGIN

		SELECT Id_Cliente , Nombre,Apellido_Paterno,Apellido_Materno FROM CLIENTE;


	END

	IF @Accion = 3 --SELECT EN CREDITO 
	BEGIN

			SELECT  DISTINCT
					CLIENTE.Id_Cliente AS Id_Cliente,
					CLIENTE.Nombre AS Nombre,
					CLIENTE.Apellido_Paterno AS Apellido_Paterno ,
					CLIENTE.Apellido_Materno AS Apellido_Materno 
					
					FROM
					CLIENTE INNER JOIN CREDITO
					ON CLIENTE.Id_Cliente = CREDITO.Id_Cliente 
				
					WHERE CREDITO.Id_Estatus=2 


		


	END

	
	IF @Accion = 4 -- Leer
	BEGIN

		IF NOT EXISTS ( SELECT 1 FROM CREDITO WHERE Id_Cliente= @P_IdCliente)
		BEGIN
			DELETE  FROM CLIENTE  WHERE Id_Cliente = @P_IdCliente;
		END

		ELSE
		BEGIN
			SELECT 1 AS '1' ;
			RETURN 1;


		END

	END

	IF @Accion = 5 -- editar
	BEGIN



		UPDATE CLIENTE
		SET

		Nombre=@P_Nombre,
		Apellido_Paterno=@P_Apellido_Paterno,
		Apellido_Materno=@P_Apellido_Materno,
		Correo=@P_Correo,
		Telefono=@P_Telefono,
		Direccion=@P_Direccion
		WHERE
		Id_Cliente = @P_IdCliente



	END

	IF @Accion = 6 -- SELECT idProveedor FROM Proveedor WHERE Nombre = @Pnombre
	BEGIN



		select Nombre, Apellido_Paterno, Apellido_Materno, Correo, Telefono, Direccion from Cliente WHERE Id_Cliente = @P_IdCliente;





	END

	


END
GO



CREATE OR ALTER PROC [dbo].[spTicket]
(
	@Accion			INT,
	@P_IdVenta	INT = NULL
	
)
AS
BEGIN
	
	

	IF @Accion = 1 -- Ticket Efectivo
	BEGIN
		
		


		SELECT
			VENTA_DETALLE.Id_Venta AS Id_Venta,
			USUARIO.Usuario AS UsuarioVenta,
			VENTA_DETALLE.Id_Producto as IdProducto,
			PRODUCTO.Nombre AS NombreProducto,
			
			VENTA_DETALLE.Cantidad AS CantidadProducto,
			VENTA_DETALLE.Precio AS PrecioProducto,
			VENTA_DETALLE.Cantidad*VENTA_DETALLE.Precio AS SubTotalProducto,
			VENTA.FechaVenta as FechaVentaProducto,
			VENTA.Total as TotalVenta,
			VENTA.Cambio as CambioVenta
		FROM
			VENTA_DETALLE 
			INNER JOIN PRODUCTO ON VENTA_DETALLE.Id_Producto = PRODUCTO.Id_Producto
			INNER JOIN VENTA ON VENTA.Id_Venta = VENTA_DETALLE.Id_Venta
			INNER JOIN USUARIO ON USUARIO.Id_Usuario = VENTA.Id_Usuario
	
			WHERE VENTA.Id_Venta=@P_IdVenta;

		

		
		
	END

	IF @Accion = 11-- TICKET INFORMACION ADICIONAL
	BEGIN
		SELECT NombreEmpresa,Direccion,Telefono,Mensaje FROM TICKET;
	END


	

	

	

	



END
GO


CREATE OR ALTER PROC [dbo].[spReportes]
(
	@Accion INT,
	@P_IdCliente INT = NULL,
	@P_FechaInicio DATE = NULL,
	@p_FechaFinal DATE = NULL
)

AS
BEGIN



	IF @Accion = 1 -- REPORTE DE VENTAS
	BEGIN


		SELECT
		VENTA_DETALLE.Id_Venta AS Id_Venta,

		VENTA_DETALLE.Id_Producto as IdProducto,

		PRODUCTO.Nombre AS NombreProducto,
		VENTA_DETALLE.Cantidad AS CantidadProducto,
		VENTA_DETALLE.Precio AS PrecioProducto,
		VENTA_DETALLE.Cantidad*VENTA_DETALLE.Precio AS SubTotalProducto,
		VENTA.FechaVenta as FechaVentaProducto


		FROM
		VENTA_DETALLE
		INNER JOIN VENTA ON VENTA_DETALLE.Id_Venta = VENTA.Id_Venta
		INNER JOIN PRODUCTO ON VENTA_DETALLE.Id_Producto = PRODUCTO.Id_Producto
		WHERE VENTA.FechaVenta BETWEEN @P_FechaInicio AND @p_FechaFinal ;

	END
END

