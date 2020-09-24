using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using OrderAppCommon.Interface;
using OrderAppCommon.Model;
using OrderProcessingApp.Controllers;

namespace OrderAppTest
{
    [TestClass]
    public class PaymentControllerTest
    {
        private Mock<IPaymentService> mockPaymentsService;

        private PaymentController paymentController;


        [TestInitialize]
        public void TestInitialize()
        {
            mockPaymentsService = new Mock<IPaymentService>(MockBehavior.Strict);
            paymentController =
                new PaymentController(mockPaymentsService.Object);
        }

        [TestMethod]
        public async Task ProcessPaymentForBooks_works()
        {
            var selectedItem = "book";
            var expectedResults = "Duplicate Sleep Created for the royalty department";
            //Arrange
            mockPaymentsService.Setup(r => r.PaymentProcess(selectedItem))
                .ReturnsAsync(expectedResults);

            var paymentType = new PaymentType
            {
                SelectedItem = "book"
            };

            //Act
            var result = await paymentController.ProcessPayment(paymentType);

            //Assert
            var okObjectResult = result as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreSame(expectedResults, okObjectResult.Value);
            mockPaymentsService.VerifyAll();
        }

        [TestMethod]
        public async Task ProcessPaymentForPhysicalProduct_works()
        {
            var selectedItem = "physical product";
            var expectedResults = "Packing slip for shipping is generated. Commission Payment of the agent";
            //Arrange
            mockPaymentsService.Setup(r => r.PaymentProcess(selectedItem))
                .ReturnsAsync(expectedResults);

            var paymentType = new PaymentType
            {
                SelectedItem = "physical product"
            };

            //Act
            var result = await paymentController.ProcessPayment(paymentType);

            //Assert
            var okObjectResult = result as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResults, okObjectResult.Value);
            mockPaymentsService.VerifyAll();
        }


        [TestMethod]
        public async Task ProcessPaymentForMembership_works()
        {
            var selectedItem = "membership";
            var expectedResults = "Membership Activated. Email has been sent to owner about activation or upgrade.";
            //Arrange
            mockPaymentsService.Setup(r => r.PaymentProcess(selectedItem))
                .ReturnsAsync(expectedResults);

            var paymentType = new PaymentType
            {
                SelectedItem = "membership"
            };

            //Act
            var result = await paymentController.ProcessPayment(paymentType);

            //Assert
            var okObjectResult = result as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResults, okObjectResult.Value);
            mockPaymentsService.VerifyAll();
        }

        [TestMethod]
        public async Task ProcessPaymentForVideoResult_works()
        {
            var selectedItem = "videos";
            var expectedResults = "Learning to SKI, add free First AID videos to the packing slip.";
            //Arrange
            mockPaymentsService.Setup(r => r.PaymentProcess(selectedItem))
                .ReturnsAsync(expectedResults);

            var paymentType = new PaymentType
            {
                SelectedItem = "videos"
            };

            //Act
            var result = await paymentController.ProcessPayment(paymentType);

            //Assert
            var okObjectResult = result as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResults, okObjectResult.Value);
            mockPaymentsService.VerifyAll();
        }

        [TestMethod]
        public async Task ProcessPaymentForUpgradeMembership_works()
        {
            var selectedItem = "upgrade membership";
            var expectedResults =
                "Membership apply for update. Email has been sent to owner about activation or upgrade.";
            //Arrange
            mockPaymentsService.Setup(r => r.PaymentProcess(selectedItem))
                .ReturnsAsync(expectedResults);

            var paymentType = new PaymentType
            {
                SelectedItem = "upgrade membership"
            };

            //Act
            var result = await paymentController.ProcessPayment(paymentType);

            //Assert
            var okObjectResult = result as OkObjectResult;
            Assert.IsNotNull(result);
            Assert.AreEqual(expectedResults, okObjectResult.Value);
            mockPaymentsService.VerifyAll();
        }
    }
}