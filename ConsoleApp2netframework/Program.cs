using SlimDX.XInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Whatever;

namespace ControlXBox
{
    class Program
    {
        static void Main(string[] args)
        {
            //creamos una instancia GamepadState y le enviamos la constante de control numero 1
            GamepadState control = new GamepadState(UserIndex.One);

            //ahora detectamos si el controll esta conectado
            if (control.Connected)
            {
                Console.WriteLine("El control esta conectado");

                //creamos un ciclo infinito solo para detectar el control cada que presionemos un boton

                while (true)
                {

                    //detectamos si se realizo una modificación, se presiono un botón o se movio una palanca etc.
                    control.Update();

                    //imprimimos el boton presionado en consola
                    Console.WriteLine(control.Controller.GetState().Gamepad.Buttons.ToString());

                }

            }
            else
            {
                //Si el control no esta conectado mostramos mensaje de que no esta conectado :(
                Console.WriteLine("El control NO esta conectado");
                Console.ReadLine();

            }

        }

    }
}