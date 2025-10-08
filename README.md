# 📦 Inventory Management System (C# WinForms + MySQL)

Este proyecto es un **sistema de gestión de inventario** desarrollado en **C# Windows Forms** con conexión a **MySQL**.  
Permite administrar productos y proveedores, mostrando la información en una interfaz amigable con `DataGridView`.

## 📄 Documentación Completa

Para ver la documentación completa y detallada del proyecto, puedes revisar el siguiente documento:

[Documentación InventoryPro (Google Docs)](https://docs.google.com/document/d/1JHYUFmD0NpDkxVGrK2o1b5L_96Pf8lPfIkCzuH09YVI/edit?usp=sharing)

A continuación, un resumen de los principales apartados incluidos en el documento:

### 🗂️ Contenidos destacados

- Introducción  
- Problematización  
  - Antecedentes  
  - Definición del proyecto  
  - Objetivos generales y específicos  
  - Metodología  
- Marco Teórico  
  - Antecedentes  
  - Software a medida  
  - Arquitectura de software  
  - Ingeniería de software  
  - Base de datos  
  - UML  
  - Lenguajes de programación  
- Desarrollo  
  - Metodología de desarrollo  
  - Requisitos funcionales y no funcionales  
  - Casos de uso  
  - Diseño de interfaz  
  - Diseño de base de datos  
  - Codificación  
- Conclusión  
- Anexos  

> ⚠️ Nota: Para mayor comodidad de lectura y edición, te recomiendo abrir el documento en modo “Presentación” o usar el menú de Google Docs para navegación por secciones.

---

## 🚀 Tecnologías utilizadas

- **Lenguaje:** C# (.NET Framework / WinForms)
- **Base de Datos:** MySQL
- **Conector:** MySQL Connector/NET
- **IDE:** Visual Studio

---

## ⚙️ Instalación

1. Clona este repositorio:
   ```bash
   git clone https://github.com/gustavitoo/InventoryManagement.git
	```
2. Asegúrate de tener instalado MySQL Server y MySQL Connector/NET.
3. Crea una base de datos llamada `inventory_managment` y ejecuta el script en tu servidor MySQL:
	```sql
	    CREATE DATABASE IF NOT EXISTS inventory_managment;
    USE inventory_managment;

    -- Tabla de proveedores
    CREATE TABLE providers (
        ProviderId INT AUTO_INCREMENT PRIMARY KEY,
        Name VARCHAR(100) NOT NULL,
        ContactName VARCHAR(100),
        Phone VARCHAR(20),
        Email VARCHAR(100),
        Address VARCHAR(200)
    );

    -- Tabla de productos
    CREATE TABLE products (
        ProductId INT AUTO_INCREMENT PRIMARY KEY,
        Name VARCHAR(100) NOT NULL,
        Category VARCHAR(50),
        Stock INT DEFAULT 0,
        UnitPrice DECIMAL(10,2),
        CostPrice DECIMAL(10,2),
        ProviderId INT,
        FOREIGN KEY (ProviderId) REFERENCES providers(ProviderId)
    );

    -- Datos de ejemplo para proveedores
    INSERT INTO providers (Name, ContactName, Phone, Email, Address) VALUES
    ('Proveedor A', 'Juan Pérez', '123456789', 'proveedora@mail.com', 'Av. Principal 123'),
    ('Proveedor B', 'María Gómez', '987654321', 'proveedorb@mail.com', 'Calle Secundaria 456'),
    ('Proveedor C', 'Carlos López', '555444333', 'proveedorc@mail.com', 'Ruta 7 Km 89');

    -- Datos de ejemplo para productos
    INSERT INTO products (Name, Category, Stock, UnitPrice, CostPrice, ProviderId) VALUES
    ('Laptop HP', 'Electrónica', 10, 750.00, 600.00, 1),
    ('Mouse Logitech', 'Accesorios', 50, 25.00, 15.00, 2),
    ('Teclado Mecánico', 'Accesorios', 30, 80.00, 50.00, 2);
    ```

## 🖥️ Funcionalidades implementadas

- Conexión a MySQL mediante DAO Pattern

- CRUD de Productos

- Visualización de productos en DataGridView con columnas personalizadas en español

- Asociación de productos con proveedores (JOIN SQL)

- CRUD de Proveedores

## 📖 Uso del programa

Al iniciar, la aplicación muestra los dos servicios disponibles: gestión de productos y gestión de proveedores.


### Productos

Selecciona "Productos" para ver y administrar los productos en inventario.
Los datos se muestran en un DataGridView con las columnas:

- ID Producto

- Nombre

- Categoría

- Stock

- Precio Venta

- Precio Costo

- Proveedor

Puedes agregar, editar o eliminar productos mediante los formularios correspondientes.
Los cambios se reflejan en la base de datos MySQL.

### Proveedores

Para gestionar proveedores, selecciona "Proveedores".
Los datos se muestran en un DataGridView con las columnas:

 - ID Proveedor

 - Nombre

 - Nombre Contacto

 - Teléfono

 - Email

 - Dirección

Puedes agregar, editar o eliminar productos y proveedores mediante los formularios correspondientes.
Los cambios se reflejan en la base de datos MySQL.
