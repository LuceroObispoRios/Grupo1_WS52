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
Convenciones: De acuerdo a W3Schools (s.f.), para facilitar la lectura y la coherencia en el código, es necesario usar espacios o tabulaciones de manera consistente, escribir los nombres de las etiquetas y de los archivos en minúsculas, usar comillas dobles para definir atributos en las etiquetas, usar el elemento <link> y <script> para relacion el archivo html con los archivos css y javascript respectivamente. Asimismo, es importante que cada elemento esté cerrado y que se agreguen solo comentarios significativos (“<!--” para iniciar un comentario y “-->” para cerrarlo).  

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
[https://cargasinestres-vue.web.app](https://cargasinestres-vue.web.app)

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

#### 5.2.2.3. Development Evidence for Sprint Review.

Para este Sprint se desarrolló el Frontend de la plataforma.  

![Development Evidence](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/development-evidence-sprint2.png?raw=true)

#### 5.2.1.4. Testing Suite Evidence for Sprint Review.

Acceptance Tests de los User Stories, archivos .feature utilizando el lenguaje Gherkin

![Testing Suite Evidence]()

![feature 1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us01.png?raw=true)    

![feature 2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us02.png?raw=true)  

![feature 3](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us03.png?raw=true)

![feature 4](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us04.png?raw=true)

![feature 5](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us05.png?raw=true)

![feature 6](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us06.png?raw=true)

![feature 7](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us07.png?raw=true)

![feature 8](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us08.png?raw=true)

![feature 9](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/feature-us09.png?raw=true)

![feature 10](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US10.jpg)

![feature 11](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US11.jpg)

![feature 12](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US12.jpg)  

![feature 13](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US13.jpg)  
 
![feature 14](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US14.jpg)  

![feature 15](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US15.jpg)  

![feature 16](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US16.jpg)  

![feature 17](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US17.jpg)  

![feature 18](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/US18.jpg) 

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

![registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution8_sprint1.JPG?raw=true)  

![registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/execution9_sprint1.JPG?raw=true)  

Link al repositorio de codigo: https://github.com/LuceroObispoRios/Grupo1_WS52.git  
Link a la plataforma:  https://luceroobisporios.github.io/Grupo1_WS52/Proyecto/Index.html  
Link al video de ejecución: https://drive.google.com/file/d/1dpaDSXDfR2oe4wCnh-DZ4etNm-LF_cYg/view?usp=sharing   

#### 5.2.1.6. Services Documentation Evidence for Sprint Review.

*Para este **primer** Sprint no fue contemplado la evidencia de la documentación de nuestros servicios.*

#### 5.2.1.7. Software Deployment Evidence for Sprint Review.

* Para este **primer** avance, el cual abarcaba la landing page, asi como el registro y login de usuarios, se llevo a cabo un desplegue por medio de GitHub Pages.  
![Page_deployment](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/deployment.png?raw=true)  

#### 5.2.1.8. Team Collaboration Insights during Sprint.
***Primer Sprint***  
Durante el primer sprint, el equipo optó por dividir los puntos entre todos los integrantes por cada capítulo para completar el informe. También, se optó por dividir las páginas por integrante teniendo en cuenta que estas deberán ser responsive y funcionales. Para asegurar que todo esté realizado correctamente, se organizaron reuniones constantes que se llevaron a cabo a través de Google Meet, donde se logró completar el informe y el código de las páginas landing page, registro para cuenta de empresa, registro para cuenta de cliente, inicio de sesión y la página de búsqueda de empresas.  
A continuación, se presentan screenshots que reflejan el trabajo realizado durante este sprint.  

![team collaboration](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/teamcollaboration_sprint1.png?raw=true)     

![team collaboration](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/teamcollaboration2_sprint1.png?raw=true)  

![team collaboration](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/teamcollaboration3_sprint1.png?raw=true)  

### 5.2.2. Sprint 2

#### 5.2.2.4. Testing Suite Evidence for Sprint Review.

Acceptance Tests de los User Stories, archivos .feature utilizando el lenguaje Gherkin
  
![feature 01](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature01-sprint2.png?raw=true)  
![feature 02](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature02-sprint2.png?raw=true)  
![feature 03](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature03-sprint2.png?raw=true)  
![feature 04](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature04-sprint2.png?raw=true)  
![feature 05](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature05-sprint2.png?raw=true)  
![feature 06](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature06-sprint2.png?raw=true)  
![feature 07](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature07-sprint2.png?raw=true)  
![feature 08](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature08-sprint2.png?raw=true)  
![feature 09](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Andrea/feature/Informe/Imagenes/feature09-sprint2.png?raw=true)  

# Bibliografia
--
Cucumber. (s.f.). Gherkin Reference. Recuperado de: https://cucumber.io/docs/gherkin/reference/ [Fecha de consulta: 04 de septiembre de 2023]  

El comercio. (s.f.). Diario Gestion. Los agentes especializados para mudarte a otro espacio.  
https://archivo.elcomercio.pe/especial/50-ideas-de-negocios/noticias/agentes-especializados-cambiar-espacios-noticia-1992612  

Expansion. (2020). Datosmacro. Sube el número de inmigrantes que viven en Perú.
https://datosmacro.expansion.com/demografia/migracion/inmigracion/peru#:~:text=En%20los%20últimos%20años%2C%20el,%2C%20un%20691%2C17%25.   

Expresso. (2019). ¿Sabías que la mayoría de personas busca una empresa de mudanza a último momento?  
https://www.expreso.com.pe/opinion/sabias-que-la-mayoria-de-personas-busca-una-empresa-de-mudanza-a-ultimo-momento/  

Ipsos. (2019). Alrededor de 200,000 personas se mudan cada año en Lima.
https://www.ipsos.com/sites/default/files/ct/publication/documents/2019-09/alrededor_de_200000_personas_se_mudan_cada_ano_en_lima.pdf    

MDN Web Docs. (s.f.). CSS Coding Style Guide. Recuperado de: https://developer.mozilla.org/en-US/docs/MDN/Writing_guidelines/Writing_style_guide/Code_style_guide/CSS [Fecha de consulta: 04 de septiembre de 2023]  

MDN Web Docs. (s.f.). Code Style Guide. Recuperado de: https://developer.mozilla.org/en-US/docs/MDN/Writing_guidelines/Writing_style_guide/Code_style_guide [Fecha de consulta: 04 de septiembre de 2023]  

W3Schools. (s.f.). HTML5 Syntax. Recuperado de: https://www.w3schools.com/html/html5_syntax.asp [Fecha de consulta: 04 de septiembre de 2023]  

Vue (s.f.). Style Guide. Recuperado de: https://v2.vuejs.org/v2/style-guide/?redirect=true [Fecha de consulta: 26 de septiembre de 2023]  

# Anexos  
## Anexo Videos de Exposiciones  

- TB1: https://drive.google.com/file/d/1lO7UTil6yBAc6I66j3eNU4A7-WtB1I02/view?usp=sharing 
- TP: 




