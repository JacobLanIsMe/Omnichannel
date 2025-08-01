using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Core.Class
{
    public class UserConnection
    {
        //public ObjectId Id { get; set; }
        public string? UserId { get; set; }
        public string? ConnectionId { get; set; }
        public DateTime? ConnectedAt { get; set; }
        public DateTime? DisconnectedAt { get; set; }
    }
}
