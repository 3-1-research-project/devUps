﻿using System.ComponentModel.DataAnnotations;

namespace minitwit_backend.Data.Model;

public partial class Follower
{
    [Key]
    public int? WhoId { get; set; }

    public int? WhomId { get; set; }
}
