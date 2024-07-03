---TAREAS PARA LA SIGUEINTE CLASE
Es tarea grupal 
Se realizará una exposición, un miembro aleatorio del grupo 
El tema es VISTAS Y TRIGGERS 
Qué son 
Fundamentos
Ejemplos de c/u y explicación
Conclusiones 
Bibliografía, no citar de CHATGPT
Desde el Jueves empiezan las exposiciones

## Vistas

- **¿Qué son las vistas?** Las vistas son como tablas virtuales que contienen los resultados de una consulta, pero solo se guarda la definición de la consulta, no los datos. [En otras palabras, una vista es una consulta que se presenta como una tabla virtual a partir de un conjunto de tablas en una base de datos relacional](https://es.wikipedia.org/wiki/Vista_%28base_de_datos%29)[1](https://es.wikipedia.org/wiki/Vista_%28base_de_datos%29).
    
- **Creación de Vistas**:
    
    - Para crear una vista, utilizamos la sentencia `CREATE VIEW`.
    - Las vistas tienen la misma estructura que una tabla: filas y columnas.
    - Los datos que se recuperan mediante una consulta a una vista se presentarán igual que los de una tabla.
- **Ejemplo de Creación de Vista**: Supongamos que tenemos dos tablas: `productos` y `categoria`. Queremos crear una vista que muestre información sobre productos y su categoría. Aquí está el ejemplo:


```sql
CREATE VIEW vista_producto_categoria AS
SELECT p.idProducto, p.nombre, p.precio, p.existencia, c.nombre AS categoria
FROM productos AS p
INNER JOIN categoria AS c ON p.idCategoria = c.id;
```


## Triggers

- **¿Qué son los triggers?** Un trigger (o disparador) es un script de programación SQL para base de datos. Se ejecuta automáticamente cuando ocurren ciertos eventos, como inserciones (INSERT), actualizaciones (UPDATE) o eliminaciones (DELETE) en la base de datos. [Los triggers pueden modificar la información de la base de datos e incluso detener la ejecución de consultas erróneas](https://www.srcodigofuente.es/aprender-sql/triggers-sql)[2](https://www.srcodigofuente.es/aprender-sql/triggers-sql).
- **Creación de Triggers**:
    - Los eventos que hacen que se ejecute un trigger son las operaciones de inserción, borrado o actualización, ya que modifican los datos de una tabla.
        
    - Los triggers mejoran la gestión de la base de datos sin requerir que un usuario los ejecute manualmente.
        
    - Ejemplo de creación de un trigger:
        
        SQL
        
        ```sql
        DELIMITER $$
        CREATE TRIGGER trigger_historico
        AFTER INSERT ON tabla
        FOR EACH ROW
        BEGIN
          -- Acciones a realizar
        END;
        $$
        ```



[1![](blob:https://edgeservices.bing.com/672a1367-1435-4978-9ac7-e339ec460d57)es.wikipedia.org](https://es.wikipedia.org/wiki/Vista_%28base_de_datos%29)[2![](blob:https://edgeservices.bing.com/9ef690ad-140c-4f1c-81a9-18371c6da429)srcodigofuente.es](https://www.srcodigofuente.es/aprender-sql/triggers-sql)[3![](blob:https://edgeservices.bing.com/0e79bf5e-55d1-4af9-8f52-ae5ea59d5429)bing.com](https://bing.com/search?q=Fundamentos+de+vistas+en+bases+de+datos)[4![](blob:https://edgeservices.bing.com/d44be218-ba55-4bc6-9177-9aff4cb143d8)ibm.com](https://www.ibm.com/docs/es/mfci/7.6.2?topic=structure-views)[5![](blob:https://edgeservices.bing.com/13c63c93-7f07-4d82-8941-7a638c2aea14)learn.microsoft.com](https://learn.microsoft.com/es-es/sql/relational-databases/views/views?view=sql-server-ver16)[6![](blob:https://edgeservices.bing.com/0e79bf5e-55d1-4af9-8f52-ae5ea59d5429)bing.com](https://bing.com/search?q=Fundamentos+de+triggers+en+bases+de+datos)[7![](blob:https://edgeservices.bing.com/9cbc2d56-fece-4db6-a76a-17e2d3c83ab9)ayudaleyprotecciondatos.es](https://ayudaleyprotecciondatos.es/bases-de-datos/trigger/)[8![](blob:https://edgeservices.bing.com/808c80dd-ba02-4619-b34a-cfef22e1307c)wikiwand.com](https://www.wikiwand.com/es/Trigger_%28base_de_datos%29)[9![](blob:https://edgeservices.bing.com/13189d58-abb3-47ee-8c7f-f23709110aad)entredata.org](https://www.entredata.org/fundamentos-de-sql/implementacion-de-triggers-en-sql-caso-de-estudio-de-una-base-de-datos-estudiantil)