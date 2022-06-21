using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Cymax.Model
{
    public class ShipmentInputAPI2
    {
        [JsonPropertyName("consignee")]
        [Required]
        public string Consignee { get; set; }

        [JsonPropertyName("consignor")]
        [Required]
        public string Consignor { get; set; }

        [Required]
        public PackageDimension Cartons { get; set; }
    }
}

