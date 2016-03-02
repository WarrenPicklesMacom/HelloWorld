using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HelloWorld;
using System.Windows.Forms;

namespace HelloWorldTestProject {
    [TestClass]
    public class UnitTest1 {
        [TestMethod]
        public void HelloWorldTestMethod( ) {
            HelloWorldForm helloWorldForm = new HelloWorldForm( );
            Assert.AreEqual( "Hello World!", helloWorldForm.label1.Text );
        }
    }
}
