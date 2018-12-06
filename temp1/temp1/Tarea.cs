using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace temp1
{
    class Tarea
    {
        int id;
        String status;

        int operacion;
        int x;
        int y;
        
        public Tarea(int x, int y, int id)
        {
            this.id = id;
            Random rnd = new Random();
            this.x = x;
            this.y = y;
            this.operacion = rnd.Next(1, 4);
            this.status = "abierto";
        }

        public int ejecutarProceso()
        {
            switch (this.operacion)
            {
                case 1:
                    //Suma
                    Console.WriteLine("Operacion: " + this.operacion );
                    return (this.x + this.y);
                    break;
                case 2:
                    //Resta
                    Console.WriteLine("Operacion: " + this.operacion);
                    return (this.x - this.y);
                    break;
                case 3:
                    //Multiplicación
                    Console.WriteLine("Operacion: " + this.operacion);
                    return (this.x * this.y);
                    break;
                case 4:
                    //Suma
                    Console.WriteLine("Operacion: " + this.operacion);
                    return (this.x + this.y);
                    break;
                default:
                    //default stuff
                    Console.WriteLine("Operacion: " + this.operacion);
                    return (this.x + this.y);
                    break;
            }
        }

    }
}
