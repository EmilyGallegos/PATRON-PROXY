internal class Program
{
    static void Main(){
        SeleccionCasas seleccionCasas = new SeleccionCasas ();

        Estudiante estudiante1 = new EstudianteGryffindor {Nombre = "Hermione Granger", Edad = 12 , Materia favorita = Encantamientos};
        Estudiante estudiante2 = new EstudianteHufflepuff {Nombre = "Cedric Diggory", Edad = 14 , Materia favorita = Posiones};
        Estudiante estudiante3 = new EstudianteRavenclaw {Nombre = "Luna Lovegood", Edad = 11 , Materia favorita = Herbología};
        Estudiante estudiante4 = new EstudianteSlytherin {Nombre = "Draco Malfoy", Edad = 13 , Materia favorita = Artes oscuras };

        seleccionCasas.AsignarrCasa(estudiante1);
        seleccionCasas.AsignarrCasa(estudiante2);
        seleccionCasas.AsignarrCasa(estudiante3);
        seleccionCasas.AsignarrCasa(estudiante4);

        seleccionCasas.MostrarEstudianteAsignado();

    }
}