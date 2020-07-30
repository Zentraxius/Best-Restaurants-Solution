using System.Collections.Generic;
using MySql.Data.MySqlClient;


namespace BestRestaurant.Models
{
  public class Cuisine
  {
    public int cuisineId { get; set; }
    public var foodtype { get; set; }
    public int restaurantId { get; set; }
    public virtual Restaurant Restaurant { get; set; }
  }
}