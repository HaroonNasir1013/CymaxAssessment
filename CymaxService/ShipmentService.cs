using Cymax.Model;
using System;

namespace CymaxService
{
    public class ShipmentService
    {
        public ShipmentOutputDto GetTotal(
           ShipmentInputDto inputDetails, string FromAddress = null, string ToAddress = null)
        {
            if(inputDetails.ContactAddress.Equals(FromAddress) && inputDetails.WareHouseAddress.Equals(ToAddress))
                return new ShipmentOutputDto() { Total = 255 };
            else
                return new ShipmentOutputDto() { Total = 1000 };
        }
        public ShipmentOutputDto GetAmount(
           ShipmentInputAPI2 inputDetails, string FromAddress = null, string ToAddress = null)
        {
            if (inputDetails.Consignor.Equals(FromAddress) && inputDetails.Consignee.Equals(ToAddress))
                return new ShipmentOutputDto() { Amount = 300 };
            else
                return new ShipmentOutputDto() { Amount = 2500 };
        }
        public ShipmentOutputDto GetQuote(
           ShipmentInputAPI3 inputDetails, string FromAddress = null, string ToAddress = null)
        {
            if (inputDetails.Source.Equals(FromAddress) && inputDetails.Destination.Equals(ToAddress))
                return new ShipmentOutputDto() { Quote = 750 };
            else
                return new ShipmentOutputDto() { Quote = 6000 };
        }
    }
}
