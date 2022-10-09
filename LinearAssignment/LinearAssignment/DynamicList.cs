/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearAssignment
{
    public class DynamicList<T>
    {
        private class ListNode
        {
            public T Element { get; set; }
            public ListNode NextNode { get; set; }
            public ListNode(T element)
            {
                this.Element = element;
                this.NextNode = null;
            }
            public ListNode(T element, ListNode previous)
            {
                this.Element = element;
                previous.NextNode = this;
            }
        }
        private ListNode head;
        private ListNode tail;
        private int count;
        public DynamicList()
        {
            this.head = null;
            this.tail = null;
            this.count = 0;
        }
        public void Add(T item)
        {
            if (this.head == null)
            {

                this.head = new ListNode(item);
                this.tail = this.head;
            }
            else
            {

                ListNode newNode = new ListNode(item, this.tail);
                this.tail = newNode;
            }
            this.count++;
        }
       // public T RemoveAt
    }

}*/
