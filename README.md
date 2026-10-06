# TP_SistemaGestionDeTurnosPeluqueria_Grupo10

Sistema de Gestión de Turnos para Peluquería
1. Descripción breve del sistema
Este sistema está diseñado para optimizar y automatizar la gestión de una peluquería o salón de belleza. Permite administrar de manera eficiente la agenda diaria, el personal, los clientes y los servicios ofrecidos, incluyendo además un sistema de fidelización de clientes.

Las entidades principales del sistema son:

Cliente: Persona que solicita y recibe los servicios de la peluquería (incluye datos de contacto, historial de visitas y contador de puntos o beneficios de fidelización).

Peluquero / Estilista: Profesional encargado de realizar los servicios.

Servicio: Prestación que ofrece la peluquería (ej. corte de cabello, tinte, barba, peinado, etc.) con su respectiva duración y costo.

Turno / Cita: Asociación en un horario determinado entre un cliente, un peluquero y uno o más servicios.

2. Objetivos y funcionalidades previstas
El objetivo principal del sistema es proporcionar una herramienta robusta (dividida en una biblioteca lógica y una interfaz de consola) para mantener la agenda ordenada, evitar solapamientos de horarios y facilitar el control administrativo del negocio y la fidelización de clientes.

A. Funcionalidades con Alta, Baja y Modificación (ABM)
Gestión de Clientes (ABM Completo):

Alta: Registrar nuevos clientes con nombre, apellido y teléfono.

Modificación: Actualizar los datos de contacto de un cliente existente o gestionar su estado de fidelización.

Baja: Dar de baja (o inactivar) a un cliente que ya no utilice los servicios del salón.

Gestión de Turnos / Citas (ABM Completo):

Alta: Agendar un nuevo turno seleccionando cliente, peluquero, servicio, fecha y hora (validando que no existan cruces de horarios y actualizando automáticamente el contador de visitas del cliente).

Modificación: Reasignar el horario, cambiar de peluquero o actualizar el servicio de un turno ya existente.

Baja: Cancelar o eliminar un turno agendado.

B. Funcionalidad Especial: Programa de Fidelización y Descuentos
Acumulación de Visitas y Beneficios:

El sistema registra de forma automática cuántas veces asiste un cliente a la peluquería a través de sus turnos completados.

Al alcanzar un determinado umbral de visitas (por ejemplo, cada 5 cortes), el sistema aplica de forma automática o permite canjear un descuento especial o un servicio bonificado para premiar su fidelidad.

C. Reportes previstos (Mínimo 4)
Reporte de Turnos Diarios:

Muestra la agenda completa organizada cronológicamente para una fecha específica, indicando hora, cliente, peluquero y servicio asignado.

Reporte de Rendimiento por Peluquero:

Detalla la cantidad de turnos atendidos por cada profesional en un período de tiempo determinado (semana o mes).

Reporte de Servicios Más Demandados:

Estadística que ordena los servicios de la peluquería según la cantidad de veces que han sido solicitados, útil para medir la popularidad de cada uno.

Reporte de Historial de Clientes y Fidelización:

Muestra el registro detallado de las visitas de un cliente en específico, cuántos turnos lleva acumulados y si califica actualmente para algún descuento o beneficio por fidelidad.


