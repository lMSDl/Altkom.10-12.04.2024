using System.Collections;

namespace Altkom._10_12._04._2024.DesignPatterns.Behavioral.Iterator
{
    internal class BufferIterator<T> : IEnumerator<(T, T)>
    {
        public (T, T) Current { get; set; }
        object IEnumerator.Current => Current;

        private IEnumerator<T>? _enumerator;
        public BufferIterator(IEnumerator<T> enumerator)
        {
            _enumerator = enumerator;
            Reset();
        }

        public void Dispose()
        {
            _enumerator?.Dispose();
            _enumerator = null;
        }

        public bool MoveNext()
        {
            if (_enumerator.MoveNext())
            {
                Current = (Current.Item2, _enumerator.Current);
                return true;
            }
            return false;
        }

        public void Reset()
        {
            _enumerator.Reset();
            Current = _enumerator.MoveNext() ? ((T, T))(default, _enumerator.Current) : default;
        }
    }
}
