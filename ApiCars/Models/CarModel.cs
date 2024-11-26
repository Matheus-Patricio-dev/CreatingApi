namespace ApiCars.Models
{
    public class CarModel
    {
        //entidade carro
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int fabricationYear { get; set; }
        public int fabricanteId { get; set; }
        public virtual fabricanteModel fabricante { get; set; }


    }
}
