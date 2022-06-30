public class tarea{
    private int tareaId;
    private string descripcion;
    private int duracion; //entre 10 - 100

    
    public tarea(int tareaId, string descripcion, int duracion){
        this.TareaId = tareaId;
        this.Descripcion = descripcion;
        this.Duracion = duracion;
    }

    public int TareaId { get => tareaId; set => tareaId = value; }
    public string Descripcion { get => descripcion; set => descripcion = value; }
    public int Duracion { get => duracion; set => duracion = value; }
}