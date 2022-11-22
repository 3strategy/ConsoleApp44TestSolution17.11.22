//test solution 17.11.22
//הפתרון מוצג בגרסת 22 ללא 
using System.Diagnostics;



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


//test countDig of others:
//static bool CountDig2(int num)
//{
//    Console.Write(num);
//    int countEven = 0, countOdd = 0;
//    int newNum = num;
//    int lastNum = 0;

//    while (newNum-lastNum>0)
//    {
//        Console.WriteLine(true);
//        lastNum = newNum % 10;
//        newNum = newNum - lastNum;
//        if (newNum % 2 != 0)
//            countOdd++;
//        else
//            countEven++;
//    }
//    return countEven == countOdd;
//}

//לא קשור למבחן:
// לולאות מקוננות
