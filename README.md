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

# Referencia de proyecto 

Tomando en cuenta los puntos que iban hacer evaluados para el proyecto que son: Evaluar la calidad de código, buenas prácticas, secuencia lógica. Decidí utilizar la metodología de trabajo más rápida en base al tiempo y mi disponibilidad. Utilice el patrón de diseño de unidad de trabajo donde de manera dinámica usando el ORM Entity framework incorporo todos los repositorios de datos que voy a utilizar usando Generic recibo cualquier entidad de la base de datos y puedo hacer las transacciones necesaria a la base de datos esto lo hice de esta manera para minimizar el tiempo en creación de procedimientos en el base de datos y hacer las consultas sencillas usando linq.

#### La solución tiene los siguientes proyectos:
- MarDom.HelpDesk
- MarDom.Data
- MarDom.Service
- MarDom.Web
- MarDom.Data

#### MarDom.Data

En este proyecto está la capa de datos su responsabilidad es realizar todas las consultas necesarias a la base de Datos. Aquí se encuentra el contexto de la base de datos y el conjunto de entidades que representan cada uno de los objetos de la base de datos. También hay una clase llamada “ProcedureContext” que se creó para utilizar linq to sql para mapear y ejecutar los procedimientos. La clase RepositorioBase es donde se encuentran los procedimientos para hacer select , insert , delete de manera genérica para cualquier entidad del proyecto y la clase UnitOfWork
es donde se crea de manera dinámica usando Dynamic y Reflection una instancia del objeto que llegue en ese momento y asi podar adaptar el repositorio genérico a la entidad que se le pase en el momento un ejemplo de implementación seria:
base.uow.Repositorio<Usuario>().GetAll().ToList();
Donde uow es la unidad de trabajo donde se le pasa la entidad y se ejecuta un método genérico para obtener todos los usuarios
 
Aquí hay un ejemplo del código del procedimiento que crea el repositorio con Dynamic


         public RepositorioBase<T> Repositorio<T>() where T : class
        {
            if (repositories == null)
            {
                repositories = new Dictionary<string, object>();
            }
 
            var type = typeof(T).Name;
 
            if (!repositories.ContainsKey(type))
            {
                var repositoryType = typeof(RepositorioBase<>);
                object repositoryInstance = null;
 
                repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType(typeof(T)), this._context);
                repositories.Add(type, repositoryInstance);
 
            }
            return (RepositorioBase<T>)repositories[type];
        }
        
        
 
#### MarDom.Service
En este proyecto está la capa de servicio de la aplicación que solo se encarga de devolver los datos de la capa de datos o la notificación de que si hubo un error o no
 
#### MarDom.Web
En este proyecto está el sitio web basado en MVC 5 , angular y los demás framework para que sea de fácil uso para el usuario


#### Estructura de base de datos:

Esta es la estructura de tablas pensadas para el proyecto con lo que tiene que ver creación de solicitudes:



 
 El flujo que pensé fue el siguiente: Un usuario hace una solicitud al departamento de tecnología el agente que es un usuario es el que se encarga de capturar lo solicitado por el usuario, este asigna el departamento y el área a la que corresponde la solicitud. Un ticket tiene una sección en el sistema que corresponde a la clasificación de la solicitud, por ejemplo: Software y Hardware son secciones de una solicitud , las categorías están relacionadas con la sección y los problemas relacionados a las categorías por ejemplo : Sección Software en la categoría Microsoft Outlook se selecciona el ProblemaId  error al enviar correo electrónico así se puede llevar una estadística de cuáles son los problemas más frecuentes de una categoría.    


Me faltaron varias cosas por disponibilidad de tiempo por el trabajo eso fue lo que pude realizar . Espero que se tome en cuenta  los conocimientos y logica

Saludos y muchas gracias 

 
 






