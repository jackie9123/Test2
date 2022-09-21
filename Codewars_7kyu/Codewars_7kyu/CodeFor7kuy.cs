using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Web;
using static System.Net.Mime.MediaTypeNames;
using System.Data.SqlTypes;
using System.Globalization;

namespace Codewars_7kyu
{
    public class CodeFor7kuy
    {
        public int[] Remove(int[] integerList, int[] valuesList)
        {
            //找出相同元素(即交集)
            // sameArr = arr1.Intersect(arr2).ToArray();
            return integerList.Where(x => !valuesList.Contains(x)).ToArray();
        }

        public List<string> Number(List<string> lines)
        {
            List<string> result = new List<string>();
            int i = 1;
            if (lines.Count > 0) {
                foreach (var line in lines) {
                    result.Add($"{i}: {line}");
                    i++;
                }
            }
            return result;
        }

        public bool IsIsogram(string str)
        {
            return str.ToLower().Distinct().Count() == str.Length;
        }

        public List<int> Unique(List<int> integers)
        {
            // Your one-liner
            return integers.Distinct().ToList();
        }

        public int Fib(int n)
        {
            if (n <= 2) {
                return 1;
            }
            return Fib(n - 1) + Fib(n - 2);
        }

        public int sumTwoSmallestNumbers(int[] numbers)
        {
            //Code here...
            Array.Sort(numbers);
            return numbers[0] + numbers[1];
        }

        public string OddOrEven(int[] array)
        {
            //enter code here
            return array.Sum() % 2 == 0 ? "even" : "odd";
        }

        //public int FourSeven(int num)
        //{
        //    // Start!
        //}

        public int ClosestMultiple10(int num)
        {
            if (num % 10 >= 5) {
                return (num / 10 + 1) * 10;
            }
            return num / 10 * 10;
        }

        public string FireFight(string s)
        {
            return s.Replace("Fire", "~~");
        }

        public string Switcher(string[] x)
        {
            Dictionary<string, string> map = new Dictionary<string, string>();
            map.Add("29", " "); map.Add("28", "?");
            map.Add("27", "!"); map.Add("26", "a");
            map.Add("25", "b"); map.Add("24", "c");
            map.Add("23", "d"); map.Add("22", "e");
            map.Add("21", "f"); map.Add("20", "g");
            map.Add("19", "h"); map.Add("18", "i");
            map.Add("17", "j"); map.Add("16", "k");
            map.Add("15", "l"); map.Add("14", "m");
            map.Add("13", "n"); map.Add("12", "o");
            map.Add("11", "p"); map.Add("10", "q");
            map.Add("9", "r"); map.Add("8", "s");
            map.Add("7", "t"); map.Add("6", "u");
            map.Add("5", "v"); map.Add("4", "w");
            map.Add("3", "x"); map.Add("2", "y");
            map.Add("1", "z");
            string result = "";
            for (int i = 0; i < x.Length; i++) {
                result += map[x[i]];
            }

            return result;

            //string.Concat(x.Select(n => "zyxwvutsrqponmlkjihgfedcba!? "[int.Parse(n) - 1]));
        }

        public int GetVowelCount(string str)
        {
            // Your code here
            return str.Count(x => "aeiou".Contains(x));
        }

        public int Consecutive(int[] arr)
        {
            if (arr.Count() <= 1) {
                return 0;
            }
            int result = arr.Max() - arr.Min() - arr.Length + 1;
            return result == 1 ? 0 : result;

            //return arr.Any() ? arr.Max() - arr.Min() - arr.Length + 1 : 0;
        }

        public int NbDig(int n, int d)
        {
            int count = 0;
            for (int i = 0; i <= n; i++) {
                foreach (var item in (i * i).ToString()) {
                    if (item.ToString().Equals(d.ToString())) {
                        count++;
                    }
                }
            }
            return count;
        }

        public ulong Factorial(int n)
        {
            ulong result = 1;
            for (ulong i = 1; i <= (ulong)n; i++) {
                result *= i;
            }
            return result;

            //return (n == 0) ? 1 : (ulong)n * Factorial(n - 1);
        }

        public long MaxIntChain(long n)
        {
            if (n < 5) {
                return -1;
            }

            long nHalf = n / 2;
            if (nHalf != n - nHalf) {
                return nHalf * (n - nHalf);
            }
            return (nHalf - 1) * (n - nHalf + 1);
        }

        public bool XO(string input)
        {
            int count_x = 0;
            int count_o = 0;
            foreach (var item in input.ToLower()) {
                if (item.Equals('x')) {
                    count_x++;
                }
                if (item.Equals('o')) {
                    count_o++;
                }
            }

            return count_o == count_x;

            //return input.ToLower().Count(i => i == 'x') == input.ToLower().Count(i => i == 'o');
        }

        public int GetSectionId(int n, int[] a)
        {
            int num = 0;
            for (int i = 0; i < a.Length; i++) {
                num += a[i];
                if (num - 1 >= n) {
                    return i;
                }
            }
            return -1;
        }

        public string GeometricSequenceElements(int a, int r, int n)
        {
            string result = "";
            for (int i = 0; i < n; i++) {
                if (i + 1 == n) {
                    result += $"{a * Math.Pow(r, i)}";
                }
                else {
                    result += $"{a * Math.Pow(r, i)}, ";
                }
            }
            return result;

            //return string.Join(", ", Enumerable.Range(0, n).Select(i => Math.Pow(r, i) * a));
        }

        public int Factorial_2(int n)
        {
            if (n < 0 || n > 12) {
                throw new ArgumentOutOfRangeException();
            }
            return n == 0 ? 1 : n * Factorial_2(n - 1);
        }

        public string Bump(string input)
        {
            return input.Count(x => x == 'n') < 16 ? "Woohoo!" : "Car Dead";
        }

        public bool MakesTheSentence(List<char> characters, string sentence)
        {
            //foreach (var item in sentence.Replace(" ","")) {
            //    if (characters.Any(x => x == item)) {
            //        characters.Remove(item);
            //    }
            //    else {
            //        return false;
            //    }
            //}
            //return true;

            foreach (char c in sentence) {
                if (characters.Count(p => p == c) < sentence.Count(p => p == c) && c != ' ')
                    return false;
            }
            return true;
        }

        public int FindSmallest(int[] numbers, string toReturn)
        {
            if (toReturn.StartsWith("v")) {
                return numbers.Min();
            }
            return Array.IndexOf(numbers, numbers.Min());
        }

        public string Gordon(string a)
        {
            List<string> result = new List<string>();
            foreach (var item in a.Split(' ')) {
                result.Add(item.ToUpper().Replace("A", "@").Replace("E", "*")
                    .Replace("I", "*").Replace("O", "*").Replace("U", "*") + "!!!!");
            }
            return string.Join(" ", result);

            //return string.Join(" ", string.Concat(a.ToUpper().Select(x => "EIOU".Contains(x) ? '*' : x == 'A' ? '@' : x)).Split().Select(x => x + "!!!!"));
        }

        public long MinValue(int[] a)
        {
            int[] b = a.Distinct().ToArray();
            Array.Sort(b);
            int count = b.Length - 1;
            long result = 0;
            foreach (var item in b) {
                result += item * (int)Math.Pow(10, count);
                count--;
            }
            return result;

            //string res = string.Concat(a.OrderBy(x => x).Distinct());
            //return Convert.ToInt64(res);
        }

        //public int[] ProductArray(int[] array)
        //{

        //}

        public int MaxProduct(int[] arr, int size)
        {
            int[] num = arr.OrderBy(x => x).Reverse().Take(size).ToArray();
            int result = 1;
            for (int i = 0; i < num.Length; i++) {
                result *= num[i];
            }
            return result;

            //return arr.OrderBy(i => -i).Take(size).Aggregate((x, y) => x * y);
        }

        public int StantonMeasure(int[] arr)
        {
            int occuts_1 = arr.Count(x => x == 1);
            int stanton = arr.Count(x => x == occuts_1);
            return stanton;
        }

        public string[] Last(string x)
        {
            return x.Split().OrderBy(s => s.Last()).ToArray();
        }

        public int WordsToMarks(string str)
        {
            int result = 0;
            foreach (var item in str) {
                result += item - 96;
            }
            return result;
        }

        public int MaxTriSum(int[] a)
        {
            return a.Distinct().OrderBy(x => -x).Take(3).Sum();
        }

        public bool TidyNumber(int n)
        {
            string strn = n.ToString();
            for (int i = 0; i < strn.Length - 1; i++) {
                if (strn[i] > strn[i + 1]) {
                    return false;
                }
            }
            return true;

            //return n.ToString() == String.Concat(n.ToString().OrderBy(c => c));
        }

        public short NextHappyYear(short year)
        {
            do {
                year++;
            } while (year.ToString().Distinct().Count() != 4);
            return year;
            //return (++year).ToString().Distinct().Count() == 4 ? year : NextHappyYear(year);
        }

        public bool IsNegativeZero(double n)
        {
            return n.ToString() == "-0";
        }

        public int[] GetPositions(int s)
        {
            return new int[] { s / 1 % 3, s / 3 % 3, s / 9 % 3 };
        }

        public bool Solution(string str, string ending)
        {
            return str.Length < ending.Length ? false : str.Substring(str.Length - ending.Length, ending.Length) == ending;
            //return str.EndsWith(ending);
        }

        public string PrinterError(String s)
        {
            Regex reg1 = new Regex(@"^[n-z]+$");
            return $"{s.Count(x => reg1.IsMatch(x.ToString()))}/{s.Length}";
        }

        public int Digits(ulong n)
        {
            return n.ToString().Length;
        }

        /// <summary>
        /// 字串替換使用Linq
        /// </summary>
        /// <param name="garden"></param>
        /// <returns></returns>
        public string RakeGarden(string garden)
        {
            string[] gardenArr = garden.Split(' ');
            for (int i = 0; i < gardenArr.Length; i++) {
                if (gardenArr[i] != "rock") {
                    if (gardenArr[i] != "gravel") {
                        gardenArr[i] = "gravel";
                    }
                }
            }

            return string.Join(" ", gardenArr);

            //return string.Join(" ", garden.Split(' ').Select(e => e == "gravel" || e == "rock" ? e : "gravel"));
        }

        public int CircleOfNumbers(int n, int FirstNumber)
        {
            int[] arr1 = Enumerable.Range(0, n / 2).ToArray();
            int[] arr2 = Enumerable.Range(n / 2, n / 2).ToArray();

            if (arr1.Contains(FirstNumber)) {
                return arr2[Array.IndexOf(arr1, FirstNumber)];
            }
            return arr1[Array.IndexOf(arr2, FirstNumber)];

            //return (n / 2 + FirstNumber) % n;
        }

        /// <summary>
        /// 判斷object型別後再處理
        /// </summary>
        /// <param name="objArray"></param>
        /// <returns></returns>
        public int DivCon(Object[] objArray)
        {
            int stringint = 0;
            int num = 0;
            foreach (var item in objArray) {
                if (item is string) {
                    stringint += int.Parse(item.ToString());
                }
                else {
                    num += (int)item;
                }
            }

            return num - stringint;

            //return objArray.Sum(o => (o is int ? 1 : -1) * int.Parse(o.ToString()));
        }

        public string Accum(string s)
        {
            int index = 0;
            string[] newstr = new string[s.Length];
            foreach (var item in s.ToLower()) {
                newstr[index] = new string(item, index + 1);
                newstr[index] = Regex.Replace(newstr[index], "^[a-z]", m => m.Value.ToUpper());
                index++;
            }

            return string.Join("-", newstr);
        }

        public double Heron(double a, double b, double c)
        {
            double s = (a + b + c) / 2;
            return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
        }

        public int RangeBitCount(int a, int b)
        {
            int countOfOne = 0;
            int[] arr = Enumerable.Range(a, b - a + 1).ToArray();
            for (int i = 0; i < arr.Length; i++) {
                string tmp = Convert.ToString(arr[i], 2);
                countOfOne += tmp.Count(x => x == '1');
            }

            return countOfOne;
        }

        public long OverTheRoad(long address, long n)
        {
            if (address % 2 != 0) {
                long index = address / 2;
                return n * 2 - index * 2;
            }
            else {
                long index = (n * 2 - address) / 2;
                return 1 + index * 2;
            }

            //return 2 * n - a + 1;
        }

        public string RemoveUrlAnchor(string url)
        {
            return url.Contains("#") ? url.Substring(0, url.IndexOf("#")) : url;
            //return url.Split('#')[0];
        }

        public int Divisors(int n)
        {
            int count = 0;
            for (int i = 1; i <= n; i++) {
                if (n % i == 0) {
                    count++;
                }
            }
            return count;
        }

        /// <summary>
        /// SkipWhile/TakeWhile
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="pred"></param>
        /// <returns></returns>
        public int[] DropWhile(int[] arr, Func<int, bool> pred)
        {
            return arr.SkipWhile(pred).ToArray();
        }

        public int DontGiveMeFive(int start, int end)
        {
            //int[] arr = Enumerable.Range(start, end - start + 1).ToArray();
            //int count = 0;
            //for (int i = 1; i <= end / 5; i += 2) {
            //    if (arr.Contains(i * 5)) {
            //        count++;
            //    }
            //}
            //return arr.Length - count;
            //return arr.Length - arr.Where(x => x % 5 == 0 && x / 5 % 2 != 0).Count();
            return Enumerable.Range(start, end - start + 1).Count(x => !x.ToString().Contains("5"));
        }

        /// <summary>
        /// 排序使用方式
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public string[] LineupStudents(string a)
        {
            string[] arra = a.Split(' ');
            return arra.OrderByDescending(x => x.Length).ThenByDescending(x => x).ToArray();
        }

        public double Arithmetic(double a, double b, string op)
        {
            switch (op) {
                case "add":
                    return a + b;
                case "subtract":
                    return a - b;
                case "multiply":
                    return a * b;
                case "divide":
                    return a / b;
                default:
                    return -1;
            }
        }

        public int GetNewNotes(int salary, int[] bills)
        {
            return salary - bills.Sum() < 5 ? 0 : (salary - bills.Sum()) / 5;
        }

        public int PredictAge(int age1, int age2, int age3, int age4, int age5, int age6, int age7, int age8)
        {
            double totalAge = Math.Pow(age1, 2) + Math.Pow(age2, 2) + Math.Pow(age3, 2) + Math.Pow(age4, 2)
                + Math.Pow(age5, 2) + Math.Pow(age6, 2) + Math.Pow(age7, 2) + Math.Pow(age8, 2);

            return (int)Math.Sqrt(totalAge) / 2;
        }

        public int Triangular(int n)
        {
            if (n <= 0) {
                return 0;
            }
            else {
                return n + Triangular(n - 1);
            }

        }

        public bool ValidatePin(string pin)
        {
            //return Regex.IsMatch(pin, @"^(\d{6}|\d{4})\z");
            return (pin.Length == 4 || pin.Length == 6) && pin.All(Char.IsDigit);
            //Regex reg = new Regex(@"^[0-9]+$");
            //return reg.IsMatch(pin) && (pin.Trim().Length == 4 || pin.Trim().Length == 6);
        }

        public int DescendingOrder(int num)
        {
            return Convert.ToInt32(String.Join("", num.ToString().OrderByDescending(x => x)));
        }

        public int Gps(int s, double[] x)
        {
            if (x.Length <= 1) {
                return 0;
            }
            double[] y = new double[x.Length - 1];
            for (int i = 0; i < x.Length - 1; i++) {
                y[i] = (x[i + 1] - x[i]) / s * 3600;
            }

            return (int)y.Max();
        }

        public string Pattern(int n)
        {
            if (n < 1) {
                return "";
            }

            string result = "";
            for (int i = 1; i <= n; i++) {
                string num = string.Join("", Enumerable.Repeat(i, i).ToArray());
                if (i == n) {
                    result += $"{num}";
                }
                else {
                    result += $"{num}\n";
                }
            }

            return result;
        }

        public int ShapeArea(int n)
        {
            if (n <= 1) {
                return 1;
            }
            else {
                return 4 * (n - 1) + ShapeArea(n - 1);
            }

        }

        public bool InviteMoreWomen(int[] L)
        {
            return L.Count(x => x == -1) >= L.Count(x => x == 1);
        }

        public int[] GiveChange(int amount)
        {
            int[] money = { 100, 50, 20, 10, 5, 1 };
            int[] moneyCount = new int[6];
            for (int i = 0; i < money.Length; i++) {
                moneyCount[i] = amount / money[i];
                amount -= moneyCount[i] * money[i];
            }
            return moneyCount.Reverse().ToArray();
        }

        public Func<int, int[]> MultiplyAll(int[] a)
        {
            // your code here
            return i => a.Select(x => x * i).ToArray();
        }

        public string ReverseLetter(string str)
        {
            //coding and coding..
            Regex reg1 = new Regex(@"^[a-z]+$");
            char[] result = str.Where(x => reg1.IsMatch(x.ToString())).Reverse().ToArray();
            return String.Join("", result);

            //return new String(str.Where(Char.IsLetter).Reverse().ToArray());
        }

        //public double Chain(double input, Func<double, double>[] fs)
        //{
        //    // your code ...

        //}

        public int KillKthBit(int n, int k)
        {
            if (n == 0)
                return 0;
            char[] nForTwo = Convert.ToString(n, 2).ToCharArray();
            nForTwo[nForTwo.Length - k] = '0';
            return Convert.ToInt32(string.Join("", nForTwo), 2);
        }

        public int Divisions(int n, int divisor)
        {
            int count = 0;
            while (n >= divisor) {
                n = n / divisor;
                count++;
            }
            return count;

            //return (int)Math.Log(n, divisor);
        }
        public int GetNumber(string str)
        {
            List<string> result = new List<string>();
            for (int i = 0; i < str.Length - 5 + 1; i++) {
                result.Add(str.Substring(i, 5));
            }

            return Convert.ToInt32(result.Max());

            //return int.Parse(Enumerable.Range(0, s.Length - 4).Max(i => s.Substring(i, 5)));
        }

        /// <summary>
        /// 多個字元替換時
        /// </summary>
        /// <param name="boringText"></param>
        /// <returns></returns>
        public string HeavyMetalUmlauts(string boringText)
        {
            string strfrom = "AEIOUYaeiouy";
            string strto = "ÄËÏÖÜŸäëïöüÿ";
            for (int i = 0; i < strfrom.Length; i++)
                boringText = boringText.Replace(strfrom[i], strto[i]);
            return boringText;
        }

        public int NbYear(int p0, double percent, int aug, int p)
        {
            int needYear = 0;
            while (p0 < p) {
                p0 += (int)(p0 * (percent * 0.01)) + aug;
                needYear++;
            }

            return needYear;
        }

        public bool IsTriangle(int a, int b, int c)
        {

            return a < 0 || b < 0 || c < 0 ? false : (a + b) > c && (a + c) > b && (b + c) > a;
        }

        public int HouseNumbersSum(int[] inputArray)
        {
            int result = 0;
            foreach (var item in inputArray) {
                if (item != 0) {
                    result += item;
                }
                else {
                    break;
                }
            }
            return result;

            // return input.TakeWhile(x => x != 0).Sum();
        }

        public int Number(List<int[]> peopleListInOut)
        {
            int result = 0;
            foreach (var item in peopleListInOut) {
                result += item[0] - item[1];
            }
            return result;

            //return peopleListInOut.Sum(x => x[0] - x[1]);
        }

        public Int32 Calc(String s)
        {
            string total1 = "";
            foreach (var item in s) {
                total1 += ((int)item).ToString();
            }
            return total1.Count(x => x == '7') * 6;

        }

        public int Mxdiflg(string[] a1, string[] a2)
        {
            // your code
            if (a1.Length <= 0 || a2.Length <= 0)
                return -1;
            int r1 = a1.Max(x => x.Length) - a2.Min(x => x.Length);
            int r2 = a2.Max(x => x.Length) - a1.Min(x => x.Length);

            return r1 > r2 ? r1 : r2;
        }

        /// <summary>
        /// 結果會出錯，值不在預期範圍內
        /// </summary>
        /// <param name="arr"></param>
        /// <param name="navg"></param>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public long NewAvg(double[] arr, double navg)
        {
            // your code
            if (navg < arr.Sum() || navg <= 0) {
                throw new ArgumentException();
            }
            double total = navg * (arr.Count() + 1);
            return Convert.ToInt64(total - arr.Sum());
        }

        public int Movie(int card, int ticket, double perc)
        {
            // your code
            int a = 0;
            double b = card;
            int times = 0;
            while (Math.Ceiling(b) >= a) {
                a += ticket;
                b += ticket * Math.Pow(perc, ++times);
            }
            return times;
        }

        public bool IsNice(int[] arr)
        {
            if (arr.Length == 0) {
                return false;
            }
            foreach (var item in arr) {
                if (!(arr.Contains(item + 1) || arr.Contains(item - 1))) {
                    return false;
                }
            }
            return true;

        }

        public int Gimme(double[] inputArray)
        {
            // Implement this function
            return Array.IndexOf(inputArray, inputArray.OrderBy(x => x).ToArray()[1]);
        }

        public int GetTheVowels(string word)
        {
            if (string.IsNullOrEmpty(word))
                return 0;

            char[] vowels = { 'a', 'e', 'i', 'o', 'u' };
            int index = 0, count = 0;

            foreach (char ch in word) {
                if (ch == vowels[index]) {
                    count++;
                    index++;

                    if (index >= vowels.Length)
                        index = 0;
                }
            }

            return count;

        }

        public List<int> RemoveSmallest(List<int> numbers)
        {
            // Good Luck!
            List<int> result = new List<int>();
            bool falg = false;
            foreach (var item in numbers) {
                if (item != numbers.Min() || falg) {
                    result.Add(item);
                }
                else {
                    falg = true;
                }
            }

            return result;
        }

        public string ReplaceNth(string text, int n, char oldValue, char newValue)
        {
            if (n <= 0) {
                return text;
            }
            int count = 0;
            string result = "";
            foreach (var item in text) {
                if (item == oldValue) {
                    count++;
                    if (count % n == 0) {
                        result += newValue;
                    }
                    else {
                        result += item;
                    }
                }
                else {
                    result += item;
                }
            }

            return result;
        }

        public long MaxRot(long n)
        {
            //56789
            long max = n;
            string number = n.ToString();
            for (int i = 0; i < number.Length - 1; i++) {
                number = number.Substring(0, i) + number.Substring(i + 1) + number[i];
                n = long.Parse(number);
                if (n > max) max = n;
            }
            return max;

        }

        public int CountRedBeads(int n)
        {
            return n < 2 ? 0 : (n - 1) * 2;
        }

        /// <summary>
        /// 字符串重複產生
        /// </summary>
        /// <param name="strng"></param>
        /// <param name="k"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        public string Scale(string strng, int k, int n)
        {
            string[] strArray = strng.Split('\n');
            List<string> strList = new List<string>();
            string word = "";
            for (int i = 0; i < strArray.Length; i++) {
                foreach (char ch in strArray[i]) {
                    for (int j = 0; j < k; j++) {
                        word += "" + ch;
                    }
                }
                if (String.IsNullOrEmpty(word)) continue;
                for (int j = 0; j < n; j++) {
                    strList.Add(word);
                }
                word = "";
            }
            return string.Join("\n", strList);

     //       return string.Join('\n', s.Split('\n').Select(x => x.Any()
     //? string.Join('\n', Enumerable.Repeat(string.Concat(x.Select(c => new string(c, k))), n))
     //: ""));
        }
        
        /// <summary>
        /// 陣列Index
        /// </summary>
        /// <param name="array"></param>
        /// <returns></returns>
        public int[] SortByValueAndIndex(int[] array)
        {
            int i = 1;
            return array.OrderBy(n => n * i++).ToArray();
        }

    }
    public static class ArrayMethods
    {
        public static TSource Head<TSource>(this List<TSource> list)
        {
            return list.First();
        }

        public static List<TSource> Tail<TSource>(this List<TSource> list)
        {
            return new List<TSource>(list.Skip(1));
        }

        public static List<TSource> Init<TSource>(this List<TSource> list)
        {
            return new List<TSource>(list.Take(list.Count - 1));
        }

        public static TSource Last_<TSource>(this List<TSource> list)
        {
            return list.Last();
        }
    }
    public class Warrior
    {
        private string name;

        public Warrior(string name)
        {
            this.name = name;
        }

        public int Health { get; set; } = 100;

        public static void Strike(Warrior enemy, int swings)
        {
            enemy.Health = Math.Max(0, enemy.Health - (swings * 10));
        }
    }
}
