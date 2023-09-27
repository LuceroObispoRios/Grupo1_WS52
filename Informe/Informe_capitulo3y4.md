# Capítulo 3: Requirements Specifications
## 3.1. To-Be Scenario Mapping

**To Be Ciudadano**

![To be segmento ciudadano](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/To-be_Ciudadano.png?raw=true)

**To Be Empresa**

![To be segmento empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/To-be_Empresa.png?raw=true)

## 3.2. User Stories


| Epic/Story ID | Título                               | Descripción                                                                                                  | Criterios de Aceptación                                                                                                                                      | Relacionado con (Epic ID) |
|---------------|-------------------------------------|--------------------------------------------------------------------------------------------------------------|------------------------------------------------------------------------------------------------------------------------------------------------------------|:---------------------------:|
| Manejo de Usuario | Registro de Empresa de Mudanzas | Como empresario, quiero poder registrar mi empresa de mudanza en la plataforma para que esté disponible y así poder realizar servicios de mudanza a los clientes. | Escenario 1: DADO QUE, soy un usuario registrado de “Carga sin estrés” con credenciales válidas, CUANDO, inicio sesión con mi nombre de usuario y contraseña, ENTONCES, accedo a mi cuenta y puedo ver mis opciones y solicitar servicios de mudanza. | #1 |
|  Manejo de Usuario | Registro de Cliente | Como usuario nuevo de Carga sin estrés, deseo registrarme en la plataforma para poder solicitar servicios de mudanza CUANDO, los necesite. | Escenario 1: DADO QUE estoy como usuario en la parte de ingreso de datos, CUANDO, esté viendo los campos a llenar, ENTONCES, puedo seleccionar si es una cuenta de cliente o empresa y los campos cambiarán. | #1 |
| Manejo de Usuario | Iniciar Sesión en la plataforma | Como usuario registrado de Carga sin estrés, quiero poder iniciar sesión en mi cuenta para acceder a mis opciones y solicitar servicios de mudanza. | Escenario 1: DADO QUE, el usuario haya decidido registrarse, CUANDO, ingrese a la parte de registro, ENTONCES, aparecerán los campos que debe llenar con su información. Escenario 2: DADO QUE, el usuario cambie de tipo de cuenta que quiere crear, CUANDO, seleccione la otra opción, ENTONCES, los campos a llenar cambiarán. | #1 |
| Manejo de Usuario | Solicitud de servicio de mudanza | Como cliente de Carga sin estrés, deseo poder solicitar un servicio de mudanza en línea, especificando los detalles de mi requerimiento. | Escenario 1: DADO QUE, soy un cliente de Carga sin estrés que necesita mudarse, CUANDO, complete un formulario de solicitud en línea con detalles de la fecha, ubicaciones y cantidad de artículos, ENTONCES, recibo una confirmación de que mi solicitud ha sido recibida y está en proceso. | #1 |
| Manejo de Usuario | Visualizar empresas de mudanza | Como cliente de Carga sin estrés, quiero ver una lista de empresas de mudanza disponibles para seleccionar la que mejor se adapte a mis necesidades. | Escenario 1: DADO QUE, soy un cliente de Carga sin estrés que busca opciones de mudanza, CUANDO, ingrese a la plataforma y filtro las empresas por ubicación y calificaciones, ENTONCES, veo una lista de empresas de mudanza disponibles con detalles relevantes para comparar. | #1 |
| Manejo de Usuario | Seleccionar empresa de mudanza | Como cliente de Carga sin estrés, quiero poder elegir una empresa de mudanza de la lista y confirmar mi elección para mi servicio de mudanza. | Escenario 1: DADO QUE, soy un cliente de Carga sin estrés que ha revisado las opciones de empresas, CUANDO, selecciono una empresa de mudanza específica y confirmo mi elección, ENTONCES, se registra mi selección y procedo a reservar la empresa para mi mudanza. | #1 |
| Manejo de Usuario | Cerrar Sesión | Como trabajador de una empresa de carga quiero cerrar la sesión de la cuenta empresarial para mantener la seguridad de la cuenta. | Escenario 1: DADO QUE, me encuentro dentro de la aplicación, CUANDO, presiono “salir de la app”, ENTONCES, se cerrará mi sesión en la aplicación. | #1 |
| Métodos de pago | Elección de membresía de   empresa | Como usuario empresa quiero   una opción que permita aumentar mi visibilidad dentro de la plataforma para   captar clientes. | Escenario 1: DADO QUE, el   usuario elige el tipo de cuenta de empresa y se muestra en la plataforma las   opciones de cuenta con membresía de 3 meses, 6 meses y 1 año. CUANDO, el   usuario selecciona una de las opciones de cuenta con membresía. ENTONCES, se   muestra la página de pago. | #2 |  
| Métodos de pago | Pago de membresía | Como usuario empresa quiero   poder ingresar los detalles de mi tarjeta para pagar la membresía. | Escenario 1: DADO QUE, como   usuario estoy eligiendo mi membresía la cual se encuentra en la página de   pago. CUANDO, elija el método de pago, complete los detalles de la tarjeta y   seleccione “Realizar pago”. ENTONCES, se mostrará la página de la cuenta del   usuario con la información de la membresía. | #2 |  
| Métodos de pago | Selección de método de pago | Como usuario cliente quiero   poder elegir entre diferentes métodos de pago al reservar el servicio de   mudanza para elegir el que más se acomode a mi preferencia. | Escenario 1: DADO QUE, el   usuario está en el perfil de la empresa y está en el proceso de reserva del   servicio. CUANDO, elija la opción “Reservar servicio”. ENTONCES, se mostrará   las opciones de pago.           Escenario 2: DADO QUE, se   muestran las opciones de pago. CUANDO, seleccione la opción deseada y   complete los detalles de la tarjeta. ENTONCES, el usuario presiona la opción   “Realizar pago”. | #2 |  
| Métodos de pago | Detalles de pago | Como usuario cliente quiero   poder revisar los detalles de pago de todas mis reservas para poder ver los   costos de los servicios contratados. | Escenario 1: DADO QUE, el   usuario se encuentra en la página de su perfil. CUANDO, selecciona “Historial   de pagos”. ENTONCES, se mostrará en forma de lista el historial de pagos los   cuales contienen información detallada. | #2 |  
| Búsqueda de empresas | Búsqueda de empresas cercanas | Como usuario cliente quiero   poder buscar empresas que ofrezcan servicios de mudanza o carga cercanos a mi   ubicación actual para asegurarme que el servicio sea conveniente. | Escenario 1: DADO QUE, el usuario está en el landing page logueado con su cuenta personal. CUANDO,   presione el botón de “Búsqueda”. ENTONCES aparece un campo donde puedo   ingresar mi ubicación actual.            Escenario 2: DADO QUE, he   ingresado mi ubicación. CUANDO, presione el botón de “Buscar”. ENTONCES, me   aparece una página que muestra una lista de empresas que ofrecen servicios de   mudanza o carga que estén dentro de un radio definido de mi ubicación.           Escenario 3: DADO QUE, estoy   viendo la lista de empresas cercanas. CUANDO, modifique mi ubicación o ajuste   el radio de búsqueda. ENTONCES, los resultados de la búsqueda se actualizan. | #3 |
| Búsqueda de empresas | Filtrar por servicios ofrecidos | Como usuario cliente quiero   poder filtrar las empresas por los servicios que ofrecen para encontrar   aquellas que ofrecen el servicio que deseo. | Escenario 1: DADO QUE, soy un   usuario logueado con su cuenta personal y está en el landing page. CUANDO,   presione el botón de “Búsqueda”. ENTONCES, aparece la opción de filtrado por   servicios ofrecidos. ENTONCES, aparece una lista de los tipos de servicios   (transporte, carga, embalaje, montaje, desmontaje)           Escenario 2: DADO QUE, estoy   viendo los tipos de servicio ofrecidos. CUANDO, seleccione uno o varios tipos   de servicio. Y presione el botón “Buscar”. ENTONCES, aparece una página que   muestra una lista de empresas que ofrecen todos los tipos de servicio que   seleccione. | #3 |
| Búsqueda de empresas |  Filtrar por calificación | Como usuario cliente quiero   poder ordenar a las empresas de acuerdo por la cantidad de estrellas promedio   y número de reseñas para tener la seguridad de encontrar calidad y   confiabilidad en el servicio. | Escenario 1: DADO QUE, me encuentro   en el landing page y estoy logueado con mi cuenta personal. CUANDO, presione   el botón de “Búsqueda”. ENTONCES, se muestra la opción “Ordenar por   calificación” y la opción “Ordenar por número de reseñas”                 Escenario 2: DADO QUE, el   usuario está viendo la lista de empresas. CUANDO, selecciona la opción de   “Ordenar por calificación”. ENTONCES, la plataforma reorganiza los resultados   para mostrar primero las empresas con las calificaciones más altas, es decir los ordena de 5 estrellas a 0 estrellas. | #3 |
| Búsqueda de empresas | Visualización de   disponibilidad | Como usuario cliente quiero   encontrar empresas que estén disponibles para una fecha específica para tener la seguridad que mi mudanza se realizará en un horario y fecha conveniente. | Escenario 1: DADO QUE, me   encuentro logueado con mi cuenta personal. Y estoy visualizando la lista de   empresas que ofrecen servicios de mudanza o carga. CUANDO, seleccione una   empresa. ENTONCES, en el perfil del trabajador se muestra un calendario con   días y horas en que hay trabajadores disponibles.           Escenario 2: DADO QUE, estoy   viendo la disponibilidad de la empresa. CUANDO, realice una reserva exitosa.   Y luego regrese a la página de disponibilidad. ENTONCES, se puede ver las   fechas y horarios actualizados para reflejar la reserva reciente. | #3 |
| Búsqueda de empresas | Visualizar perfil de empresa | Como usuario cliente quiero   poder visualizar el perfil de cada empresa para conocer su información   detallada y así tomar una decisión informada y confiable al seleccionar la   empresa adecuada para mis necesidades. | Escenario 1: DADO QUE, estoy   viendo la lista de empresas disponibles. CUANDO, haga clic en el nombre o   foto de una empresa. ENTONCES, el sistema me redirige a la página de su  perfil.            Escenario 2: DADO QUE, estoy   en el perfil del trabajador. CUANDO, me desplace hacia abajo. ENTONCES, la página muestra una breve descripción, su experiencia, ubicación, foto,   calificación promedio, reseñas anteriores, disponibilidad y servicios   ofrecidos, así como el botón de “Reserva”. | #3 |
| Reserva de servicios | Ingresar a la reserva del   servicio | Como cliente quiero ingresar a la información de los servicios para ver si esa empresa es la que me conviene reservar. | Escenario 1: DADO QUE, el cliente está en la sección de búsqueda, CUANDO, éste encuentre una empresa   que le resulte interesante ENTONCES, podrá ingresar a la información de los   servicios que ésta ofrece al pulsar sobre el nombre de la empresa. | #4 |
| Reserva de servicios | Seleccionar servicios a   reservar | Como cliente quiero poder seleccionar los servicios que necesito de la lista ofrecida por la empresa   para reservarlos. | Escenario 1: DADO QUE, el   cliente esté viendo los servicios ofrecidos por una empresa, CUANDO,   presiones “reservar servicio”, ENTONCES, podrá seleccionar los servicios que   desea reservar. | #4 |
| Reserva de servicios | Envío de información sobre la posible reserva | Como cliente quiero que la información de los servicios que escogí se envíe a la empresa de mudanza para   que estos tengan más detalle de la reserva que quiero. | Escenario 1: DADO QUE, el   cliente haya terminado de seleccionar los servicios que requiere, CUANDO,   presione “envío de información de reserva”, ENTONCES se enviará a la empresa   de mudanza para que estos tengan más detalle de la reserva. | #4 |
| Reserva de servicios | Contactar con el trabajador de   la empresa | Como trabajador de una empresa de mudanza quiero poder comunicarme con el cliente una vez haya enviado los   servicios que quiere para aclarar detalles. | Escenario 1: DADO QUE, el   cliente haya terminado de seleccionar los servicios que requiere, CUANDO,   presione “contactar trabajador”, ENTONCES a la cuenta de la empresa le   llegará una notificación de que le ha llegado un posible trabajo y podrán   iniciar un chat. | #4 |
| Reserva de servicios | Acordar un precio por servicio reservado | Como cliente quiero acordar   detalles y precio por los servicios tras conversar con el trabajador para   realizar mi mudanza en otro momento. | Escenario 1: DADO QUE, el   cliente y un trabajador de la empresa de mudanza están en chat en vivo,   CUANDO, terminen de definir detalles, ENTONCES, podrán acordar un precio para   el servicio y terminar la  reserva.  | #4 |
| Historial de reservas | Visualizar historial de reservas | Como usuario cliente quiero poder ver los servicios de mudanza contratados para tener control y seguimiento de mis transacciones dentro de la aplicación. | Escenario 1: El usuario ingresa a reservas. Dado que el usuario ingresa a la sección de reservas. Cuando seleccione el botón ver historial de reservas. Entonces aparecerá la página del historial. Escenario 2: El usuario visualiza su historial de reservas. Dado que el usuario se encuentra en la página del historial de reservas. Cuando el usuario haga scroll. Entonces la página le permitirá ver más reservas hechas anteriormente. Escenario 3: El usuario visualiza sus últimas reservas. Dado que el usuario ingresa a la sección de reservas. Cuando la plataforma carga la página. Entonces las últimas reservas se visualizarán primero y las más antiguas al último. | #5 |

## 3.3. Impact Mapping  
![Impact_Map](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/Impactmapping.jpg?raw=true)

## 3.4. Product Backlog

| # Orden   |     User   Story ID    |     Título                                             |     Descripción                                                                                                                                                                                                                   |     Story   Points (1/2/3/5/8)    |
|-----------|------------------------|--------------------------------------------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|-----------------------------------|
|     1     |     HU04               |     Ajustes de cuenta de   cliente                     |     **Como** cliente registrado en Carga sin estrés, **quiero** ajustar los datos de mi cuenta **para** que refleje mis datos actuales.                                                                                                   |     1                             |
|     2     |     HU05               |     Ajustes de cuenta de   empresa                     |     **Como** empresa usuaria de Carga sin estrés, **quiero** ajustar los datos de la cuenta de empresa **para** que reflejen el estado actual de esta.                                                                                    |     1                             |
|     3     |     HU06               |     Cerrar Sesión                                      |     **Como** usuario **quiero** cerrar la sesión de la cuenta empresarial **para** mantener la seguridad de la cuenta.                                                                                                                      |     1                             |
|     4     |     HU13               |     Filtrar por calificación                           |     **Como** usuario cliente **quiero** poder ordenar a las empresas de acuerdo por la cantidad de estrellas promedio y número de reseñas **para** tener la seguridad de encontrar calidad y   confiabilidad en el servicio.              |     1                             |
|     5     |     HU17               |     Visualizar historial de   reservas                 |     **Como** usuario cliente **quiero** poder ver los servicios de mudanza contratados **para** tener control y seguimiento de mis transacciones dentro de la aplicación.                                                                 |     1                             |
|     6     |     HU07               |     Elección de membresía de   empresa                 |     **Como** usuario empresa **quiero** una opción que permita aumentar mi visibilidad dentro de la plataforma **para** captar clientes.                                                                                                  |     2                             |
|     7     |     HU10               |     Detalles de pago                                   |     **Como** usuario cliente **quiero** poder revisar los detalles de pago de todas mis reservas **para** poder ver los costos de los servicios contratados.                                                                              |     2                             |
|     8     |     HU11               |     Búsqueda de empresas   cercanas                    |     **Como** usuario cliente **quiero** poder buscar empresas que ofrezcan servicios de mudanza o carga cercanos a mi ubicación actual **para** asegurarme que el servicio sea conveniente.                                               |     2                             |
|     9     |     HU12               |     Filtrar por servicios   ofrecidos                  |     **Como** usuario cliente **quiero** poder filtrar las empresas por los servicios que ofrecen **para** encontrar aquellas que ofrecen el servicio que deseo.                                                                           |     2                             |
|     10    |     HU15               |     Envío de información sobre   la posible reserva    |     **Como** cliente **quiero** hacer una reserva sobre los servicios que ofrece la empresa de mudanza **para** que estos tengan más detalle de la reserva que quiero.                                                                    |     2                             |
|     11    |     HU16               |     Acordar un precio por   servicio reservado         |     **Como** empresa **quiero** acordar horarios y precio por los servicios tras conversar con el cliente **para** realizar la mudanza.                                                                                                   |     2                             |
|     12    |     HU01               |     Registro de Empresa de   Mudanzas                  |     **Como** empresario, **quiero** poder registrar mi empresa de mudanza en la plataforma **para** que esté disponible y así poder realizar servicios de mudanza a los clientes.                                                         |     3                             |
|     13    |     HU02               |     Registro de Cliente                                |     **Como** usuario nuevo de Carga sin estrés, **quiero** registrarme en la plataforma **para** poder solicitar servicios de mudanza cuando los necesite.                                                                                 |     3                             |
|     14    |     HU09               |     Pago para reserva de servicio                      |     **Como** usuario cliente **quiero** poder elegir entre diferentes métodos de pago al reservar el servicio de mudanza **para** elegir el que más se acomode a mi preferencia y pueda pagar el servicio exitosamente.                 |     3                             |
|     15    |     HU14               |     Visualizar perfil de   empresa                     |     **Como** usuario cliente **quiero** poder visualizar el perfil de cada empresa **para** conocer su información detallada y así tomar una decisión informada y confiable al seleccionar la empresa adecuada para mis necesidades.    |     3                             |
|     16    |     HU03               |     Iniciar Sesión en la   plataforma                  |     **Como** usuario registrado de Carga sin estrés, **quiero** poder iniciar sesión en mi cuenta **para** acceder a mis opciones según mi tipo de cuenta.                                                                                |     5                             |
|     17    |     HU08               |     Pago de membresía                                  |     **Como** usuario empresa **quiero** poder ingresar los detalles de mi tarjeta **para** pagar la membresía.                                                                                                                              |     5                             |
|     18    |     HU18               |     Comunicación mediante chat   con la empresa        |     **Como** usuario cliente **quiero** comunicarme con la empresa que reservé **para** poder coordinar los detalles de   la mudanza.                                                                                                       |     5                             |
  

# Capítulo 4: Product Design
## 4.1. Style Guidelines
### 4.1.1. General Style Guidelines

Para la elaboración del Landing Page, se utilizó la paleta de colores (Color), en la cual empleamos 4 colores bases para la elaboración de nuestra aplicación/sitio web. Asimismo, se muestra el "font" la cual seleccionamos los tipos de letra a utilizar. Es por ello que diseñamos varios (Spacing) para ajustarlo y añadirlo en nuestra app, de diferentes tamaños y formas. Además, agregamos dos secciones importantes como es (buttons and icons & shapes) que nos ayudó a mejorar las interfaces de nuestra aplicación; así como simplificar opciones, ya que son de mucha ayuda y modelo llamativo. Por último en esta sección elaboramos y diseñamos varios modelos propuestos por el logo de nuestra app (Branding), de tal forma que nos ayudó para obtener un logo final muy sofisticado y elegante, en la cual lo implementamos en la aplicación/sitio web.

#### Color
![General Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Color.png?raw=true)

#### Font
![General Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Font.png?raw=true)

#### Spacing
![General Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Spacing.png?raw=true)

#### Branding
![General Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Branding.png?raw=true)

### 4.1.2. Web Style Guidelines

En esta sección visualizaremos la guía de estilos para la versión web. Asimismo, se ha respetado al pie de la letra los estilos generales planteados anteriormente. Sin embargo, se han añadido algunos íconos en la diferentes páginas de estilo web.

#### Typography
![Web Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Typography.png?raw=true)

#### Buttons
![Web Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Buttons.png?raw=true)

#### Icons
![Web Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Icons.png?raw=true)

## 4.2. Information Architecture

### 4.2.1. Organization Systems.
En esta parte, se establece la conexión entre el sistema visual de organización y los grupos de información del programa de manera apropiada. Además, se determinará cuándo se aplicarán los esquemas de categorización de contenido.

***Organizacion jerarquica***

Proximidad: Se trata sobre colocar elementos relacionados juntos y hacer que los usuarios perciban que están conectados de alguna manera. Este principio se puede utilizar en nuestro programa a la hora de agrupar los reviews que dejan los clientes en las empresas. También, luego de obtener los resultados de búsqueda, es importante colocar toda la información relacionada a una empresa de tal forma que quede junta, pero separado a la información de las otras empresas que también salieron como resultado de la búsqueda.
Color: El color negro es aquel que brinda mayor contraste, por tanto, para este programa se utilizarán fuentes de letra de color negro, mientras que los colores del fondo serán más claros para llevar a cabo el contraste.
Organizar fuentes: Con el objetivo de hacer que la página web sea fácil de leer y entender para el usuario, se deberá crear una jerarquía de tipo de letra que consiste en fuentes de título, subtítulos, encabezados graduados y demás texto. Entonces, para destacar los títulos se utilizará la variación de tamaño de letra, así como el peso de la fuente seleccionada.

***Esquemas de categorización***

- Según audiencia: El contenido del programa será categorizado para 2 audiencias, los cuales son los usuarios que desean solicitar servicios de mudanza o carga y los que brindan estos servicios.
- Por tópicos: Cuando se lleva a cabo la búsqueda de trabajadores que brinden estos servicios, los usuarios clientes tienen a su disposición distintos filtros y campos como criterios de búsqueda.
- Cronológico: Si el usuario desea ver las reservas de los servicios que realizó, entonces estas aparecerán en una lista de forma cronológica, siendo la solicitud más antigua la que aparece en la parte de arriba y la solicitud realizada recientemente en la parte de abajo.

### 4.2.2. Labeling Systems.
A continuación, se definirán las etiquetas a utilizar para agrupar conjuntos de información, así como las asociaciones entre las mismas.

![General Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/LabelingSystems.png?raw=true)

### 4.2.3. SEO Tags and Meta Tags
***Landing page:***
* Titulo:
~~~
<title>Carga Sin Estrés</title>
~~~
* Meta tags description:
~~~
<meta name="description" content="Encuentra a los expertos en mudanza y carga que necesitas. Nuestra plataforma te conecta con profesionales de confianza para simplificar tu próxima mudanza. Cotiza, compara y elige la solución perfecta para tus necesidades de transporte en un solo lugar"/>
~~~
* Keywords:
~~~
<meta name="keywords" content="carga, mudanza, busqueda, empresas, embalaje, transporte, montaje, desmontaje"/>
~~~
* Author:
~~~
<meta name="author" content="Lucero Obispo, Andrea O'Higgins, Eric Cuevas, Damaris Tasayco" />
~~~

### 4.2.4. Searching Systems.  
La aplicación de mudanzas y transporte contará con un sistema de búsqueda que permitirá visualizar todas las empresas de mudanza y transporte. Al inicio de la página principal, se visualizarán las empresas destacadas, aquellas que han adquirido una membresía para poder aparecer en esta sección, y debajo de ellas se listarán las demás empresas. Además, con el objetivo de simplificar la elección de la empresa por parte de los usuarios, se visualizarán los datos principales de cada empresa, incluyendo su nombre, logotipo y los servicios que ofrecen. Asimismo, los usuarios podrán explorar fácilmente las distintas opciones de empresas a través de filtros. Éstos permitirán la búsqueda de empresas por cercanía, en función de los servicios que el usuario haya seleccionado, la calificación por estrellas y las reseñas de la empresa, así como su disponibilidad.
  
### 4.2.5. Navigation Systems.
Se dispondra de un menu despegable en la parte superior de la de la aplicación, el cual mostrara las secciones de contenido disponibles.   
El “navbar” permitirá al usuario podernavegar a cualquier sección de la página, en cualquier momento, esto permitirá a los usuarios ver todo  
el contenido sin tener que volver al principio y cuando sea necesario, con un botón, volver a desplegar el navbar en mobile, o de manera  
incluso más sencilla en web dirigiendose al menu directamente.  
  
## 4.3. Landing Page UI Design.

### 4.3.1. Landing Page Wireframe.
![LandingPage_wireframe](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe_LandingPage.png?raw=true)  
![mobile-wireframe](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-mobile-landing.png?raw=true)  

### 4.3.2. Landing Page Mock-up.
![LandingPage_mock_up](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup_LandingPage.png?raw=true)
![mobile-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/landing-mobile.png?raw=true)  
## 4.4. Web Applications UX/UI Design.  

### 4.4.1. Web Applications Wireframes.  
![registro-cliente-wireframe](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-registro-cliente.png?raw=true)  
![registro-empresa-wireframe](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-registro-empresa.png?raw=true)  
![inicio-sesion-wireframe](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-login.png?raw=true)  
![busqueda-wireframe](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-busqueda.png?raw=true)  

### 4.4.2. Web Applications Wireflow Diagrams.  
![wireframe-flow1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframes-flow1.png?raw=true)  
  
![wireframe-flow2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframes-flow2.png?raw=true)  

### 4.4.2. Web Applications Mock-ups.  
![registro-cliente-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-registro-cliente.png?raw=true)  
![registro-empresa-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-registro-empresa.png?raw=true)  
![inicio-sesion-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup_login.png?raw=true)  
![busqueda-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-busqueda.png?raw=true)  
![mobile-login-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/login-mobile.png?raw=true)
![mobile-cliente-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-cliente-mobile.png?raw=true)  
![mobile-empresa-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-empresa.mobile.png?raw=true)  

### 4.4.3. Web Applications User Flow Diagrams.  
![mockup-flow1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-flow1.png?raw=true)  
  
![mockup-flow2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-flow2.png?raw=true) 
## 4.5. Web Applications Prototyping.  
El prototipo de secuencia web se encuentra en el siguiente enlace :  
[https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-453&t=wLRuXHHBxMj8lVew-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A453&show-proto-sidebar=1&mode=design](https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-453&t=wLRuXHHBxMj8lVew-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A453&show-proto-sidebar=1&mode=design)    

El prototipo de secuencia mobile se encuentra en el siguiente enlace :  
[https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-885&t=1YhgDvhIeuMcfiDB-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A885&show-proto-sidebar=1&mode=design](https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-885&t=1YhgDvhIeuMcfiDB-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A885&show-proto-sidebar=1&mode=design)  


## 4.6. Domain-Driven Software Architecture. 

Los diagramas c4 se realizaron con Structurizr.   Enlace:[https://www.structurizr.com/share/85676/294b91b5-fde5-4ad9-bb61-11105de941e6](https://www.structurizr.com/share/85676/294b91b5-fde5-4ad9-bb61-11105de941e6)  

### 4.6.1. Software Architecture Context Diagram.  

![Context Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Contexto.png?raw=true)  

### 4.6.2. Software Architecture Container Diagrams.  

![Container Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Contenedor.png?raw=true)  

### 4.6.3. Software Architecture Components Diagrams.  
**Service Context**

![Service Component Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ServiceComponents.png?raw=true)  

**Account Context**
![Account Component Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/AccountComponents.png?raw=true)  

**Notification Context**
![Notification Component Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/NotificationComponents.png?raw=true)  

## 4.7. Software Object-Oriented Design.  

### 4.7.1. Class Diagrams.  
El diagrama de clases se realizo con la pagina Lucidchart, este es el enlace del diagrama: [https://lucid.app/lucidchart/c9014eb0-9946-4bec-94b9-7b2daffbd7ea/edit?viewport_loc=-668%2C-172%2C3028%2C1565%2C0_0&invitationId=inv_178b2402-cdb0-42b0-ad04-ffbc706d72ae](https://lucid.app/lucidchart/c9014eb0-9946-4bec-94b9-7b2daffbd7ea/edit?viewport_loc=-668%2C-172%2C3028%2C1565%2C0_0&invitationId=inv_178b2402-cdb0-42b0-ad04-ffbc706d72ae)  
![General Style Guidelines](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/DiagramaDeClases.png?raw=true)  

### 4.7.2. Class Dictionary.  
![Class_Dictionary_1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary1.JPG?raw=true)  
![Class_Dictionary_2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary2.JPG?raw=true)  
![Class_Dictionary_3](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary3.JPG?raw=true)  
![Class_Dictionary_4](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary4.JPG?raw=true)  
![Class_Dictionary_5](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary5.JPG?raw=true)  
![Class_Dictionary_6](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary6.JPG?raw=true)  
![Class_Dictionary_7](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ClassDictionary7.JPG?raw=true)  

## 4.8. Database Design.

### 4.8.1. Database Diagram.
![Database](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Eric/feature/Informe/Imagenes/Carga_sin_estresDB.png?raw=true)

