using System;
// Programa de gestión de cuentas bancarias
Console.WriteLine("Bienevendio al programa de gestión de cuentas bancarias.\n\n\n");
// Crear dos cuentas bancarias
//CUENTA 1
CuentaBancaria cuenta1 = new CuentaBancaria("Juan Pérez", 123456);
cuenta1.MostrarSaldo();
//CUENTA 2
CuentaBancaria cuenta2 = new CuentaBancaria("Alexis Samboy", 458255);
cuenta2.MostrarSaldo();
// Realizar operaciones en las cuentas
//depositos cuenta 1
Console.WriteLine($"¿Cuánto va a depositar a la primera cuenta:");
decimal deposito = Convert.ToDecimal(Console.ReadLine());
cuenta1.Depositar(deposito);
//depositos cuenta 2
Console.WriteLine($"¿Cuánto va a depositar a la segunda cuenta:");
deposito = Convert.ToDecimal(Console.ReadLine());
cuenta2.Depositar(deposito);
//retiro cuenta 1
Console.WriteLine($"¿Cuánto va a retirar de la primera cuenta:");
decimal retiro = Convert.ToDecimal(Console.ReadLine());
cuenta1.Retirar(retiro);
//retiro cuenta 2
Console.WriteLine($"¿Cuánto va a retirar de la segunda cuenta:");
decimal retiro2 = Convert.ToDecimal(Console.ReadLine());
cuenta2.Retirar(retiro2);
// Mostrar saldos finales
Console.WriteLine("\nSaldos finales:");
cuenta1.MostrarSaldo();
cuenta2.MostrarSaldo();