using PaymentContext.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaymentContext.Tests.Commands
{
    [TestClass]
    public class CreateBoletoSubscriptionCommandTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenNameIsInvalid()
        {
            var command = new CreateBoletoSubscriptionCommand();
            command.FirstName = string.Empty;

            command.Validate();
            Assert.AreEqual(false, command.Valid);
        }
    }
}
