using System;

namespace Plus
{

}

namespace twodays
{
    class Program
    {

        static void Main(string[] args)
        {


            //// .toupper = 소문자를 대문자로 변환 
            /////   .tolower = 대문자를 소문자로 변환
            ////    .trim = 시작과 끝에 연속된 무언가를  없애줌
            ///     .trimstart/.trimend = 원하는 범위에 무언가를 없애줌 
        
           //concat, join 이 보이면 최대한 바꿀 것

           
            string str1 = "가.나.다";
            string[] str2 = str1.Split('.');

            Console.WriteLine (str2);
        


            ////replace 가공한 상태의 값의 첫번째 인자의 문자 혹은 문자열을 두번째 인자로 변환 

            //string str1 = "가나다 라마 바사 아  자차";
            //string str2 = str1.Replace(" "        ,        "");
            //                         //(1번째인자),//(2번째인자)
            //Console.WriteLine(str2);





            //string level = "";
            //Console.Write("등급을 입력해주세요 :");
            //level = Console.ReadLine();


            //switch (level)
            //{
            //    case "A":
            //        Console.WriteLine("90점 이상입니다.");
            //        break;
            //    case "B":
            //        Console.WriteLine("70점 이상 90점 미만입니다.");
            //        break;
            //    case "C":
            //        Console.WriteLine("40점이상 70점 미만입니다.");
            //        break;
            //    case "F":
            //        Console.WriteLine("10점 이하입니다.");
            //        break;
            //    case "D":
            //        Console.WriteLine("10~40점 사이입니다.");
            //        break;

            //}

















            /*
                        int score = 0;
                        Console.Write("점수를 입력해주세요 :");
                        score = Convert.ToInt32(Console.ReadLine());

                        if (score >= 90) 
                         {
                             Console.WriteLine ("A");
                         }
                         else if (score >= 70 && score < 90  )
                         {
                             Console.WriteLine ("B");
                         }

                         else if (score >= 40 && score <70 ) 
                         {
                             Console.WriteLine ("C");
                         }


                         else if (score <= 10) 
                         {
                             Console.WriteLine ("F");
                         }

                         else
                         {
                             Console.WriteLine ("D");
                         }
                        */



















            //char 는 작은 따옴표 'c' / string "c"
            // Indexof = 내가 원하는 값의 위치를 숫자로 나타내는 옵션 뒤에 ,를 붙힐때마다 범위를 정할 수 있다.


            /*
        string a = "tuesday";
        string b = "today";
            // StringComparison.Ordinal == 옵션을 추가해서 대소문자 체크를 반드시 하겠다.
            // StringComparison.OrdinalIgnoreCase == 옵션을 추가해서 대소문자 체크를 하지 않겠다.

            if (a.Contains(b, StringComparison.OrdinalIgnoreCase)) ;
            {
                Console.WriteLine("a 문장에 b가 속해있어요");

            }
            
            
            
            
            
            
            
            
            
            
            
            
            /*
            bool a = true;
            bool b = 5;

            int c = 0;
           
            if (a==false) //if 안에 조건체크 / 저건이 bool일때 
            {
                c++;
            }

            Console.WriteLine("c의 값:" + c);
            */



            /*
                        else if (b == 5;)
                        {

                        }
                        else if  ( a != true)
                        {

                        }
                        else
            */


















            // 비트연산자  /xor(두개의 비트가 서로 다른 경우 1을 반환) * 하나있을때는 계산 2개이상은 ture false
            //숫자를 이진수로 변환후 값을 반환 
            /*
                        int a = 7; //111
                        int b = 4; //100

                        c = a ^ b;
                        Console.WriteLine(c);
                        */
            /*
                        int a = 8; //1000
                        int b = 11; // 1011

                        int c = a >> 2; // 10 = 2
                        int d = b << 1; // 10110 = 22

                        // 조건연산자 / 삼항연산자 
            */ /*
            int a = 5;
            int b = 10;
            bool c;

            c = a < b ? true : false; 

            // a가 b보다 작으니 트루를 반환

            c = a < b ?    3 : 5; 
                         (true)(false)

           

            
           
            
            // a가 b보다 작으니 트루위치에 있는 값을 반환


           //null 명확한 숫자는 안되고 넣고 싶다면 ?을 붙히지만 문제가 생길일이 큼 


            string str = null;
            int? a = null;


            str ?? = string.Empty; // 내용이 없다
            a ??= 0; / // 정수에 비었다는건 있을 수 없는일  a가 비었다면 0을 넣는다. 
    
                


       


            






            /*
            int a = 5;
            int b = 10;

            if (a == b)
            {
                Console.WriteLine("a와 b가 같습니다");
            }

            else if (a != b)
            {
                Console.WriteLine("a와 b가 같지 않습니다");
            }


            //증감연산자

            /*
            int a = 5;
            int b = 10;

            int result = 0;

            result = ++a /* 전위증감자 + b--; 
            Console.WriteLine($"전위증가한 {a}와 후위감소한 {b} 의 더하기 결과값 {result} ");


            /*
            int a = 0;

            Console.WriteLine("짝수인지 판별할 수를 입력해 주세요.");
            a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("짝수입니까?" + (a % 2 == 0 ? "네" : "아니요")); */

            // 바뀐부분
        }

    }
}

