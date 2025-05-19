using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace Skinet.Core.Entities;

public class Product:BaseEntity
{
    public required string Name { get; set; }
    public required string Description { get; set; }
    
    [Precision(18,2)]
    public required decimal Price { get; set; }
    public required string PictureUrl { get; set; }
    public required string Type { get; set; }
    public required string Brand { get; set; }
    public required int QuantityInStock { get; set; }

}