using System;
using FluentAssertions;
using NSubstitute;
using Xunit;

namespace InvoicesExmaple
{
    public class Class1
    {

        [Fact]
        public void When_I_add_invoice_it_returns_its_database_id()
        {
            // arrange
            var persistency = Substitute.For<IPersistency>();


            var controller = new InvoiceController(persistency);
            var invoice = new InvoiceModel
            {
                Head = "Jan Kowalski, nip, adres",
                Positions = new[]
                {
                    new Position("Komputer", 5500, 1, 0.23)
                }
            };

            var invoice2 = new InvoiceModel
            {
                Head = "Jan Kowalskfsdfsdi, nip, adres",
                Positions = new[]
                {
                    new Position("sdf", 5500, 1, 0.23),
                    new Position("sdf", 5500, 1, 0.23),
                    new Position("sdf", 5500, 1, 0.23),
                    new Position("sdf", 5500, 1, 0.23)
                }
            };

            persistency.Save(Arg.Is(invoice)).Returns(Guid.Parse("5CBE16A2-0494-4F1D-B127-02929D5E59CB"));

            //act
            var result = controller.Post(invoice);
            var result2 = controller.Post(invoice2);

            //assert
            result.Should().Be(Guid.Parse("5CBE16A2-0494-4F1D-B127-02929D5E59CB"));
            result2.Should().Be(Guid.Parse("5CBE16A2-0494-4F1D-B127-02929D5E59CB"));
        }
    }

    public interface IPersistency
    {
        Guid Save(InvoiceModel invoice);
    }

    public class InvoiceController
    {
        private IPersistency _persistency;

        public InvoiceController(IPersistency persistency)
        {
            _persistency = persistency;
        }

        public Guid Post(InvoiceModel invoice)
        {
            // todo obliczyć sumy (logika biznesowa)
            //
            // todo zapisać do bazy
            //
            // i zwrócić identyfikator z bazy
            //
            // czyli klasyczne kwadrat -> kwadrat -> beczka

            return _persistency.Save(invoice);
        }
    }

    public class InvoiceModel
    {
        public string Head { get; set; }
        public Position[] Positions { get; set; }
    }

    public class Position
    {
        public string Item { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public double Vat { get; set; }

        public Position(string item, double price, int count, double vat)
        {
            Item = item;
            Price = price;
            Count = count;
            Vat = vat;
        }
    }




}
