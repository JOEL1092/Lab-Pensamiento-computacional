//EJercicios de Lab #10 - Kevin Joel Atz Amaya - Carne: 2001025
using System;
class Program {
 static void Main() {

//Ejerccio 1: pedir la edad de una persona y clasifcarla segun su etapa de vida
Console.WriteLine("Ingrese su edad para clasificarlo segun su etapa de vida");
int edad = Convert.ToInt32(Console.ReadLine());

    if (edad < 12)//Si es menor a 12 años es un niño
        {
            Console.WriteLine("Niño");
        }
    else    
        {
            if (edad >= 12 && edad <= 17)//Entre 12 y 17 años es adolescente
                {
                    Console.WriteLine("Adolecente");
                }

            else
                {
                    if (edad >= 18 && edad <= 64)// Entre 18 y 64 años es adulto
                        {
                            Console.WriteLine("Adulto");
                        }
                    
                    else 
                        {
                            if (edad >= 65)// De 65 años o más es adulto mayor
                                {
                                    Console.WriteLine("Adulto mayor");
                                }
                        }
                }

        }
 
 
//Ejerccio 2: Solicite al usuario su calificación y determine surendimiento
Console.WriteLine("Ingrese su calificación");
int calificación= Convert.ToInt32(Console.ReadLine());

    if (calificación >= 0 && calificación <= 59)// De 0 a 59: Reprobado
        {
            Console.WriteLine("Reporbado");
        }
    else    
        {
            if (calificación >= 60 && calificación <= 79)// De 60 a 79: Aprobado
                {
                    Console.WriteLine("Aprobado");
                }

            else
                {
                    if (calificación >= 80 && calificación <= 89)// De 80 a 89: Notable
                        {
                            Console.WriteLine("Notable");
                        }
                    
                    else 
                        {
                            if (calificación >= 90 && calificación <= 100)// De 90 a 100: Excelente
                                {
                                    Console.WriteLine("Excelente");
                                }
                        }
                }

        }

//Ejerccio 3:  calcule la tarifa del transporte público según la categoría del usuario. 
//El usuario podrá seleccionar entre las siguientes opciones:
double tarifa = 0;
Console.WriteLine("La tarifa normal de transporte publico es de Q 10.00");
Console.WriteLine("Selecciones las siguientes opciones para calcular su tarifa, ingrese el numero de la opcion");
Console.WriteLine("1. Adulto");
Console.WriteLine("2. Estudiante");
Console.WriteLine("3. Adulto mayor");
Console.WriteLine("4. Niñ0");
Console.WriteLine("5. Salir del programa");
int opciones = Convert.ToInt32(Console.ReadLine());
 
    switch (opciones){

        case 1://Adulto (tarifa normal)
            Console.WriteLine("Su tarifa es de Q 10 (tarifa normal)");
        break;

        case 2://Estudiante (descuento del 50%)
            tarifa = 10 * 0.5;
                Console.WriteLine("Su tarifa es de Q " + tarifa);
        break;

        case 3://Adulto mayor (descuento del 30%)
            tarifa = 10 * 0.7;
                Console.WriteLine("Su tarifa es de Q " + tarifa);
        break;

        case 4://Niño (gratis si es menor de 5 años, 50% de descuento si es entre 5 y 12)
            Console.WriteLine("Ingrese la edad del niño");
            int edadN = Convert.ToInt32(Console.ReadLine());

            if (edadN < 5)
                {
                    Console.WriteLine("Su tarifa es gratis");
                }
            
            else 
                {
                    if (edadN >= 5 && edadN <= 12)
                        {
                            tarifa = 10 * 0.5;
                            Console.WriteLine("Su tarifa es de Q " + tarifa);
                        }
                }
                
        break;

        case 5://Salir del programa
            Console.WriteLine("Has salido del programa");
        break;

        default://Resto de numeros que no son opciones
            Console.WriteLine("No es una opcion");
        break;

    }
 }
 
 }
