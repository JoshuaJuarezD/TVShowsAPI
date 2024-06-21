namespace TVShowsAPI.Aplication.DTOs
{
    //* Dtos para los datos que se muestran*/
    public class TvShowDto
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public bool Favorite { get; set; }
    }
}
