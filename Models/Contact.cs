using System;
using System.Collections.Generic;

namespace OracleCommentFail.Models;

public partial class Contact
{
    public Guid Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}
