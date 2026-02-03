using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class Stapel<T>
    {
        private List<T> items;

        public Stapel()
        {
            items = new List<T>();
        }

        // Push an item onto the stack
        public void Push(T item)
        {
            items.Add(item);
        }

        // Pop an item from the stack
        public T Pop()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty. Cannot pop.");
            }

            T item = items[items.Count - 1];
            items.RemoveAt(items.Count - 1);
            return item;
        }

        // Peek at the top item without removing it
        public T Peek()
        {
            if (items.Count == 0)
            {
                throw new InvalidOperationException("Stack is empty. Cannot peek.");
            }

            return items[items.Count - 1];
        }

        // Check if the stack is empty
        public bool IsEmpty()
        {
            return items.Count == 0;
        }

        // Get the number of items in the stack
        public int Count
        {
            get { return items.Count; }
        }

        // Clear all items from the stack
        public void Clear()
        {
            items.Clear();
        }

        // Display all items in the stack (for debugging)
        public void Display()
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Stack is empty.");
                return;
            }

            Console.WriteLine("Stack contents (top to bottom):");
            for (int i = items.Count - 1; i >= 0; i--)
            {
                Console.WriteLine($"  [{i}] {items[i]}");
            }
        }
    }
}
