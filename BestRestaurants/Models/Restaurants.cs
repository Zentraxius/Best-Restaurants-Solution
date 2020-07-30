using System.Collections.Generic;

namespace BestRestaurant.Models
{
  public class Restaurant 
  {
    public Restaurant()
    {
      this.Cuisines = new HashSet<Cuisine>();
    }
    public int pricerange {get; set;}
    public int restaurantId { get; set;}
    public char name { get; set;}
    public char description {get; set;}
    public virtual ICollection<Cuisine> Cuisines {get;set;}
  }
}