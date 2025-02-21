using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lionstudy5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            //숫자 데이터 형식: 정수와 실수를 다룰 때 사용하는 다양한 타입
            int integernum = 10;    //정수 데이터
            float floatnum = 3.14f; //단정밀도 실수 끝에 f를 붙여 double과 구분
            double doublenum = 3.1415;  //배정밀도 실수

            Console.Write(integernum);
            Console.Write(floatnum);
            Console.Write(doublenum);
            */

            /*
            //정수 데이터형식: 소수점이 없는 숫자를 표현
            int value = -100; //4바이트 크기의 정수
            long longvalue = 12345678L; //8바이트 크기의 정수

            Console.WriteLine(value);
            Console.WriteLine(longvalue);
            */

            /*
            // 1비트 0과 1이 8개가 구성되면 1바이트
            // 부호 있는 정수 : 음수와 양수를 모두 표현 가능
            sbyte signedbyte = -50; //1바이트 크기
            short signedShort = -32000; //2바이트 크기
            int signedint = -200000000; //4바이트 크기

            Console.WriteLine(signedbyte);
            Console.WriteLine(signedShort);
            Console.WriteLine(signedint);
            */

            /*
            //부호 없는 정수 데이터 형식 (양수만 저장)
            byte unsignedByte = 255; //1바이트 크기
            ushort unsignedShort = 65000; //2바이트 크기
            uint unsignedint = 4000000000; //4바이트 크기

            Console.WriteLine(unsignedByte);
            Console.WriteLine(unsignedShort);
            Console.WriteLine(unsignedint);
            */

            
            //실수형 데이터 형식: 소수점을 포함한 숫자를 표현
            float singleprecision = 3.14f; //단정밀도 실수
            double doubleprecision = 3.1415926535; //배정밀도 실수 (8바이트)
            decimal hightprecision = 3.14159262342342414134m; //고정밀도 (16바이트)

            Console.WriteLine(singleprecision);
            Console.WriteLine(doubleprecision);
            Console.WriteLine(hightprecision);


        }
    }
}
