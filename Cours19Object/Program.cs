using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cours19Object
{
    public class MyBucket<T> : IEnumerator<T>
    {
        public MyBucket()
        {
            
        }

        public T Current => throw new NotImplementedException();

        object IEnumerator.Current => throw new NotImplementedException();

        T IEnumerator<T>.Current => throw new NotImplementedException();

        public void Dispose()
        {
            
            throw new NotImplementedException();
        }

        public bool MoveNext()
        {
            throw new NotImplementedException();
        }

        public void Reset()
        {
            throw new NotImplementedException();
        }
    }
   public class Program
    {


        static void Main(string[] args)
        {

            var joe = new MyBucket<string>();
            
            /*  IEnumerator<T>
             *  good for huge data loads
             *
             *
             * Debug // RC executer jusquau curseur
             *
             *
             */
        }
    }
}
