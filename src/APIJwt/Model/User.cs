using LiteDB;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace APIJwt.Model
{
    public class User
    {
        [Required]
        [Key]
        [BsonId(true)]
        public string UserID { get; set; }
        [Required]
        public string AccessKey { get; set; }
    }

    public class TokenConfigurations
    {
        public string Audience { get; set; }
        public string Issuer { get; set; }
        public int Seconds { get; set; }
    }
}
