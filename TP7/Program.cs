
// See https://aka.ms/new-console-template for more information
List<tarea> listaTareasPediente = new List<tarea>();
List<tarea> listaTareasRealizada = new List<tarea>();


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

buscarPorDescripcion(listaTareasPediente);
horasTrabajadasTotales(listaTareasRealizada);
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

void buscarPorDescripcion(List<tarea> listaTareas){
    Console.WriteLine("\nIngrese la descripcion a buscar");
    string? descripcionBuscar = Console.ReadLine();
    foreach(tarea tareaX in listaTareas){
        if(tareaX.Descripcion.Contains(descripcionBuscar)){
            Console.WriteLine("\n se encontro la tarea");
            Console.WriteLine("ID:" + tareaX.TareaId + " - " + tareaX.Descripcion + " - Duracion:" + tareaX.Duracion);
        }
    }
}


void horasTrabajadasTotales(List<tarea> listaTareas){
    double total=0;
    foreach(tarea tareaX in listaTareas){
        total = total + tareaX.Duracion;
    }

    Console.WriteLine("Horas totales trabajadas: "+ total);
}