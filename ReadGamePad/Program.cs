using SharpDX.DirectInput;

var directinput = new DirectInput();
var JoystickGuid = Guid.Empty;
foreach (var deviceInstance in directinput.GetDevices(
    DeviceType.Gamepad, DeviceEnumerationFlags.AllDevices))
    JoystickGuid = deviceInstance.InstanceGuid;

if(JoystickGuid == Guid.Empty)
    foreach (var deviceInstance in directinput.GetDevices(
    DeviceType.Joystick, DeviceEnumerationFlags.AllDevices))
        JoystickGuid = deviceInstance.InstanceGuid;

if (JoystickGuid == Guid.Empty)
{
    Console.WriteLine("No hay ningún control conectado");
    Environment.Exit(1);
}

var Joystick = new Joystick(directinput, JoystickGuid);
Console.WriteLine("El control es {0}", JoystickGuid);
Joystick.Properties.BufferSize = 128;
Joystick.Acquire();

while (true)
{
    Joystick.Poll();
    var data = Joystick.GetBufferedData();

    foreach (var state in data)
    {
        //if(state.Offset.ToString().Contains("Boton"))

        Console.WriteLine(state);
    }
}







