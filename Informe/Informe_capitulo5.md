# Capitulo 5
## 5.1. Software Configuration Management.

### 5.1.1. Software Development Environment Configuration.

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

### 5.1.4. Software Deployment Configuration.
Para almacenar y manejar el flujo de trabajo del equipo, hemos creado un repositorio en GitHub. Utilizaremos "main" como la rama principal para el desarrollo.
Para su configuración es necesario clonar el repositorio desde GitHub con el URL: https://github.com/LuceroObispoRios/Grupo1_WS52.git.  Este proceso descargará todo el contenido del repositorio en la máquina local.
Para el entorno de desarrollo se utilizará el Visual Studio Code.
A medida que el proyecto avance, se agregarán más elementos de configuración, incluyendo configuración para la base de datos relacional, configuración de pruebas y configuración de gestión de paquetes y dependencias.

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

#### 5.2.1.3. Development Evidence for Sprint Review.

#### 5.2.1.4. Testing Suite Evidence for Sprint Review.

Acceptance Tests de los User Stories con el código de .feature

![feature 1](/Informe/Imagenes/feature-us01.png)

![feature 2](/Informe/Imagenes/feature-us02.png)

![feature 3](/Informe/Imagenes/feature-us03.png)

![feature 4](/Informe/Imagenes/feature-us04.png)

![feature 5](/Informe/Imagenes/feature-us05.png)

![feature 6](/Informe/Imagenes/feature-us06.png)

![feature 7](/Informe/Imagenes/feature-us07.png)

![feature 8](/Informe/Imagenes/feature-us08.png)

![feature 9](/Informe/Imagenes/feature-us09.png)

![feature 10](/Informe/Imagenes/feature-us10.png)

![feature 11](/Informe/Imagenes/feature-us11.png)


#### 5.2.1.5. Execution Evidence for Sprint Review.
***Primer Sprint***  
Durante este sprint, nos enfocamos en completar el landing page y en las páginas de registro para cuenta de empresa, registro para cuenta de cliente, inicio de sesión y la página de búsqueda de empresas.  
![landing page](/Informe/Imagenes/execution_sprint1.jpg)  
![landing page](/Informe/Imagenes/execution2_sprint1.jpg)  
![landing page](/Informe/Imagenes/execution3_sprint1.jpg)  
![inicio sesion](/Informe/Imagenes/execution4_sprint1.jpg)  
![busqueda empresa](/Informe/Imagenes/execution5_sprint1.jpg)  
![busqueda empresa](/Informe/Imagenes/execution6_sprint1.jpg)  
![registro cliente](/Informe/Imagenes/execution7_sprint1.jpg) 
![registro empresa](/Informe/Imagenes/execution8_sprint1.jpg) 
![registro empresa](/Informe/Imagenes/execution9_sprint1.jpg) 

Link al repositorio de codigo: [https://github.com/LuceroObispoRios/Grupo1_WS52.git]  
Link a la plataforma:  
Link al video de ejecución:  

#### 5.2.1.6. Services Documentation Evidence for Sprint Review.

#### 5.2.1.7. Software Deployment Evidence for Sprint Review.

#### 5.2.1.8. Team Collaboration Insights during Sprint.
Durante el primer sprint, el equipo optó por dividir los puntos entre todos los integrantes por cada capítulo para completar el informe. También, se optó por dividir las páginas por integrante teniendo en cuenta que estas deberán ser responsive y funcionales. Para asegurar que todo esté realizado correctamente, se organizaron reuniones constantes que se llevaron a cabo a través de Google Meet, donde se logró completar el informe y el código de las páginas landing page, registro para cuenta de empresa, registro para cuenta de cliente, inicio de sesión y la página de búsqueda de empresas.  
A continuación, se presentan screenshots que reflejan el trabajo realizado durante este sprint.


