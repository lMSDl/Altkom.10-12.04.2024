using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altkom._10_12._04._2024.DesignPatterns.Creational.ObjectPool
{
    internal class Item
    {
        private bool isCollected;

        public bool IsVisible { get; set; }
        public bool IsCollected
        {
            get => isCollected;
            set
            {
                if (isCollected = value)
                    IsVisible = false;
            }
        }

        public byte[] Content { get; } = new byte[1024];
    }
}
