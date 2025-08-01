using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Class
{
    public class Message
    {
        //public ObjectId Id { get; set; }
        public string? FromUserId { get; set; }
        public string? ToUserId { get; set; }
        public string? Content { get; set; }
        public DateTime? SentAt { get; set; }
        public bool IsRead { get; set; } = false;
    }
}
