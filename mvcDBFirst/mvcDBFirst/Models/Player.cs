using System;
using System.Collections.Generic;

namespace mvcDBFirst.Models;

public partial class Player
{
    public int PlayerId { get; set; }

    public string? PlayerName { get; set; }

    public int? TeamId { get; set; }

    public virtual Team? Team { get; set; }
}
