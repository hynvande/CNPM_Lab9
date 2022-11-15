using StudentServiceLib;
using System.ComponentModel;

namespace TestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Student s;
        [TestMethod]
        public void testCase1()
        {
            Student student = new Student();
            student.Score = 8;
            char letter = student.getLetterScore();
            Assert.AreEqual('A', letter);
        }

        [TestMethod]
        public void testCase2()
        {
            Student student = new Student();
            student.Score = 7.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('B', letter);
        }

        [TestMethod]
        public void testCase3()
        {
            Student student = new Student();
            student.Score = 6.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('C', letter);
        }

        [TestMethod]
        public void testCase4()
        {
            Student student = new Student();
            student.Score = 3.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void testCase5()
        {
            Student student = new Student();
            student.Score = 2.5;
            char letter = student.getLetterScore();
            Assert.AreEqual('E', letter);
        }

        [TestInitialize]
        public void init()
        {
            s = new Student();
        }

        [TestMethod]
        [DataRow(8.0, 'A')]
        [DataRow(7.5, 'B')]
        [DataRow(6.5, 'C')]
        [DataRow(3.5, 'D')]
        [DataRow(2.5, 'E')]
        public void TestMultipScore(double score, char excep)
        {
            s.Score = score;
            char letter = s.getLetterScore();
            Assert.AreEqual(excep, letter);
        }
        [TestMethod]
        public void testExceptionMessage(Student new_student)
        {
            String expectedMess_1 = "Mã số sinh viên đã có trong danh sách";
            StudentService ss=new StudentService();
            try
            {
                ss.addStudent(new_student);
            }
            catch (Exception error)
            {

            }
        }
        
        
        
    }
}