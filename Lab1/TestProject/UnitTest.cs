
using Lab1;
using System.Linq;
namespace TestProject
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethodCountElements()
        {
            List<int> sizes = new List<int>() { 10, 20, 30, 40, 50 };
            foreach (int n in sizes)
            {
                Problem problem = new(n);
                Assert.AreEqual(n, problem.items.Count);
            }
        }

        // Tests to do from pdf
        [TestMethod]
        public void Test_At_Least_One_Item_Returned()
        {
            Problem problem = new(5);
            problem.Solve(10);

            // Assert
            Assert.IsTrue(problem.Result_obj.result.Count > 0);
        }

        [TestMethod]
        public void Test_Empty_Solution_Returned()
        {
            Problem problem = new(5);
            problem.Solve(0);

            // Assert
            Assert.IsTrue(problem.Result_obj.result.Count == 0);
        }

        [TestMethod]
        public void Test_Item_Order_Does_Not_Affect_Solution()
        {
            Problem shuffleProblem = new(5);
            Problem originalProblem = shuffleProblem;

            // Shuffle items
            shuffleProblem.items = shuffleProblem.items.OrderBy(a => Guid.NewGuid()).ToList();

            // Solve the problem with the original and shuffled lists
            
            originalProblem.Solve(10);

            shuffleProblem.Solve(10);

            // Assert
            Assert.AreEqual(originalProblem.Result_obj.result, shuffleProblem.Result_obj.result);
        }

        [TestMethod]
        public void Test_Specific_Instance()
        {
            Problem problem = new(5);
            problem.Solve(10);

            // Assert
            Assert.AreEqual(0, problem.Result_obj.result[0].Id);
            Assert.AreEqual(3, problem.Result_obj.result[0].Values);
            Assert.AreEqual(2, problem.Result_obj.result[0].Weights);
            Assert.AreEqual(2, problem.Result_obj.result[1].Id);
            Assert.AreEqual(7, problem.Result_obj.result[1].Values);
            Assert.AreEqual(5, problem.Result_obj.result[1].Weights);
        }


        // My own Test

        // Check if provided data is in range <1, 10>
        [TestMethod]
        public void Test_Weights_And_Values_In_Range()
        {
            Problem problem = new(5);
            for (int i = 0; i < 5; i++)
            {
                Assert.IsTrue(problem.items[i].Weights >= 1 && problem.items[i].Weights <= 10);
                Assert.IsTrue(problem.items[i].Values >= 1 && problem.items[i].Values <= 10);
            }
        }
        // Test if Solve method it sorting items correctly by ratio
        [TestMethod]
        public void Test_Solve_Sorts_Items_By_Ratio()
        {
            Problem problem = new(10);
            problem.Solve(50);

            //Assert
            Assert.AreEqual(0, problem.items[0].Id);
            Assert.AreEqual(2, problem.items[1].Id);
            Assert.AreEqual(9, problem.items[2].Id);
            Assert.AreEqual(7, problem.items[3].Id);
            Assert.AreEqual(1, problem.items[4].Id);
            Assert.AreEqual(8, problem.items[5].Id);
            Assert.AreEqual(6, problem.items[6].Id);
            Assert.AreEqual(3, problem.items[7].Id);
            Assert.AreEqual(5, problem.items[8].Id);
            Assert.AreEqual(4, problem.items[9].Id);
        }

        // Checking if method ToString is correct
        [TestMethod]
        public void Test_ToString_Returns_Correct_String_Representation()
        {
            Problem problem = new(5);

            //class Problem
            string expectedString = "no.: 0\t value: 3  \t weigth: 2\n" +
                                    "no.: 1\t value: 5  \t weigth: 8\n" +
                                    "no.: 2\t value: 7  \t weigth: 5\n" +
                                    "no.: 3\t value: 4  \t weigth: 10\n" +
                                    "no.: 4\t value: 2  \t weigth: 7\n";
            Assert.AreEqual(expectedString, problem.ToString());

            //class Item
            expectedString = "no.: 0\t value: 3  \t weigth: 2\n";
            Assert.AreEqual(expectedString, problem.items[0].ToString());
            expectedString = "no.: 4\t value: 2  \t weigth: 7\n";
            Assert.AreEqual(expectedString, problem.items[4].ToString());

            //class Result
            expectedString = "Total value: 10\nTotal weight: 7\nItems: 0, 2, ";
            problem.Solve(10);
            Assert.AreEqual(expectedString, problem.Result_obj.ToString());
        }


        // Checking for negative Values or Weights
        [TestMethod]
        public void Test_Solve_With_Items_Having_Negative_Values_Or_Weights()
        {
            // Arrange
            Problem problem = new(3)
            {
                items =
                [
                    new(0, -1, 2),
                    new(1, 3, -4),
                    new(2, -5, -6)
                ]
            };
            problem.Solve(5);

            // Assert
            Assert.AreEqual(0, problem.Result_obj.Total_weight);
            Assert.AreEqual(0, problem.Result_obj.Total_value);
        }

    }
}