using System.ComponentModel.DataAnnotations;

namespace GameListApi.Dtos;

public record class CreateGameDto(
  [Required] [StringLength(50)] string Name,
  int GenreId,
  [Required] [Range(1, 10000000)] decimal Price,
  [Required] DateOnly ReleaseDate
);
