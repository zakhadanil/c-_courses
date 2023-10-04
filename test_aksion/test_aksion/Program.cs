using System;
using System.Linq;
using System.Collections.Generic;

namespace test_aksion
{
    class Measures  //Создание класса Измерителей, в качестве структуру данных
    {
        private double lowRange;
        private double highRange;
        private double measurementError;

        public Measures(double lowRange, double highRange, double measurementError)
        {            
            this.lowRange = lowRange;
            this.highRange = highRange;
            this.measurementError = measurementError;
        }

        public double LowRange
        {
            get { return this.lowRange;}           
        }

        public double HighRange
        {
            get { return this.highRange; }
        }

        public double MeasurementError
        {
            get { return this.measurementError; }
        }

        public bool isMatches(string lowRange, string highRange)    //Поиск с погрешностью, с вводом двух границ диапозона
        {
            double lowRangeWithError = this.lowRange + (this.lowRange * this.measurementError/100);
            double highRangeWithError = this.highRange - (this.highRange * this.measurementError / 100);
            if (lowRangeWithError <= Convert.ToDouble(lowRange) && highRangeWithError >= Convert.ToDouble(highRange))
            {
                return true;
            }
            return false;
        }
        public bool isMatches(string singleValue)   //Поиск с погрешностью, с вводом одной границы диапозона
        {
            double lowRangeWithError = this.lowRange + (this.lowRange * this.measurementError / 100);
            double highRangeWithError = this.highRange - (this.highRange * this.measurementError / 100);
            if (lowRangeWithError <= Convert.ToDouble(singleValue) && highRangeWithError >= Convert.ToDouble(singleValue))
            {
                return true;
            }
            return false;
        }
        public override string ToString()
        {
            return string.Format("Measuring (lowrange={0}, highrange={1})",this.lowRange, this.highRange);
        }
    }

    class Program
    {
        private const char Slash ='/';

        private static Tuple<string, string> input()    //Метод, для обработки введенных пользователем данных
        {
            Console.WriteLine("Введите значения диапозона через '/'");
            string measureValues = Console.ReadLine();  //Принимаем значения пользователя на вход
            if (string.IsNullOrWhiteSpace(measureValues))
            {
                Console.WriteLine("Введены неверные данные, введите еще раз");
                return input();
            }
            if (measureValues.Contains(Slash))
            {
                string[] splitMeasures = measureValues.Split(Slash);
                return Tuple.Create(splitMeasures[0], splitMeasures[1]);
            }
            else
            {
                string[] splitMeasures = measureValues.Split(Slash);
                return Tuple.Create(splitMeasures[0], "");
            }                  
        }

        private static Measures find(string lowRange, string highRange, IList<Measures> measuringDevices)   //Поиск измерителя по диапозону с минимальной погрешностью
        {
            
            if (string.IsNullOrWhiteSpace(highRange))
            {
                return measuringDevices.Where(it => it.isMatches(lowRange)).OrderBy(it=>it.MeasurementError).FirstOrDefault();
            }

            return measuringDevices.Where(it => it.isMatches(lowRange, highRange)).OrderBy(it=>it.MeasurementError).FirstOrDefault();          
        }
        
        static void Main(string[] args)
        {
            IList<Measures> measuringDevices=new List<Measures> { new Measures(0, 100, 5), new Measures(200, 400, 10), new Measures(300, 500, 15) };
            Tuple<string, string> rangeOfMeasures = input();
            Measures measuringDevice = find(rangeOfMeasures.Item1, rangeOfMeasures.Item2, measuringDevices);

            if (measuringDevice == null)
            {
                Console.WriteLine("Нет подходящих измерителей");
            }

            Console.WriteLine(measuringDevice);            
        }
    }
}
