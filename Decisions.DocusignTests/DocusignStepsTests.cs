using Microsoft.VisualStudio.TestTools.UnitTesting;
using Decisions.Docusign;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decisions.Docusign.Tests
{
    [TestClass()]
    public class DocusignStepsTests
    {
        [TestMethod()]
        public void DeserialiseDocuSignEnvelopeInformationTest()
        {
            var xml = System.IO.File.ReadAllText("XMLFile1.xml");
            var SUT = Decisions.Docusign.DocusignSteps.DeserialiseDocusignEnvelopeInformation(xml);

            Assert.Fail();
        }
    }
}