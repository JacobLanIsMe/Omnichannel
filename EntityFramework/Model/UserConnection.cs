using System;
using System.Collections.Generic;

namespace EntityFramework.Model;

public partial class UserConnection
{
    public int SqlId { get; set; }

    public Guid Id { get; set; }

    public Guid UserId { get; set; }

    public string ConnectionId { get; set; } = null!;

    public DateTime ConnectedAt { get; set; }

    public DateTime? DisconnectedAt { get; set; }
}
