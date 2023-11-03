# Capítulo 3: Requirements Specifications
## 3.1. To-Be Scenario Mapping

**To Be Ciudadano**

![To be segmento ciudadano](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/To-be_Ciudadano.png?raw=true)

**To Be Empresa**

![To be segmento empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/To-be_Empresa.png?raw=true)

## 3.2. User Stories

<table>
    <tr>
        <th>Epic/Story ID</th>
        <th>Título</th>
        <th>Descripción</th>
        <th>Criterios de Aceptación</th>
        <th>Relacionado con (Epic ID)</th>
    </tr>
    <tr>
        <td>Manejo de usuario</td>
        <td>Registro de Empresa de Mudanzas</td>
        <td>Como empresario, quiero poder registrar mi empresa de mudanza en la plataforma para que esté disponible y así poder realizar servicios de mudanza a los clientes.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario ingresa al formulario de registro de empresa.
DADO  QUE soy un representante autorizado de una empresa de mudanzas, CUANDO acceda a la página de registro Y seleccione la opción cuenta de empresa de mudanza o carga, ENTONCES aparece un formulario de registro que solicita información de la empresa, incluyendo username, email, ubicación, número de contacto, contraseña, los servicios que ofrece y una descripción corta de la empresa.</li>
                <li><strong>Escenario 2:</strong> El usuario registra sus datos de empresa correctamente.
DADO  QUE estoy completando el registro de mi empresa de mudanzas, CUANDO ingresó la información requerida, Y presiono el botón “Registrar Empresa”, ENTONCES recibo una confirmación en pantalla de que la empresa se ha registrado correctamente.</li>
            </ul>
        </td>
        <td>#1</td>
    </tr>
    <tr>
        <td>Manejo de usuario</td>
        <td>Registro de Cliente</td>
        <td>Como usuario nuevo de Carga sin estrés, deseo registrarme en la plataforma para poder solicitar servicios de mudanza cuando los necesite.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario ingresa al formulario de registro de cliente.
DADO QUE soy un cliente interesado en utilizar el servicio de mudanzas, CUANDO acceda a la página de registro de clientes, Y seleccione la opción cuenta de cliente, ENTONCES puedo ver un formulario de registro que solicita información básica.</li>
                <li><strong>Escenario 2:</strong> El usuario registra sus datos de cliente correctamente.
DADO QUE estoy completando el registro como cliente, CUANDO ingreso la información requerida como son los campos nombre, apellido materno, apellido paterno, celular, dirección, correo electrónico, contraseña, Y presiono el botón “Registrar”, ENTONCES recibo una confirmación en pantalla de que mi registro se ha completado con éxito.</li>
            </ul>
        </td>
        <td>#1</td>
    </tr>
    <tr>
        <td>Manejo de usuario</td>
        <td>Iniciar Sesión en la plataforma</td>
        <td>Como usuario registrado de Carga sin estrés, quiero poder iniciar sesión en mi cuenta para acceder a mis opciones según mi tipo de cuenta.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario cliente inicia sesión.
DADO QUE, soy un usuario tipo cliente registrado en la plataforma, CUANDO ingreso mi dirección de correo electrónico o usuario, y contraseña en el formulario de inicio de sesión, ENTONCES soy redirigido a la página de búsqueda de empresas.</li>
                <li><strong>Escenario 2:</strong> El usuario empresa inicia sesión.
DADO QUE, soy un usuario tipo empresa registrado en la plataforma, CUANDO ingreso mi dirección de correo electrónico o usuario, y contraseña en el formulario de inicio de sesión, ENTONCES soy redirigido a la página de mi perfil.</li>
                <li><strong>Escenario 3:</strong> El usuario inicia sesión con datos incorrectos.
DADO QUE, ingresé datos incorrectos al intentar iniciar sesión, CUANDO presiono el botón de inicio de sesión, ENTONCES recibo un mensaje de error que indique que la cuenta no existe.</li>
            </ul>
        </td>   
        <td>#1</td>
    </tr>
    <tr>
        <td>Manejo de usuario</td>
        <td>Ajustes de cuenta de cliente</td>
        <td>Como cliente registrado en Carga sin estrés, quiero ajustar los datos de mi cuenta para que refleje mis datos actuales.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario modifica sus datos satisfactoriamente.
DADO QUE soy un cliente que haya iniciado sesión en Carga sin estrés, Y seleccione la opción de “Editar Perfil”, CUANDO llene los datos en el formulario, nombre, apellido materno, apellido paterno, celular, dirección y confirme el correo electrónico y su contraseña, Y seleccione el botón de “Guardar cambios” , ENTONCES, la aplicación validará y modificará los datos actuales.</li>
                <li><strong>Escenario 2:</strong> El usuario ya no desea modificar sus datos.
DADO QUE soy un cliente que haya iniciado sesión en Carga sin estrés , Y seleccione la opción de “Editar Perfil”, Y desee salir de la página de edición de datos, CUANDO, seleccione el botón “Cancelar” entonces se mostrará la página de búsqueda de empresas. </li>
                <li><strong>Escenario 3:</strong> El usuario modifica sus datos y coloca datos erróneos.
DADO QUE soy un cliente que haya iniciado sesión en Carga sin estrés, , CUANDO llene los datos en el formulario, Y llene con datos erróneos el campo de correo electrónico y contraseña, CUANDO selecciono el botón “Guardar cambios”, ENTONCES, la página no permitirá actualizar los datos.</li>
            </ul>
        </td>
        <td>#1</td>
    </tr>
    <tr>
        <td>Manejo de usuario</td>
        <td>Ajustes de cuenta de empresa</td>
        <td>Como empresa usuaria de Carga sin estrés, quiero ajustar los datos de la cuenta de empresa para que reflejen el estado actual de esta.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario modifica sus datos satisfactoriamente.
DADO QUE el usuario haya iniciado sesión en Carga sin estrés, Y seleccione la opción de “Editar Perfil”, CUANDO llene los datos en el formulario, nombre de empresa, correo, dirección, teléfono, descripción, Y marque las opciones de servicio que ofrece dentro de la lista que se muestra,  Y su contraseña, Y seleccione el botón de “Guardar cambios” , ENTONCES, la aplicación validará y modificará los datos actuales.</li>
                <li><strong>Escenario 2:</strong> El usuario ya no desea modificar sus datos.
DADO QUE, que el usuario haya iniciado sesión en Carga sin estrés , Y seleccione la opción de “Editar Perfil”, Y desee salir de la página de edición de datos, CUANDO, seleccione el botón “Cancelar” entonces se mostrará la página de principal de empresas. </li>
                <li><strong>Escenario 3:</strong> El usuario modifica sus datos y coloca datos erróneos.
DADO QUE,  el usuario haya iniciado sesión en Carga sin estrés, , CUANDO llene los datos en el formulario, Y llene con datos erróneos el campo de correo electrónico y contraseña, CUANDO selecciono el botón “Guardar cambios”, ENTONCES, la página no permitirá actualizar los datos.</li>    
            </ul>
        </td>
        <td>#1</td>
    </tr>
    <tr>
        <td>Manejo de usuario</td>
        <td>Cerrar Sesión</td>
        <td>Como usuario quiero cerrar la sesión de la cuenta empresarial para mantener la seguridad de la cuenta.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario empresa cierra sesión.  
DADO QUE, soy un usuario con tipo de cuenta empresa autenticado en la plataforma, CUANDO hago clic en la opción "Cerrar Sesión" en cualquier página, ENTONCES soy redirigido a la landing page, Y mi sesión se cierra con éxito.</li>
                <li><strong>Escenario 2:</strong> El usuario cliente cierra sesión.
DADO QUE, soy un usuario con tipo de cuenta cliente autenticado en la plataforma, CUANDO hago clic en la opción "Cerrar Sesión" en cualquier página, ENTONCES soy redirigido a la landing page, Y mi sesión se cierra con éxito.</li>
            </ul>
        </td>
        <td>#1</td>
    </tr>
    <tr>
        <td>Métodos de pago</td>
        <td>Elección de membresía de empresa</td>
        <td>Como usuario empresa quiero una opción que permita aumentar mi visibilidad dentro de la plataforma para captar clientes.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza los planes de membresía.   
DADO QUE, soy un representante autorizado de una empresa de mudanzas, CUANDO accedo a la sección de elección de membresía en mi perfil, ENTONCES puedo visualizar los diferentes planes de membresía disponibles.
                </li>
                <li><strong>Escenario 2:</strong> El usuario selecciona un plan de membresía.   
DADO QUE, soy un representante autorizado de una empresa de mudanzas, CUANDO selecciono un plan de membresía, ya sea de 3 meses, 6 meses o 1 año, Y presiono el botón “Adquirir Membresía”, ENTONCES se muestra la página de pago.
                </li>
            </ul>
        </td>
        <td>#2</td>
    </tr>
    <tr>
        <td>Métodos de pago</td>
        <td>Pago de membresía</td>
        <td>Como usuario empresa quiero poder ingresar los detalles de mi tarjeta para pagar la membresía.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario paga la membresía que eligió.   
DADO QUE, estoy en la página de procesamiento de pagos para un plan de membresía premium, CUANDO elija el método de pago Y coloque la información de mi tarjeta Y presione "Pagar", ENTONCES el sistema procesa la transacción de manera segura y exitosa
                </li>
                <li><strong>Escenario 2:</strong> El usuario ingresa datos incorrectos en el sistema de pago.  
DADO QUE, soy un representante autorizado de una empresa de mudanzas, CUANDO el sistema detecta un problema durante el procesamiento del pago, como datos incorrectos, ENTONCES recibo un mensaje de error claro que explique la razón del problema y cómo corregirlo.</li>
                <li><strong>Escenario 3:</strong> El usuario visualiza los beneficios de la membresía que eligió.   
DADO QUE, he realizado con éxito el pago de la membresía premium, CUANDO vuelvo a mi perfil de empresa, ENTONCES se aplican los beneficios de la membresía premium de manera inmediata.</li>
            </ul>
        </td>
        <td>#2</td>
    </tr>
    <tr>
        <td>Métodos de pago</td>
        <td>Pago para reserva de servicio</td>
        <td>Como usuario cliente quiero poder ingresar los detalles de mi tarjeta al momento de realizar una reserva de servicio, y que la plataforma cobre automáticamente el importe al finalizar el servicio, para facilitar un proceso de pago conveniente y sin complicaciones.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario ingresa su tarjeta al momento de la reserva.
DADO QUE, el usuario está en el proceso de reserva de servicio de mudanza o carga. CUANDO, introduce los detalles de su tarjeta ENTONCES  se guardan los datos de manera segura y protegida, utilizando un formulario de pago encriptado y confiable.</li>
                <li><strong>Escenario 2:</strong> Cobro automático al finalizar el servicio.
DADO QUE, el servicio de mudanza o carga ha sido completado con éxito según la reserva. CUANDO, la plataforma indica la finalización del servicio. ENTONCES se procederá a cobrar automáticamente el importe acordado previamente de la tarjeta registrada al realizar la reserva.</li>
            </ul>
        </td>
        <td>#2</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Búsqueda de empresas cercanas</td>
        <td>Como usuario cliente quiero poder buscar empresas que ofrezcan servicios de mudanza o carga cercanos a mi ubicación actual para asegurarme que el servicio sea conveniente.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario ingresa su ubicación para buscar empresas.
DADO QUE, el usuario está en el landing page logueado con su cuenta personal. CUANDO, presione el botón de “Búsqueda”. ENTONCES aparece un campo donde puedo ingresar mi ubicación actual. </li>
                <li><strong>Escenario 2:</strong> El usuario visualiza las empresas de acuerdo a su ubicación.
DADO QUE, he ingresado mi ubicación. CUANDO, presione el botón de “Buscar”. ENTONCES, me aparece una página que muestra una lista de empresas que ofrecen servicios de mudanza o carga que estén dentro de un radio definido de mi ubicación.</li>
                <li><strong>Escenario 3:</strong> El usuario modifica la ubicación de búsqueda de empresas.
DADO QUE, estoy viendo la lista de empresas cercanas. CUANDO, modifique mi ubicación o ajuste el radio de búsqueda. ENTONCES, los resultados de la búsqueda se actualizan.</li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Filtrar por servicios ofrecidos</td>
        <td>Como usuario cliente quiero poder filtrar las empresas por los servicios que ofrecen para encontrar aquellas que ofrecen el servicio que deseo.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza la opción de búsqueda por servicios.
DADO QUE soy un usuario logueado con su cuenta personal y está en el landing page. CUANDO, me dirija a la página de búsqueda de empresas”. ENTONCES, aparece un input en el cual se puede buscar por nombre de servicios.</li>
                <li><strong>Escenario 2:</strong> El usuario realiza la opción de búsqueda por servicios seleccionados.
DADO QUE, estoy viendo el buscador CUANDO, escriba las letras del nombre del servicio que quiero. ENTONCES, se muestran las filas con las empresas que tienen ese tipo de servicio.</li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Filtrar por calificación</td>
        <td>Como usuario cliente quiero poder ordenar a las empresas de acuerdo por la cantidad de estrellas promedio para tener la seguridad de encontrar calidad y confiabilidad en el servicio.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza las opciones de filtro de ordenamiento de las empresas.  
DADO QUE, me encuentro en el landing page y estoy logueado con mi cuenta personal. CUANDO, presione el botón de “Búsqueda”. ENTONCES, se muestra la opción “Ordenar por calificación” 
                </li>
                <li><strong>Escenario 2:</strong> El usuario selecciona el filtro de ordenamiento por calificación.  
DADO QUE, el usuario está viendo la lista de empresas. CUANDO, selecciona la opción de “Ordenar por calificación” Y selecciona la opción de mostrar empresas con calificación 5 estrellas, ENTONCES, la plataforma organiza los resultados para mostrar solo las empresas con las calificaciones promedio a 5 estrellas.
                </li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Visualizar perfil de empresa</td>
        <td>Como usuario cliente quiero poder filtrar las empresas por los servicios que ofrecen para encontrar aquellas que ofrecen el servicio que deseo.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario selecciona una empresa para ver su información.
DADO QUE, estoy viendo la lista de empresas disponibles. CUANDO, haga clic en el nombre o foto de una empresa. ENTONCES, el sistema me redirige a la página de su perfil. 
                </li>
                <li><strong>Escenario 2:</strong> El usuario realiza la opción de búsqueda por servicios seleccionados.
DADO QUE, estoy en el perfil de la empresa. CUANDO, me desplace hacia abajo. ENTONCES, la página muestra una breve descripción, su experiencia, ubicación, foto, calificación promedio, reseñas anteriores, disponibilidad y servicios ofrecidos, así como el botón de “Reserva”. 
                </li>
            </ul>
        </td>
        <td>#3</td> 
    </tr>
    <tr>
        <td>Reserva de servicios</td>
        <td>Envío de información sobre la posible reserva</td>
        <td>Como cliente quiero hacer una reserva sobre los servicios que ofrece la empresa de mudanza para que estos tengan más detalle de la reserva que quiero.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza el formulario de reservación de servicio.
DADO QUE, el cliente esté viendo los servicios ofrecidos por una empresa, CUANDO, presione “reservar servicio”, ENTONCES, se muestra un formulario para reservar los servicios de esa empresa.</li>
                <li><strong>Escenario 2:</strong> El usuario realiza la reserva del servicio.
DADO QUE, el cliente se encuentra en el formulario de reserva de servicios de una empresa, CUANDO, seleccione los servicios, Y presione “contactar trabajador”, ENTONCES se abre un chat desde el que se podrá comunicar con un trabajador de la empresa para definir detalles del servicio. </li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Reserva de servicios</td>
        <td>Visualizar historial de reservas</td>
        <td>Como usuario quiero poder ver los servicios de mudanza contratados para tener control y seguimiento de mis transacciones dentro de la aplicación.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario ingresa a reservas.
DADO QUE, el usuario ingresa a la sección de reservas. CUANDO seleccione el botón ver historial de reservas. ENTONCES aparecerá la página del historial. 
                </li>
                <li><strong>Escenario 2:</strong> El usuario visualiza su historial de reservas.   
DADO QUE, el usuario se encuentra en la página del historial de reservas. CUANDO el usuario haga scroll. ENTONCES la página le permitirá ver más reservas hechas anteriormente. 
                </li>
                <li><strong>Escenario 3:</strong> El usuario visualiza sus últimas reservas.
DADO QUE, el usuario ingresa a la sección de reservas. CUANDO la plataforma carga la página. ENTONCES las últimas reservas se visualizarán primero y las más antiguas al último.</li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Reserva de servicios</td>
        <td>Calificación del servicio</td>
        <td>Como usuario cliente, quiero poder calificar el servicio de la empresa de mudanza o carga para poder compartir mi experiencia y retroalimentar la calidad del servicio.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza la opción de calificación de servicio.
DADO QUE el usuario completó un servicio de mudanza o carga. CUANDO acceda a la sección de historial de reservas. ENTONCES aparecerá un botón para realizar la calificación del servicio Y se mostrará la opción de seleccionar una puntuación y proporcionar un comentario sobre la experiencia del servicio.</li>
                <li><strong>Escenario 2:</strong> El usuario no ingresa un comentario o puntuación
DADO QUE, el usuario completa un servicio de mudanza o carga. CUANDO desee dejar una reseña Y no complete los campos requeridos como puntuación y comentario. ENTONCES aparece un mensaje  de error. </li>
                <li><strong>Escenario 3:</strong> El usuario no ingresa su comentario con el mínimo número de palabras requerido.
DADO QUE, el usuario completa un servicio de mudanza o carga. CUANDO desee dejar una reseña Y complete el campo de comentario con menos del mínimo de cantidad de palabras. ENTONCES aparecerá un mensaje  de error.</li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Reserva de servicios</td>
        <td>Comunicación mediante chat con la empresa</td>
        <td>Como usuario quiero comunicarme con la empresa para poder coordinar los detalles de la mudanza.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario ingresa al chat.
DADO QUE, el usuario ingresa a su historial de reservas. Y en su última reserva aparece como estado “En curso”, Y se mostrará en el recuadro de su última reserva un botón “Chat”, CUANDO seleccione el botón, ENTONCES se desplegará un diálogo con un chat, este contendrá un campo donde ingresar el mensaje y en la parte inferior los botones de “Cancelar” y “Enviar”.</li>
                <li><strong>Escenario 2:</strong> El usuario envía mensaje.
DADO QUE, el usuario seleccione el botón “Chat”, Y se muestre el diálogo del chat, Y se muestra dentro del diálogo el título “Chat” y el nombre de la empresa a enviar mensaje, Y el usuario escriba el mensaje en el recuadro. CUANDO,  seleccione el botón “Enviar” que está en la parte inferior. ENTONCES, se guardará el mensaje.</li>
                <li><strong>Escenario 3:</strong> El usuario cancela el envío del mensaje.
DADO QUE, el usuario seleccione el botón “Chat”, Y se muestre el diálogo del chat, Y se muestra dentro del diálogo el título “Chat” y el nombre de la empresa a enviar mensaje, Y el usuario escriba el mensaje en el recuadro. CUANDO,  seleccione el botón “Cancelar” que está en la parte inferior. ENTONCES, el diálogo de chat se cerrará.</li>
            </ul>
        </td>
        <td>#4</td>
    </tr>  
    <tr>
        <td>Reserva de servicios</td>
        <td>Cancelar una reserva</td>
        <td>Como usuario quiero poder cancelar una reserva para dejar de solicitar los servicios de una empresa.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario cancela una reserva.
DADO QUE, el usuario ha realizado una reserva de servicios de mudanza o carga. CUANDO el usuario accede a la plataforma Y se dirige a la página de historial de reservas Y presiona el botón de cancelar reserva en la reserva que ya no desea. ENTONCES el estado de la reserva cambia ha finalizado.</li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Buscar Empresas por su nombre</td>
        <td>Como usuario cliente quiero buscar a las empresas dentro de la app por su nombre para hallar las que me llaman la atención.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza la opción de búsqueda por nombre de empresa.  
DADO QUE soy un usuario logueado con su cuenta personal y me encuentro en la página de editar datos de la cuenta. CUANDO, me dirija a la página de búsqueda de empresas”. ENTONCES, aparece un input en el cual se puede buscar por nombre de empresa.</li>
                <li><strong>Escenario 2:</strong> El usuario realiza la opción de búsqueda por nombre de empresa.  
DADO QUE, estoy viendo el buscador CUANDO, escriba las letras del nombre de la empresa que quiero. ENTONCES, se muestran las filas con las empresas cuyos nombres llevan las letras que ingrese en el buscador.</li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Visualización de reseñas de una empresa</td>
        <td>Como usuario cliente quiero poder ver reseñas dejadas hacia una empresa para que influyan en mi decisión sobre si buscar sus servicios.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong>El usuario accede a la página de perfil de la empresa.  
DADO QUE, soy un cliente interesado en los servicios de una empresa, CUANDO accedo a la página de perfil de la empresa, ENTONCES puedo ver una sección dedicada a las reseñas dejadas por otros clientes.
                </li>  
                <li><strong>Escenario 2:</strong> El usuario visualiza la calificación promedio de la empresa.
DADO QUE, estoy en la página del perfil de la empresa, CUANDO veo la sección de reseñas, ENTONCES puedo visualizar una calificación promedio basada en las reseñas dejadas por los clientes.
                </li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Resaltar las empresas con membresías</td>
        <td>Como una empresa de mudanzas con membresía en la app quiero que los datos de mi empresa se muestren al inicio de la búsqueda para llegar a más posibles clientes.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> el usuario visualiza primero las empresas con membresía al buscar empresas.  
DADO QUE soy un usuario logueado con cuenta de cliente, CUANDO me dirija a la pagina de busqueda de empresas, ENTONCES podré visualizar primero a las empresas con membresía
                </li>
                <li><strong>Escenario 2:</strong> el usuario visualiza empresas resaltadas en la búsqueda de empresas.  
DADO QUE soy un usuario logueado con cuenta de cliente, CUANDO me dirija a la pagina de busqueda de empresas, ENTONCES veré resaltada la información de las empresas con membresía
                </li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
    <tr>
        <td>Reserva de Servicios</td>
        <td>Búsqueda de una Carga Rápida</td>
        <td>Como usuario quiero poder generar reservas al momento para obtener servicios de carga rápidamente de las empresas de la app.</td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza el diálogo de Carga Rápida.
DADO QUE el usuario se encuentre en la vista de búsqueda de empresas, CUANDO seleccione el botón “Carga Rápida”, ENTONCES aparecerá el diálogo desde el cual se pueden generar Reservas tipo Carga Rápida.</li>
                <li><strong>Escenario 2:</strong> El usuario utiliza el diálogo emergente para generar una Reserva Carga Rápida.
DADO QUE el usuario se encuentre visualizando el diálogo de Carga Rápida CUANDO seleccione el botón “Buscar Carga Rápida”, ENTONCES se genera una reserva para ese momento.</li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Reserva de Servicios</td>
        <td>Agregar reseña sobre el trabajador de empresa de mudanzas</td>
        <td>Como usuario cliente quiero poder agregar reseñas sobre el servicio que brindó un trabajador en particular para brindar retroalimentación constructiva, quejas o impresiones positivas.
        </td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> Acceder al Historial de Reservas  
DADO QUE soy un usuario registrado en la página web, CUANDO presiona el botón de Historial de Reservas desde el toolbar, ENTONCES aparece el historial de reservas a través de la plataforma.  
                </li>
                <li><strong>Escenario 2:</strong> Dejar una Reseña en una Reserva Pasada DADO QUE he accedido a mi historial de reservas, CUANDO me posiciono en una reserva en la que el trabajo se ha completado, ENTONCES aparece una opción clara y accesible para dejar una reseña sobre el servicio proporcionado por el trabajador.  
                </li>
                <li><strong>Escenario 3:</strong> Enviar la Reseña   
DADO QUE estoy escribiendo una reseña sobre el servicio, CUANDO completo mi reseña y estoy satisfecho con mi comentario, Y presione el botón Enviar Reseña, ENTONCES la reseña se envía para su procesamiento y publicación.  
                </li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Reserva de Servicios</td>
        <td>Visualizar reseñas de los trabajadores de empresa de mudanzas</td>
        <td>Como usuario empresa quiero poder visualizar las reseñas de mis trabajadores para validar si están brindando un buen servicio.
        </td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> Acceder al Historial de Reservas
DADO QUE soy un usuario registrado en la página web, CUANDO presiona el botón de Historial de Reservas desde el toolbar, ENTONCES aparece el historial de reservas a través de la plataforma.
                </li>
                <li><strong>Escenario 2:</strong> Visualización de las Reseñas de Trabajadores   
DADO QUE he accedido al historial de reservas, CUANDO me posiciono en una reserva en la que el trabajo se ha completado, ENTONCES se puede visualizar la reseña dejada por el cliente sobre sobre el servicio proporcionado por ese trabajador.
                </li>
            </ul>
        </td>
        <td>#4</td>
    </tr>
    <tr>
        <td>Búsqueda de empresas</td>
        <td>Filtrar por calificación</td>
        <td>Como usuario cliente quiero poder ordenar a las empresas de acuerdo por la cantidad de estrellas promedio para tener la seguridad de encontrar calidad y confiabilidad en el servicio.  
        </td>
        <td>
            <ul>
                <li><strong>Escenario 1:</strong> El usuario visualiza la página de búsqueda de empresas.  
DADO QUE, me encuentro en el landing page y estoy logueado con mi cuenta personal. CUANDO, presione el botón de “Búsqueda de empresas”. ENTONCES, se muestra la lista completa de las empresas junto a filtros para realizar una búsqueda especializada.
                </li>
                <li><strong>Escenario 2:</strong> El usuario selecciona el filtro para mostrar empresas según promedio de calificación de sus reseñas.   
DADO QUE, el usuario está viendo la lista de empresas. CUANDO, selecciona la opción de “Ordenar por calificación” Y selecciona la opción de mostrar empresas con calificación 5 estrellas, ENTONCES, la plataforma organiza los resultados para mostrar solo las empresas con las calificaciones promedio a 5 estrellas.  
                </li>
            </ul>
        </td>
        <td>#3</td>
    </tr>
</table>





## 3.3. Impact Mapping  
![Impact_Map](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/Damaris/feature/Informe/Imagenes/Impactmapping.jpg?raw=true)

## 3.4. Product Backlog

| **# Orden** | **User Story Id** | **Título** | **Descripción** | **Story Points (1/2/3/5/8)** |
|--------------|--------------|--------------|--------------|--------------|
| 1| HU01    | Registro de Empresa de Mudanzas  | Como empresario, quiero poder registrar mi empresa de mudanza en la plataforma para que esté disponible y así poder realizar servicios de mudanza a los clientes.    | 3|
| 2| HU02   | Registro de Cliente    | Como usuario nuevo de Carga sin estrés, deseo registrarme en la plataforma para poder solicitar servicios de mudanza cuando los necesite.   | 2|
| 3| HU03    | Iniciar Sesión en la plataforma    | Como usuario registrado de Carga sin estrés, quiero poder iniciar sesión en mi cuenta para acceder a mis opciones según mi tipo de cuenta.     | 3|
| 4| HU04   | Ajustes de cuenta de cliente  | Como cliente registrado en Carga sin estrés, quiero ajustar los datos de mi cuenta para que refleje mis datos actuales.    | 2|
| 5| HU05   | Ajustes de cuenta de empresa   | Como empresa usuaria de Carga sin estrés, quiero ajustar los datos de la cuenta de empresa para que reflejen el estado actual de esta.    | 3|
| 6| HU06   | Cerrar Sesión   | Como usuario quiero cerrar la sesión de la cuenta empresarial para mantener la seguridad de la cuenta.   | 1|
| 7| HU07   | Elección de membresía de empresa    | Como usuario empresa quiero una opción que permita aumentar mi visibilidad dentro de la plataforma para captar clientes.    | 2|
| 8| HU08    | Pago de membresía  | Como usuario empresa quiero poder ingresar los detalles de mi tarjeta para pagar la membresía.   | 3|
| 9| HU09   | Pago para reserva de servicio   | Como usuario cliente, quiero poder ingresar los detalles de mi tarjeta al momento de realizar una reserva de servicio, y que la plataforma cobre automáticamente el importe al finalizar el servicio, para facilitar un proceso de pago conveniente y sin complicaciones.   | 5|
| 10| HU10   | Búsqueda de empresas cercanas  | Como usuario cliente quiero poder buscar empresas que ofrezcan servicios de mudanza o carga cercanos a mi ubicación actual para asegurarme que el servicio sea conveniente.   | 2|
| 11| HU11   | Filtrar por servicios ofrecidos  | Como usuario cliente quiero poder filtrar las empresas por los servicios que ofrecen para encontrar aquellas que ofrecen el servicio que deseo.   | 3|
| 12| HU12    | Visualizar perfil de empresa    | Como usuario cliente quiero poder visualizar el perfil de cada empresa para conocer su información detallada y así tomar una decisión informada y confiable al seleccionar la empresa adecuada para mis necesidades. | 2|
| 13| HU13   | Envío de información sobre la posible reserva  | Como cliente quiero hacer una reserva sobre los servicios que ofrece la empresa de mudanza para que estos tengan más detalle de la reserva que quiero.    | 5|
| 14| HU14   | Visualizar historial de reservas | Como usuario quiero poder ver los servicios de mudanza contratados para tener control y seguimiento de mis transacciones dentro de la aplicación.  | 5|  
| 15| HU15   | Calificación del servicio | Como usuario cliente, quiero poder calificar el servicio de la empresa de mudanza o carga para poder compartir mi experiencia y retroalimentar la calidad del servicio.  | 3|  
| 16| HU16   | Comunicación mediante chat con la empresa | Como usuario quiero comunicarme con la empresa para poder coordinar los detalles de la mudanza.   | 5|  
| 17| HU17   | Cancelar una reserva | Como usuario quiero poder cancelar una reserva para dejar de solicitar los servicios de una empresa.   | 1|  
| 18| HU18   | Buscar Empresas por su nombre | Como usuario cliente quiero buscar a las empresas dentro de la app por su nombre para hallar las que me llaman la atención.   | 2| 
| 19| HU19   | Visualización de reseñas de una empresa | Como usuario cliente quiero poder ver reseñas dejadas hacia una empresa para que influyan en mi decisión sobre si buscar sus servicios.  | 2|  
| 20| HU20   | Resaltar las empresas con membresías | Como una empresa de mudanzas con membresía en la app quiero que los datos de mi empresa se muestren al inicio de la búsqueda para llegar a más posibles clientes.  | 4|  
| 21| HU21   | Búsqueda de una Carga Rápida | Como usuario quiero poder generar reservas al momento para obtener servicios de carga rápidamente de las empresas de la app.  | 4|  
| 22| HU22   | Agregar reseña sobre el trabajador de empresa de mudanzas | Como usuario cliente quiero poder agregar reseñas sobre el servicio que brindó un trabajador en particular para brindar retroalimentación constructiva, quejas o impresiones positivas.  | 3|  
| 23| HU23   | Visualizar reseñas de los trabajadores de empresa de mudanzas | Como usuario empresa quiero poder visualizar las reseñas de mis trabajadores para validar si están brindando un buen servicio  | 2|  
| 24| HU24   | Filtrar por calificación | Como usuario cliente quiero poder ordenar a las empresas de acuerdo por la cantidad de estrellas promedio para tener la seguridad de encontrar calidad y confiabilidad en el servicio. | 2|  

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
#### DESKTOP  
![wireframe registro cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-registro-cliente.png?raw=true)  
![wireframe registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-registro-empresa.png?raw=true)  
![wireframe inicio sesion](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-login.png?raw=true) 
![wireframe busqueda de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframeDesktop-CompanySearch.png?raw=true) 
![wireframe detalle de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframeDesktop-CompanyDetail.png?raw=true) 
![wireframe historial de reservas](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-booking-history.png?raw=true)
![wireframe chat](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-chat.png?raw=true)
![wireframe review](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-review.png?raw=true)
![wireframe worker](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-worker.png?raw=true)
![wireframe membresia](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-membresia.png?raw=true)
![ajustes-empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-ajustes-empresa.png?raw=true)
![ajustes-cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-ajustes-cliente.png?raw=true)

#### MOBILE  
![mobile wireframe registro cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-registro-cliente-m.png?raw=true)
![mobile wireframe registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-registro-empresa-m.png?raw=true)
![mobile wireframe inicio sesion](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-login-m.png?raw=true) 
![mobile wireframe busqueda de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframeMobile-CompanySearch.png?raw=true) 
![mobile wireframe detalle de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframeMobile-CompanyDetail.png?raw=true) 
![mobile wireframe historial de reservas](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-booking-history-responsive.png?raw=true)
![mobile wireframe chat](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-chat-responsive.png?raw=true)
![mobile wireframe review](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-review-responsive.png?raw=true)
![mobile wireframe worker](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframe-worker-responsive.png?raw=true)
![wireframe membresia](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mobile-wireframe-membresia.png?raw=true)
![ajustes-empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-ajustes-empresa-m.png?raw=true)
![ajustes-cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/w-ajustes-cliente-m.png?raw=true)

### 4.4.2. Web Applications Wireflow Diagrams.  
![wireframe-flow1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframes-flow1.png?raw=true)  
  
![wireframe-flow2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/wireframes-flow2.png?raw=true)  

### 4.4.2. Web Applications Mock-ups.  
#### DESKTOP   
![registro-cliente-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-cliente.png?raw=true)    
![registro-empresa-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-empresa.png?raw=true)    
![inicio-sesion-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/login.png?raw=true)   
![formulario-membresias](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/formulario-membresia.png?raw=true)
![ajustes-empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ajustes-empresa.png?raw=true)
![ajustes-cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ajustes-cliente.png?raw=true)
![busquedaSearch-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/companySearch_mockupDesktop.png?raw=true)    
![busquedaDetail-mockup](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/companyDetail_mockupDesktop.png?raw=true)    


#### MOBILE   
![mobile mockup registro cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-cliente-m.png) 
![mobile mockup registro empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/registro-empresa-m.png?raw=true)  
![mobile mockup inicio sesion](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/login-m.png?raw=true)  
![formulario-membresia](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/formulario-membresia-m.png?raw=true)
![ajustes-empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ajustes-empresa-m.png?raw=true)
![ajustes-cliente](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/ajustes-cliente-m.png?raw=true)
![mobile mockup busqueda de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/companySearch_mockupMobile.png?raw=true)  
![mobile mockup detalle de empresa](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/companyDetail_mockupMobile.png?raw=true)  
![mobile mockup historial de reservas](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-booking-history-responsive.png?raw=true)   
![mobile mockup chat](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-chat-responsive.png?raw=true)   
![mobile mockup review](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-review-responsive.png?raw=true)   
![mobile mockup worker](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-worker-responsive.png?raw=true)   

### 4.4.3. Web Applications User Flow Diagrams.  
![mockup-flow1](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-flow1.png?raw=true)  
  
![mockup-flow2](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/mockup-flow2.png?raw=true) 
## 4.5. Web Applications Prototyping.  
El prototipo de secuencia web se encuentra en el siguiente enlace :  
[https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-453&t=wLRuXHHBxMj8lVew-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A453&show-proto-sidebar=1&mode=design](https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-453&t=wLRuXHHBxMj8lVew-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A453&show-proto-sidebar=1&mode=design)    

El prototipo de secuencia mobile se encuentra en el siguiente enlace :  
[https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-885&t=1YhgDvhIeuMcfiDB-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A885&show-proto-sidebar=1&mode=design](https://www.figma.com/proto/FFKvovSKPyL6LW7e2DDSph/Wireframes?type=design&node-id=26-885&t=1YhgDvhIeuMcfiDB-1&scaling=min-zoom&page-id=2%3A3&starting-point-node-id=26%3A885&show-proto-sidebar=1&mode=design)  


## 4.6. Domain-Driven Software Architecture. 

Los diagramas c4 se realizaron con Structurizr.   Enlace:[https://www.structurizr.com/share/85676/294b91b5-fde5-4ad9-bb61-11105de941e6]  

### 4.6.1. Software Architecture Context Diagram.  

En el diagrama de contexto se observa la relación de tipos de usuarios que interactúan con la aplicación, los cuales son "Ciudadano" y "Empresa". Así como los sistemas externos que se utilizan para el funcionamiento de la aplicación como el sistema de pago Niubiz.  

![Context Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Contexto.png?raw=true)  

### 4.6.2. Software Architecture Container Diagrams.  

En el diagrama de contenedores se observa la relación de los componentes dentro de nuestra aplicación, como el landing page, la aplicación web, los contextos, la base de datos y el API REST.  

![Container Diagram](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/Contenedor.png?raw=true)  

### 4.6.3. Software Architecture Components Diagrams.  

Los componentes de nuestra aplicación se dividen en 3 contextos, y los patrones utilizados son los siguientes:  
El patrón **Repository** utilizado para separar la capa de acceso a datos de la capa de la lógica de negocio. Además, ayuda a decidir si debe recuperar datos de una red o usar resultados almacenados en caché de una base de datos local, lo que mejora la gestión de datos y la eficiencia de la aplicación.  
El patrón **Gateway** utilizado para actuar como un intermediario entre nuestra aplicación y un sistema de pago externo Niubiz. Este enfoque nos proporciona una capa de abstracción que simplifica la comunicación y gestión de pagos, al tiempo que garantiza la seguridad y la flexibilidad en nuestras transacciones financieras.   

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
![Database](https://github.com/LuceroObispoRios/Grupo1_WS52/blob/main/Informe/Imagenes/CargaSinEstres-Web-DB.png?raw=true)

