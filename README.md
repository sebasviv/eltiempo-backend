Las tablas en la base de datos ya estan creadas, en caso de quererla instalar en otra base de datos local, dejo instrucciones.

Para instalar correctamente la base de datos desde el repositorio.

1. Abrir la solucion
2. Configurar la Connection string en el archivo appSettings.json
3. Abrir la consola de administrador de paquetes
4. ejecutar el comando Add-Migration prueba
5. ejecutar el comando Update-database
6. Compilar con IIS Express



Nota: El usuario escrito en appsettings.json ya fue probado para que se pueda conectar de manera satisfactoria a la base de datos, en caso de un error preguntar.

Nota: Los permisos CORS estan habilitados para el dominio localhost:3000

Nota: Los servicios del front estan apuntando al dominio https://localhost:44391/api/ 
