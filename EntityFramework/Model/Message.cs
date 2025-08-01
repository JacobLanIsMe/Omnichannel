using System;
using System.Collections.Generic;

namespace EntityFramework.Model;

public partial class Message
{
    public int SqlId { get; set; }

    public Guid Id { get; set; }

    public Guid FromUserId { get; set; }

    public Guid ToUserId { get; set; }

    public string Content { get; set; } = null!;

    public DateTime SentAt { get; set; }

    public bool IsRead { get; set; }
}
