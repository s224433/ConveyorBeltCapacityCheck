Console.WriteLine("How many motors are carrying the packages?");
var motors = int.Parse(Console.ReadLine());

Console.WriteLine("How many kg of packages do we expect?");
var weight =double.Parse(Console.ReadLine());

var avgLoadPerMotor = weight / motors;

if (avgLoadPerMotor <= 5.6)
{
    Console.WriteLine("Yes! The conveyor belt can carry the packages.");
}
else
{
    Console.WriteLine("No! The conveyor belt can carry the packages."); 
}
//
