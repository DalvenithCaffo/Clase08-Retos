// See https://aka.ms/new-console-template for more information
using Herencia;

Vendedor vendedor = new Vendedor();
vendedor.Caja = "VENDOR01";

//Propiedades de la Herencia - trabajador
vendedor.Agencia = "Santa anita";
vendedor.Sueldo = 5000;
//Propiedades de la Herencia - Persona
vendedor.Nombre = "Nombre Vendedor";
vendedor.Apellido = "Apellido Vendedor";
vendedor.DNI = "12345678";
vendedor.Edad = 35;

Cliente cliente = new Cliente();
cliente.Email = "cliente@miempresa.com.pe";
cliente.Telefono = "123456789";
cliente.Direccion = "ladirecciondelcliente";
cliente.Edad = 14;

//Propiedades de la herencia Persona
cliente.Nombre = "ClienteNombre";
cliente.Apellido = "ClienteApellido";
cliente.DNI = "87654321";

Gerente gerente = new Gerente();
gerente.fechaingreso = new DateTime(2000, 1, 20);

//Propiedades de la Herencia - trabajador
gerente.Agencia = "Miraflores";
gerente.Sueldo = 10000;

//Propiedades de la Herencia - Persona
gerente.Nombre = "Nombre Gerente";
gerente.Apellido = "Apellido Gerente";
gerente.DNI = "66666666";

    
Console.WriteLine($"Gerente nombre:"+gerente.Nombre);