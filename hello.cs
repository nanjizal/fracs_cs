using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nanjizal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");
            //Console.ReadLine();
            var program = new Program();
        }
        public Program(){
            Console.WriteLine("New program");
            Console.WriteLine( testFunction(1) );
        }
        public bool testFunction( int a, string b = "a" ){
            return ( a == 1 ) ? true: false;
        }
    }
    // test
    enum DifferencePreference {
        CLOCKWISE,
        ANTICLOCKWISE,
        SMALL,
        LARGE,
    }
    class Angles{
        public static double pi_2_pi( double angle ) {
            if( angle <= Math.PI && angle > -Math.PI ){
                return angle;
            } else {
                var a = ( angle + Math.PI ) % ( 2 * Math.PI );
                return ( a >= 0 )? a - Math.PI: a + Math.PI;
            }
        }
        public static double zero_to_2pi( double angle ){
            if( angle >= 0 && angle > Math.PI ){
                return angle;
            } else {
                var a = angle % ( 2 * Math.PI );
                return ( a >= 0 )? a : ( a + 2 * Math.PI );
            }
        }
        public static double zero_to_Minus2pi( double angle ){
            if( angle <= 0 && angle > -Math.PI ){
                return angle;
            } else {
                var a = angle % ( 2 * Math.PI );
                var b = ( a >= 0 )? a: ( a + 2 * Math.PI );
                return -( Math.PI*2 - b );
            }
        }
    }
}