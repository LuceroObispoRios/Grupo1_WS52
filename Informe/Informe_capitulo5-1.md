# Capitulo 5
## 5.1. Software Configuration Management.

### 5.1.1. Software Development Environment Configuration.

Para el presente trabajo, por motivo de comodidad, dominio o preferencia de ciertas herramientas tecnológicas en la actualidad. El equipo vio adecuado optar por las siguientes:

**Visual Studio Code**: Es un IDE o entorno de desarrollo integrado. En otras palabras, es un editor de código fuente líder en el mundo. Dado que, cuenta con el beneficio de poder complementarse con extensiones, trabajar con múltiples lenguajes de programación, etc. Por otro lado, este IDE es conocido por los integrantes del equipo, asi como han realizado proyectos con anterioridad. Por estos motivos, el equipo decidio trabajar con esta herramienta.   

*Ruta de descarga de Visual Studio Code*: https://code.visualstudio.com/
Una vez descargado el ejecutable, teniendo en cuenta el sistema operativo del usuario, se procede a 
la instalación, la cual es guiada e intuitiva. 	

![Visual Studio Code](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/VisualStudioCodeLogo.png?raw=true)  


*Se han utilizado las siguientes extensiones, todas ellas se encuentran dentro de la tienda de extensiones en el IDE Visual Studio Code:*

**Live Server (Extensión de Visual Studio Code)**: La extensión "Live Server" es una herramienta esencial para cualquier desarrollador web que busque agilizar el proceso de desarrollo y pruebas de aplicaciones web. Con esta herramienta podemos tener una experiencia de desarrollo en tiempo real, permitiéndonos ver los cambios que realizamos en el Landing Page y el aplicativo web de inmediato en el navegador, sin necesidad de recargar la página manualmente. Esto nos permite  concentrarnos en la lógica y la apariencia de nuestro diseño sin interrupciones.

![Extension Live Server](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/LiveServer.png?raw=true)  

**Auto Rename Tag (Extensión de Visual Studio Code)**: La extensión "AutoRenameTag" es una herramienta esencial que simplifica la edición de etiquetas HTML en el desarrollo web. Esta extensión permite cambiar automáticamente el nombre de una etiqueta y su cierre correspondiente cuando se modifica una de ellas. Esta extensión ahorra tiempo y posibles errores al equipo dado a la cantidad de actualizaciones en el código.

![Extension Auto Rename Tag](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/AutoRenameTag.png?raw=true)  

**vscode-styled-components (Extensión de Visual Studio Code)**: La extensión "vscode-styled-components" fue de gran utilidad para el desarrollo del código CSS.  Los beneficios que esta extensión puede ofrecer es dar detalle sobre las propiedades y autocompletado  inteligente para las plantillas de estilo dentro de  componentes. Esto facilita la creación de CSS-JS de manera eficiente y ayuda a mantener  un código limpio y organizado.

![Extensión vscode-style-components](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/vscode-style-components.png?raw=true)  


**Git**: Dado que es necesario colaborar en el proyecto tanto del landing page como el aplicativo web de  manera remota. Se optó por el sistema de control de versiones GIT. Dado que permite la colaboración activa de los miembros del equipo incluso cuando no tengan acceso a internet. Cada miembro almacena  un clon local del proyecto y puede realizar las actualizaciones correspondientes.    

*Ruta de descarga de Git*: https://git-scm.com/downloads    
Una vez descargado el ejecutable, teniendo en cuenta el sistema operativo del usuario, se procede a 
la instalación, la cual es guiada e intuitiva.

![Extensión vscode-style-components](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitLogo.png?raw=true)

**Github**: GitHub es la herramienta perfecta para nuestro equipo. En primer lugar, nos permite  mantener un control preciso de cada cambio en nuestro código, lo que facilita la colaboración  en tiempo real y minimiza los conflictos. Además, es posible realizar revisiones de código,  abrir problemas y fusionar solicitudes de extracción de manera fluida hace que nuestro  trabajo en equipo sea más eficiente y efectivo. En resumen, GitHub se ha convertido en el  núcleo de nuestra estrategia de desarrollo.

Ruta de descarga: https://desktop.github.com    
Una vez descargado el ejecutable, teniendo en cuenta el sistema operativo del usuario, se procede a la instalación, la cual es guiada e intuitiva.

![Extensión vscode-style-components](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/GitHubLogo.png?raw=true)

### 5.1.2. Source Code Management.
El repositorio de Github donde esta el proyecto y el markdown de este informe será [https://github.com/LuceroObispoRios/Grupo1_WS52.git]  
  
Implementaremos una main branch, la cual representara la versión estable del software. Por otro lado para cada feature se creara un Branch separado llamado feature/nombre. Esto nos permitira trabajar en cada feature sin afectar el main branch.  
  
Estas ramas se deben distinguir claramente y por ello es que utilizaran prefijos descriptivos que identifiquen la funcionalidad que se esta desarrollando en la rama. Por ejemplo, si estamos trabajando una función de registro de usuarios, se podria utilizar el prefijo "feature/registration" en el nombremiento de la rama. Al mismo tiempo se recomienda el uso de guiones (-) u otros separadores como barras diagonales(/) cuando sea meritorio en el nombre de las ramas. Esto mejora la estructura del nombre y la legibilidad de este.  
  
Otras cuestiones del manejo del codigo son utilizar letras minusculas, para mantener consistencia y evitar problemas potenciales en el control de versiones, en los nombres de las branches, asi como ser concisos con el nombramiento de archivos y ramas, evitando a su vez nombres genericos o ambiguos. Por ultimo, aunque no lo planteamos como obligatorio, es usar el idioma inglés en el repositorio, tanto en archivos como ramas, de esta manera se mantiene mayor coherencia y uniformidad.  
  
### 5.1.3. Source Code Style Guide & Conventions.  
***Gherkin:***   
(user Story).feature  
Descripción: Es un lenguaje específico de Dominio (DSL), diseñado para resolver un problema muy específico en “pasos”. Está diseñado para ser legible y comprensible tanto por técnicos como por personas no técnicas como perfiles de negocio.  
Convenciones: De acuerdo a Cucumber (s.f.), Gherkin utiliza palabras clave específicas como “Given” (dado), “When” (cuando), “Then” (entonces) y “And” (y) para estructurar escenarios claros y comprensibles; mientras que, las tablas se utilizan para representar datos de entrada y salida usados en los escenarios. Asimismo, se deben tener en cuenta sólo agregar comentarios significativos (líneas que comienza con ”#”) y que cada archivo Gherkin contiene una única característica, y esta contiene uno o más escenarios.  

***HTML:***    
(file).html  
Descripción: Hypertext Makeup Language es el lenguaje estándar que se utiliza para crear y estructurar el contenido de páginas web. Consiste en una serie de etiquetas y elementos que definen diferentes partes del contenido para que se vean o comporten de una determinada manera. 
Convenciones: De acuerdo a W3Schools (s.f.), para facilitar la lectura y la coherencia en el código, es necesario usar espacios o tabulaciones de manera consistente, escribir los nombres de las etiquetas y de los archivos en minúsculas, usar comillas dobles para definir atributos en las etiquetas, usar el elemento <"link"> y <"script"> para relacion el archivo html con los archivos css y javascript respectivamente. Asimismo, es importante que cada elemento esté cerrado y que se agreguen solo comentarios significativos (“<!--” para iniciar un comentario y “-->” para cerrarlo).  

***CSS:***  
(file).css  
Descripción: Cascading Style Sheets en un lenguaje de hojas de estilo que es utilizado para dar formato y diseño a las páginas web.  
Convenciones: De acuerdo a MDN Web Docs (s.f.), para mejorar la legibilidad, se debe mantener los espacios adecuados, se usarán nombres de clases y selectores en minúscula y claros que reflejen su función, se debe procurar agrupar propiedades relacionadas juntas en el mismo bloque, y se usarán los id’s para poder modificar algún atributo en específico.  

***JavaScript:***  
(file).js  
Descripción: Lenguaje de programación que se usa para poder darle funcionalidades a las páginas web y que permita manipular su contenido y responder a acciones del usuario.  
Convenciones: De acuerdo a MDN Web Docs (s.f.), para mejorar la comprensión del código, se utilizaran nombre de variables y funciones en minúscula, no abreviados y que describan su propósito. Asimismo, se dividirán funciones largas en funciones más pequeñas para facilitar la lectura. 

***Vue***  
Descripción: Framework de Javascript que se usa para construir interfaces de usuario interactivas y dinamicas en aplicaciones web.
Convenciones: De acuerdo a Vue (s.f.), la nomenclatura debe estar en formato camelCase. Tambien, se utilizara el prefijo "v" en plantillas HTML como 'v-if', 'v-for', 'v-bind', etc.

### 5.1.4. Software Deployment Configuration.
Para el desplegue de nuestra aplicación decidimos usar firebase.  

El despliegue de la aplicación se realiza primero creando una cuenta en [https://firebase.google.com](https://firebase.google.com), a partir de eso, se debe crear un proyecto vacio en el cual guardar el despliegue del proyecto.  
![Proyecto en Firebase](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/firebase.JPG?raw=true)

Para realizar el despliegue en si, se tiene que ejecutar los siguientes comandos en orden :  
![Paso1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/paso1.JPG?raw=true)   
![Paso2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/paso2.JPG?raw=true)   
![Paso4](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/paso4.JPG?raw=true)   
  
En este punto se generara la carpeta dist  
  
![CarpetaDist](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/dist.JPG?raw=true)    
  
Ahora, para inicializar el despliegue:  
![Paso3](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/paso3.JPG?raw=true)  
![Paso5](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/paso5.JPG?raw=true) 
![Paso6](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/paso6.JPG?raw=true)  
  
Con esto nuestra aplicación fue desplegada y se puede encontrar en el siguiente link:  
[https://cargasinestres-tb2.web.app](https://cargasinestres-tb2.web.app)

*Para que funcione correctamente se tiene que hacer $json-server --watch db.json --routes routes.json , a nuestra db en json 

## 5.2. Landing Page, Services & Applications Implementation.

### 5.2.1. Sprint 1

#### 5.2.1.1. Sprint Planning 1.
| **Sprint 1** | |
|:---: | :---| 
| | **Sprint planning background** |   
| Date | 27/08/23 |
| Time | 08:00 PM |
| Location | Google Meet - Virtual Meeting |
| Prepared by | Obispo, Lucero |
| Attendees to meeting | Cuevas, Eric / O´Higgins, Andrea / Vilcamiza, Damaris  |
| Sprint n - 0 Review Summary | Se termino de Arreglar los contenidos de los capitulos 1 a 4, y la opinion general es que se hizo satisfactoriamente respecto al tiempo que se utilizo. |
| Sprint n - 0 Retrospective Summary | Las opiniones del equipo indican que durante el transcurso de ese sprint se logro encontrar una manera en la cual esl grupo podria trabajar fluidamente. |
| | **Sprint Goal & User Stories** |
| Sprint & Goal | El objetivo del Sprint 1 sera terminar la Landing Page, asi como los sistemas de registro y login de la aplicación, desarrollandolos de manera que sean responsive y coherentes con el Diseño de Carga sin Estres, además de empezar las preparaciones para desplegar el suigiente sprint. |
| Sprint & Velocity | Debido al alcanze establecido para este sprint, asi como el tiempo que se tiene para realizar este considerando el trabajo anterior, el Velocity establecido para este sprint es 35 |
| Sum of Story Point | La suma de Story points que el equipo estara desarrollano este sprint es 30 |

#### 5.2.1.2. Sprint Backlog 1.

|     Sprint #         |     Sprint 1                |                           |                                                        |                                                                                             |                   |                         |                      |
|----------------------|-----------------------------|---------------------------|--------------------------------------------------------|---------------------------------------------------------------------------------------------|-------------------|-------------------------|----------------------|
|     User   Story     |                             |     Work –   Item/Task    |                                                        |                                                                                             |                   |                         |                      |
|     Id               |     Título                  |     Id                    |     Título                                             |     Descripción                                                                             |     Estimación    |     Asignado   a        |     Estado           |
|     HU001 – HU007    |     Manejo de Usuario       |     WI01                  |     Registro   de empresas de mudanza                  |     Hacer uso de HTML, CSS y JavaScript para implementar el registro de empresas            |     2h            |     Andrea O’Higgins    |     Completado       |
|                      |                             |     WI02                  |     Registro   de cliente                              |     Hacer uso de HTML, CSS y JavaScript para implementar el registro de cliente             |     2h            |     Andrea O’Higgins    |     Completado       |
|                      |                             |     WI03                  |     Iniciar   Sesión la plataforma                     |     Hacer uso de HTML, CSS y JavaScript para implementar la estructura   del login          |     4h            |     Andrea O’Higgins    |     Completado       |
|                      |                             |     WI04                  |     Solicitud   de servicio de mudanza                 |     Hacer uso de HTML, CSS y JavaScript para implementar la solicitud de   servicio         |     2h            |     Lucero Obispo       |     Por completar    |
|                      |                             |     WI05                  |     Visualizar   empresas de mudanza                   |     Hacer uso de HTML y CSS para visualizar las empresas de mudanza                         |     1h            |     Lucero Obispo       |     Completado       |
|                      |                             |     WI06                  |     Seleccionar   empresa de mudanza                   |     Hacer uso de HTML, CSS y JavaScript para seleccionar la empresa de   mudanza            |     2h            |     Lucero Obispo       |     Completado       |
|                      |                             |     WI07                  |     Cerrar   Sesión                                    |     Hacer uso de HTML, CSS y JavaScript para implementar el cierre de   sesión.             |     2h            |     Andrea O’Higgins    |     Por completar    |
|     HU008-HU011      |     Métodos de pago         |     WI08                  |     Elección   de membresía de empresa                 |     Hacer uso de HTML y JavaScript para implementar la elección de   membresía              |     2h            |     Lucero Obispo       |     Por completar    |
|                      |                             |     WI09                  |     Pago   de membresía                                |     Hacer uso de HTML y JavaScript para implementar el pago de membresía                    |     2h            |     Eric Cuevas         |     Por completar    |
|                      |                             |     WI10                  |     Selección   de método de pago                      |     Hacer uso de HTML y JavaScript para implementar la selección de método   de pago        |     3h            |     Eric Cuevas         |     Por completar    |
|                      |                             |     WI11                  |     Detalles   de pago                                 |     Hacer uso de HTML para implementar los detalles de pago                                 |     1h            |     Eric Cuevas         |     Por completar    |
|     HU012-HU016      |     Búsqueda de empresas    |     WI12                  |     Búsqueda de empresas cercanas                      |     Hacer uso de HTML y JavaScript para implementar la búsqueda de   empresa                |     1h            |     Damaris Tasayco     |     Completado       |
|                      |                             |     WI13                  |     Filtrar por servicios ofrecidos                    |     Hacer uso de HTML y JavaScript para implementar el filtrado por servicios               |     2h            |     Damaris Tasayco     |     Por completar    |
|                      |                             |     WI14                  |     Filtrar por calificación                           |     Hacer uso de HTML y JavaScript para implementar el filtrado por calificación            |     2h            |     Damaris Tasayco     |     Por completar    |
|                      |                             |     WI15                  |     Visualización de disponibilidad                    |     Hacer uso de HTML y JavaScript para implementar la visualización de   disponibilidad    |     1h            |     Lucero Obispo       |     Por completar    |
|                      |                             |     WI16                  |     Visualizar perfil de empresa                       |     Hacer uso de HTML, CSS y JavaScript para implementar el perfil de empresa               |     1h            |     Lucero Obispo       |     Completado       |
|     HU017-HU021      |     Reserva de servicios    |     WI17                  |     Ingresar   a la reserva del servicio               |     Hacer uso de HTML y JavaScript para ingresar a la reserva del   servicio                |     2h            |     Eric Cuevas         |     Por completar    |
|                      |                             |     WI18                  |     Seleccionar   servicios a reservar                 |     Hacer uso de HTML y JavaScript para implementar la selección de   servicios             |     2h            |     Eric Cuevas         |     Completado       |
|                      |                             |     WI19                  |     Envío   de información sobre la posible reserva    |     Hacer uso de JavaScript para implementar el envío de información                        |     1h            |     Damaris Tasayco     |     Por completar    |
|                      |                             |     WI20                  |     Contactar   con el trabajador de la empresa        |     Hacer uso de HTML para implementar el contacto con el trabajador                        |     1h            |     Damaris Tasayco     |     Por completar    |
|                      |                             |     WI21                  |     Acordar   un precio por servicio reservado         |     Hacer uso de HTML y JavaScript para aceptar la reserva.                                 |     1h            |     Damaris Tasayco     |     Por completar    |

#### 5.2.1.3. Development Evidence for Sprint Review.

| **Repository**                                      | **Branch** |             **Commit Id**                 | **Commit Message**                        | **Commit Message Body** | **Commited on (Date)** |
|--------|----------|--------|-------|-------|--------|
| https://github.com/LuceroObispoRios/Grupo1_WS52.git | main       |  adeab3adab0d7d8e516d4d737b6a9a53e90a7ae5 | Create index.html                         |           -             |        29/08/2023      |
|                                                     | main       | 1c5836a269bf7a816ea2fef09057784bf48f6247  | Update Index.html                         |           -             |        30/08/2023      |
|                                                     | main       | ffe7eb207a661f4b70ebd9e49a84506d54349f43  | Add files via upload (inicio-sesion.html) |           -             |        31/08/2023      |
|                                                     | main       | f0e3e5ca74f48dd4289f57f836c774ea0caa357f  | Add files via upload (reg-empresa.html    |           -             |        02/09/2023      |
|                                                     | main       | 51e1be5e36f6677bd62e7544d1e18a84e83462d7  | Add files via upload (reg-cliente.html)   |           -             |        03/09/2023      |


#### 5.2.1.4. Testing Suite Evidence for Sprint Review.

Acceptance Tests de los User Stories, archivos .feature utilizando el lenguaje Gherkin

![feature 1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us01.png?raw=true)    

![feature 2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us02.png?raw=true)  

![feature 3](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us03.png?raw=true)

![feature 4](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us04.png?raw=true)

![feature 5](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us05.png?raw=true)

![feature 6](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us06.png?raw=true)

![feature 7](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us07.png?raw=true)

![feature 8](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us08.png?raw=true)

![feature 9](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us09.png?raw=true)

![feature 10](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us10.png?raw=true)

![feature 11](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us11.png?raw=true)

![feature 12](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US012.jpg?raw=true)  

![feature 13](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US013.jpg?raw=true)  
 
![feature 14](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US014.jpg?raw=true)  

![feature 15](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US015.jpg?raw=true)  

![feature 16](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US016.jpg?raw=true)  

![feature 17](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US017.jpg?raw=true)  

![feature 18](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US018.jpg?raw=true)  
 
![feature 19](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US019.jpg?raw=true) 

![feature 20](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US020.jpg?raw=true)  

![feature 21](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/US021.jpg?raw=true)

#### 5.2.1.5. Execution Evidence for Sprint Review.
***Primer Sprint***  
Durante este sprint, nos enfocamos en completar el landing page y en las páginas de registro para cuenta de empresa, registro para cuenta de cliente, inicio de sesión y la página de búsqueda de empresas.  
![landing page](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution_sprint1.JPG?raw=true)   

![landing page](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution2_sprint1.JPG?raw=true)   

![landing page](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution3_sprint1.JPG?raw=true)   

![inicio sesion](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution4_sprint1.JPG?raw=true)   

![busqueda empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution5_sprint1.JPG?raw=true)   

![busqueda empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution6_sprint1.JPG?raw=true)   

![registro cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution7_sprint1.JPG?raw=true)  

![registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-empresa.png?raw=true)  

![registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution9_sprint1.JPG?raw=true)  

Link al repositorio de codigo: https://github.com/LuceroObispoRios/Grupo1_WS52.git  
Link a la plataforma:  https://luceroobisporios.github.io/Grupo1_WS52/Proyecto/Index.html  
Link al video de ejecución: https://drive.google.com/file/d/1dpaDSXDfR2oe4wCnh-DZ4etNm-LF_cYg/view?usp=sharing   

#### 5.2.1.6. Services Documentation Evidence for Sprint Review.

*Para este **primer** Sprint no fue contemplado la evidencia de la documentación de nuestros servicios.*

#### 5.2.1.7. Software Deployment Evidence for Sprint Review.

* Para este **primer** avance, el cual abarcaba la landing page, asi como el registro y login de usuarios, se llevo a cabo un desplegue por medio de GitHub Pages.  
![Page_deployment](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/landing-page-deployment.jpeg?raw=true)  

#### 5.2.1.8. Team Collaboration Insights during Sprint.
***Primer Sprint***  
Durante el primer sprint, el equipo optó por dividir los puntos entre todos los integrantes por cada capítulo para completar el informe. También, se optó por dividir las páginas por integrante teniendo en cuenta que estas deberán ser responsive y funcionales. Para asegurar que todo esté realizado correctamente, se organizaron reuniones constantes que se llevaron a cabo a través de Google Meet, donde se logró completar el informe y el código de las páginas landing page, registro para cuenta de empresa, registro para cuenta de cliente, inicio de sesión y la página de búsqueda de empresas.  

Asimismo, nuestra estructura en nuestro repositorio de GitHub se basa de la rama rama main, en el cual colocabamos todo los cambios de todos los integrantes, ya sea del proyecto o informe. 

A continuación, se presentan screenshots que reflejan el trabajo realizado durante este sprint.  

![team collaboration](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/teamcollaboration_sprint1.png?raw=true)     

![team collaboration](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/teamcollaboration2_sprint1.png?raw=true)  

![team collaboration](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/teamcollaboration3_sprint1.png?raw=true)  

### 5.2.2. Sprint 2
#### 5.2.2.1. Sprint Planning 2.  
  
| **Sprint 2** | |
|:---: | :---| 
| | **Sprint planning background** |   
| Date | 12/09/23 |
| Time | 08:00 PM |
| Location | Google Meet - Virtual Meeting |
| Prepared by | Obispo, Lucero |
| Attendees to meeting | Cuevas, Eric / O´Higgins, Andrea / Vilcamiza, Damaris  |
| Sprint n - 1 Review Summary | Se Inicio con el desarrollo de la aplicación web, implementandose la landing page y los principios de otras partes de la aplicación, asi como se termino una primera versión del informe |
| Sprint n - 1 Retrospective Summary | Junto con el feedback recibido, podemos acordar que varias partes del desarrollo en ambos el informe y aplicación necesitan mejoras para cumplir los estandares requeridos, aspiramos a que este sprint 2 sea mejor. |
| | **Sprint Goal & User Stories** |
| Sprint & Goal | El objetivo del Sprint 2 sera terminar con la sección de manejo de usuario, lo cual engloba el registro y ajuste de datos de ambos tipos de usuario, asi como el inicio de sesión de la app, y tambien se terminara con la busqueda de empresas, vista principal del cliente. A su vez se avanzaran la vista de membresias para empresas, del historial de reservas del cliente, asi como los servicios y componentes del dominio Public.|
| Sprint & Velocity | El Sprint Velocity establecido para este sprint es 60 |
| Sum of Story Point | La suma de Story points que el equipo estara desarrollando este sprint es 50 |  
  
#### 5.2.2.2. Sprint Backlog 2.  

|     Sprint #         |     Sprint 2             |                           |                                                        |                                                                                    |                   |                         |                      |
|----------------------|--------------------------|---------------------------|--------------------------------------------------------|------------------------------------------------------------------------------------|-------------------|-------------------------|----------------------|
|     User   Story     |                          |     Work –   Item/Task    |                                                        |                                                                                    |                   |                         |                      |
|     Id               |     Título               |     Id                    |     Título                                             |     Descripción                                                                    |     Estimación    |     Asignado   a        |     Estado           |
|     HU001 – HU006    |     Manejo de Usuario    |     WI01                  |     Registro de Empresa de Mudanzas                    |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI02                  |     Registro de Cliente                                |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI03                  |     Iniciar Sesión en la plataforma                    |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     4h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI04                  |     Ajustes de cuenta de cliente                       |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI05                  |     Ajustes de cuenta de empresa                       |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     1h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI06                  |     Cerrar Sesión                                      |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Eric Cuevas         |     Completado       |
| HU007-HU010          | Métodos de pago          |     WI07                  |     Elección de membresía de empresa                   |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     4h            |     Damaris Tasayco     |     Completado       |
|                      |                          |     WI08                  |     Pago de membresía                                  |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Damaris Tasayco     |     Completado       |
|                      |                          |     WI09                  |     Pago para reserva de servicio                      |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Damaris Tasayco     |     Por completar    |
|                      |                          |     WI10                  |     Detalles de pago                                   |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Damaris Tasayco     |     Completado       |
| HU011-HU014          | Búsqueda de empresas     |     WI11                  |     Búsqueda de empresas cercanas                      |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     4h            |     Lucero Obispo       |     Completado       |
|                      |                          |     WI12                  |     Filtrar por servicios ofrecidos                    |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Lucero Obispo       |     Completado       |
|                      |                          |     WI13                  |     Filtrar por calificación                           |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Lucero Obispo       |     Completado       |
| HU014-HU016          | Reserva de Servicios     |     WI14                  |     Visualizar perfil de empresa                       |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Lucero Obispo       |     Completado       |
|                      |                          |     WI15                  |     Envío de información sobre la   posible reserva    |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Por completar    |
|                      |                          |     WI16                  |     Acordar un precio por servicio   reservado         |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Completado       |
| HU017                | Historial de reservas    |     WI17                  |     Visualizar historial de reservas                   |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Completado       |
| HU018                | Chat de reservas         |     WI18                  |     Comunicación mediante chat con la empresa          |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Completado       |
  
#### 5.2.2.3. Development Evidence for Sprint Review.  

Para este Sprint se desarrolló el Frontend de la plataforma.
![development evidence](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/development-evidence-sprint2.png?raw=true)
  
#### 5.2.2.4. Testing Suite Evidence for Sprint Review.  
  
Acceptance Tests de los User Stories, archivos .feature utilizando el lenguaje Gherkin
  
![feature 01](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us01.png?raw=true)  
![feature 02](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature02-sprint2.png?raw=true)  
![feature 03](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature03-sprint2.png?raw=true)  
![feature 04](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature04-sprint2.png?raw=true)  
![feature 05](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature05-sprint2.png?raw=true)  
![feature 06](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature06-sprint2.png?raw=true)  
![feature 07](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature07-sprint2.png?raw=true)  
![feature 08](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature08-sprint2.png?raw=true)  
![feature 09](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature09-sprint2.png?raw=true)   
![feature 10](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US10.jpg?raw=true)
![feature 11](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US11.jpg?raw=true)
![feature 12](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US12.jpg?raw=true)  
![feature 13](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US13.jpg?raw=true)  
![feature 14](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US14.jpg?raw=true)  
![feature 15](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US15.jpg?raw=true)  
![feature 16](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US16.jpg?raw=true)  
![feature 17](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US17.jpg?raw=true)  
![feature 18](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US18.jpg?raw=true) 

  
#### 5.2.2.5. Execution Evidence for Sprint Review. 
***Segundo Sprint***  
Durante este sprint, nos enfocamos en terminar con la sección de manejo de usuario, lo cual engloba el registro y ajuste de datos de ambos tipos de usuario, asi como el inicio de sesión de la app, y tambien con la busqueda de empresas, vista principal del cliente. A su vez se avanzaran la vista de membresias para empresas, del historial de reservas del cliente, asi como los servicios y componentes del dominio Public.   
  
![Login-sprint2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution1.JPG?raw=true)  
![Registrar-cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution2.JPG?raw=true)
![registrar-empresa1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution3.JPG?raw=true)
![registrar-empresa2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution4.JPG?raw=true)
![ajustes de cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution5.JPG?raw=true)
![busqueda de empresas](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution6.JPG?raw=true)
![Carta de información de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution7.JPG?raw=true)
![historial de reservas](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution8.JPG?raw=true)
![ajustes de empresa 1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution9.JPG?raw=true)
![ajustes de empresa 2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution10.JPG?raw=true)
![membresias](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution11.JPG?raw=true)
![membresias2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/execution12.JPG?raw=true)
  
Link al repositorio de codigo: https://github.com/LuceroObispoRios/Grupo1_WS52.git  
Link a la plataforma: [https://cargasinestres-vue.web.app/home](https://cargasinestres-vue.web.app/home)  
  
#### 5.2.2.6. Services Documentation Evidence for Sprint Review.  
  
**Introducion:**  
Para este segundo sprint se ha logrado implementar 12 endpoints, los cuales han sido exitosamente logrados y documentados.  
Los metodos GET clients y companies con parametro de id estan relacionados a la pantalla de Login, para verificar que el usuario existe en la base de datos json.  
Asmismo, los metodos POST companies y clientes estan relacionados a las pantallas de Register Client y Register Company para registrar la informacion tanto del cliente como de la empresa.  
Los metodos PUT clients y companies estan relacionados a las pantallas Client Settings y Company Settings, para editar los datos de estos.  
Los metodos GET companies y GET companies con parametro de id, estan relacionados a la pantalla de Busqueda de Empresas, donde el usuario puede ver la lista completa de empresa, y cuando le da click a una fila puede acceder a la informacion de una empresa en especifica.  
Por ultimo, los metodos POST bookingHistory, GET booking History, asi como los metodos GET chat y POST chat permiten al usuario crear una reserva como visualizar en el historia de reservas, teniendo en cuenta que desde este historial se puede crear mensajes.
  
**Tabla:**  

|     **Endpoint**    | **Metodo HTTP** |           **Acciones (Explicacion del response)**                                                           | **Enlace** | 
|--------|----------|--------|-------|
|  /companies         |       GET       | 200 OK: Retorna la lista de todas las empresas registradas                                                  |    [https://cargasinestres-vue.web.app/company-search](https://cargasinestres-vue.web.app/company-search)     |
|  /companies/{id}    |       GET       | 200 OK: Retorna información de la compañía correspondiente al ID especificado (parametro: id, ejemplo: '1') |    [https://cargasinestres-vue.web.app/company/1](https://cargasinestres-vue.web.app/company/1)        |
|  /bookingHistory    |       POST      | 201 Created: Indica que la reserva ha sido creada exitosamente                                              |    [https://cargasinestres-vue.web.app/company/1](https://cargasinestres-vue.web.app/company/1)        |
|  /bookingHistory    |       GET       | 200 OK: Retorna la lista de todas las reservas de historial registradas                                     |    [https://cargasinestres-vue.web.app/bookingHistory](https://cargasinestres-vue.web.app/bookingHistory)       |
|  /clients           |       GET       | 200 OK: Retorna la información del cliente si el email y contrasena son válidas                             |    [https://cargasinestres-vue.web.app/login](https://cargasinestres-vue.web.app/login)   |
|  /companies         |       GET       | 200 OK: Retorna la información de la empresa si el email y contrasena son válida                            |    [https://cargasinestres-vue.web.app/login](https://cargasinestres-vue.web.app/login)       |
|  /clients           |       POST      | 201 Created: Indica que el cliente ha sido creado exitosamente                                              |    [https://cargasinestres-vue.web.app/register-client](https://cargasinestres-vue.web.app/register-client)     |
|  /companies         |       POST      | 201 Created: Indica que la compañía ha sido creada exitosamente                                             |    [https://cargasinestres-vue.web.app/register-company](https://cargasinestres-vue.web.app/register-company)        |
|  /clients/{id}      |       PUT       | 200 OK: Indica que los datos del cliente han sido actualizados exitosamente (parametro: id, ejemplo: '31')      |    [https://cargasinestres-vue.web.app/client-settings/1](https://cargasinestres-vue.web.app/client-settings/1)     |
|  /companies/{id}    |       PUT       | 200 OK: Indica que los datos de la compañía han sido actualizados exitosamente (paranetro: id, ejemplo: '2')    |   [https://cargasinestres-vue.web.app/company-settings/8](https://cargasinestres-vue.web.app/company-settings/8)    |  
  
Link del Repositorio de Web Services: [https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/carga-sin-estres/src/company-search/services/cargaSinEstres-api.service.js](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/carga-sin-estres/src/company-search/services/cargaSinEstres-api.service.js)
  
**Captura de interaccion con datos de prueba**   
*Registrar Cliente*  
- Antes de registrar cliente Lucero. Como se puede ver, el unico cliente es Eric  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services1.JPG?raw=true)
  
- Despues de registrar el cliente Lucero. Como se puede ver, el db.json cambio, pues se ha agregado un nuevo registro que guarda la informacion del cliente lucero. Mediante la sintaxis POST /clients  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services2.JPG?raw=true)
  
*Obtener la informacion de una empresa por su id*   
- Mediante la sintaxis GET /companies/{id}. En la consola se puede visualizar la informacion obtenida de esa empresa en especifico  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services3.JPG?raw=true)  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services4.JPG?raw=true)
  
*Realizar una reserva*   
- Mediante la sintaxis POST /bookingHistory. Se crea una reserva y se almacena el db.json, se puede ver en la consola la informacion de la nueva reserva.  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services5.JPG?raw=true)
  
**Editar datos de una empresa**   
- Antes de presionar el boton de guardar cambios, se puede ver en la consola que la informacion de la direccion de la empresa Mudanzas Plata es en Monterrico  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services6.JPG?raw=true)
  
- Mediante la sintaxis PUT /clients/{id}. Se edita los datos de la empresa de mudanzas plata, y son reemplazados por la nueva informacion ingresada en el formulario. Por ejemplo la direccion cambio a San Isidro  
![servicios-ejemplos](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/services7.JPG?raw=true)
  
#### 5.2.2.7. Software Deployment Evidence for Sprint Review.  
  
La aplicación desplegada se encuentra en el siguiente enlace  
[https://cargasinestres-vue.web.app](https://cargasinestres-vue.web.app),   
más para su correcto funcionamiento, se necesita desplegar el servidor json-server de nustro archivo db.json, en cual se encuentra en el siguiente enlace [https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/carga-sin-estres/server/db.json](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/carga-sin-estres/server/db.json)     
  
#### 5.2.2.8. Team Collaboration Insights during Sprint.  

Durante este sprint, nuestro equipo trabajó de manera organizada en GitHub. Establecimos dos ramas principales: "main" para el informe final y "develop" para consolidar las contribuciones de todos. Cada uno de nosotros tenía su propia rama personalizada, lo que nos permitió trabajar de manera eficiente y llevar un registro claro de nuestras contribuciones al proyecto. Realizamos reuniones regulares y actualizaciones periódicas para asegurarnos de que todos contribuyeran de manera equitativa. Esta estructura organizativa y enfoque de colaboración eficiente fueron esenciales para nuestro éxito en este sprint.

**GitFlow**     
![gitflow1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/gitflowSprint2.JPG?raw=true)  
![gitflow2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/gitflowSprint2_1.JPG?raw=true)  
  
**Contribuitors**    
![contribuitors](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/contribuitorsSprint2.JPG?raw=true)   

### 5.2.3. Sprint 3
  
#### 5.2.3.1. Sprint Planning 3.  
| **Sprint 1** | |
|:---: | :---| 
| | **Sprint planning background** |   
| Date | 2/10/23 |
| Time | 08:00 PM |
| Location | Google Meet - Virtual Meeting |
| Prepared by | Obispo, Lucero |
| Attendees to meeting | Cuevas, Eric / O´Higgins, Andrea / Vilcamiza, Damaris / ... ,Leonardo |
| Sprint 2 Review Summary | Se realizo el sprint 2, se mejoro el codigo y se trato de terminar el aspecto front-end de la aplicación |
| Sprint 2 Retrospective Summary | Se trabajo fluidamente, participando todos por igual en la realización del proyecto, más en la aopinión del grupo creemos que pudimos haber terminado más partes del front-end. |
| | **Sprint Goal & User Stories** |
| Sprint & Goal | El objetivo del Sprint 3 sera terminar Frontend de la applicación, asi como avanzar el back-end hasta un punto funcional que podamos completar el siguiente sprint. |
| Sprint & Velocity | Debido al alcanze establecido para este sprint, el Velocity establecido para este sprint es 39. |
| Sum of Story Point | La suma de Story points que el equipo estara desarrollano este sprint es 39. |

#### 5.2.3.2. Sprint Backlog 3.

|     Sprint #         |     Sprint 3             |                           |                                                                      |                                                                                    |                   |                         |                      |
|----------------------|--------------------------|---------------------------|----------------------------------------------------------------------|------------------------------------------------------------------------------------|-------------------|-------------------------|----------------------|
|     User   Story     |                          |     Work –   Item/Task    |                                                                      |                                                                                    |                   |                         |                      |
|     Id               |     Título               |     Id                    |     Título                                                           |     Descripción                                                                    |     Estimación    |     Asignado   a        |     Estado           |
| HU001-HU003          |    Manejo de Usuario     |     WI01                  |     Ajustes de cuenta de cliente                                     |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI02                  |     Ajustes de cuenta de empresa                                     |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Eric Cuevas         |     Completado       |
|                      |                          |     WI03                  |     Visualización de membresia de la empresa                         |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     1h            |     Damaris Tasayco     |     Completado       |
| HU004-HU005          | Métodos de pago          |     WI04                  |     Pago para reserva de servicio                                    |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     4h            |     Andrea O’Higgins    |     Completado       |
|                      |                          |     WI05                  |     Activar funcionalidades de membresia                             |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Damaris Tasayco     |     Completado       |
| HU006-HU010          | Búsqueda de empresas     |     WI06                  |     Búsqueda de empresas cercanas                                    |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     4h            |     Lucero Obispo       |     Completado       |
|                      |                          |     WI07                  |     Filtrar por servicios ofrecidos                                  |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     3h            |     Lucero Obispo       |     Completado       |
|                      |                          |     WI08                  |     Filtrar por calificación                                         |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Leonardo Patrocinio |     Completado       |
|                      |                          |     WI09                  |     Filtrar por ubicación                                            |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Lucero Obispo       |     Completado       |
|                      |                          |     WI10                  |     Solicitar Carga rápida                                           |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Eric Cuevas         |     Completado       |
| HU011-HU013          | Reserva de Servicios     |     WI11                  |     Realizar la transacción                                          |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Damaris Tasayco     |     Completado       |
|                      |                          |     WI12                  |     Visualizar la calificación de la empresa                         |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Leonardo Patrocinio |     Completado       |
|                      |                          |     WI13                  |     Visualizar reseñas de los trabajadores de empresa de mudanza     |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Completado       |
| HU013 - HU016        | Historial de reservas    |     WI14                  |     Realizar una reseña a la empresa                                 |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Leonardo Patrocinio |     Completado       |
|                      |                          |     WI15                  |     Cancelar reserva                                                 |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Completado       |
|                      |                          |     WI16                  |     Agregar reseña de un trabajador de empresa                       |     Hacer uso de la herramienta WebStorm, los lenguajes:  VUE, CSS y JavaScript    |     2h            |     Andrea O’Higgins    |     Completado       |

#### 5.2.3.3. Development Evidence for Sprint Review.  

Para este Sprint se desarrolló el frontend y backend de la plataforma.  

<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_SW53/blob/main/Informe/Imagenes/development-evidence-sprint3-1.png?raw=true" alt="Development Evidence - parte 1" width="400">
</div>  
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_SW53/blob/main/Informe/Imagenes/development-evidence-sprint3-2.png?raw=true" alt="Development Evidence - parte 2" width="400">
</div>  
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_SW53/blob/main/Informe/Imagenes/development-evidence-sprint3-3.png?raw=true" alt="Development Evidence - parte 3" width="400">
</div>  

#### 5.2.3.4. Testing Suite Evidence for Sprint Review.  
Acceptance Tests actualizados de los User Stories, archivos .feature utilizando el lenguaje Gherkin.  


**feature 9**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature9-sprint3.png?raw=true" width="600px" alt="feature 9">
</div>

**feature 10**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature10-sprint3.png?raw=true" width="600px" alt="feature 10">
</div>

**feature 11**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature11-sprint3.png?raw=true" width="600px" alt="feature 11">
</div>

**feature 15**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature15-sprint3.png?raw=true" width="600px" alt="feature 15">
</div>

**feature 16**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature16-sprint3.png?raw=true" width="600px" alt="feature 16">
</div>

**feature 17**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature17-sprint3.png?raw=true" width="600px" alt="feature 17">
</div>

**feature 18**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature18-sprint3.png?raw=true" width="600px" alt="feature 18">
</div>

**feature 19**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature19-sprint3.png?raw=true" width="600px" alt="feature 19">
</div>

**feature 20**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature20-sprint3.png?raw=true" width="600px" alt="feature 20">
</div>

**feature 21**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature21-sprint3.png?raw=true" width="600px" alt="feature 21">
</div>

**feature 22**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature22-sprint3.png?raw=true" width="600px" alt="feature 22">
</div>  

**feature 23**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature23-sprint3.png?raw=true" width="600px" alt="feature 23">
</div> 

**feature 24**
<div style="text-align:center;">
    <img src="https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature24-sprint3.png?raw=true" width="600px" alt="feature 24">
</div> 


#### 5.2.3.5. Execution Evidence for Sprint Review  

Durante este tercer sprint, en términos generales, hemos alcanzado los siguientes hitos:

- Establecimiento de múltiples archivos(frontend,backend, informes) en el repositorio de nuestro GitHub. 
- Elaboración del frontend(membresía, reseñas, añadir filtros por servicio, )
- Realización de la implementación de companies, client y reviews en backend
- Despliegue del fronted de Carga Sin Estrés

##### Empresa
![membership]https://github.com/LuceroObispoRios/Grupo1_WS52/raw/develop/Informe/Imagenes/membership.jpg?raw=true)
![membership2](https://github.com/LuceroObispoRios/Grupo1_WS52/raw/develop/Informe/Imagenes/membership1.jpg?raw=true)

##### Cliente
![filtro](https://github.com/LuceroObispoRios/Grupo1_WS52/raw/develop/Informe/Imagenes/filtro.jpg?raw=true)
![reservas](https://github.com/LuceroObispoRios/Grupo1_WS52/raw/develop/Informe/Imagenes/reservas.jpg?raw=true)
![reseñas](https://github.com/LuceroObispoRios/Grupo1_WS52/raw/develop/Informe/Imagenes/rese%C3%B1as.jpg?raw=true)
  
#### 5.2.3.6. Services Documentation Evidence for Sprint Review.  

**Introduccion:**  
Para este tercer sprint se ha logrado implementar 11 endpoints, los cuales han sido exitosamente logrados y documentados.  
Los metodos GET clients y companies con parametro de id estan relacionados a la pantalla de Login, para verificar que el usuario existe en la base de datos json.  
Asmismo, los metodos POST companies y clientes estan relacionados a las pantallas de Register Client y Register Company para registrar la informacion tanto del cliente como de la empresa.  
Ademas, los metodos PUT companies y clientes estan relacionados a las pantallas de Client Settings y Company Settings para editar la informacion tanto del cliente como de la empresa.  
Los metodos GET all companies y GET companies con parametro de id, estan relacionados a la pantalla de Busqueda de Empresas, donde el usuario puede ver la lista completa de empresa, y cuando le da click a una fila puede acceder a la informacion de una empresa en especifica.  
Los metodos GET all reviews y GET reviews, estan relacionados a la pantalla de Informacion de Empresa porque aqui se visualizaran las reseñas que recibe, mientras que en la pantalla Historial de Reservas se podrá crear una reseña, una vez la reserva tenga como estado finalizado.

**Tabla:**  

|     **Endpoint**    | **Metodo HTTP** |           **Acciones (Explicacion del response)**                                                           | **Enlace** | 
|--------|----------|--------|-------|
|  /companies                    |       GET       | 200 OK: Retorna la lista de todas las empresas registradas                                                      | [https://localhost:7122/api/v1/companies](https://localhost:7122/api/v1/companies)  |
|  /companies/{id}               |       GET       | 200 OK: Retorna información de la compañía correspondiente al ID especificado (parametro: id, ejemplo: '1')     | [http://localhost:7122/api/v1/companies/1](http://localhost:7122/api/v1/companies/1)     |
|  /companies/sign-up            |       POST      | 201 Created: Indica que la compañía se ha registrado exitosamente                                               | [http://localhost:7122/api/v1/companies](http://localhost:7122/api/v1/companies/sign-up)     |
|  /companies/sign-in            |       POST      | 201 Created: Indica que la compañía se ha logeado exitosamente                                                  | [http://localhost:7122/api/v1/companies](http://localhost:7122/api/v1/companies/sign-in)     |
|  /companies/{id}               |       PUT       | 200 OK: Indica que la compañía con el ID especificado se ha actualizado con exito (parametro: id, ejemplo: '1') | [http://localhost:7122/api/v1/companies/1](http://localhost:7122/api/v1/companies/1)     |
|  /clients                      |       GET       | 200 OK: Retorna la lista de todos clientes registrados                                                          | [http://localhost:7122/api/v1/clients](http://localhost:7122/api/v1/clients)  |
|  /clients                      |       POST      | 201 Created: Indica que el cliente ha sido creado exitosamente                                                  | [http://localhost:7122/api/v1/clients](http://localhost:7122/api/v1/clients) |
|  /clients/{id}                 |       GET       | 200 OK: Retorna información del cliente correspondiente al ID especificado (parametro: id, ejemplo: '1')        | [http://localhost:7122/api/v1/clients/1](http://localhost:7122/api/v1/clients/1) |
|  /clients/{id}                 |       PUT       | 200 OK: Indica que el cliente con el ID especificado se ha actualizado con exito (parametro: id, ejemplo: '1')  | [http://localhost:7122/api/v1/clients/1](http://localhost:7122/api/v1/clients/1) |
|  /reviews                      |       POST      | 201 Created: Indica que la reseña ha sido creada exitosamente                                                   | [http://localhost:7122/api/v1/reviews](http://localhost:7122/api/v1/reviews) |
|  /reviews                      |       GET       | 200 OK: Retorna la lista de todas las reseñas guardadas                                                         | [http://localhost:7122/api/v1/reviews](http://localhost:7122/api/v1/reviews)  |

Link del Repositorio de Web Services: [https://github.com/LuceroObispoRios/Grupo1_WS52/tree/main/backend](https://github.com/LuceroObispoRios/Grupo1_WS52/tree/main/backend)  
Link del swagger desplegado: [http://ericcr-001-site1.atempurl.com/swagger/index.html](http://ericcr-001-site1.atempurl.com/swagger/index.html)

**Capturas de interaccion con datos de prueba**  
- Registrar empresa (POST)   
El usuario agrega una nueva empresa a la base de datos para registrarse. Esta operación se realiza mediante una solicitud HTTP POST. En este ejemplo vemos que el usuario ha colocado todos datos necesarios para registrar su empresa Plata
Una vez que se haya registrado la empresa, el servidor enviará una respuesta al cliente que realizó la solicitud POST. Esta respuesta generalmente incluirá un código de estado HTTP para indicar si la operación se realizó con éxito (por ejemplo, código 201 - Creado) o si hubo algún error (por ejemplo, código 400 - Error de solicitud).   
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services1_3.JPG?raw=true)   
- Registrar cliente (POST)   
El usuario agrega un nuevo cliente a la base de datos para registrarse. Esta operación se realiza mediante una solicitud HTTP POST. En este ejemplo vemos que el usuario Lucero ha colocado todos datos necesarios para registrar su cuenta personal
Una vez que se haya registrado el cliente, el servidor enviará una respuesta al cliente que realizó la solicitud POST. Esta respuesta generalmente incluirá un código de estado HTTP para indicar si la operación se realizó con éxito (por ejemplo, código 201 - Creado) o si hubo algún error (por ejemplo, código 400 - Error de solicitud).    
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services2_3.JPG?raw=true)   
- Registrar reseña (POST)   
El usuario agrega una nueva reseña a la base de datos para calificar el servicio brindado por una empresa. Esta operación se realiza mediante una solicitud HTTP POST. En este ejemplo vemos que el usuario ha colocado todos datos necesarios para publicar su reseña.
Una vez que se haya creado la reseña, el servidor enviará una respuesta al cliente que realizó la solicitud POST. Esta respuesta generalmente incluirá un código de estado HTTP para indicar si la operación se realizó con éxito (por ejemplo, código 201 - Creado) o si hubo algún error (por ejemplo, código 400 - Error de solicitud).   
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services3_3.JPG?raw=true)      
- Obtener lista de todas las empresas (GET)   
Los usuarios desean consultar una lista de todas las empresas registradas en la plataforma de búsqueda de servicios de mudanza. Esta operación se realiza mediante una solicitud HTTP GET. A continuación, se presenta un ejemplo en el que un cliente solicita la lista de todas las empresas disponibles.  
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services4_3.JPG?raw=true)     
- Obtener empresa por su id (GET)  
Los usuarios desean consultar la información de una empresa específica en la plataforma de búsqueda de servicios de mudanza. Esta operación se realiza mediante una solicitud HTTP GET utilizando el identificador único (ID) de la empresa. A continuación, se presenta un ejemplo en el que un cliente solicita la información de una empresa por su ID.    
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services5_3.JPG?raw=true)      
- Obtener cliente por su id (GET)
Los usuarios desean consultar su información personal, por eso se brinda el id del cliente. Esta operación se realiza mediante una solicitud HTTP GET utilizando el identificador único (ID) del cliente. A continuación, se presenta un ejemplo en el que se solicita la información de un cliente por su ID.  
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services6_3.JPG?raw=true)     
- Obtener reseñas (GET)    
Esta funcionalidad permite obtener reseñas asociadas a empresas. Se realiza una solicitud HTTP GET para recuperar los detalles de las reseñas de la empresa. A continuación, se presenta un ejemplo en el que se solicita información de las reseñas.   
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services7_3.JPG?raw=true)   
- Editar empresa (PUT)   
El usuario con cuenta de empresa edita sus datos para mantener su informacion actualizada para sus cliente.  Esta operación se realiza mediante una solicitud HTTP PUT utilizando el identificador único (ID) de la empresa. A continuación, se presenta un ejemplo en el que una empresa solicita actualizar su información brindando su ID.  
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services8_3.JPG?raw=true)   
- Editar cliente (PUT)    
El usuario con cuenta de cliente edita sus datos para mantener su informacion actualizada.  Esta operación se realiza mediante una solicitud HTTP PUT utilizando el identificador único (ID) del cliente. A continuación, se presenta un ejemplo en el que un cliente solicita actualizar su información brindando su ID.  
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services9_3.JPG?raw=true)
- Obtener lista de todos los clientes (GET)   
Consultar una lista de todas los clientes registrados en la plataforma de búsqueda de servicios de mudanza. Esta operación se realiza mediante una solicitud HTTP GET. A continuación, se presenta un ejemplo en el que solicita la lista de todas los clientes.  
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services10_3.JPG?raw=true)
- Logearse con cuenta de empresa (POST)  
El usuario ingresa su email y password para logearse en la web. Esta operación se realiza mediante una solicitud HTTP POST. En este ejemplo vemos que el usuario Plata ha colocado todos los datos necesarios para logearse en su cuenta empresa
Una vez que se haya logeado la empresa, el servidor enviará una respuesta al cliente que realizó la solicitud POST. Esta respuesta generalmente incluirá un código de estado HTTP para indicar si la operación se realizó con éxito (por ejemplo, código 201 - Creado) o si hubo algún error (por ejemplo, código 400 - Error de solicitud).    
![services](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/services11_3.JPG?raw=true)  

#### 5.2.3.7. Software Deployment Evidence for Sprint Review.  
  
La aplicación Frontend desplegada se encuentra en el siguiente enlace :  
[https://cargasinestres-vue-tb2.web.app/](https://cargasinestres-vue-tb2.web.app/),   
*más para su correcto funcionamiento esta entrega, se necesita desplegar el servidor json-server de nuestro archivo db.json, el cual se encuentra en este mismo repositorio  
  
Para el backend se puede acceder por medio de estos links:  
Este para el servidor - [https://win8030.site4now.net:8172/msdeploy.axd?site=ericcr-001-site1](https://win8030.site4now.net:8172/msdeploy.axd?site=ericcr-001-site1)  
*la cuenta es ericcr-001 y la contraseña u202112766  
Y este para la pagina - [http://ericcr-001-site1.atempurl.com/swagger/index.html](http://ericcr-001-site1.atempurl.com/swagger/index.html)  
  
#### 5.2.3.8. Team Collaboration Insights during Sprint.  

**Gitflow**
Durante este sprint, nuestra colaboración como equipo se destacó por una organización eficiente en nuestro repositorio de GitHub. Decidimos establecer un proceso sólido para gestionar nuestros commits y ramas, lo que contribuyó significativamente al flujo de trabajo. En primer lugar, designamos dos ramas fundamentales: "main" y "develop". La rama "main" se reservó para el informe final y el proyecto completo, listo para su presentación en esta entrega. La rama "develop" desempeñó un papel central, ya que la actualizamos constantemente. Fue en esta rama donde reunimos y fusionamos todas las contribuciones individuales de los miembros del equipo. Además, cada integrante tuvo su propia rama personalizada cuyo formato de nombre es "nombre de integrante/feature", esta organización garantizó que cada integrante tuviera su propio espacio para trabajar de manera efectiva y mantener un registro claro de sus aportaciones al proyecto en un entorno de colaboración sin problemas. Durante el proceso, establecimos una rutina de reuniones periódicas y commits en días específicos, asegurándonos de que cada miembro aportara de manera equitativa. Este enfoque en la organización y la colaboración efectiva fue fundamental para el éxito de nuestro proyecto en este sprint.
En adicion a ello, se tiene que tener en cuenta que en este sprint se ha agregado una rama llamada Leonardo/feature, ya que Leonardo es nuevo miembro del equipo y tambien requeria de su espacio personal para trabajar en el repositorio.

![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/develop/Informe/Imagenes/gitflow1_3.JPG?raw=true)  
![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitflow2_3.JPG?raw=true)  
![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitflow3_3.JPG?raw=true)  
![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitflow4_3.JPG?raw=true)  
![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitflow5_3.JPG?raw=true)  
![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitflow6_3.JPG?raw=true)  
![gitflow](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/gitflow7_3.JPG?raw=true)  
