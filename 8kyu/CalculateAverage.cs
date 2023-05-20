/*Write a function which calculates the average of the numbers in a given list.*/

using System.Linq;
class AverageSolution {
    public static double FindAverage(double[] array) {
        return array.Length == 0 ? 0 : array.Sum() / array.Length;
    }
}