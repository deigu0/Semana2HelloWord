// See https://aka.ms/new-console-template for more information
using Semana2HelloWord;

Console.WriteLine("Hello, World!");

string curso = "Desarrollo de Ambiente Web";
int edad = 30;
double salario = 20000;


var alumno = "Diego Roldan";
var notaFinal = 19.50;

var persona = new Persona();
persona.Dni = 20249349;
persona.Telefono = "434-5466"
persona.NombreCompleto = "Pepito Perez";
persona.Estado = true;

var persona2 = new Persona();
{
    Dni = 22356456,
    Telefono = "534-4567",
    NombreCompleto = "Juan Juarez",
    Estado = true
};

var persona3 = new Persona(2783722,"Alex Quis","123-7785",false);

var personas = new List<Persona>();
personas.Add(persona);
personas.Add(persona2);
personas.Add(persona3);

//Personas activas
var busqueda = personas.Where(x=> x.Estado == true).ToList();

//Busqueda por DNI
var busquedaDNI = personas.Where(z=>z.Dni == 22356456).FirstOrDefault();

var busquedaLINQ = (from p in personas
                    where p.Dni == 22356456
                    select p).FirstOrDefault();