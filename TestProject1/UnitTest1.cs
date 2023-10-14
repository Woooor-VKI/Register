using  Register;
using NUnit.Framework;


namespace TestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1() // логин - номер телефона в нормальном виде, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("+7-983-392-1798", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test2() // логин - почта в нормальном виде, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("kOma_bb", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test3() // логин - набор символов, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("kOma_bb", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test4() // логин - номер телефона в неправильном формате, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("+72323929098", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test5() // логин - номер телефона, в котором больше цифр, чем должно быть, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("+72323929098", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test6() // логин - номер почта, в которой два символа @, чем должно быть, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("komabb@@mail.ru", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test7() // логин - почта неправильного формата, чем должно быть, корректные пароли
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez14@", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test8() // логин короче чем должен быть
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwe", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }
        
        [Test]
        public void Test9() // максимально длинный логин
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("sHR*IYUDGVBNIYURDBNGiuyrdezuiyhgbnyhuidenbguidnhbuiodtfruhbngidofutnhgbouitfdoguibhftrioughnbft", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test10() // логин с кириллицей
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("привет", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test11() // логин в корректном формате
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("QWEz23", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test12() // совпадение с логинами из списка
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("user11", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test13() // пароль с корректным форматом, с использованием кириллицы, цифр и спецсимволов
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("qwez23_12", "QWERTYz23@", "QWERTYz23@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test14() // пароль с латиницей
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "aQWERTYz23@", "aQWERTYz23@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test15() // пароль, который короче 7 символов
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "a", "a");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test16() // длиииииииииинный пароль
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12",
            "ezsdghsrjdtkfyugkyjthregwdfhrtjykgulgkytfjrhdsegfsrlhkjhrsegafwdfagsrhtjdykluyktrestawrEADFEGHRDTJYKULGYKTJRHESAWarftegrhjtkygjreweGHRJTKYGUYTJRHEWAARFTEYSRUDJTKYGRYTWEAR" +
            "ezsdghsrjdtkfyugkyjthregwdfhrtjykgulgkytfjrhdsegfsrlhkjhrsegafwdfagsrhtjdykluyktrestawrEADFEGHRDTJYKULGYKTJRHESAWarftegrhjtkygjreweGHRJTKYGUYTJRHEWAARFTEYSRUDJTKYGRYTWEAR", "А");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test17() // пароль без букв верхнего регистра
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test18() // пароль без букв нижнегоо регистра
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test19() // пароль без цифр
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test20() // пароль без спецсимволов
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test21() // пароль не совпадают
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test22() // пароли не совпадают по регистру
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }
    }
}