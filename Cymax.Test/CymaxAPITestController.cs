using Microsoft.VisualStudio.TestTools.UnitTesting;
using CymaxAssessment.Controllers;
using Cymax.Model;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;

namespace Cymax.Test
{
    [TestClass]
    public class CymaxAPITestController
    {
        [TestMethod]
        public void GetTotal_LessThan_AmountAndQuote()
        {
            var testShipmentInput = new ShipmentInputDto() { ContactAddress = "1 Fieldstone Street Madisonville,KY 42431", WareHouseAddress = "9946 West Taylor Street Levittown, NY 11756", PackageDimensions = new PackageDimension() { Height = 1.25, Length = 2.25, Width = 3.52 } };
            var controller = new ProcessController();

            var testShipmentOutput = new ShipmentOutputDto().Total;

            var result = controller.GetTotal(testShipmentInput);
            Assert.IsNotNull(result);
            Assert.AreEqual(testShipmentOutput, result);
        }

        [TestMethod]
        public void GetAmount_LessThan_TotalAndQuote()
        {
            var testShipmentInput = new ShipmentInputAPI2() { Consignor = "43 N. Cross Ave.Hickory,NC 28601", Consignee = "388 Summerhouse Dr.Riverview, FL 33569", Cartons = new PackageDimension() { Height = 1.25, Length = 2.25, Width = 3.52 } };
            var controller = new ProcessController();

            var testShipmentOutput = new ShipmentOutputDto().Amount;

            var result = controller.GetAmount(testShipmentInput);
            Assert.IsNotNull(result);
            Assert.AreEqual(testShipmentOutput, result);
        }

        [TestMethod]
        public void GetQuote_LessThan_AmountAndTotal()
        {
            var testShipmentInput = new ShipmentInputAPI3() { Source = "611 Durham St.Middleton, WI 53562", Destination = "96 Edgefield Court Copperas Cove,TX 76522", Packages = new PackageDimension() { Height = 1.25, Length = 2.25, Width = 3.52 } };
            var controller = new ProcessController();

            var testShipmentOutput = new ShipmentOutputDto().Quote;

            var result = controller.GetQuote(testShipmentInput);
            Assert.IsNotNull(result);
            Assert.AreEqual(testShipmentOutput, result);
        }



    }
}
