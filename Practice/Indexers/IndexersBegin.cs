using System;
using System.Linq;
using System.Collections.Generic;

namespace Practice.Indexers
{
    //   C# Indexer는 클래스 객체의 데이타를 배열 형태로 인덱스를 써서 엑세스할 수 있게 해준다.
    //   즉, 클래스 객체는 배열이 아님에도 불구하고, 마치 배열처럼 []를 사용하여 클래스 내의 특정 필드 데이타를 엑세스하는 것이다.
    public class IndexersSamples
    {
        private class Page
        {
            private readonly List<Measurements> pageData = new List<Measurements>();
            private readonly int startingIndex;
            private readonly int length;
            private bool dirty;
            private DateTime lastAccess;

            public Page(int startingIndex, int length)
            {
                this.startingIndex = startingIndex;
                this.length = length;
                lastAccess = DateTime.Now;

                // This stays as random stuff:
                var generator = new Random();
                for (int i = 0; i < length; i++)
                {
                    var m = new Measurements
                    {
                        HiTemp = generator.Next(50, 95),
                        LoTemp = generator.Next(12, 49),
                        AirPressure = 28.0 + generator.NextDouble() * 4
                    };
                    pageData.Add(m);
                }
            }
            public bool HasItem(int index) =>
                ((index >= startingIndex) &&
                (index < startingIndex + length));

            public Measurements this[int index]
            {
                get
                {
                    lastAccess = DateTime.Now;
                    return pageData[index - startingIndex];
                }
                set
                {
                    pageData[index - startingIndex] = value;
                    dirty = true;
                    lastAccess = DateTime.Now;
                }
            }

            public bool Dirty => dirty;
            public DateTime LastAccess => lastAccess;
        }

        private readonly int totalSize;
        private readonly List<Page> pagesInMemory = new List<Page>();

        public IndexersSamples(int totalSize)
        {
            this.totalSize = totalSize;
        }

        public Measurements this[int index]
        {
            get
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Cannot index less than 0");
                if (index >= totalSize)
                    throw new IndexOutOfRangeException("Cannot index past the end of storage");

                var page = updateCachedPagesForAccess(index);
                return page[index];
            }
            set
            {
                if (index < 0)
                    throw new IndexOutOfRangeException("Cannot index less than 0");
                if (index >= totalSize)
                    throw new IndexOutOfRangeException("Cannot index past the end of storage");
                var page = updateCachedPagesForAccess(index);

                page[index] = value;
            }
        }

        private Page updateCachedPagesForAccess(int index)
        {
            foreach (var p in pagesInMemory)
            {
                if (p.HasItem(index))
                {
                    return p;
                }
            }
            var startingIndex = (index / 1000) * 1000;
            var newPage = new Page(startingIndex, 1000);
            addPageToCache(newPage);
            return newPage;
        }

        private void addPageToCache(Page p)
        {
            if (pagesInMemory.Count > 4)
            {
                // remove oldest non-dirty page:
                var oldest = pagesInMemory
                    .Where(page => !page.Dirty)
                    .OrderBy(page => page.LastAccess)
                    .FirstOrDefault();
                // Note that this may keep more than 5 pages in memory
                // if too much is dirty
                if (oldest != null)
                    pagesInMemory.Remove(oldest);
            }
            pagesInMemory.Add(p);
        }
    }
}
