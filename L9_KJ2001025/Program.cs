//EJercicios de Lab #09 - Kevin Joel Atz Amaya - Carne: 2001025
using System;
class Program {
 static void Main() {

 Console.Write("¿Cómo te llamas? ");
 string nombre = Console.ReadLine();
 Console.WriteLine("Hola, " + nombre + " ¡Bienvenido a C#!");

//////////////////////    Ejercicio 1   //////////////////////////////////////////////////////////////////////////////////////
// /////////////  Una tienda de ropa ofrece descuentos según el monto de la compra  //////////////////////////////////////////
    double Descuento = 0;
Console.WriteLine("Para realizar el descuento a su compra ingrese su monto $:");
    double monto = Convert.ToDouble(Console.ReadLine());


//si el monto es igual o mayor a 100 se le realizara un descuento del 20%
    if (monto >= 100)
        {
            Descuento = Math.Round((monto * 0.80),2);
            Console.WriteLine("Su descuento es del 20% ");
            Console.WriteLine("total a pagar es de: " + Descuento + " $");
        }   


//si el monto es igual o mayor a 50, pero menor o igual a 99 se le realizara un descuento del 10%
    if (monto >= 50 && monto <= 99)
        {
            Descuento = Math.Round((monto * 0.90),2);
            Console.WriteLine("Su descuento es del 10% ");
            Console.WriteLine("total a pagar es de: " + Descuento + " $");
        }   


//si el monto es menor a 50, no se le realiza descuento
    if (monto < 50)
        {
            Console.WriteLine("No tiene descuento");
        }   

//////////////////////////     Ejercicio 2      /////////////////////////////////////////////////////////////////////////////
//// Una discoteca desea implementar un programa para leer la edad de una persona y mostrar un mensaje que //////////////////
// /////////////  indique “Acceso denegado” si no es mayor de edad  /////////////////////////////////////////////////////////

Console.WriteLine("Para tener acceso a la discoteca, tenemos que validar si eres mayor de edad ");
Console.WriteLine("Ingresa tu edad: ");
    int edad = Convert.ToInt32(Console.ReadLine());

//Si la edad es menor a 18 se niega el acceso
    if (edad < 18) 
        {
            Console.WriteLine("Acceso denegado");
        }

//Si la edad es mayor o igual a 18 se autoriza el acceso
    if (edad >= 18) 
        {
            Console.WriteLine("Acceso autorizado");
        }

///////////////////////////////     Ejercicio 3    /////////////////////////////////////////////////////////////////////////////
//////////////// Leer dos números por teclado y multiplicarlos si son iguales,//////////////////////////// 
//////restarlos si el primero es mayor que el segundo o sumarlos si el primero es menor que el segundo. ///////////////  

    int Resultado = 0;
Console.WriteLine("Ingrese dos numeros para operar segun su valor");
Console.WriteLine("Ingrese el primer numero: ");
    int N1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ingrese el segundo numero: ");
    int N2 = Convert.ToInt32(Console.ReadLine());

//Si los numeros son iguales se multiplican
    if (N1 == N2) 
        {
            Resultado = (N1 * N2);
            Console.WriteLine("El resultado es de: " + Resultado); 
        }

//Si el primero es mayor al segundo se restan
    if (N1 > N2) 
        {
            Resultado = (N1 - N2);
            Console.WriteLine("El resultado es de: " + Resultado); 
        }

//Si el primero es menor al segundo se suman
    if (N1 < N2) 
        {
            Resultado = (N1 + N2);
            Console.WriteLine("El resultado es de: " + Resultado); 
        }

///////////////////////////////     Ejercicio 4    /////////////////////////////////////////////////////////////////////////////
// Una agencia de autos necesita un sistema para calcular el pago mensual para un agente de ventas de autos, basándose en lo siguiente://
//a. El pago base es de $350, más una comisión de $15 por cada auto vendido y un bono de $40 si vendió más de 15 autos.
//b. El impuesto a pagar es el 5 % del pago total.
//c. Los datos de entrada son el nombre del vendedor y el número de autos vendidos en el mes.
//d. Se desea imprimir el nombre del vendedor, el sueldo bruto, el impuesto y el sueldo neto. 

//Asignacion de variables y constantes
 int PagoBase = 350;//Pago base
 int Comision = 15;//Comisiones por auto
 int Bono = 40;//Bono por cada 15 autos vendidos
 double Impuesto = 0.05;//Impuesto de 5%
 int SueldoB = 0;//Sueldo Bruto
 double SueldoN = 0;//Sueldo Neto
 double ImpuestoTotal = 0;//Impuesto total del sueldo Bruto

Console.WriteLine("Ingrese el nombre y la cantidad de autos que el agente vendio para saber su sueldo mensualdo");
Console.WriteLine("Ingrese el nombre del vendedor");
    string vendero = Console.ReadLine();
Console.WriteLine("Ingrese la cantidad de autos vendidos en el mes");
    int Autos = int.Parse(Console.ReadLine());

//Si la cantidad de autos es menor a 15, no se le da bono 
    if (Autos < 15)
        {
            SueldoB = PagoBase + (Autos * Comision); //El sueldo bruto es pago base + Cantidad de autos por 15
            ImpuestoTotal = SueldoB * Impuesto;//El impuesto total es la multiplicacion del sueldo bruto por el 5%
            SueldoN = SueldoB - ImpuestoTotal;//El sueldo neto es sueldo bruto - impuesto del sueldo bruto
            Console.WriteLine("Vendedor: " + vendero);
            Console.WriteLine("Sueldo bruto: " + SueldoB + " $");
            Console.WriteLine("Impuesto: " + ImpuestoTotal + " $");
            Console.WriteLine("Sueldo Neto: " + SueldoN + " $");
        }

//Si la cantidad de autos es igual o mayor a 15, se le da bonos cada 15 autos vendidos 
 if (Autos >= 15)
        {
            SueldoB = PagoBase + (Autos * Comision) +((Autos/15) * Bono);//El sueldo bruto es pago base + Cantidad de autos por 15 + la cantidad de autos entre 15 por 40
            ImpuestoTotal = SueldoB * Impuesto;//El impuesto total es la multiplicacion del sueldo bruto por el 5%
            SueldoN = SueldoB - ImpuestoTotal;//El sueldo neto es sueldo bruto - impuesto del sueldo bruto
            Console.WriteLine("Vendedor: " + vendero);
            Console.WriteLine("Sueldo bruto: " + SueldoB + " $");
            Console.WriteLine("Impuesto: " + ImpuestoTotal + " $");
            Console.WriteLine("Sueldo Neto: " + SueldoN + " $");
        } 
 }
}
