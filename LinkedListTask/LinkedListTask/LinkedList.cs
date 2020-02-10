using System;

namespace LinkedList {
    
    public class LinkedList <T> {
        
        private class Node
        {
            
            public T value;
            public Node nextPtr;
            
            public Node(T value, Node nextPtr)
            {
                this.value = value;
                this.nextPtr = nextPtr;
            }
        }

        private Node head;
        private Node tail;
        private int _size;

        public int size()
        {
            return _size;
        }
        
        public void add(T value)
        {
            if (head == null)
            {
                head = new Node(value, null);
                tail = head;
            }
            else
            {
                tail.nextPtr = new Node(value, null);
                tail = tail.nextPtr;
            }

            _size++;
        }
        
        public void add(T value, int index){
            int count = 0;
            Node it = head;
            while (count != index - 1){
                it = it.nextPtr;
                count++;
            }

            Node tmpNext = it.nextPtr;
            it.nextPtr = new Node(value,tmpNext);
            
            _size++;
        }

        public T get(int index)
        {
            int count = 0;
            Node it = head;
            while (count < index){
                it = it.nextPtr;
                count++;
            }
            return it.value;
        }

        public T remove(int index)
        {
            int count = 0;
            Node it = head;
            while (count != index - 1){
                it = it.nextPtr;
                count++;
            }

            T value = it.nextPtr.value;
            it.nextPtr = it.nextPtr.nextPtr;

            _size--;
            return value;
        }

    }
}