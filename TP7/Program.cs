
// See https://aka.ms/new-console-template for more information
List<tarea> listaTareasPediente = new List<tarea>();

int ID=1;
string descripcion;
int duracion;
var numeroTareas = new Random().Next(1, 3);//Crea aleatoriamente el numero de tareas
var numeroTareas2 = numeroTareas;

while (numeroTareas > 0)
{
    Console.WriteLine("Ingrese la descripcion de la tarea " + ID + ": ");
    descripcion = Console.ReadLine();
    duracion = new Random().Next(10, 100);
    tarea nuevaTarea = new tarea(ID, descripcion, duracion);
    listaTareasPediente.Add(nuevaTarea);
    //listaTareasPediente.Insert(ID, nuevaTarea);
    ID++;
    numeroTareas--;
}

ID = 0;
while(numeroTareas2 != 0){
    Console.WriteLine("---------");
    Console.WriteLine("ID: " + listaTareasPediente[ID].TareaId);
    Console.WriteLine("Descripcion: " + listaTareasPediente[ID].descripcion);
    Console.WriteLine("Duracion: " + listaTareasPediente[ID].duracion);
    numeroTareas2--;
    ID++;
}


