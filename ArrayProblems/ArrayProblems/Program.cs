namespace ArrayProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            ArrayProblems.TwoSum([2, 7, 11, 15], 9);
        }

        public class ArrayProblems
        {
            // <summary>
            ///  an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
            ///  You may assume that each input would have exactly one solution, and you may not use the same element twice.
            ///  You can return the answer in any order.
            /// </summary>
            /// <param name="nums"></param>
            /// <param name="target"></param>
            /// <returns></returns>
            /// <exception cref="ArgumentException"></exception>
            public static int[] TwoSum(int[] nums, int target)
            {
                Dictionary<int, int> map = new Dictionary<int, int>();
                for (int i = 0; i < nums.Length; i++)
                {
                    int complement = target - nums[i];
                    if (map.ContainsKey(complement))
                    {
                        return new int[] { map[complement], i };
                    }

                    if (!map.ContainsKey(nums[i]))
                    {
                        map[nums[i]] = i;
                    }
                }

                throw new ArgumentException("No two sum solutions");
            }
        }
    }
}
