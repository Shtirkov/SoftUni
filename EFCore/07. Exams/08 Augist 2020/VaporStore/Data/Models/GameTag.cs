namespace VaporStore.Data.Models
{
    public class GameTag
    {
        //•	GameId – integer, Primary Key, foreign key(required)
        //•	Game – Game
        //•	TagId – integer, Primary Key, foreign key(required)
        //•	Tag – Tag

        public int GameId { get; set; }

        public Game Game { get; set; }

        public int TagId { get; set; }

        public Tag Tag { get; set; }
    }
}