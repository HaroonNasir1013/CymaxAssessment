using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Text.Json.Serialization;

namespace Cymax.Model
{
    public class ShipmentInputDto
    {
        [JsonPropertyName("contact_address")]
        [Required]
        public string ContactAddress { get; set; }

        [JsonPropertyName("wareHouse_address")]
        [Required]
        public string WareHouseAddress { get; set; }

        [Required]
        public PackageDimension PackageDimensions { get; set; }
    }
}
