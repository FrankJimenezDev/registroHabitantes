namespace RegistroHabitantes
{
    public class Habitante
    {
        public string nombreCompleto;
        public int DNI;
        public EstadoCivil estadoCivil;
        public DateTime fechaNacimiento;
        public string email;
        public string Barrio;

        public static Habitante getHabitanteFromData(string habitante)
        {
            var datosHabitante = habitante.Split(',');
            return new Habitante()
            {
                nombreCompleto = datosHabitante[0],
                DNI = int.Parse(datosHabitante[1]),
                estadoCivil = Enum.Parse<EstadoCivil>(datosHabitante[2]),
                fechaNacimiento = DateTime.Parse(datosHabitante[3]),
                email = datosHabitante[4],
                Barrio = datosHabitante[5]
            };
        }
    }
}
