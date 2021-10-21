using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1;
using NUnit.Framework;
using System.Windows.Forms;

namespace TestProject1
{
    class GameTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test_Check_For_Tie()
        {
            HelperClass helper = new HelperClass();

            Assert.IsTrue(helper.CheckForTie(9, 9));
            Assert.IsFalse(helper.CheckForTie(8, 9));
        }

        /* ------------------------ COLUMN -----------------*/
        [Test]
        public void Test_Check_Column()
        {
            string[,] array =
            {
                {"X", " ", "X" },
                {"X", "O", "O" },
                {"X", "O", "O" }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckColumn(0, "X", 3, array);
            Assert.AreEqual(expected, actual);

        }
        [Test]
        public void Test_Check_Column_For_None()
        {
            string[,] array =
            {
                {"X", " ", "X" },
                {" ", "O", "O" },
                {"X", "O", "O" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckColumn(0, "X", 3, array);
            Assert.AreEqual(expected, actual);

        }

        [Test]
        public void Test_Check_Column_4x4()
        {
            string[,] array =
            {
                {"X", "X", "X","" },
                {"X", "O", "O", "O" },
                {"X", "O", "O", " " },
                {"X", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckColumn(0, "X", 4, array);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Check_Column_4x4_For_None()
        {
            string[,] array =
            {
                {"X", "X", "X","" },
                {"", "O", "O", "O" },
                {"", "O", "O", " " },
                {"X", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckColumn(0, "X", 4, array);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Check_Column_5x5()
        {
            string[,] array =
            {
                {"X", "O", "X","", ""},
                {"X", "O", "O", "O", "" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {" ", "O", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "O";
            string actual = helper.CheckColumn(1, "O", 5, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Column_5x5_For_None()
        {
            string[,] array =
            {
                {"X", "O", "X","", ""},
                {"X", "O", "O", "O", "" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {" ", "X", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckColumn(4, "O", 5, array);
            Assert.AreEqual(expected, actual);
        }

        /* ------------------------ ROW -----------------*/
        [Test]
        public void Test_Check_Row()
        {
            string[,] array =
               {
                {"X", "O", "X" },
                {"O", "O", "O" },
                {" ", "X", "X" }
            };

            HelperClass helper = new HelperClass();
            string expected = "O";
            string actual = helper.CheckRow(1, "O", 3, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Row_For_None()
        {
            string[,] array =
               {
                {"X", "O", "X" },
                {"", "O", "O" },
                {" ", "X", "X" }
            };

            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckRow(1, "O", 3, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Row_4x4()
        {
            string[,] array =
            {
                {"X", "X", "X","X" },
                {"X", "O", "O", "O" },
                {"X", "O", "O", " " },
                {"", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckRow(0, "X", 4, array);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Check_Row_4x4_For_None()
        {
            string[,] array =
            {
                {"X", "X", "X","" },
                {"", "O", "O", "O" },
                {"", "O", "O", " " },
                {"X", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckColumn(0, "X", 4, array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Check_Row_5x5()
        {
            string[,] array =
            {
                {"X", "O", "X","", ""},
                {"O", "O", "O", "O", "O" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {" X", "", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "O";
            string actual = helper.CheckRow(1, "O", 5, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Row_5x5_For_None()
        {
            string[,] array =
            {
                {"X", "O", "X","", ""},
                {"X", "O", "O", "O", "" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {" ", "X", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckRow(4, "O", 5, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        /* ------------------------ LEFT DIAGONAL -----------------*/
        public void Test_Check_Left_Diagonal()
        {
            string[,] array =
              {
                {"O", "O", "X" },
                {"",  "X", "O" },
                {"X", "X", "O" }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckLeftDiagonal("X", 3, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Left_Diagonal_For_None()
        {
            string[,] array =
              {
                {"O", "O", "X" },
                {"",  "X", "O" },
                {"", "X", "X" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckLeftDiagonal("X", 3, array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Check_Left_Diagonal_4x4()
        {
            string[,] array =
            {
                {"X", "X", "X","O" },
                {"X", "O", "O", "O" },
                {"X", "O", "O", "X" },
                {"O", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "O";
            string actual = helper.CheckLeftDiagonal("O", 4, array);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Check_Left_Diagonal_4x4_For_None()
        {
            string[,] array =
            {
                {"X", "X", "X","" },
                {"", "O", "O", "O" },
                {"", "O", "O", " " },
                {"X", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckLeftDiagonal( "X", 4, array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Check_Left_Diagonal_5x5()
        {
            string[,] array =
            {
                {"X", "O", "X","", "O"},
                {"O", "O", "O", "O", "O" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {"O", "", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "O";
            string actual = helper.CheckLeftDiagonal("O", 5, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Left_Diagonal_5x5_For_None()
        {
            string[,] array =
            {
                {"X", "O", "X","", ""},
                {"X", "O", "O", "O", "" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {" ", "X", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckLeftDiagonal("O", 5, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]

        /* ------------------------ RIGHT DIAGONAL -----------------*/
        public void Test_Check_Right_Diagonal()
        {
            string[,] array =
              {
                {"X", "O", "X" },
                {"",  "X", "O" },
                {"O", "X", "X" }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckRightDiagonal("X", 3, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Right_Diagonal_For_None()
        {
            string[,] array =
              {
                {"X", "O", "X" },
                {"",  "", "O" },
                {"O", "X", "X" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckRightDiagonal("X", 3, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Right_Diagonal_4x4()
        {
            string[,] array =
            {
                {"X", "X", "X","O" },
                {"X", "X", "O", "O" },
                {"X", "O", "X", "X" },
                {"O", "O", "O", "X" }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckRightDiagonal("X", 4, array);
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Check_Right_Diagonal_4x4_For_None()
        {
            string[,] array =
            {
                {"X", "X", "X","" },
                {"", "O", "O", "O" },
                {"", "O", "O", " " },
                {"X", "O", "O", " " }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckRightDiagonal("X", 4, array);
            Assert.AreEqual(expected, actual);
        }


        [Test]
        public void Test_Check_Right_Diagonal_5x5()
        {
            string[,] array =
            {
                {"X", "O", "X","", "O"},
                {"O", "X", "O", "O", "O" },
                {"X", "O", "X", "X", "O" },
                {"X", "O", "O", "X", "O" },
                {"", "", "O", "X", "X" }
            };
            HelperClass helper = new HelperClass();
            string expected = "X";
            string actual = helper.CheckRightDiagonal("X", 5, array);
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Check_Right_Diagonal_5x5_For_None()
        {
            string[,] array =
            {
                {"X", "O", "X","", ""},
                {"X", "O", "O", "O", "" },
                {"X", "O", "O", "X", "" },
                {"X", "O", "O", "X", "" },
                {" ", "X", "O", "X", "" }
            };
            HelperClass helper = new HelperClass();
            string expected = "None";
            string actual = helper.CheckRightDiagonal("O", 5, array);
            Assert.AreEqual(expected, actual);
        }

    }
}
