namespace ApiCars.Models
{
    public class CarModel
    {
        //entidade carro
        public int Id { get; set; }
        public string Model { get; set; }
        public string Type { get; set; }
        public int FabricationYear { get; set; }
        public int FabricanteId { get; set; }
        public virtual FabricanteModel? fabricante { get; set; }


    }
}
