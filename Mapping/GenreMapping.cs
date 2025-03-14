using System;
using GameListApi.Dtos;
using GameListApi.Entities;

namespace GameListApi.Mapping;

public static class GenreMapping
{
  public static GenreDto ToDto(this Genre genre)
  {
    return new GenreDto(genre.Id, genre.Name);
  }
}
