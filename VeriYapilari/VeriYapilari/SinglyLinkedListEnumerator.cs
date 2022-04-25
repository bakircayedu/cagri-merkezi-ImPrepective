using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapilari
{
    public class SinglyLinkedListEnumerator<T> : IEnumerator<T>
    {
        private SinglyLinkedListNode<T> _head;
        private SinglyLinkedListNode<T> _current;
        public SinglyLinkedListEnumerator(SinglyLinkedListNode<T> head)
        {
            _head = head;

        }
        public T Current => _current.Value;

        object IEnumerator.Current => Current;


        public void Dispose()
        {
            _head = null;
        }

        public bool MoveNext()
        {
            if (_current == null)
            {
                _current = _head;
                return true;
            }
            else
            {
                _current = _current.Next;
                return _current != null;
            }
        }

        public void Reset()
        {
            _current = null;
        }
    }
}
