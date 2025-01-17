﻿
using System.Reactive.Linq;
using System.Threading.Channels;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            List<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };

            var buffer = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                Console.WriteLine(buffer + list[i]);
                buffer = list[i];
            }

            var iterator = list.GetEnumerator();
            if (iterator.MoveNext())
            {
                buffer = iterator.Current;
                while (iterator.MoveNext())
                {
                    Console.WriteLine(buffer + iterator.Current);
                    buffer = iterator.Current;
                }
            }


            var listBuffer = new Buffer<string>(list);

            var bufferIterator = listBuffer.GetEnumerator();
            while (bufferIterator.MoveNext())
            {
                Console.WriteLine($"{bufferIterator.Current.Item1}{bufferIterator.Current.Item2}");
            }

            foreach (var item in new Buffer<string>(list))
            {
                Console.WriteLine($"{item.Item1}{item.Item2}");
            }


            list.ToObservable()
                .Buffer(2, 1)
                .Where(x => x.Count == 2)
                .ToEnumerable()
                .ToList()
                .ForEach(x => Console.WriteLine(x[0] + x[1]));

        }
    }
}
