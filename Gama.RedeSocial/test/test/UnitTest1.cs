using Gama.RedeSocial.Domain.Interfaces.Services;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Repository.Repositories;

namespace test
{
    [TestClass]
    public class GenderTest
    {
        private readonly IGenderService _service;

        public GenderTest()
        {
            var repository = new GenderRepository();
            var _service = new IGenderService(repository);

        }
        [TestMethod]
        public void GenderValidation()
        {

        }
    }
}
