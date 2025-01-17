﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.ObjectPool
{
    public class Client
    {
        public static void Execute()
        {
            /*var counter = 0;
            while (true)
            {
                if (counter > 1000)
                    continue;
                var item = new Item() { IsVisible = true };
                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; Interlocked.Decrement(ref counter); });
                Interlocked.Increment(ref counter);
            }*/

            /*var objectPool = new ObjectPool<Item>(1000, () => new Item());
            while (true)
            {
                var item = objectPool.Acquire();
                if (item is null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                item.IsVisible = true;
                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; objectPool.Release(item); });
            }*/

            var itemPool = new ItemPool(1000);
            while (true)
            {
                var item = itemPool.Acquire();
                if (item is null)
                {
                    Thread.Sleep(1);
                    continue;
                }
                Task.Delay(100).ContinueWith(x => { item.IsVisible = false; });
            }
        }
    }
}