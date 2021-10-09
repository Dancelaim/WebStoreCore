
using System;
using System.Collections.Generic;

using WowCarryCore.Models;

public class OptionViewModel
{
    public ProductOption ParentOption { get; set; }
    public Guid ChildOptionId { get; set; }
}
