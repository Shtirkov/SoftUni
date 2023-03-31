﻿using System.Collections;

namespace Froggy
{
    public class Lake : IEnumerable<int>
    {

        private readonly List<int> _stones;

        public Lake(List<int> stones)
        {
            _stones = stones;
        }
        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < _stones.Count(); i++)
            {
                if (i % 2 == 0)
                {
                    yield return _stones[i];                    
                }
            }

            for (int i = _stones.Count() - 1; i >= 0; i--)
            {
                if (i % 2 != 0)
                {
                    yield return _stones[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
