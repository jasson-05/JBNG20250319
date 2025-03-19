using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace JBNG20250319.AppWebMVC.Models;

public partial class Brand
{
    public int BrandId { get; set; }

    [Display(Name = "Nombre")]
    public string BrandName { get; set; } = null!;

    [Display(Name = "Pais")]
    public string? Country { get; set; }

    public virtual ICollection<Product> Products { get; set; } = new List<Product>();
}
