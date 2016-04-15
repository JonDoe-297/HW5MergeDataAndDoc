using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sy2
{
    [TestFixture]
    public class test
    {
        [Test]
        public void Test()
        {
            StringReader input = new StringReader("Tom	c1234234	2年");
            StringReader input1 = new StringReader("${中文姓名}先生(身份证字号${身份证字号})为本校专任教师，聘期${年数}。");
            StringWriter output = new StringWriter();
            MergeDataAndDoc.Program.StringMethod(input, input1, output);
            Assert.That(output.ToString(), Is.EqualTo("Tom先生(身份证字号c1234234)为本校专任教师，聘期2年。\r\n\r\n\r\n"));

        }
    }
}
