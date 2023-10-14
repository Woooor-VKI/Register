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
        public void Test1() // ����� - ����� �������� � ���������� ����, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("+7-983-392-1798", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test2() // ����� - ����� � ���������� ����, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("kOma_bb", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test3() // ����� - ����� ��������, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("kOma_bb", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test4() // ����� - ����� �������� � ������������ �������, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("+72323929098", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test5() // ����� - ����� ��������, � ������� ������ ����, ��� ������ ����, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("+72323929098", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test6() // ����� - ����� �����, � ������� ��� ������� @, ��� ������ ����, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("komabb@@mail.ru", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test7() // ����� - ����� ������������� �������, ��� ������ ����, ���������� ������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez14@", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test8() // ����� ������ ��� ������ ����
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwe", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }
        
        [Test]
        public void Test9() // ����������� ������� �����
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("sHR*IYUDGVBNIYURDBNGiuyrdezuiyhgbnyhuidenbguidnhbuiodtfruhbngidofutnhgbouitfdoguibhftrioughnbft", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test10() // ����� � ����������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("������", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test11() // ����� � ���������� �������
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("QWEz23", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test12() // ���������� � �������� �� ������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("user11", "QWERTYz23", "QWERTYz23");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test13() // ������ � ���������� ��������, � �������������� ���������, ���� � ������������
        {
            var sut = new LoginPassword();
            var expected = "True";
            var actual = sut.CheckRegister("qwez23_12", "QWERTYz23@", "QWERTYz23@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test14() // ������ � ���������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "aQWERTYz23@", "aQWERTYz23@");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test15() // ������, ������� ������ 7 ��������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "a", "a");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test16() // ���������������� ������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12",
            "ezsdghsrjdtkfyugkyjthregwdfhrtjykgulgkytfjrhdsegfsrlhkjhrsegafwdfagsrhtjdykluyktrestawrEADFEGHRDTJYKULGYKTJRHESAWarftegrhjtkygjreweGHRJTKYGUYTJRHEWAARFTEYSRUDJTKYGRYTWEAR" +
            "ezsdghsrjdtkfyugkyjthregwdfhrtjykgulgkytfjrhdsegfsrlhkjhrsegafwdfagsrhtjdykluyktrestawrEADFEGHRDTJYKULGYKTJRHESAWarftegrhjtkygjreweGHRJTKYGUYTJRHEWAARFTEYSRUDJTKYGRYTWEAR", "�");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test17() // ������ ��� ���� �������� ��������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test18() // ������ ��� ���� �������� ��������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test19() // ������ ��� ����
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test20() // ������ ��� ������������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test21() // ������ �� ���������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }

        [Test]
        public void Test22() // ������ �� ��������� �� ��������
        {
            var sut = new LoginPassword();
            var expected = "False";
            var actual = sut.CheckRegister("qwez23_12", "gggggggggggggg1", "gggggggggggggg1");
            Assert.That(actual.Item1, Is.EqualTo(expected));
        }
    }
}