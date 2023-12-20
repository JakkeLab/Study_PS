using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {
            var cnt = Console.ReadLine();
            var nums = Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToList();
            var accumMax = GetMaxSum(nums);
            Console.WriteLine(accumMax);
        }

        public static int GetMaxSum(List<int> nums)
        {
            //연속합 저장공간과 연속합에서의 최대값, 최솟값 저장
            var res = new List<int>();
            int maxAccum = nums[0];
            int minAccum = nums[0];
            int maxSole = nums.Max();
            for (int i = 0; i < nums.Count; i++)
            {
                if (i == 0)
                {
                    res.Add(nums[0]);
                }
                else
                {
                    var accum = res[i - 1] + nums[i];

                    //방금 구한 누적합이 최대값보다 큰 경우 최대값으로 할당
                    if (accum > maxAccum)
                    {
                        maxAccum = accum;
                    }

                    //지금까지의 누적합 중 가장 작은 값이 최소 누적합보다 작은 경우 최솟값으로 할당
                    if (accum < minAccum)
                    {
                        minAccum = accum;
                    }

                    //방금 구한 누적합 - 최소 누적합 > 최댓값이면 최댓값 갱신.
                    if (accum - minAccum > maxAccum)
                    {
                        maxAccum = accum - minAccum;
                    }

                    //누적합 추가를 여기서 해야함
                    res.Add(accum);
                }
            }

            maxAccum = maxSole > 0 ? maxAccum : maxSole;
            return maxAccum;
        }
    }
}
