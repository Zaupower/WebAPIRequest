using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace WebAPIClient
{
    class Repository
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
