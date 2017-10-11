using ampel.svc;
using Nancy;
using Nancy.Json.Simple;
using Nancy.Testing;
using NUnit.Framework;
using servicehost;

namespace ampel.service.tests
{
    [TestFixture]
    public class IntegrationTests
    {
        [SetUp]
        public void Setup() {
            var restService = new RESTService(); // reference a type from the assembly so that Nancy will find it 
        }

        [Test]
        public void Add_subscription() {
            var module = ServiceModuleFactory.Build();
            var browser = new Browser(with => { with.Module(module); });

            var subscription = new Subscription {
                Name = "n1",
                Firstname = "f1",
                Email = "e1",
                Tag = "t1"
            };
            var json = SimpleJson.SerializeObject(subscription);
            var result = browser.Post("/subscriptions", with => { with.Body(json); });

            Assert.That(result.Result.StatusCode, Is.EqualTo(HttpStatusCode.OK));
        }
    }
}