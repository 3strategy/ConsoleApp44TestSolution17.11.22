//test solution 17.11.22
//הפתרון מוצג בגרסת 22 ללא 
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
    Console.WriteLine(num);
    //Debug.Assert(CountDig(num)==CountDig2(num));
    if (CountDig(num)) // 'בדיקת המספר בעזרת הפונקציה מסעיף א 
      Console.WriteLine("Odd and even digits of are equal");
    else
      Console.WriteLine("Odd and even digits of are NOT equal");
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
Console.WriteLine("starting a heavy operative calculation");
BigInteger sumBig = 0;
for (long i = 0; i <= 241235832; i++)
  sumBig += i;
Console.WriteLine("Done. Got: " + sumBig);
Console.WriteLine("ended this timely loop\nNow do it quickly - Declarative thinking:");

//( מטלה 14 שאלה 5 ( אתגר חשיבה דקלרטיבית 
sumBig = 241235832;
BigInteger big2 = 241235833;
sumBig = sumBig * big2 / 2;
Console.WriteLine(sumBig);

// מערכים ולולאות מקוננות
// מטלה 15 שאלה 1
Console.WriteLine("Matala 15 Q1:");
string[] names = new string[8];
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