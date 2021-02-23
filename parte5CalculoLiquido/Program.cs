using System;

namespace parte5CalculoLiquido
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Title = "Pago liquido del empleado";
            String nombre, apellido, cargo, gerente, asistente, secretaria, otros;
            Double horasTrab, sueldoLiq, sueldoBas, hMayores, hMenores, AFP, renT, ISS, descuentos, descTotal, sueldoG;//decimales
            Console.WriteLine("Ingrese el nombre del empleado:");
            nombre = (Console.ReadLine());
            Console.WriteLine("Introduzca el apellido del empleado");
            apellido = (Console.ReadLine());
            Console.WriteLine("Introduzca el cargo del empleado");
            cargo = (Console.ReadLine());
            Console.WriteLine("Introduzca las horas trabajadas por el empleado");
            horasTrab = Double.Parse(Console.ReadLine());                              
            
            if (horasTrab <= 0)//
            {
                Console.WriteLine("Sus datos ingresados no son validos");
            }
            else if (horasTrab > 0)
            {
                Console.WriteLine("Sus horas trabajadas " + horasTrab + " ");
                if ((horasTrab <= 160) && (horasTrab > 160))
                {
                    //horas menores a 160h
                    hMenores = 9.75;
                    sueldoBas = horasTrab * 9.75 * 30;                   
                }
                else if (horasTrab < 160);
                {//horas mayores a 160h
                    hMayores = 11.50;
                    sueldoBas = horasTrab * hMayores * 30;                   
                }//decimales
                renT = sueldoBas-(1 / 10) * 100;//
                AFP = sueldoBas-(43 / 625) * 100;
                ISS = sueldoBas-(21 / 400) * 100;
                descTotal = (0.2213) * 100;
                descuentos = (sueldoBas) * (0.22);
                sueldoLiq = sueldoBas - descuentos;
                sueldoG = sueldoLiq + ((0.1) * 100);                              
                Console.WriteLine("Nombre del empleado: "+nombre+" "+apellido+" ");
                Console.WriteLine("Descuento por ISS es de: "+ISS+" ");
                Console.WriteLine("Descuento por AFP es de: "+AFP+" ");
                Console.WriteLine("Descuento por RENTA es de: " +renT+ " ");
                Console.WriteLine("Su sueldo con liquido (final) es de: $" + sueldoG + ".");
                Console.ReadKey();
            }
        }

    }
}
        

