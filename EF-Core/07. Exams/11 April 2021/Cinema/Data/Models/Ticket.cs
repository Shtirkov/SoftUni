namespace Cinema.Data.Models
{
    public class Ticket
    {
        //•	Id – integer, Primary Key
        //•	Price – decimal (non-negative, minimum value: 0.01) (required)
        //•	CustomerId – integer, Foreign key(required)
        //•	Customer – the Ticket’s Customer 
        //•	ProjectionId – integer, Foreign key(required)
        //•	Projection – the Ticket’s Projection

        public int Id { get; set; }

        public decimal Price { get; set; }

        public int CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        public int ProjectionId { get; set; }

        public virtual Projection Projection { get; set; }
    }
}