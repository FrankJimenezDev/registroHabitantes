namespace RegistroHabitantes
{
    public class Habitante
    {
        public string nombreCompleto { get; set; }
        public int DNI { get; set; }
        public EstadoCivil estadoCivil { get; set; }
        public DateTime fechaNacimiento { get; set; }
        public string email { get; set; }

        public override string ToString()
        {
            return $"{nombreCompleto};{DNI};{estadoCivil},{fechaNacimiento};{email}";
        }

        public static Habitante GetHabitanteFromData(string habitante)
        {
            var datosHabitante = habitante.Split(',');
            return new Habitante()
            {
                nombreCompleto = datosHabitante[0],
                DNI = int.Parse(datosHabitante[1]),
                estadoCivil = Enum.Parse<EstadoCivil>(datosHabitante[2]),
                fechaNacimiento = DateTime.Parse(datosHabitante[3]),
                email = datosHabitante[4],
            };
        }
    }
}
