# MarDom.HelpDesk
Aplicación para realizar solicitudes de soportes

## Requerimientos de Base de Datos:

1.-Definir Una pequeña base de datos, la cual contenga las tablas básicas para el
registro del soporte.La tabla principal deberá de contener los siguientes campos:
(Fecha, Usuario que solicita, Descripción del problema, Departamento,
ID Problema (Con tabla creada previa), lugar al que pertenece la solicitud (si es
soporte, Desarrollo, etc.)


## Requerimientos de sistema: 

1- Debe de permitir a los usuarios registrados y autentificados poder postear las
Registros de un máximo de 200 caracteres y serán visualizadas por los usuarios
Seguidores autentificados o usuario no registrados.

2.- Deberá permitir que un usuario registrado siga (Follow) a otro usuario
Registrado con la finalidad de recibir cada una de las actualizaciones en las registros
de entrada realizadas por el usuario .

3.-El sistema deberá permitir Agregar y modificar solicitudes de soporte y en la cual le
permita realizar opción de cierre y asignaciones a los tickets registrados, según
presentación al modelo de pantalla realizado:

#### A).-Pantalla de insertar:
![1](https://cloud.githubusercontent.com/assets/11558655/26476721/947b9da8-418e-11e7-8b09-ba21e117430c.PNG)

#### B).-Pantalla de Modificar asignar y cerrar tickets
![2](https://cloud.githubusercontent.com/assets/11558655/26476761/ce74d8c6-418e-11e7-9aa0-16b5ed6828fe.PNG)
- Deberá permitir anexar documento o imágenes en caso del usuario necesitarlo.

5.- Cada formulario utilizado debe hacer uso de las validaciones de sus campos ya sea
Utilizando JavaScript (mostrando todos los errores de una sola vez de manera
elegante), HTML 5 o desde el servidor.

6.-Presentar a través del dashboard y según grafico las siguientes consultas:
- Histórico de solicitudes, todas o por rango de fecha
- Lista de solicitudes por rango de fecha, tipo de solicitudes, asignadas, por departamento
- Tiempo de gestión de las solicitudes.
- Cantidad de solicitudes cerradas


 
 






