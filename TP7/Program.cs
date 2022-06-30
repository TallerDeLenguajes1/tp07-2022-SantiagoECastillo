
// See https://aka.ms/new-console-template for more information
List<tarea> listaTareasPediente = new List<tarea>();
List<tarea> listaTareasRealizada = new List<tarea>();

List<int> indices = new List<int>();
int ID = 1;
Random rnd = new Random();
//int numeroTareas = rnd.Next(1, 4);//Crea aleatoriamente el numero de tareas
int numeroTareas = 3;

do{
    Console.WriteLine("Ingrese la descripcion de la tarea");
    string descripcionTarea = Console.ReadLine();
    int duracion = rnd.Next(10, 101);
    tarea nuevaTarea = new tarea(ID, descripcionTarea, duracion);

    listaTareasPediente.Add(nuevaTarea);
    
    ID++;
    numeroTareas--;

}while(numeroTareas != 0);


foreach(tarea tareaX in listaTareasPediente){
    Console.WriteLine("ID:" + tareaX.TareaId + " - " + tareaX.Descripcion+ " - Duracion:" + tareaX.Duracion);
    Console.WriteLine("Se realizo la tarea? (s/n)");
    string confirmacion = Console.ReadLine();
    if(confirmacion == "s"){
        listaTareasRealizada.Add(tareaX);
    }
}


listaTareasPediente.RemoveAll(listaTareasRealizada.Contains); //elimina en pendientes todas sus coincidencias con realizadas

mostrarPendientes();
mostrarRealizadas();
Console.WriteLine("FIN");


void mostrarPendientes(){
    Console.WriteLine("------PENDIENTES------");
    foreach(tarea tareax in listaTareasPediente){
        Console.WriteLine("ID:" + tareax.TareaId + " - " + tareax.Descripcion + " - Duracion:" + tareax.Duracion);
    }
}

void mostrarRealizadas(){
    Console.WriteLine("------REALIZADAS------");
    foreach(tarea tareax in listaTareasRealizada){
        Console.WriteLine("ID:" + tareax.TareaId + " - " + tareax.Descripcion + " - Duracion:" + tareax.Duracion);
    }
}



/*
string descripcion;


var numeroTareas = 3;
var numeroTareas2 = numeroTareas;

while (numeroTareas2 > 0)
{
    Console.WriteLine("Ingrese la descripcion de la tarea " + ID + ": ");
    descripcion = Console.ReadLine();
    duracion = new Random().Next(10, 100);
    tarea nuevaTarea = new tarea(ID, descripcion, duracion);
    listaTareasPediente.Add(nuevaTarea);
    ID++;
    numeroTareas2--;
}

ID = 0;
numeroTareas2 = numeroTareas;
while(numeroTareas2 != 0){
    Console.WriteLine("---------");
    Console.WriteLine("ID: " + listaTareasPediente[ID].TareaId);
    Console.WriteLine("Descripcion: " + listaTareasPediente[ID].descripcion);
    Console.WriteLine("Duracion: " + listaTareasPediente[ID].duracion);
    Console.WriteLine("Se realizo la tarea? s/n");
    string respuesta = Console.ReadLine();
    if(respuesta == "s"){
        listaTareasRealizada.Add(listaTareasPediente[ID]);
        listaTareasPediente.RemoveAt(ID);
    }
    numeroTareas2--;
    ID++;
}

numeroTareas2 = numeroTareas;
for(int i=0; i<numeroTareas2; i++){
    Console.WriteLine("---------Tareas Realizdas-------------");
    Console.WriteLine("ID: " + listaTareasRealizada[i].TareaId);
    Console.WriteLine("Descripcion: " + listaTareasRealizada[i].descripcion);
    Console.WriteLine("Duracion: " + listaTareasRealizada[i].duracion);
}

numeroTareas2 = numeroTareas;
for(int i=0; i<numeroTareas2; i++){
    Console.WriteLine("---------Tareas Pendientes-------------");
    Console.WriteLine("ID: " + listaTareasRealizada[i].TareaId);
    Console.WriteLine("Descripcion: " + listaTareasRealizada[i].descripcion);
    Console.WriteLine("Duracion: " + listaTareasRealizada[i].duracion);
}*/