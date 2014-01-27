using NUnit.Framework;
using System.Diagnostics;
namespace RegEx.Test
{
   
    public class RegularExpressionsTest
    {
        private const string NumberPattern = "^d/$";
        private static readonly string EmailPattern=@"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,9})$";
        private static readonly string ZipCodePatten = "";

        [Test]
        public void IsNumeric()
        {
            var input = "123455";
            var result = RegularExpressions.Match(input, NumberPattern);
            Assert.IsTrue(result);
        }
        [Test]
        public void IsNotNumeric ()
        {
            var input = "01234565##";
            var result = RegularExpressions.Match(input, NumberPattern);
            Assert.IsFalse(result);
        }

        [Test]
        public void IsEmail()
        {
            var input = "michael.hidalgo@owasp.org";
            var result = RegularExpressions.Match(input, EmailPattern);
            Assert.IsTrue(result);
        }


        [Test]
        public void NotValidEmail()
        {
            var watcher = new Stopwatch();
            var input = "michaelhidalgoowaspsmichaelhidalgoowasps.org";
            watcher.Start();
            var result = RegularExpressions.Match(input, EmailPattern);
            watcher.Stop();
            Debug.WriteLine(string.Format("Tiempo transcurrido {0} segundos", watcher.ElapsedMilliseconds/1000.0m));
            Assert.IsFalse(result);
        }
    }
}
