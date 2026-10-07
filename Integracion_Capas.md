# Integración de capas del sistema para guardar un registro

La integración y comunicación de las distintas capas de la arquitectura del software para almacenar un nuevo registro en la base de datos se realiza de la siguiente manera:

* **Capa de Presentación:** Es la interfaz de usuario donde se ingresan y capturan los datos mediante formularios. Al confirmar la acción, empaqueta la información y la envía a la siguiente capa.
* **Capa de Lógica de Negocio:** Recibe los datos enviados desde la interfaz y aplica las reglas de negocio y validaciones necesarias del sistema. Una vez procesada y validada la información, la transfiere hacia la capa de datos.
* **Capa de Acceso a Datos (ORM):** Utiliza un mapeador objeto-relacional (ORM) para traducir las entidades y objetos del sistema en sentencias SQL estructuradas compatibles con el motor de base de datos.
* **Base de Datos:** Recibe la instrucción enviada por el ORM, valida las restricciones de integridad y almacena de forma definitiva el registro en la tabla correspondiente.
