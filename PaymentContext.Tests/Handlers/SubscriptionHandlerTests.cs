using System;
using PaymentContext.Tests.Mocks;
using PaymentContext.Domain.Enums;
using PaymentContext.Domain.Handlers;
using PaymentContext.Domain.Commands;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PaymentContext.Tests.Handlers
{
    [TestClass]
    public class SubcriptionHandlerTests
    {
        [TestMethod]
        public void ShouldReturnErrorWhenDocumentExists()
        {
            var handler = new SubscriptionHandler(new FakeStudentRepository(), new FakeEmailService());
            var command = new CreateBoletoSubscriptionCommand();

            command.FirstName = "Bruce";
            command.LastName = "Wayne";
            command.Document = "99999999999";
            command.Email = "hello@balta.io2";
            command.BarCode = "123456789";
            command.BoletoNumber = "123245455";
            command.PaymentNumber = "123243432";
            command.PaidDate = DateTime.Now;
            command.ExpireDate = DateTime.Now.AddMonths(1);
            command.Total = 60;
            command.TotalPaid = 60;
            command.Payer = "WAYNE ENTERPRISE";
            command.PayerDocument = "12345678911";
            command.PayerDocumentType = EDocumentType.CPF;
            command.PayerEmail = "batman@dc.com";
            command.Street = "dasdsadsa";
            command.Number = "123";
            command.Neighborhood = "dadsdassd";
            command.City = "Gotham";
            command.State = "dadsa";
            command.Country = "dsda";
            command.ZipCode = "111111111";

            handler.Handle(command);
            Assert.AreEqual(false, handler.Valid);
        }
    }
}
