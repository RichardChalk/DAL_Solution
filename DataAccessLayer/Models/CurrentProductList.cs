using System;
using System.Collections.Generic;

namespace DataAccessLayer.Models;

public partial class CurrentProductList
{
    public int ProductId { get; set; }

    public string ProductName { get; set; } = null!;
}
