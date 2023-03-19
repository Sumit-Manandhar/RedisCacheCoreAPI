using System;
using System.Collections.Generic;

namespace DataAccess.NewFolder2;

public partial class DataMember
{
    public int MemberId { get; set; }

    public string? Name { get; set; }

    public string? Address { get; set; }

    public int? CountryId { get; set; }

    public string? Phone { get; set; }
}
