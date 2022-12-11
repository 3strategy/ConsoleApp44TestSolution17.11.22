//test solution 17.11.22
//הפתרון מוצג בגרסת 22 ללא 
using System;
using System.Diagnostics;
using System.Numerics;



MainQ1(); // ( קריאה לפונקציה (בבחינה אין צורך בזה
// אין בשאלה 1 תועלת בכתיבה כפונקציה
// הן פונצקיות Main(), MainQ1, MainQ2() זכרו שכמובן גם

//Question 1 שאלה
static void MainQ1()
{
  Random rnd = new Random();
  int counter = 1;
  int firstNum = rnd.Next(5, 41); // הגרלת מספר ראשון
  for (int i = 0; i < 19; i++) // 19 הנותרים
    if (rnd.Next(5, 14) == firstNum)
      counter++;
  Console.WriteLine(counter);
}



// פונקצית שירות להדפסות
// לא לימדתי. בא לחסוך רישום מיותר בבחינה
// מסוכן בבגרות - לא בטוח שבוחן יקבל. בסה"כ
// בבגרות לא יהיו לכם יותר מדי הדפסות ולכן חבל להסתכן
static void CW(object s) => Console.WriteLine(s);
// מוצגת כאן רק לצורך לימודי CW

// Question שאלה 2
static void MainQ2()
{
  Console.WriteLine("Please enter 3 whole numbers");
  int a = 100; //קלוט מספר שלם
  int b = 101; //קלוט מספר שלם
  int c = 101; //קלוט מספר שלם
               //אם התנאי ארוך, ולא יהיה שימוש במשתנים לאורך זמן
               //עדיף לקלוט לשמות קצרים
  if (a + b == 200 || b + c == 200 || a + c == 200)
    Console.WriteLine("true");
  else
    CW("false");
}
MainQ2(); // קריאה לבדיקה. בבחינה לא צריך 

//Q2 alternative, as a function, short version:
static bool IsSum200(int a, int b, int c) =>
    a + b == 200 || b + c == 200 || a + c == 200;
//במקרה של ספק הוסיפו סוגריים כדי שהביטוי "יוערך" כפי שרציתם

//Q2 alternative, as a function, long version:
static bool IsSum200LongerVersion(int a, int b, int c)
{
  return a + b == 200 || b + c == 200 || a + c == 200;
  //בכל מקרה לרשום כאן כתנאי יעיד על 
  // כך שאינכם מבינים שהביטוי הזה הוא בעצמו
  // true או false
  // ולכן פשוט מחזירים אותו
}

// שאלה 3 היא שאלת אנליזה
// 3ב: 
// עבור קלט בו ספרת האחדות קטנה או שווה 
// לספרת העשרות הלולאה לא תרוץ
// > היחס => הוא ההפך מ
// די לתת דוגמא מספרית כגון 66 ולהסביר

// 3ג:
// מספרים דו ספרתיים בעלי ספרות מקיימים זוגיות הפרש הספרות
// כיוון שהאלגוריתם מקטין את הפרש הספרות ב-2 
// נקבל כפלט מספר בר ספרות זהות (כמעט) בכל מקרה בו הספרה הימנית אינה קטנה מהשמאלית, והפרשן זוגי

// אם בסוף התוכנית יש החזר צריך לרשום מתחת לטבלה
// אם זו פונקציה ויש מספר מקומות בהם יש החזר, 
// חשוב לציין את מספר השורה או לרשום את ההוראה שבה בוצע 
// return


// Question 4
// סעיף א
static bool CountDig(int num)
{
  int countEven = 0, countOdd = 0;
  if (num == 0) return false; // טיפול במקרה קצה של 0
                              // !!! לעיל דוגמא ללא מעבר שורה. ממש לא נהוג

  while (num > 0)
  {   // אילו ידענו כמה ספרות יש היינו יכולים להשתמש במונה יחיד
      // הפתרון שמוצג אגנוסטי למספר הספרות
    if (num % 2 == 0)
      countEven++;
    else
      countOdd++;
    num /= 10; // קיצוץ ספרה ימנית
  }
  return countOdd == countEven;
}
// הערה: המספר אפס זוגי כי הוא מתחלק ב-2 ללא שארית

static void MainQ4B()
{
  Random rnd = new Random();
  for (int i = 0; i < 15; i++)
  {
    int num = rnd.Next(100000, 1000000); //בני 6 ספרות
    //Debug.Assert(CountDig(num)==CountDig2(num));
    if (CountDig(num)) // 'בדיקת המספר בעזרת הפונקציה מסעיף א 
      Console.WriteLine($"Odd and even digit count of {num} is equal");
    else
      Console.WriteLine($"Odd and even digit count of {num} is NOT equal");
  }
}

MainQ4B(); // קריאה לפונצקיה (בדיקה). אתם בבחינה מכנים
// כרגיל. Main() שלכם Main() את כל הפוקציות
// אני חייב לשנות שם כדי שהקוד כולו ירוץ
// שלא צריכות להופיע בבחינה MainQ()  ולהוסיף קריאות לפונקציה

// ? public אז למה אני לא רושם
// אתם בבחינה תמשיכו לרשום 
// static ולא רק  public static 
// אוטוטו אסביר את הנושא כשנכתוב מחלקות
//  (in Linux/Max OS VS2022 syntax) ,כאן בקוד  
// the public access modifier cannot be used because the
// MainQ1, MainQ2, etc... functions,
// are implemented as internal functions inside
// an implicit Main() that is generated at compile time.
// זה ממומש כאן כפונצקות בתוך פונקציות
// משהו שלא היה קיים עד לא מזמן



// לא קשור למבחן :
// לולאות מקוננות
// (מטלה 14 שאלה 3ג (אתגר
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\nMatala 14 Q3 gimel");
for (int i = 1; i <= 5; i++)
{
  for (int j = 5 - i - 1; j >= 0; j--)
    Console.Write("-");
  Console.Write(i);
  for (int j = 0; j < i; j++)
    Console.Write("X");
  Console.WriteLine();
}

// מטלה 14 שאלה 4 ללא קלט וללא טיפול בקטן מבין שני קלטים
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine("\nstarting a heavy operative calculation:");
BigInteger sumBig = 0;
//for (long i = 0; i <= 241235832; i++)   sumBig += i; // יש לבטל את ההערה כדי לראות את זה רץ
Console.WriteLine("Done. Got: " + sumBig);
Console.WriteLine("ended this timely loop \n(if it ran fast then the loop is \\\\commented)\nNow do it quickly - Declarative thinking:");

//( מטלה 14 שאלה 5 ( אתגר חשיבה דקלרטיבית 
sumBig = 241235832;
BigInteger big2 = 241235833;
sumBig = sumBig * big2 / 2;
Console.WriteLine(sumBig);

// מערכים ולולאות מקוננות
// מטלה 15 שאלה 1
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine("\nMatala 15 Q1:");
string[] names = new string[0]; // should be 8 
for (int i = 0; i < names.Length; i++)
  names[i] = ""; // מקובל לאתחל את איברי המערך
for (int i = 0; i < names.Length; i++)
{
  // קלט ובדיקה שאין חזרות
  // נניח לדוגמא שאנחנו בקלט החמישי
  Console.WriteLine($"input name {i}");
  names[i] = Console.ReadLine();
  //רוצים להשוות את השם במקום החמישי עם השמות
  // במקומות ה-0 1 2 3 4
  for (int j = 0; j < i; j++)
  {
    if (names[i] == names[j])
    { //מצב בעייתי - לא רוצה לקלוט את השם שקלטתי
      Console.WriteLine($"Found duplicate on i=={i}");
      i--; // קידום לאחור יאפשר לקלוט שוב לאותו אינדקס
      break; // אין טעם להמשיך בבדיקה
    }
  }
}
foreach (var item in names)
  Console.WriteLine(item);

//============  תבנית לפונקציה שמקבלת מערך ומנתחת אותו ===========

// תרגול כיתה 7.06  טיפול בדרך השלילה  
// הקוד מניח שהכל בסדר והפונקציה עולה ממש תמיד
// הבדיקה היא אם יש מצב בו היא אינה עולה 
// false במקרה זה יוחזר 
// true אם לא נמצאה בעייה, בסוף הפונקציה יוחזר 
static bool IsRising(int[] arr)
{
  for (int i = 0; i < arr.Length - 1; i++)
    if (arr[i] >= arr[i + 1])
      return false; // כל הפרה של החוקיות מצדיקה עצירת הבדיקה
                    // false והחזרת תשובה 

  return true; // אם הגענו עד כאן כנראה שאין בעייה
}
// תכנית ראשית לבדיקה:
Console.ForegroundColor = ConsoleColor.Red;

int[] what = { 1, 3, 5, 7, 9 };
foreach (var item in what)
  Console.Write(item + ", ");
Console.WriteLine("\nCheck above sequence is rising:");
Console.WriteLine(IsRising(what)); //print the returned value from IsRising

//======   תבנית לפונקציה המקבלת מערך ועובדת עליו ======
static void Fill1(int[] arr)
{
  //fill in the numbers 10,20,30,40,....100
  for (int i = 0; i < arr.Length; i++)
    arr[i] = 10 * (i + 1);
}
//1,4,9,16,25,36
static void Fill2(int[] arr)
{
  //fill in the numbers 10,20,30,40,....100
  for (int i = 0; i < arr.Length; i++)
    arr[i] = i * i;
}

int[] nums = new int[10];
Console.ForegroundColor = ConsoleColor.Cyan;
Console.WriteLine("\nCall a function that will fill the array:");
Fill1(nums); // קריאה לפונקציה
foreach (var item in nums)
  Console.WriteLine(item); // ניתן לראות שהפונקציה שינתה את המערך
Fill2(nums); // קריאה לפונקציה
foreach (var item in nums)
  Console.WriteLine(item); // ניתן לראות שהפונקציה שינתה את המערך
int x = 0;
int[] num = new int[5];

for (int i = 0; i < nums.Length; i++)
  nums[i] = x * (i + 1);

//Mathala 15 Q5
//Alef
static int TotalTime(int hours, int mins) => hours * 60 + mins;
//bet
static int Tot2Times(int hours, int mins, int hours2, int mins2) =>
  Math.Abs(TotalTime(hours, mins) - TotalTime(hours2, mins2));
//Gimel
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Hagasha 15 - 5 gimel");
int max1 = int.MinValue;
int maxDay = 0;
for (int i = 0; i < 0; i++)
{
  Console.WriteLine("Enter start time and and time \nas 4 numbers");
  int n1 = int.Parse(Console.ReadLine());
  int n2 = int.Parse(Console.ReadLine());
  int n3 = int.Parse(Console.ReadLine());
  int n4 = int.Parse(Console.ReadLine());
  int totalTime = Tot2Times(n1, n2, n3, n4);
  if (totalTime > max1)
  {
    max1 = totalTime;
    maxDay = i + 1;
  }
}
Console.WriteLine($"The max work time was {max1} on day {maxDay}");
Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("\n\nMatala 17 Q1");
int[] numbers17 = { 1, 6, 6, 6, 1, 6, 1, 1, 1 };
Mikumim(numbers17);
Console.WriteLine("second version:");
Mikumim2(numbers17);
static void Mikumim(int[] arr)
{
  //assuming only 2 types:
  int mispar1 = arr[0];
  int mispar2 = 0, count1 = 0;
  string str1 = "", str2 = "";
  for (int i = 0; i < arr.Length; i++)
  {
    if (arr[i] == mispar1)
    {
      count1++;
      str1 += i + ",";
    }
    else
    {
      str2 += i + ",";
      mispar2 = arr[i];
    }
  }
  if (count1 > arr.Length / 2)
    //first num is more frequent
    Console.WriteLine($"{mispar1} is the most frequent and appears in {str1}");
  else
    Console.WriteLine($"{mispar2} is the most frequent and appears in {str2}");

}

static void Mikumim2(int[] arr)
{
  //assuming only 2 types:
  int mispar1 = arr[0];
  int mispar2 = 0, count1 = 0;
  foreach (int n in arr)
    if (n == mispar1)
      count1++;
    else
      mispar2 = n;
  if (count1 > arr.Length / 2)
  {
    Console.WriteLine(mispar1 + "is the most frequent and its located at:");
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == mispar1)
        Console.Write(i + ", ");
  }
  else
  {
    Console.WriteLine(mispar2 + "is the most frequent and its located at:");
    for (int i = 0; i < arr.Length; i++)
      if (arr[i] == mispar2)
        Console.Write(i + ", ");
  }
}

//Matala 9 Q1
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("\n\nMatala9 Q1 grade evaluation");
Console.WriteLine(GradeEval(79, 92, 100));
Console.WriteLine(GradeEval(79, 92, 100));
Console.WriteLine(GradeEval(79, 92, 100));
static bool GradeEval(int g1, int g2, int g3)
{
  double avg = (g1 + g2 + g3) / 3.0;
  if (avg > 90 && g1 >= 80 && g2 >= 80 && g3 >= 80)
    return true;
  return false;
}

static bool GradeEval2(int g1, int g2, int g3)
{
  double avg = (g1 + g2 + g3) / 3.0;
  return avg > 90 && g1 >= 80 && g2 >= 80 && g3 >= 80;
}

static bool GradeEval3(int g1, int g2, int g3) =>
  (g1 + g2 + g3) / 3.0 > 90 && g1 >= 80 && g2 >= 80 && g3 >= 80;

