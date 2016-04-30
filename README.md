# Diseño con componentes
Ejemplos para explicar cómo diseñar componentes de software.

Se muestra una aplicación que cumple los principios de orientación a objetos y está organizada por componentes hasta lograr la Inversión de Dependencias.

## 1 Sin componentes: 
Representa un aplicación web como las que uno lee en los tutoriales en internet. Todo está programado dentro del mismo proyecto. No hay pruebas unitarias y hay bifurcaciones en los algoritmos.

## 2 Con componentes tradicionales
Representa a una aplicación donde se buscó separar la interfaz gráfica, de la lógica de negocio, y del acceso a datos. Sin embargo, no se logró hacer ya que no se puede probar la lógica de negocio sin la base de datos, por lo que terminamos probando todo manualmente desde a interfaz gráfica. No hay pruebas unitarias y hay bifurcaciones en los algoritmos.

## 3 Con inversión de dependencias
Representa a la verdadera división por componentes, cumpliendo los principios SOLID. 
* Está escrito con orientación a objetos con responsabilidades únicas (Single Responsibility Principle). 
* Las clases que participan en condicionales se pueden extender sin cambiar el código existente (Open Closed Principle). 
* Se hace un uso correcto de la herencia (Liskov Substitution Principle). 
* Ningún flujo de ejecución tiene bifurcaciones (Interface Segregation Principle). 
* La verdadera componentización se da porque la lógica de negocio obtiene datos de la base de datos y del UI sin estar acoplado ("amarrado") a sus tecnologías. Es fácil de entender, de probar y de cambiar.

# Más información
Si desea más información para cursos o capacitaciones en diseño en software ágile, me puede contactar.
