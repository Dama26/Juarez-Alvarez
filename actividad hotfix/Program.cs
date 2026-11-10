using actividad_hotfix;
using actividad_hotfix.personaje;

Personaje personaje = new Personaje()
{
    Nombre = "Oxidiana",
    Vida = 80,
    Ataque = 50,
    Defensa = 35,
    Nivel = 3
};

Console.WriteLine("--- Datos del Personaje ---");
Console.WriteLine($"Nombre: {personaje.Nombre}");
Console.WriteLine($"Vida: {personaje.Vida}");
Console.WriteLine($"Ataque: {personaje.Ataque}");
Console.WriteLine($"Defensa: {personaje.Defensa}");
Console.WriteLine($"Nivel: {personaje.Nivel}");