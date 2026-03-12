using System;
using System.Collections.Generic;

namespace mvcDBFirst.Models;

public partial class Team
{
    public int TeamId { get; set; }

    public string? TeamName { get; set; }

    public virtual ICollection<Player> Players { get; set; } = new List<Player>();
}
