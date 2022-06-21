using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Cymax.Model
{
    public class ShipmentInputAPI3
    {
        [JsonPropertyName("source")]
        [Required]
        public string Source { get; set; }

        [JsonPropertyName("destination")]
        [Required]
        public string Destination { get; set; }

        [Required]
        public PackageDimension Packages { get; set; }
    }
}
