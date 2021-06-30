using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AdevintaApiGateway.Dtos
{
    public class Post
    {
        public int UserId { get; set; }
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
    }
}
